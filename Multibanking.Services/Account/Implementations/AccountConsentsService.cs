using Multibanking.AccountClient.Model;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Data.OpenAPIBankClients.AccountClient;
using Multibanking.Data.Repositories.Account;
using Multibanking.Services.User;

namespace Multibanking.Services.Account.Implementations;

public class AccountConsentsService(IAccountConsentsClient accountConsentsClient, IAccountConsentRepository accountConsentRepository, IUserContextService userContextService)
    : IAccountConsentsService
{
    public void CreateAccountAccessConsents(ICollection<AccountConsent> consentStatusTypes)
    {
        var user = userContextService.GetUserDtoFromHttpContext();

        if (user.UserAccountConsent != null)
            RevokeAccountAccessConsent();

        var consentResponse = accountConsentsClient.CreateAccountAccessConsents(
            new Consent(
                new DataType(consentStatusTypes.Select(accountConsent => (PermissionsType)(int)accountConsent).ToList()), new object()
            )
        );
        if (consentResponse == null)
            throw new Exception("На стороне банкинга произошла ошибка, список согласия не возвращаются, попробуйте позже");
        if (consentResponse.Data.Status != ConsentStatusType.Authorised)
        {
            throw new Exception("Согласия не прошли валидацию на стороне банкинга, попробуйте позже");
        }

        var accountConsent = accountConsentRepository.Read().Single(accountConsent => accountConsent.UserId == user.Id);
        
        accountConsent.AccountConsentId = consentResponse.Data.ConsentId;
        accountConsentRepository.Update(accountConsent);
        accountConsentRepository.SaveChanges();
    }
    
    

    public void RevokeAccountAccessConsent()
    {
        var userDto = userContextService.GetUserDtoFromHttpContext();
        if (userDto.UserAccountConsent == null)
            throw new InvalidOperationException("У пользователя нет согласия");
        accountConsentsClient.DeleteAccountAccessConsentsConsentId(userDto.UserAccountConsent.AccountConsentId);

        var userAccountConsent = accountConsentRepository.Read().Single(consent => consent.AccountConsentId == userDto.UserAccountConsent.AccountConsentId);
        accountConsentRepository.Delete(userAccountConsent);
        accountConsentRepository.SaveChanges();
    }
}