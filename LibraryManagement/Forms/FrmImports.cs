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
    public partial class FrmImports : Form
    {
        private readonly IImportService _importService;
        private readonly IUnitOfWork _uow;

        public FrmImports()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _uow = new UnitOfWork(context);
            _importService = new ImportService(_uow);

            LoadBooks();
            LoadImports();
            dtpImportDate.Value = DateTime.Now;
        }

        private void LoadBooks()
        {
            var books = _uow.Books.GetAll().ToList();
            cboBook.DataSource = books;
            cboBook.DisplayMember = "Title";
            cboBook.ValueMember = "BookId";
        }

        private void LoadImports()
        {
            dgvImports.DataSource = _importService.GetAll().ToList();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = (int)cboBook.SelectedValue;

                int quantity;
                if (!int.TryParse(numQuantity.Text, out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Số lượng phải > 0.");
                    return;
                }

                DateTime importDate = dtpImportDate.Value.Date;
                string note = txtNote.Text.Trim();

                _importService.ImportBook(bookId, quantity, importDate, note);
                MessageBox.Show("Nhập sách thành công.");

                LoadImports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadImports();
        }

        private void FrmImports_Load(object sender, EventArgs e)
        {

        }
    }
}
