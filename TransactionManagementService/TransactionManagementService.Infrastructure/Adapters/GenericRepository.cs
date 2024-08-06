using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TransactionManagementService.Domain.Commons.Entities;
using TransactionManagementService.Infrastructure.DataContext;
using TransactionManagementService.Infrastructure.Ports;

namespace TransactionManagementService.Infrastructure.Adapters
{
    public class GenericRepository<T> : IRepository<T> where T : DomainEntity
    {
        private readonly AppDataContext _context;
        private readonly DbSet<T> _dataset;
        private readonly char[] _separator = [','];

        public GenericRepository(AppDataContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetListAsync(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeStringProperties = "", bool isTracking = false)
        {
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!string.IsNullOrEmpty(includeStringProperties))
            {
                foreach (var includeProperty in includeStringProperties.Split
                             (_separator, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync().ConfigureAwait(false);
            }

            return (!isTracking) ? await query.AsNoTracking().ToListAsync() : await query.ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            _ = entity ?? throw new ArgumentNullException(nameof(entity), "Entity can not be null");
            await _dataset.AddAsync(entity);
            return entity;
        }

        public void DeleteAsync(T entity)
        {
            _ = entity ?? throw new ArgumentNullException(nameof(entity), "Entity can not be null");
            _dataset.Remove(entity);
        }

        public async Task<T> GetAsync(Guid id, string? includeStringProperties = default)
        {
            var query = _dataset.AsQueryable();

            if (!string.IsNullOrEmpty(includeStringProperties))
            {
                foreach (var includeProperty in includeStringProperties.Split(_separator,
                             StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.FirstOrDefaultAsync(entity => entity.Id == id) ?? default!;
        }

        public void UpdateAsync(T entity)
        {
            _dataset.Update(entity);
        }

        public Task<int> CountAsync()
        {
            return _dataset.CountAsync();
        }
    }
}