using Multibanking.AccountClient.Model;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Services.Account.Implementations;

public class AccountConsentsService(IAccountConsentsClient accountConsentsClient) : IAccountConsentsService
{
    public void CreateAccountAccessConsents(ICollection<AccountConsent> consentStatusTypes)
    {
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
    }
}