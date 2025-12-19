using LibraryManagement.Data;
using LibraryManagement.Data.Repositories;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Services.Implementations;
using LibraryManagement.Services.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagement.WinForms.Forms
{
    public partial class FrmBorrow : Form
    {
        private readonly IBorrowService _borrowService;
        private readonly IUnitOfWork _uow;

        public FrmBorrow()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _uow = new UnitOfWork(context);
            _borrowService = new BorrowService(_uow);

            LoadReaders();
            LoadBooks();
            LoadBorrowRecords();
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(7);
        }

        private void LoadReaders()
        {
            var readers = _uow.Readers.GetAll().ToList();
            cboReader.DataSource = readers;
            cboReader.DisplayMember = "FullName";
            cboReader.ValueMember = "ReaderId";
        }

        private void LoadBooks()
        {
            var books = _uow.Books.GetAll().ToList();
            cboBook.DataSource = books;
            cboBook.DisplayMember = "Title";
            cboBook.ValueMember = "BookId";
        }

        private void LoadBorrowRecords(string? status = null)
        {
            dgvBorrow.DataSource = _borrowService.GetAll(status).ToList();
        }

        private BorrowRecord? GetSelectedRecord()
        {
            return dgvBorrow.CurrentRow?.DataBoundItem as BorrowRecord;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                int readerId = (int)cboReader.SelectedValue;
                int bookId = (int)cboBook.SelectedValue;
                DateTime borrowDate = dtpBorrowDate.Value.Date;
                DateTime dueDate = dtpDueDate.Value.Date;

                _borrowService.BorrowBook(readerId, bookId, borrowDate, dueDate);
                MessageBox.Show("Mượn sách thành công.");
                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var record = GetSelectedRecord();
            if (record == null)
            {
                MessageBox.Show("Chọn 1 phiếu mượn để trả.");
                return;
            }

            try
            {
                _borrowService.ReturnBook(record.BorrowId, DateTime.Now);
                MessageBox.Show("Trả sách thành công.");
                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBorrowRecords();
        }

        private void btnFilterBorrowing_Click(object sender, EventArgs e)
        {
            LoadBorrowRecords("Borrowing");
        }

        private void dgvBorrow_SelectionChanged(object sender, EventArgs e)
        {
            // Nếu muốn, bạn có thể hiển thị thông tin chi tiết phiếu mượn lên vài Label.
            // Ở đây tạm để trống.
        }
    }
}
