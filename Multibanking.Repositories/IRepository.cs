using System.Linq.Expressions;
using Multibanking.Entities;

namespace Multibanking.Repositories;

public interface IRepository<T> where T : class, IEntity
{
    void Create(T entity);

    ICollection<T> Read(Func<IQueryable<T>, IQueryable<T>> query);

    void Update(T entity);

    void Delete(T entity);
    
    bool Exist(Expression<Func<T, bool>> predicate);

    void SaveChanges();
}