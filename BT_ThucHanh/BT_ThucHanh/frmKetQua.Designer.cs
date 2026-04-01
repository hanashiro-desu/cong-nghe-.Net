namespace BT_ThucHanh
{
    partial class frmKetQua
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
            lblSinhVien = new Label();
            cboSinhVien = new ComboBox();
            btnXem = new Button();
            pnlTongKet = new Panel();
            lblDTB = new Label();
            lblSoMon = new Label();
            lblXepLoai = new Label();
            dgvKetQua = new DataGridView();
            btnXuatCSV = new Button();
            pnlTongKet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // lblSinhVien
            // 
            lblSinhVien.AutoSize = true;
            lblSinhVien.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSinhVien.ForeColor = Color.IndianRed;
            lblSinhVien.Image = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            lblSinhVien.ImageAlign = ContentAlignment.TopCenter;
            lblSinhVien.Location = new Point(37, 42);
            lblSinhVien.Margin = new Padding(4, 0, 4, 0);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.Size = new Size(103, 24);
            lblSinhVien.TabIndex = 0;
            lblSinhVien.Text = "Sinh viên:";
            // 
            // cboSinhVien
            // 
            cboSinhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSinhVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSinhVien.FormattingEnabled = true;
            cboSinhVien.Location = new Point(162, 33);
            cboSinhVien.Margin = new Padding(4, 3, 4, 3);
            cboSinhVien.Name = "cboSinhVien";
            cboSinhVien.Size = new Size(474, 33);
            cboSinhVien.TabIndex = 1;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.FromArgb(46, 125, 50);
            btnXem.BackgroundImage = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            btnXem.BackgroundImageLayout = ImageLayout.Center;
            btnXem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXem.ForeColor = Color.IndianRed;
            btnXem.Image = Properties.Resources.z7474017090296_da338a7dda9af91b265bc12dbb254a4d;
            btnXem.Location = new Point(644, 33);
            btnXem.Margin = new Padding(4, 3, 4, 3);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(179, 33);
            btnXem.TabIndex = 2;
            btnXem.Text = "🔍 Xem kết quả";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // pnlTongKet
            // 
            pnlTongKet.BackColor = Color.FromArgb(232, 248, 240);
            pnlTongKet.BackgroundImage = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            pnlTongKet.BackgroundImageLayout = ImageLayout.Center;
            pnlTongKet.BorderStyle = BorderStyle.FixedSingle;
            pnlTongKet.Controls.Add(lblDTB);
            pnlTongKet.Controls.Add(lblSoMon);
            pnlTongKet.Controls.Add(lblXepLoai);
            pnlTongKet.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlTongKet.Location = new Point(-6, 92);
            pnlTongKet.Margin = new Padding(4, 3, 4, 3);
            pnlTongKet.Name = "pnlTongKet";
            pnlTongKet.Size = new Size(877, 43);
            pnlTongKet.TabIndex = 3;
            // 
            // lblDTB
            // 
            lblDTB.AutoSize = true;
            lblDTB.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblDTB.ForeColor = Color.IndianRed;
            lblDTB.Image = Properties.Resources.z7474017090296_da338a7dda9af91b265bc12dbb254a4d;
            lblDTB.ImageAlign = ContentAlignment.TopCenter;
            lblDTB.Location = new Point(14, 12);
            lblDTB.Margin = new Padding(4, 0, 4, 0);
            lblDTB.Name = "lblDTB";
            lblDTB.Size = new Size(55, 16);
            lblDTB.TabIndex = 0;
            lblDTB.Text = "ĐTB: —";
            // 
            // lblSoMon
            // 
            lblSoMon.AutoSize = true;
            lblSoMon.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblSoMon.ForeColor = Color.IndianRed;
            lblSoMon.Image = Properties.Resources.z7474017090296_da338a7dda9af91b265bc12dbb254a4d;
            lblSoMon.ImageAlign = ContentAlignment.TopCenter;
            lblSoMon.Location = new Point(250, 12);
            lblSoMon.Margin = new Padding(4, 0, 4, 0);
            lblSoMon.Name = "lblSoMon";
            lblSoMon.Size = new Size(105, 16);
            lblSoMon.TabIndex = 1;
            lblSoMon.Text = "Môn đã học: —";
            // 
            // lblXepLoai
            // 
            lblXepLoai.AutoSize = true;
            lblXepLoai.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblXepLoai.ForeColor = Color.IndianRed;
            lblXepLoai.Image = Properties.Resources.z7474017090296_da338a7dda9af91b265bc12dbb254a4d;
            lblXepLoai.ImageAlign = ContentAlignment.TopCenter;
            lblXepLoai.Location = new Point(526, 12);
            lblXepLoai.Margin = new Padding(4, 0, 4, 0);
            lblXepLoai.Name = "lblXepLoai";
            lblXepLoai.Size = new Size(82, 16);
            lblXepLoai.TabIndex = 2;
            lblXepLoai.Text = "Xếp loại: —";
            // 
            // dgvKetQua
            // 
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(-6, 223);
            dgvKetQua.Margin = new Padding(4, 3, 4, 3);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.ReadOnly = true;
            dgvKetQua.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.Size = new Size(877, 244);
            dgvKetQua.TabIndex = 4;
            // 
            // btnXuatCSV
            // 
            btnXuatCSV.BackgroundImage = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            btnXuatCSV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatCSV.ForeColor = Color.IndianRed;
            btnXuatCSV.Location = new Point(963, 32);
            btnXuatCSV.Margin = new Padding(4, 3, 4, 3);
            btnXuatCSV.Name = "btnXuatCSV";
            btnXuatCSV.Size = new Size(200, 45);
            btnXuatCSV.TabIndex = 5;
            btnXuatCSV.Text = "💾 Xuất CSV";
            btnXuatCSV.UseVisualStyleBackColor = true;
            btnXuatCSV.Click += btnXuatCSV_Click;
            // 
            // frmKetQua
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(866, 464);
            Controls.Add(btnXuatCSV);
            Controls.Add(dgvKetQua);
            Controls.Add(pnlTongKet);
            Controls.Add(btnXem);
            Controls.Add(cboSinhVien);
            Controls.Add(lblSinhVien);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ForeColor = Color.IndianRed;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmKetQua";
            Text = "frmKetQua — Kết quả học tập";
            Load += frmKetQua_Load;
            pnlTongKet.ResumeLayout(false);
            pnlTongKet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSinhVien;
        private ComboBox cboSinhVien;
        private Button btnXem;
        private Panel pnlTongKet;
        private Label lblDTB;
        private Label lblSoMon;
        private Label lblXepLoai;
        private DataGridView dgvKetQua;
        private Button btnXuatCSV;
    }
}
