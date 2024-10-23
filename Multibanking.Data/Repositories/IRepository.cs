using System.Linq.Expressions;
using Multibanking.Entities;

namespace Multibanking.Data.Repositories;

public interface IRepository<T> where T : class, IEntity
{
    void Create(T entity);

    IQueryable<T> Read();

    void Update(T entity);

    void Delete(T entity);

    bool Exist(Expression<Func<T, bool>> predicate);

    void SaveChanges();
}