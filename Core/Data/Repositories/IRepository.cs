using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public partial interface IRepository<T> where T : class
    {
        ValueTask<T> GetByIdAsync(int Id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void RemoveAsync(T entity);
        void RemoveRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
    }
}