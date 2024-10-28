using AutoMapper;
using Multibanking.Contracts.PeriodPaymentConsent;
using Multibanking.Data.OpenAPIBankClients.PeriodPaymentClient;
using Multibanking.Data.Repositories.PeriodPayments;
using Multibanking.Entities.PeriodPayments;
using Multibanking.PeriodPaymentClient.Model;
using Multibanking.Services.Cards;
using Multibanking.Services.PeriodPayments.Models;
using Multibanking.Services.User;

namespace Multibanking.Services.PeriodPayments.Implementations;

public class PeriodPaymentConsentService(
    IPeriodPaymentConsentClient periodPaymentConsentClient,
    ICardService cardService,
    IMapper mapper,
    IPeriodPaymentConsentRepository periodPaymentConsentRepository,
    IUserContextService userContextService) : IPeriodPaymentConsentService
{
    private const int QuantityLongPullingAttempts = 10;
    private const int LongPullingPeriod = 1000;

    private VRPConsentResponse CreatePeriodPaymentConsentBankingInit(CreatePeriodPaymentConsentModel createPeriodPaymentConsentModel)
    {
        var periodPaymentConsentResponse = periodPaymentConsentClient.CreateVRPConsent(new VRPConsentRequest(
                new VRPConsentRequestData(
                    new VrpConsentRequestDataControlParameters(DateTime.Now, default,
                        new VRPControlParametersMaximumIndividualAmount(createPeriodPaymentConsentModel.Amount, createPeriodPaymentConsentModel.Currency),
                        [createPeriodPaymentConsentModel.PeriodAmount], [], [],
                        new object()),
                    new VRPConsentRequestDataInitiation(
                        new VRPInitiationDebtorAccount(schemeName: AccountIdentificationCode.PAN, identification: createPeriodPaymentConsentModel.DebtorPan),
                        creditor: new VRPInitiationCreditor(
                            name: createPeriodPaymentConsentModel.CreditorName,
                            identification: [createPeriodPaymentConsentModel.CreditorIdentification]
                        )
                    ),
                    VRPConsentRequestData.ReadRefundAccountEnum.No
                ),
                new VRPConsentRequestRisk()
            ), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
        return periodPaymentConsentResponse;
    }

    private async Task<VRPConsentResponse> CreatePeriodPaymentConsentBankingWithValidation(CreatePeriodPaymentConsentModel periodPaymentConsentModel)
    {
        var periodPaymentConsentResponse = CreatePeriodPaymentConsentBankingInit(periodPaymentConsentModel);
        if (periodPaymentConsentResponse == null)
            throw new Exception("Со стороны банкинга не пришло ответа, попробуйте операцию позже");

        var longPullingAttempt = 0;
        while (periodPaymentConsentResponse.Data.Status == ConsentStatus.AwaitingAuthorisation)
        {
            if (longPullingAttempt == QuantityLongPullingAttempts)
                throw new Exception($"Банкинг не дал ответа по транзакции в течении {QuantityLongPullingAttempts} попыток. Вы можете отследить транзакцию в меню транзакций");
            await Task.Delay(LongPullingPeriod);

            periodPaymentConsentResponse = periodPaymentConsentClient.GetVRPConsentConsentId(periodPaymentConsentResponse.Data.ConsentId, Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

            longPullingAttempt++;
        }

        if (periodPaymentConsentResponse.Data.Status != ConsentStatus.Authorised)
            throw new Exception("Банкинг не дал подтверждения для согласия на периодические платежи. Попробуйте позже");

        return periodPaymentConsentResponse;
    }

    public async Task CreatePeriodPaymentConsent(CreatePeriodPaymentConsentDto periodPaymentConsentDto)
    {
        cardService.ValidateUserCard(periodPaymentConsentDto.CardGuid);

        var periodPaymentConsentModel = mapper.Map<CreatePeriodPaymentConsentModel>(periodPaymentConsentDto);
        periodPaymentConsentModel.DebtorPan = cardService.GetDecryptedPan(periodPaymentConsentDto.CardGuid);

        var consentResponse = await CreatePeriodPaymentConsentBankingWithValidation(periodPaymentConsentModel);

        CreatePeriodPaymentConsentSystem(periodPaymentConsentDto, consentResponse);
    }

    private void CreatePeriodPaymentConsentSystem(CreatePeriodPaymentConsentDto periodPaymentConsentDto, VRPConsentResponse consentResponse)
    {
        periodPaymentConsentRepository.Create(new PeriodPaymentConsent
        {
            CardId = periodPaymentConsentDto.CardGuid,
            ConsentBanking = consentResponse,
            UserId = userContextService.GetUserDtoFromHttpContext().Id
        });
        periodPaymentConsentRepository.SaveChanges();
    }

    public List<ReadPeriodPaymentConsentDto> GetPeriodPaymentConsents()
    {
        var userDto = userContextService.GetUserDtoFromHttpContext();
        return mapper.Map<List<ReadPeriodPaymentConsentDto>>(periodPaymentConsentRepository.Read().Where(consent => consent.UserId == userDto.Id).ToList());
    }

    public void DeletePeriodPaymentConsent(Guid periodPaymentConsentId)
    {
        var userDto = userContextService.GetUserDtoFromHttpContext();
        var consent = periodPaymentConsentRepository.Read().SingleOrDefault(consent => consent.Id == periodPaymentConsentId);
        if (consent == null)
            throw new ArgumentException("Данного согласия не существует");
        if (consent.UserId != userDto.Id)
            throw new ArgumentException("Нельзя взаимодействовать с чужими согласиями");

        periodPaymentConsentClient.DeleteVRPConsentsConsentId(consent.ConsentBanking.Data.ConsentId);
        periodPaymentConsentRepository.Delete(consent);
        periodPaymentConsentRepository.SaveChanges();
    }

    public ReadPeriodPaymentConsentDto GetPeriodPaymentConsent(Guid periodPaymentConsentId)
    {
        var periodPaymentConsent = periodPaymentConsentRepository.Read().SingleOrDefault(consent => consent.Id == periodPaymentConsentId);

        if (periodPaymentConsent == null)
            throw new Exception("Данного согласия не существует");

        if (periodPaymentConsent.UserId != userContextService.GetUserDtoFromHttpContext().Id)
            throw new Exception("Нельзя получить чужие согласия");

        return mapper.Map<ReadPeriodPaymentConsentDto>(periodPaymentConsent);
    }
}