using System.Windows.Forms;

namespace LibraryManagement.WinForms.Forms
{
    partial class FrmImports
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cboBook;
        private TextBox numQuantity;      // TextBox dùng như số lượng
        private DateTimePicker dtpImportDate;
        private TextBox txtNote;
        private DataGridView dgvImports;
        private Button btnImport;
        private Button btnRefresh;
        private Label lblBook;
        private Label lblQuantity;
        private Label lblImportDate;
        private Label lblNote;

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
            cboBook = new ComboBox();
            numQuantity = new TextBox();
            dtpImportDate = new DateTimePicker();
            txtNote = new TextBox();
            dgvImports = new DataGridView();
            btnImport = new Button();
            btnRefresh = new Button();
            lblBook = new Label();
            lblQuantity = new Label();
            lblImportDate = new Label();
            lblNote = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvImports).BeginInit();
            SuspendLayout();
            // 
            // cboBook
            // 
            cboBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBook.FormattingEnabled = true;
            cboBook.Location = new Point(110, 17);
            cboBook.Name = "cboBook";
            cboBook.Size = new Size(220, 23);
            cboBook.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(110, 52);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(80, 23);
            numQuantity.TabIndex = 3;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Format = DateTimePickerFormat.Short;
            dtpImportDate.Location = new Point(110, 87);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(120, 23);
            dtpImportDate.TabIndex = 5;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(110, 122);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(220, 80);
            txtNote.TabIndex = 7;
            // 
            // dgvImports
            // 
            dgvImports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvImports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImports.Location = new Point(350, 20);
            dgvImports.Name = "dgvImports";
            dgvImports.Size = new Size(430, 360);
            dgvImports.TabIndex = 10;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(20, 220);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(85, 30);
            btnImport.TabIndex = 8;
            btnImport.Text = "Nhập sách";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(120, 220);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 30);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Location = new Point(20, 20);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(32, 15);
            lblBook.TabIndex = 0;
            lblBook.Text = "Sách";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 55);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(54, 15);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng";
            // 
            // lblImportDate
            // 
            lblImportDate.AutoSize = true;
            lblImportDate.Location = new Point(20, 90);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(65, 15);
            lblImportDate.TabIndex = 4;
            lblImportDate.Text = "Ngày nhập";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(20, 125);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(48, 15);
            lblNote.TabIndex = 6;
            lblNote.Text = "Ghi chú";
            // 
            // FrmImports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(dgvImports);
            Controls.Add(btnRefresh);
            Controls.Add(btnImport);
            Controls.Add(txtNote);
            Controls.Add(lblNote);
            Controls.Add(dtpImportDate);
            Controls.Add(lblImportDate);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cboBook);
            Controls.Add(lblBook);
            Name = "FrmImports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu nhập sách";
            Load += FrmImports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
