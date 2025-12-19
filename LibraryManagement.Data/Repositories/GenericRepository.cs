using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibraryManagement.Data.Repositories
{
    // Cài đặt cụ thể cho CRUD bằng EF Core
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly LibraryContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(LibraryContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
                query = query.Where(filter);

            foreach (var includeProperty in includeProperties.Split(
                         new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }

        public T? GetById(object id) => _dbSet.Find(id);

        public void Insert(T entity) => _dbSet.Add(entity);

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            var entityToDelete = _dbSet.Find(id);
            if (entityToDelete != null)
                Delete(entityToDelete);
        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity);

            _dbSet.Remove(entity);
        }
    }
}
