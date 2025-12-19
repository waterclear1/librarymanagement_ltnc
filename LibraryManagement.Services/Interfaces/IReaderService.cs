using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Services.Interfaces
{
    public interface IReaderService
    {
        IEnumerable<Reader> GetAll(string? keyword = null);
        Reader? GetById(int id);
        void Create(Reader reader);
        void Update(Reader reader);
        void Delete(int id);
    }
}
