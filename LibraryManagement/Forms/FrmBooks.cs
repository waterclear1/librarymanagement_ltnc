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
    public partial class FrmBooks : Form
    {
        private readonly IBookService _bookService;
        private readonly IUnitOfWork _uow;

        public FrmBooks()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _uow = new UnitOfWork(context);
            _bookService = new BookService(_uow);

            LoadCategories();
            LoadData();
        }

        private void LoadCategories()
        {
            var categories = _uow.Categories.GetAll().ToList();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
        }

        private void LoadData(string? keyword = null)
        {
            dgvBooks.DataSource = _bookService.GetAll(keyword).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = txtTitle.Text.Trim(),
                CategoryId = (int)cboCategory.SelectedValue,
                Publisher = txtPublisher.Text.Trim(),
                PublishedYear = int.Parse(txtYear.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Available = int.Parse(txtQuantity.Text),
                Description = txtDescription.Text.Trim()
            };

            _bookService.Create(book);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow?.DataBoundItem is not Book selected) return;

            selected.Title = txtTitle.Text.Trim();
            selected.CategoryId = (int)cboCategory.SelectedValue;
            selected.Publisher = txtPublisher.Text.Trim();
            selected.PublishedYear = int.Parse(txtYear.Text);
            selected.Quantity = int.Parse(txtQuantity.Text);
            selected.Description = txtDescription.Text.Trim();

            _bookService.Update(selected);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow?.DataBoundItem is not Book selected) return;

            if (MessageBox.Show("Xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _bookService.Delete(selected.BookId);
                LoadData();
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow?.DataBoundItem is not Book selected) return;

            txtTitle.Text = selected.Title;
            txtPublisher.Text = selected.Publisher;
            txtYear.Text = selected.PublishedYear.ToString();
            txtQuantity.Text = selected.Quantity.ToString();
            txtDescription.Text = selected.Description;
            cboCategory.SelectedValue = selected.CategoryId;
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
