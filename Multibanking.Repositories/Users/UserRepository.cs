using Multibanking.Entities.Database;
using Multibanking.Entities.Users;

namespace Multibanking.Repositories.Users;

public interface IUserRepository : IRepository<User>;

public class UserRepository(MultibankingDbContext dbContext) : Repository<User>(dbContext), IUserRepository
{
    
}