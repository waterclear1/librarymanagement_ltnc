using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!; // demo: có thể lưu plain text
        public string Role { get; set; } = "User";        // Admin / Librarian ...
        public bool IsActive { get; set; } = true;
    }
}
