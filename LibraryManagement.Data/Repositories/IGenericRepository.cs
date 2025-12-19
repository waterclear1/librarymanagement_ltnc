using System.Linq.Expressions;

namespace LibraryManagement.Data.Repositories
{
    // Interface dùng chung cho CRUD
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeProperties = "");

        T? GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
        void Delete(T entity);
    }
}