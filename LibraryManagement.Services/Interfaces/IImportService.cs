using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Services.Interfaces
{
    public interface IImportService
    {
        IEnumerable<BookImport> GetAll();
        void ImportBook(int bookId, int quantity, DateTime importDate, string? note = null);
    }
}
