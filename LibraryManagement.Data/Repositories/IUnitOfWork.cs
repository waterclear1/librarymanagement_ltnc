using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Data.Repositories
{
    // Gom tất cả repository, quản lý SaveChanges
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Book> Books { get; }
        IGenericRepository<BookCopy> BookCopies { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Reader> Readers { get; }
        IGenericRepository<BorrowRecord> BorrowRecords { get; }
        IGenericRepository<BookImport> BookImports { get; }
        IGenericRepository<AppUser> AppUsers { get; }

        int Save();
    }
}
