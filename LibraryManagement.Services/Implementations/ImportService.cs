using LibraryManagement.Data.Repositories;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Services.Interfaces;

namespace LibraryManagement.Services.Implementations
{
    public class ImportService : IImportService
    {
        private readonly IUnitOfWork _uow;

        public ImportService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<BookImport> GetAll()
        {
            return _uow.BookImports.GetAll(includeProperties: "Book");
        }

        public void ImportBook(int bookId, int quantity, DateTime importDate, string? note = null)
        {
            var book = _uow.Books.GetById(bookId)
                       ?? throw new InvalidOperationException("Không tìm thấy sách.");

            var import = new BookImport
            {
                BookId = bookId,
                Quantity = quantity,
                ImportDate = importDate,
                Note = note
            };

            book.Quantity += quantity;
            book.Available += quantity;

            _uow.BookImports.Insert(import);
            _uow.Books.Update(book);
            _uow.Save();
        }
    }
}
