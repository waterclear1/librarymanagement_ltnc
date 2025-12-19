using LibraryManagement.Data.Repositories;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Services.Interfaces;

namespace LibraryManagement.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _uow;

        public AuthService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public AppUser? Login(string username, string password)
        {
            return _uow.AppUsers
                .GetAll(u => u.UserName == username && u.PasswordHash == password && u.IsActive)
                .FirstOrDefault();
        }
    }
}
