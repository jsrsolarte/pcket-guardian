using System.Linq.Expressions;
using TransactionManagementService.Domain.Commons.Entities;

namespace TransactionManagementService.Infrastructure.Ports
{
    public interface IRepository<T> where T : DomainEntity
    {
        Task<T> GetAsync(Guid id, string? includeStringProperties = default);
        Task<IEnumerable<T>> GetListAsync(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeStringProperties = "",
            bool isTracking = false);
        Task<T> AddAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(T entity);
        Task<int> CountAsync();

    }
}
