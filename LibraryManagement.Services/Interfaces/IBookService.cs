using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll(string? keyword = null);
        Book? GetById(int id);
        void Create(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}
