using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Domain.Entities
{
    public class BorrowRecord
    {
        [Key]
        public int BorrowId { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime? PayDate { get; set; }     // ngày trả thực tế
        public DateTime DueDate { get; set; }      // hạn trả
        public string Status { get; set; } = "Borrowing";
        // Borrowing / Returned / Late ...

        public Reader Reader { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}
