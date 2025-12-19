using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Publisher { get; set; } = null!;
        public int PublishedYear { get; set; }
        public int Quantity { get; set; }
        public int Available { get; set; }
        public string? Description { get; set; }

        public Category Category { get; set; } = null!;
        public ICollection<BookCopy> BookCopies { get; set; } = new List<BookCopy>();
        public ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
        public ICollection<BookImport> Imports { get; set; } = new List<BookImport>();
    }
}
