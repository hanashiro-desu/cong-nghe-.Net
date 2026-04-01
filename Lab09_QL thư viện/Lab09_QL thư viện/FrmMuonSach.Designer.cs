namespace Lab09_QL_thư_viện
{
    partial class FrmMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMuonSach));
            label1 = new Label();
            label2 = new Label();
            Bttthem = new Button();
            label3 = new Label();
            Cboxmadocgia = new ComboBox();
            cbbten = new ComboBox();
            cbbhanthe = new ComboBox();
            cbbtacgia = new ComboBox();
            cbbtensach = new ComboBox();
            cbbmasach = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvPhieuMuon = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            dgvDSmuon = new DataGridView();
            dgvchitietphieu = new DataGridView();
            label9 = new Label();
            Btt_save = new Button();
            Btt_xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSmuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvchitietphieu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(26, 46);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "Ma Doc Gia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.LightSkyBlue;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 1;
            label2.Text = "Ten Doc Gia";
            // 
            // Bttthem
            // 
            Bttthem.BackColor = SystemColors.GradientActiveCaption;
            Bttthem.BackgroundImage = (Image)resources.GetObject("Bttthem.BackgroundImage");
            Bttthem.BackgroundImageLayout = ImageLayout.Stretch;
            Bttthem.FlatStyle = FlatStyle.Popup;
            Bttthem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Bttthem.ForeColor = Color.LightSkyBlue;
            Bttthem.Image = (Image)resources.GetObject("Bttthem.Image");
            Bttthem.ImageAlign = ContentAlignment.TopRight;
            Bttthem.Location = new Point(724, 188);
            Bttthem.Name = "Bttthem";
            Bttthem.Size = new Size(53, 37);
            Bttthem.TabIndex = 7;
            Bttthem.Text = "➕ Them";
            Bttthem.TextAlign = ContentAlignment.TopCenter;
            Bttthem.UseVisualStyleBackColor = false;
            Bttthem.Click += them_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.LightSkyBlue;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(26, 150);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 14;
            label3.Tag = "Han the";
            label3.Text = "Han the";
            // 
            // Cboxmadocgia
            // 
            Cboxmadocgia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cboxmadocgia.FormattingEnabled = true;
            Cboxmadocgia.Location = new Point(160, 45);
            Cboxmadocgia.Name = "Cboxmadocgia";
            Cboxmadocgia.Size = new Size(235, 33);
            Cboxmadocgia.TabIndex = 15;
            Cboxmadocgia.SelectedIndexChanged += Cboxmadocgia_SelectedIndexChanged;
            // 
            // cbbten
            // 
            cbbten.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbten.FormattingEnabled = true;
            cbbten.Location = new Point(160, 98);
            cbbten.Name = "cbbten";
            cbbten.Size = new Size(235, 33);
            cbbten.TabIndex = 16;
            // 
            // cbbhanthe
            // 
            cbbhanthe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbhanthe.FormattingEnabled = true;
            cbbhanthe.Location = new Point(160, 149);
            cbbhanthe.Name = "cbbhanthe";
            cbbhanthe.Size = new Size(235, 33);
            cbbhanthe.TabIndex = 17;
            // 
            // cbbtacgia
            // 
            cbbtacgia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbtacgia.FormattingEnabled = true;
            cbbtacgia.Location = new Point(542, 149);
            cbbtacgia.Name = "cbbtacgia";
            cbbtacgia.Size = new Size(235, 33);
            cbbtacgia.TabIndex = 23;
            // 
            // cbbtensach
            // 
            cbbtensach.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbtensach.FormattingEnabled = true;
            cbbtensach.Location = new Point(542, 98);
            cbbtensach.Name = "cbbtensach";
            cbbtensach.Size = new Size(235, 33);
            cbbtensach.TabIndex = 22;
            // 
            // cbbmasach
            // 
            cbbmasach.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbmasach.FormattingEnabled = true;
            cbbmasach.Location = new Point(542, 45);
            cbbmasach.Name = "cbbmasach";
            cbbmasach.Size = new Size(235, 33);
            cbbmasach.TabIndex = 21;
            cbbmasach.SelectedIndexChanged += cbbmasach_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.LightSkyBlue;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(405, 150);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 20;
            label4.Tag = "Han the";
            label4.Text = "Tác giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(405, 99);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 19;
            label5.Text = "Ten Sach";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.LightSkyBlue;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(401, 46);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 18;
            label6.Text = "Ma Sach";
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Location = new Point(604, 268);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPhieuMuon.Size = new Size(399, 187);
            dgvPhieuMuon.TabIndex = 24;
            dgvPhieuMuon.CellContentClick += dgvPhieuMuon_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.LightSkyBlue;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(0, 466);
            label7.Name = "label7";
            label7.Size = new Size(242, 32);
            label7.TabIndex = 25;
            label7.Tag = "Danh sach phieu muon";
            label7.Text = "Danh sach phieu muon";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientActiveCaption;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label8.ForeColor = Color.LightSkyBlue;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(604, 233);
            label8.Name = "label8";
            label8.Size = new Size(241, 32);
            label8.TabIndex = 26;
            label8.Tag = "CHITIETPHIEUMUON";
            label8.Text = "CHI TIET PHIEU MUON";
            // 
            // dgvDSmuon
            // 
            dgvDSmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSmuon.Location = new Point(0, 501);
            dgvDSmuon.Name = "dgvDSmuon";
            dgvDSmuon.Size = new Size(1013, 205);
            dgvDSmuon.TabIndex = 28;
            // 
            // dgvchitietphieu
            // 
            dgvchitietphieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvchitietphieu.Location = new Point(0, 258);
            dgvchitietphieu.Name = "dgvchitietphieu";
            dgvchitietphieu.Size = new Size(474, 205);
            dgvchitietphieu.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientActiveCaption;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label9.ForeColor = Color.LightSkyBlue;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(0, 223);
            label9.Name = "label9";
            label9.Size = new Size(158, 32);
            label9.TabIndex = 30;
            label9.Tag = "Danh sach phieu muon";
            label9.Text = "Chi Tiet Phieu ";
            // 
            // Btt_save
            // 
            Btt_save.BackColor = SystemColors.GradientActiveCaption;
            Btt_save.BackgroundImage = (Image)resources.GetObject("Btt_save.BackgroundImage");
            Btt_save.BackgroundImageLayout = ImageLayout.Stretch;
            Btt_save.FlatStyle = FlatStyle.Popup;
            Btt_save.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Btt_save.ForeColor = Color.LightSkyBlue;
            Btt_save.Image = (Image)resources.GetObject("Btt_save.Image");
            Btt_save.ImageAlign = ContentAlignment.TopRight;
            Btt_save.Location = new Point(646, 188);
            Btt_save.Name = "Btt_save";
            Btt_save.Size = new Size(72, 37);
            Btt_save.TabIndex = 32;
            Btt_save.Text = "Save";
            Btt_save.TextAlign = ContentAlignment.TopCenter;
            Btt_save.UseVisualStyleBackColor = false;
            Btt_save.Click += Btt_save_Click;
            // 
            // Btt_xoa
            // 
            Btt_xoa.BackColor = SystemColors.GradientActiveCaption;
            Btt_xoa.BackgroundImage = (Image)resources.GetObject("Btt_xoa.BackgroundImage");
            Btt_xoa.BackgroundImageLayout = ImageLayout.Stretch;
            Btt_xoa.FlatStyle = FlatStyle.Popup;
            Btt_xoa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Btt_xoa.ForeColor = Color.LightSkyBlue;
            Btt_xoa.Image = (Image)resources.GetObject("Btt_xoa.Image");
            Btt_xoa.ImageAlign = ContentAlignment.TopRight;
            Btt_xoa.Location = new Point(792, 188);
            Btt_xoa.Name = "Btt_xoa";
            Btt_xoa.Size = new Size(53, 37);
            Btt_xoa.TabIndex = 33;
            Btt_xoa.Text = "- Xoa";
            Btt_xoa.TextAlign = ContentAlignment.TopCenter;
            Btt_xoa.UseVisualStyleBackColor = false;
            Btt_xoa.Click += Btt_xoa_Click;
            // 
            // FrmMuonSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1005, 707);
            Controls.Add(Btt_xoa);
            Controls.Add(Btt_save);
            Controls.Add(label9);
            Controls.Add(dgvchitietphieu);
            Controls.Add(dgvDSmuon);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvPhieuMuon);
            Controls.Add(cbbtacgia);
            Controls.Add(cbbtensach);
            Controls.Add(cbbmasach);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(cbbhanthe);
            Controls.Add(cbbten);
            Controls.Add(Cboxmadocgia);
            Controls.Add(label3);
            Controls.Add(Bttthem);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmMuonSach";
            Text = "FormMuonSach";
            Load += FormQLBC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSmuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvchitietphieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Bttthem;
        private Label label3;
        private ComboBox Cboxmadocgia;
        private ComboBox cbbten;
        private ComboBox cbbhanthe;
        private ComboBox cbbtacgia;
        private ComboBox cbbtensach;
        private ComboBox cbbmasach;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvPhieuMuon;
        private Label label7;
        private Label label8;
        private DataGridView dgvDSmuon;
        private DataGridView dgvchitietphieu;
        private Label label9;
        private Button Btt_save;
        private Button Btt_xoa;
    }
}