using System.Linq.Expressions;

namespace HR_Management.Core.ServiceContract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>>? predicate =null, string? IncludeWord = null );
        Task<T> GetElement (Expression<Func<T, bool>>? predicate = null, string? IncludeWord = null);
        Task AddAsync(T entity);

        void Remove (T entity);
        void RemoveRange (IEnumerable<T> entities);
    }
}
