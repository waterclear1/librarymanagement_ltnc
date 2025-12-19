using LibraryManagement.Data.Repositories;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Services.Interfaces;

namespace LibraryManagement.Services.Implementations
{
    public class BorrowService : IBorrowService
    {
        private readonly IUnitOfWork _uow;

        public BorrowService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<BorrowRecord> GetAll(string? status = null)
        {
            return _uow.BorrowRecords.GetAll(
                filter: string.IsNullOrWhiteSpace(status) ? null : br => br.Status == status,
                includeProperties: "Reader,Book");
        }

        public BorrowRecord? GetById(int id) => _uow.BorrowRecords.GetById(id);

        public void BorrowBook(int readerId, int bookId, DateTime borrowDate, DateTime dueDate)
        {
            var book = _uow.Books.GetById(bookId)
                       ?? throw new InvalidOperationException("Không tìm thấy sách.");

            if (book.Available <= 0)
                throw new InvalidOperationException("Sách không còn để mượn.");

            var record = new BorrowRecord
            {
                ReaderId = readerId,
                BookId = bookId,
                BorrowDate = borrowDate,
                DueDate = dueDate,
                Status = "Borrowing"
            };

            book.Available -= 1;

            _uow.BorrowRecords.Insert(record);
            _uow.Books.Update(book);
            _uow.Save();
        }

        public void ReturnBook(int borrowId, DateTime returnDate)
        {
            var record = _uow.BorrowRecords.GetById(borrowId)
                         ?? throw new InvalidOperationException("Không tìm thấy phiếu mượn.");

            if (record.Status == "Returned") return;

            var book = _uow.Books.GetById(record.BookId)
                       ?? throw new InvalidOperationException("Không tìm thấy sách.");

            record.PayDate = returnDate;
            record.Status = returnDate > record.DueDate ? "Late" : "Returned";
            book.Available += 1;

            _uow.BorrowRecords.Update(record);
            _uow.Books.Update(book);
            _uow.Save();
        }
    }
}
