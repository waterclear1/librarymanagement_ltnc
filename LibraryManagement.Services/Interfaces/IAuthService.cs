using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Services.Interfaces
{
    public interface IAuthService
    {
        AppUser? Login(string username, string password);
    }
}
