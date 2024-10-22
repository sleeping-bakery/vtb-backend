using System.Linq.Expressions;
using Multibanking.Entities;
using Multibanking.Entities.Database;
namespace Multibanking.Repositories;

public abstract class Repository<T>(MultibankingDbContext dbContext) : IRepository<T> where T : class, IEntity
{
    public void Create(T entity)
    {
        dbContext.Add(entity);
    }

    public IQueryable<T> Read()
    {
        return dbContext.Set<T>();
    }

    public void Update(T entity)
    {
        dbContext.Update(entity);
    }

    public void Delete(T entity)
    {
        dbContext.Remove(entity);
    }

    public bool Exist(Expression<Func<T, bool>> predicate)
    {
        return dbContext.Set<T>().SingleOrDefault(predicate) is not null;
    }

    public void SaveChanges()
    {
        dbContext.SaveChanges();
    }
}