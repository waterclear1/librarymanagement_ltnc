using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _context;

        public IGenericRepository<Book> Books { get; }
        public IGenericRepository<BookCopy> BookCopies { get; }
        public IGenericRepository<Category> Categories { get; }
        public IGenericRepository<Reader> Readers { get; }
        public IGenericRepository<BorrowRecord> BorrowRecords { get; }
        public IGenericRepository<BookImport> BookImports { get; }
        public IGenericRepository<AppUser> AppUsers { get; }

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
            Books = new GenericRepository<Book>(_context);
            BookCopies = new GenericRepository<BookCopy>(_context);
            Categories = new GenericRepository<Category>(_context);
            Readers = new GenericRepository<Reader>(_context);
            BorrowRecords = new GenericRepository<BorrowRecord>(_context);
            BookImports = new GenericRepository<BookImport>(_context);
            AppUsers = new GenericRepository<AppUser>(_context);
        }

        public int Save() => _context.SaveChanges();

        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    _context.Dispose();

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
