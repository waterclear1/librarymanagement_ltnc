using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class BookCopy
    {
        public int BookId { get; set; }
        public int BookCopyId { get; set; }        // số thứ tự bản in
        public string Status { get; set; } = "Available"; // Available/Borrowed/Lost...

        public Book Book { get; set; } = null!;
    }
}
