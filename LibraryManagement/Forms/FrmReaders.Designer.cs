using System.Windows.Forms;

namespace LibraryManagement.WinForms.Forms
{
    partial class FrmReaders
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvReaders;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private DateTimePicker dtpDOB;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblFullName;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblDOB;
        private Label lblSearch;

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
            dgvReaders = new DataGridView();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            dtpDOB = new DateTimePicker();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblFullName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            lblDOB = new Label();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReaders).BeginInit();
            SuspendLayout();
            // 
            // dgvReaders
            // 
            dgvReaders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReaders.Location = new Point(350, 45);
            dgvReaders.Name = "dgvReaders";
            dgvReaders.Size = new Size(430, 340);
            dgvReaders.TabIndex = 0;
            dgvReaders.SelectionChanged += dgvReaders_SelectionChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(110, 17);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(220, 23);
            txtFullName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(110, 52);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(110, 87);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(110, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 12;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(110, 157);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(120, 23);
            dtpDOB.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(409, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(635, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 25);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(706, 11);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 25);
            btnClear.TabIndex = 4;
            btnClear.Text = "Xóa lọc";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 30);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(70, 30);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 30);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(20, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(43, 15);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "Họ tên";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 55);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(28, 15);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "SĐT";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(20, 90);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(43, 15);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 125);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(20, 160);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(60, 15);
            lblDOB.TabIndex = 13;
            lblDOB.Text = "Ngày sinh";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(350, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(57, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Tìm kiếm";
            // 
            // FrmReaders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvReaders);
            Name = "FrmReaders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý độc giả";
            Load += FrmReaders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReaders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
