using Multibanking.Entities.Database;
using Multibanking.Entities.PeriodPayments;

namespace Multibanking.Data.Repositories.PeriodPayments;

public interface IPeriodPaymentConsentRepository : IRepository<PeriodPaymentConsent>;

public class PeriodPaymentConsentRepository(MultibankingDbContext dbContext) : Repository<PeriodPaymentConsent>(dbContext), IPeriodPaymentConsentRepository;