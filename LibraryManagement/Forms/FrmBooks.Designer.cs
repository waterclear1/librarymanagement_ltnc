using System.Windows.Forms;

namespace LibraryManagement.WinForms.Forms
{
    partial class FrmBooks
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvBooks;
        private TextBox txtTitle;
        private TextBox txtPublisher;
        private TextBox txtYear;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private ComboBox cboCategory;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblTitle;
        private Label lblCategory;
        private Label lblPublisher;
        private Label lblYear;
        private Label lblQuantity;
        private Label lblDescription;
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
            dgvBooks = new DataGridView();
            txtTitle = new TextBox();
            txtPublisher = new TextBox();
            txtYear = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            cboCategory = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblTitle = new Label();
            lblCategory = new Label();
            lblPublisher = new Label();
            lblYear = new Label();
            lblQuantity = new Label();
            lblDescription = new Label();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(350, 45);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(430, 340);
            dgvBooks.TabIndex = 0;
            dgvBooks.SelectionChanged += dgvBooks_SelectionChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(110, 17);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(220, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(110, 87);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(220, 23);
            txtPublisher.TabIndex = 9;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(110, 122);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(80, 23);
            txtYear.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(110, 157);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(80, 23);
            txtQuantity.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(110, 192);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 80);
            txtDescription.TabIndex = 15;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(110, 52);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(220, 23);
            cboCategory.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(409, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(675, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 25);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(115, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(210, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(46, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Tiêu đề";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 55);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(49, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Thể loại";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(20, 90);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(77, 15);
            lblPublisher.TabIndex = 8;
            lblPublisher.Text = "Nhà xuất bản";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(20, 125);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(81, 15);
            lblYear.TabIndex = 10;
            lblYear.Text = "Năm xuất bản";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 160);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(54, 15);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Số lượng";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 195);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(38, 15);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Mô tả";
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
            // FrmBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtPublisher);
            Controls.Add(lblPublisher);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvBooks);
            Name = "FrmBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sách";
            Load += FrmBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
