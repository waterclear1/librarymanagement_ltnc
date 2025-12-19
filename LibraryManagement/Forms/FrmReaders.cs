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
    public partial class FrmReaders : Form
    {
        private readonly IReaderService _readerService;
        private readonly IUnitOfWork _uow;

        public FrmReaders()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _uow = new UnitOfWork(context);
            _readerService = new ReaderService(_uow);

            LoadData();
        }

        private void LoadData(string? keyword = null)
        {
            dgvReaders.DataSource = _readerService.GetAll(keyword).ToList();
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            dtpDOB.Value = DateTime.Now.AddYears(-18);
            dgvReaders.ClearSelection();
        }

        private Reader? GetSelectedReader()
        {
            return dgvReaders.CurrentRow?.DataBoundItem as Reader;
        }

        private void dgvReaders_SelectionChanged(object sender, EventArgs e)
        {
            var selected = GetSelectedReader();
            if (selected == null) return;

            txtFullName.Text = selected.FullName;
            txtPhone.Text = selected.Phone;
            txtAddress.Text = selected.Address;
            txtEmail.Text = selected.Email;
            dtpDOB.Value = selected.DOB;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Họ tên và SĐT là bắt buộc.");
                return;
            }

            var reader = new Reader
            {
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DOB = dtpDOB.Value.Date,
                CreatedDate = DateTime.Now
            };

            _readerService.Create(reader);
            LoadData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedReader();
            if (selected == null) return;

            selected.FullName = txtFullName.Text.Trim();
            selected.Phone = txtPhone.Text.Trim();
            selected.Address = txtAddress.Text.Trim();
            selected.Email = txtEmail.Text.Trim();
            selected.DOB = dtpDOB.Value.Date;

            _readerService.Update(selected);
            LoadData(txtSearch.Text.Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedReader();
            if (selected == null) return;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa độc giả này?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _readerService.Delete(selected.ReaderId);
                LoadData(txtSearch.Text.Trim());
                ClearForm();
            }
        }

        private void FrmReaders_Load(object sender, EventArgs e)
        {

        }
    }
}
