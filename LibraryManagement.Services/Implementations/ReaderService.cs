using LibraryManagement.Data.Repositories;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Services.Interfaces;

namespace LibraryManagement.Services.Implementations
{
    public class ReaderService : IReaderService
    {
        private readonly IUnitOfWork _uow;

        public ReaderService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Reader> GetAll(string? keyword = null)
        {
            return _uow.Readers.GetAll(
                filter: string.IsNullOrWhiteSpace(keyword)
                    ? null
                    : r => r.FullName.Contains(keyword) || r.Phone.Contains(keyword));
        }

        public Reader? GetById(int id) => _uow.Readers.GetById(id);

        public void Create(Reader reader)
        {
            reader.CreatedDate = DateTime.Now;
            _uow.Readers.Insert(reader);
            _uow.Save();
        }

        public void Update(Reader reader)
        {
            _uow.Readers.Update(reader);
            _uow.Save();
        }

        public void Delete(int id)
        {
            _uow.Readers.Delete(id);
            _uow.Save();
        }
    }
}
