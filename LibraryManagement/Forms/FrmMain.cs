using LibraryManagement.Domain.Entities;
using System;
using System.Windows.Forms;

namespace LibraryManagement.WinForms.Forms
{
    public partial class FrmMain : Form
    {
        private readonly AppUser _currentUser;

        public FrmMain(AppUser user)
        {
            InitializeComponent();
            _currentUser = user;
            Text = $"Library Management - {_currentUser.UserName} ({_currentUser.Role})";
        }

        private void menuBooks_Click(object sender, EventArgs e)
        {
            new FrmBooks().ShowDialog();
        }

        private void menuReaders_Click(object sender, EventArgs e)
        {
            new FrmReaders().ShowDialog();
        }

        private void menuBorrow_Click(object sender, EventArgs e)
        {
            new FrmBorrow().ShowDialog();
        }

        private void menuImports_Click(object sender, EventArgs e)
        {
            new FrmImports().ShowDialog();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
