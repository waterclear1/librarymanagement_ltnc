using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Services.Interfaces
{
    public interface IBorrowService
    {
        IEnumerable<BorrowRecord> GetAll(string? status = null);
        BorrowRecord? GetById(int id);
        void BorrowBook(int readerId, int bookId, DateTime borrowDate, DateTime dueDate);
        void ReturnBook(int borrowId, DateTime returnDate);
    }
}
