using LibraryManagement.Data.Repositories;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Services.Interfaces;

namespace LibraryManagement.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _uow;

        public BookService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Book> GetAll(string? keyword = null)
        {
            return _uow.Books.GetAll(
                filter: string.IsNullOrWhiteSpace(keyword)
                    ? null
                    : b => b.Title.Contains(keyword),
                includeProperties: "Category");
        }

        public Book? GetById(int id) => _uow.Books.GetById(id);

        public void Create(Book book)
        {
            book.Available = book.Quantity;
            _uow.Books.Insert(book);
            _uow.Save();
        }

        public void Update(Book book)
        {
            _uow.Books.Update(book);
            _uow.Save();
        }

        public void Delete(int id)
        {
            _uow.Books.Delete(id);
            _uow.Save();
        }
    }
}
