using Multibanking.Entities.Database;
using Multibanking.Entities.GuaranteeOrders;

namespace Multibanking.Data.Repositories.Guarantee;

public class GuaranteeOrderRepository(MultibankingDbContext dbContext) : Repository<GuaranteeOrder>(dbContext), IGuaranteeOrderRepository;