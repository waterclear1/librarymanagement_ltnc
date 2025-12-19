using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class Reader
    {
        public int ReaderId { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime DOB { get; set; }
        public string Phone { get; set; } = null!;
        public string? Address { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
    }
}
