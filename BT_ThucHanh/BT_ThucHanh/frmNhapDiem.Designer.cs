namespace Lab08_QuanLySV.Models
{
    partial class frmNhapDiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            lblSinhVien = new Label();
            lblMonHoc = new Label();
            lblDiem = new Label();
            cboSinhVien = new ComboBox();
            cboMonHoc = new ComboBox();
            nudDiem = new NumericUpDown();
            btnLuuDiem = new Button();
            btnCapNhat = new Button();
            btnXoaDiem = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            lblDTB = new Label();
            dgvDiem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // lblSinhVien
            // 
            lblSinhVien.AutoSize = true;
            lblSinhVien.BackColor = Color.SlateBlue;
            lblSinhVien.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblSinhVien.ForeColor = Color.SlateBlue;
            lblSinhVien.Image = (Image)resources.GetObject("lblSinhVien.Image");
            lblSinhVien.ImageAlign = ContentAlignment.MiddleLeft;
            lblSinhVien.Location = new Point(70, 28);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.Size = new Size(87, 20);
            lblSinhVien.TabIndex = 0;
            lblSinhVien.Text = "Sinh viên:";
            // 
            // lblMonHoc
            // 
            lblMonHoc.AutoSize = true;
            lblMonHoc.BackColor = Color.SlateBlue;
            lblMonHoc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblMonHoc.ForeColor = Color.SlateBlue;
            lblMonHoc.Image = (Image)resources.GetObject("lblMonHoc.Image");
            lblMonHoc.ImageAlign = ContentAlignment.MiddleLeft;
            lblMonHoc.Location = new Point(70, 68);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(82, 20);
            lblMonHoc.TabIndex = 1;
            lblMonHoc.Text = "Môn học:";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.BackColor = Color.SlateBlue;
            lblDiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDiem.ForeColor = Color.SlateBlue;
            lblDiem.Image = (Image)resources.GetObject("lblDiem.Image");
            lblDiem.ImageAlign = ContentAlignment.MiddleLeft;
            lblDiem.Location = new Point(70, 106);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(55, 20);
            lblDiem.TabIndex = 2;
            lblDiem.Text = "Điểm:";
            // 
            // cboSinhVien
            // 
            cboSinhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSinhVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSinhVien.FormattingEnabled = true;
            cboSinhVien.Location = new Point(166, 25);
            cboSinhVien.Margin = new Padding(3, 2, 3, 2);
            cboSinhVien.Name = "cboSinhVien";
            cboSinhVien.Size = new Size(333, 33);
            cboSinhVien.TabIndex = 3;
            // 
            // cboMonHoc
            // 
            cboMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonHoc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(166, 64);
            cboMonHoc.Margin = new Padding(3, 2, 3, 2);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(333, 33);
            cboMonHoc.TabIndex = 4;
            // 
            // nudDiem
            // 
            nudDiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudDiem.ForeColor = Color.DarkOrchid;
            nudDiem.Location = new Point(166, 103);
            nudDiem.Margin = new Padding(3, 2, 3, 2);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(105, 32);
            nudDiem.TabIndex = 5;
            nudDiem.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnLuuDiem
            // 
            btnLuuDiem.BackColor = Color.SlateBlue;
            btnLuuDiem.BackgroundImage = (Image)resources.GetObject("btnLuuDiem.BackgroundImage");
            btnLuuDiem.FlatStyle = FlatStyle.Flat;
            btnLuuDiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnLuuDiem.ForeColor = Color.SlateBlue;
            btnLuuDiem.Image = (Image)resources.GetObject("btnLuuDiem.Image");
            btnLuuDiem.ImageAlign = ContentAlignment.TopLeft;
            btnLuuDiem.Location = new Point(15, 150);
            btnLuuDiem.Margin = new Padding(3, 2, 3, 2);
            btnLuuDiem.Name = "btnLuuDiem";
            btnLuuDiem.Size = new Size(114, 39);
            btnLuuDiem.TabIndex = 6;
            btnLuuDiem.Text = "➕ Lưu điểm";
            btnLuuDiem.UseVisualStyleBackColor = false;
            btnLuuDiem.Click += btnLuuDiem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.SlateBlue;
            btnCapNhat.BackgroundImage = (Image)resources.GetObject("btnCapNhat.BackgroundImage");
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCapNhat.ForeColor = Color.SlateBlue;
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.TopLeft;
            btnCapNhat.Location = new Point(15, 201);
            btnCapNhat.Margin = new Padding(3, 2, 3, 2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(114, 39);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "📣Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoaDiem
            // 
            btnXoaDiem.BackColor = Color.SlateBlue;
            btnXoaDiem.BackgroundImage = (Image)resources.GetObject("btnXoaDiem.BackgroundImage");
            btnXoaDiem.FlatStyle = FlatStyle.Flat;
            btnXoaDiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnXoaDiem.ForeColor = Color.SlateBlue;
            btnXoaDiem.Image = (Image)resources.GetObject("btnXoaDiem.Image");
            btnXoaDiem.ImageAlign = ContentAlignment.TopLeft;
            btnXoaDiem.Location = new Point(12, 261);
            btnXoaDiem.Margin = new Padding(3, 2, 3, 2);
            btnXoaDiem.Name = "btnXoaDiem";
            btnXoaDiem.Size = new Size(114, 39);
            btnXoaDiem.TabIndex = 8;
            btnXoaDiem.Text = "🗑️ Xóa điểm";
            btnXoaDiem.UseVisualStyleBackColor = false;
            btnXoaDiem.Click += btnXoaDiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.SlateBlue;
            btnLamMoi.BackgroundImage = (Image)resources.GetObject("btnLamMoi.BackgroundImage");
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.SlateBlue;
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(157, 149);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(114, 39);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.BackColor = Color.SlateBlue;
            lblTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.SlateBlue;
            lblTimKiem.Image = (Image)resources.GetObject("lblTimKiem.Image");
            lblTimKiem.Location = new Point(294, 103);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(73, 20);
            lblTimKiem.TabIndex = 10;
            lblTimKiem.Text = "Từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(294, 157);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(167, 32);
            txtTimKiem.TabIndex = 11;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SlateBlue;
            btnTimKiem.BackgroundImage = (Image)resources.GetObject("btnTimKiem.BackgroundImage");
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.SlateBlue;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(478, 154);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(64, 39);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "🔍";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblDTB
            // 
            lblDTB.AutoSize = true;
            lblDTB.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDTB.ForeColor = Color.Blue;
            lblDTB.Location = new Point(15, 201);
            lblDTB.Name = "lblDTB";
            lblDTB.Size = new Size(0, 20);
            lblDTB.TabIndex = 13;
            // 
            // dgvDiem
            // 
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Location = new Point(-2, 377);
            dgvDiem.Margin = new Padding(3, 2, 3, 2);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.ReadOnly = true;
            dgvDiem.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiem.Size = new Size(823, 232);
            dgvDiem.TabIndex = 14;
            dgvDiem.SelectionChanged += dgvDiem_SelectionChanged;
            // 
            // frmNhapDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(814, 607);
            Controls.Add(dgvDiem);
            Controls.Add(lblDTB);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoaDiem);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuuDiem);
            Controls.Add(nudDiem);
            Controls.Add(cboMonHoc);
            Controls.Add(cboSinhVien);
            Controls.Add(lblDiem);
            Controls.Add(lblMonHoc);
            Controls.Add(lblSinhVien);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmNhapDiem";
            Text = "frmNhapDiem — Nhập Điểm";
            Load += frmNhapDiem_Load;
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSinhVien;
        private Label lblMonHoc;
        private Label lblDiem;
        private ComboBox cboSinhVien;
        private ComboBox cboMonHoc;
        private NumericUpDown nudDiem;
        private Button btnLuuDiem;
        private Button btnCapNhat;
        private Button btnXoaDiem;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label lblDTB;
        private DataGridView dgvDiem;
    }
}
