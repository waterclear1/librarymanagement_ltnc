using System.Windows.Forms;

namespace LibraryManagement.WinForms.Forms
{
    partial class FrmBorrow
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cboReader;
        private ComboBox cboBook;
        private DateTimePicker dtpBorrowDate;
        private DateTimePicker dtpDueDate;
        private DataGridView dgvBorrow;
        private Button btnBorrow;
        private Button btnReturn;
        private Button btnRefresh;
        private Button btnFilterBorrowing;
        private Label lblReader;
        private Label lblBook;
        private Label lblBorrowDate;
        private Label lblDueDate;

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
            this.cboReader = new System.Windows.Forms.ComboBox();
            this.cboBook = new System.Windows.Forms.ComboBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilterBorrowing = new System.Windows.Forms.Button();
            this.lblReader = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Location = new System.Drawing.Point(20, 20);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(48, 15);
            this.lblReader.TabIndex = 0;
            this.lblReader.Text = "Độc giả";
            // 
            // cboReader
            // 
            this.cboReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReader.FormattingEnabled = true;
            this.cboReader.Location = new System.Drawing.Point(110, 17);
            this.cboReader.Name = "cboReader";
            this.cboReader.Size = new System.Drawing.Size(220, 23);
            this.cboReader.TabIndex = 1;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(20, 55);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(31, 15);
            this.lblBook.TabIndex = 2;
            this.lblBook.Text = "Sách";
            // 
            // cboBook
            // 
            this.cboBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBook.FormattingEnabled = true;
            this.cboBook.Location = new System.Drawing.Point(110, 52);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(220, 23);
            this.cboBook.TabIndex = 3;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(20, 90);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(61, 15);
            this.lblBorrowDate.TabIndex = 4;
            this.lblBorrowDate.Text = "Ngày mượn";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(110, 87);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(120, 23);
            this.dtpBorrowDate.TabIndex = 5;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(20, 125);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(50, 15);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Hạn trả";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(110, 122);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(120, 23);
            this.dtpDueDate.TabIndex = 7;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(20, 160);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 30);
            this.btnBorrow.TabIndex = 8;
            this.btnBorrow.Text = "Mượn";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(115, 160);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Trả";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(210, 160);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFilterBorrowing
            // 
            this.btnFilterBorrowing.Location = new System.Drawing.Point(305, 160);
            this.btnFilterBorrowing.Name = "btnFilterBorrowing";
            this.btnFilterBorrowing.Size = new System.Drawing.Size(125, 30);
            this.btnFilterBorrowing.TabIndex = 11;
            this.btnFilterBorrowing.Text = "Đang mượn";
            this.btnFilterBorrowing.UseVisualStyleBackColor = true;
            this.btnFilterBorrowing.Click += new System.EventHandler(this.btnFilterBorrowing_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(20, 210);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowTemplate.Height = 25;
            this.dgvBorrow.Size = new System.Drawing.Size(760, 170);
            this.dgvBorrow.TabIndex = 12;
            this.dgvBorrow.SelectionChanged += new System.EventHandler(this.dgvBorrow_SelectionChanged);
            // 
            // FrmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.btnFilterBorrowing);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.cboBook);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.cboReader);
            this.Controls.Add(this.lblReader);
            this.Name = "FrmBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn / trả sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
