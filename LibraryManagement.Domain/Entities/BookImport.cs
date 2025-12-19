using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class BookImport
    {
        public int BookImportId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime ImportDate { get; set; }
        public string? Note { get; set; }

        public Book Book { get; set; } = null!;
    }
}
