using Multibanking.Entities.Database;
using Multibanking.Entities.Users;

namespace Multibanking.Data.Repositories.Users;

public class UserRepository(MultibankingDbContext dbContext) : Repository<User>(dbContext), IUserRepository
{
}