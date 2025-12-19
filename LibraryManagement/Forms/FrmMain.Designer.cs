using System.Windows.Forms;

namespace LibraryManagement.WinForms.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuBooks;
        private ToolStripMenuItem menuReaders;
        private ToolStripMenuItem menuBorrow;
        private ToolStripMenuItem menuImports;
        private ToolStripMenuItem menuLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuBooks = new ToolStripMenuItem();
            menuReaders = new ToolStripMenuItem();
            menuBorrow = new ToolStripMenuItem();
            menuImports = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuBooks, menuReaders, menuBorrow, menuImports, menuLogout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuBooks
            // 
            menuBooks.Name = "menuBooks";
            menuBooks.Size = new Size(87, 20);
            menuBooks.Text = "Quản lý sách";
            menuBooks.Click += menuBooks_Click;
            // 
            // menuReaders
            // 
            menuReaders.Name = "menuReaders";
            menuReaders.Size = new Size(102, 20);
            menuReaders.Text = "Quản lý độc giả";
            menuReaders.Click += menuReaders_Click;
            // 
            // menuBorrow
            // 
            menuBorrow.Name = "menuBorrow";
            menuBorrow.Size = new Size(112, 20);
            menuBorrow.Text = "Quản lý mượn trả";
            menuBorrow.Click += menuBorrow_Click;
            // 
            // menuImports
            // 
            menuImports.Name = "menuImports";
            menuImports.Size = new Size(79, 20);
            menuImports.Text = "Phiếu nhập";
            menuImports.Click += menuImports_Click;
            // 
            // menuLogout
            // 
            menuLogout.Alignment = ToolStripItemAlignment.Right;
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(72, 20);
            menuLogout.Text = "Đăng xuất";
            menuLogout.Click += menuLogout_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
