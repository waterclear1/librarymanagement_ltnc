using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagement;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<BookCopy> BookCopies => Set<BookCopy>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Reader> Readers => Set<Reader>();
        public DbSet<BorrowRecord> BorrowRecords => Set<BorrowRecord>();
        public DbSet<BookImport> BookImports => Set<BookImport>();
        public DbSet<AppUser> AppUsers => Set<AppUser>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=NguyenXuanPhat;Initial Catalog=LibraryDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Khóa chính composite cho BookCopy
            modelBuilder.Entity<BookCopy>()
                .HasKey(bc => new { bc.BookId, bc.BookCopyId });

            // Quan hệ BookCopy - Book
            modelBuilder.Entity<BookCopy>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCopies)
                .HasForeignKey(bc => bc.BookId);

            // Book - Category
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);

            // BorrowRecord - Book
            modelBuilder.Entity<BorrowRecord>()
               .HasOne(br => br.Book)
               .WithMany(b => b.BorrowRecords)
               .HasForeignKey(br => br.BookId);


            // BorrowRecord - Reader
            modelBuilder.Entity<BorrowRecord>()
                .HasOne(br => br.Reader)
                .WithMany(r => r.BorrowRecords)
                .HasForeignKey(br => br.ReaderId);

            // BookImport - Book
            modelBuilder.Entity<BookImport>()
                .HasOne(bi => bi.Book)
                .WithMany(b => b.Imports)
                .HasForeignKey(bi => bi.BookId);

            // Seed 1 user admin để đăng nhập
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    AppUserId = 1,
                    UserName = "admin",
                    PasswordHash = "admin",
                    Role = "Admin",
                    IsActive = true
                });
        }
    }
}
