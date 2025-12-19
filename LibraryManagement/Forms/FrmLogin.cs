using LibraryManagement.Data;
using LibraryManagement.Data.Repositories;
using LibraryManagement.Services.Implementations;
using LibraryManagement.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace LibraryManagement.WinForms.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly IAuthService _authService;

        public FrmLogin()
        {
            InitializeComponent();

            var context = new LibraryContext();
            var uow = new UnitOfWork(context);
            _authService = new AuthService(uow);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _authService.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }

            Hide();
            var mainForm = new FrmMain(user);
            mainForm.ShowDialog();
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}


