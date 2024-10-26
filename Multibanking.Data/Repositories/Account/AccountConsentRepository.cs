using Multibanking.Entities.Accounts;
using Multibanking.Entities.Database;

namespace Multibanking.Data.Repositories.Account;

public class AccountConsentRepository(MultibankingDbContext dbContext) : Repository<UserAccountConsent>(dbContext), IAccountConsentRepository
{
}