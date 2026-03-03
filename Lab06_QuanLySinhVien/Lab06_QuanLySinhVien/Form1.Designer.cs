namespace Lab06_QuanLySinhVien
{
    partial class FrmQLSINHVIEN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLSINHVIEN));
            label1 = new Label();
            label2 = new Label();
            Btt_catnhat = new Button();
            Btt_xoa = new Button();
            Btt_thoat = new Button();
            Txtmasv = new TextBox();
            Txthovaten = new TextBox();
            Btt_tim = new Button();
            TxtTimKiem = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Btt_chon1hs = new Button();
            Btt_tra1hs = new Button();
            Btt_chontatca = new Button();
            Btt_tratatca = new Button();
            LstVDSSINHVIEN = new ListView();
            ColumnSTT1 = new ColumnHeader();
            ColumnMaSV1 = new ColumnHeader();
            ColumnHovaten1 = new ColumnHeader();
            LstVDSdachon = new ListView();
            columnSTT2 = new ColumnHeader();
            columnMaSV2 = new ColumnHeader();
            columnHoVaTen2 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Ma SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(150, 24);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 1;
            label2.Text = "Ho Va Ten";
            // 
            // Btt_catnhat
            // 
            Btt_catnhat.BackColor = Color.FromArgb(128, 255, 255);
            Btt_catnhat.BackgroundImageLayout = ImageLayout.Stretch;
            Btt_catnhat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_catnhat.ForeColor = Color.Blue;
            Btt_catnhat.Location = new Point(449, 51);
            Btt_catnhat.Name = "Btt_catnhat";
            Btt_catnhat.Size = new Size(88, 33);
            Btt_catnhat.TabIndex = 2;
            Btt_catnhat.Text = "Luu";
            Btt_catnhat.UseVisualStyleBackColor = false;
            Btt_catnhat.Click += Btt_catnhat_Click;
            // 
            // Btt_xoa
            // 
            Btt_xoa.BackColor = Color.FromArgb(128, 255, 255);
            Btt_xoa.BackgroundImageLayout = ImageLayout.Stretch;
            Btt_xoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_xoa.ForeColor = Color.Blue;
            Btt_xoa.Location = new Point(579, 51);
            Btt_xoa.Name = "Btt_xoa";
            Btt_xoa.Size = new Size(88, 33);
            Btt_xoa.TabIndex = 3;
            Btt_xoa.Text = "Xoa";
            Btt_xoa.UseVisualStyleBackColor = false;
            Btt_xoa.Click += Btt_xoa_Click;
            // 
            // Btt_thoat
            // 
            Btt_thoat.BackColor = Color.FromArgb(128, 255, 255);
            Btt_thoat.BackgroundImageLayout = ImageLayout.Stretch;
            Btt_thoat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_thoat.ForeColor = Color.Blue;
            Btt_thoat.Location = new Point(700, 51);
            Btt_thoat.Name = "Btt_thoat";
            Btt_thoat.Size = new Size(88, 33);
            Btt_thoat.TabIndex = 4;
            Btt_thoat.Text = "Thoat";
            Btt_thoat.UseVisualStyleBackColor = false;
            Btt_thoat.Click += Btt_thoat_Click;
            // 
            // Txtmasv
            // 
            Txtmasv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtmasv.Location = new Point(12, 57);
            Txtmasv.Name = "Txtmasv";
            Txtmasv.Size = new Size(88, 29);
            Txtmasv.TabIndex = 0;
            Txtmasv.TextAlign = HorizontalAlignment.Right;
            // 
            // Txthovaten
            // 
            Txthovaten.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txthovaten.ForeColor = Color.Blue;
            Txthovaten.Location = new Point(150, 57);
            Txthovaten.Name = "Txthovaten";
            Txthovaten.Size = new Size(249, 29);
            Txthovaten.TabIndex = 5;
            // 
            // Btt_tim
            // 
            Btt_tim.BackColor = Color.FromArgb(128, 255, 255);
            Btt_tim.BackgroundImageLayout = ImageLayout.Stretch;
            Btt_tim.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_tim.ForeColor = Color.Blue;
            Btt_tim.Location = new Point(198, 132);
            Btt_tim.Name = "Btt_tim";
            Btt_tim.Size = new Size(79, 33);
            Btt_tim.TabIndex = 6;
            Btt_tim.Text = "Tim Kiem";
            Btt_tim.UseVisualStyleBackColor = false;
            Btt_tim.Click += TxtTimKiem_TextChanged;
            // 
            // TxtTimKiem
            // 
            TxtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtTimKiem.ForeColor = Color.Blue;
            TxtTimKiem.Location = new Point(283, 135);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(290, 29);
            TxtTimKiem.TabIndex = 7;
            TxtTimKiem.KeyPress += TxtTimKiem_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Fuchsia;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(3, 142);
            label3.Name = "label3";
            label3.Size = new Size(189, 21);
            label3.TabIndex = 8;
            label3.Text = "DANH SACH SINH VIEN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Fuchsia;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(579, 135);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 9;
            label4.Text = "DANH SACH DA CHON";
            // 
            // Btt_chon1hs
            // 
            Btt_chon1hs.BackColor = Color.FromArgb(128, 255, 255);
            Btt_chon1hs.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_chon1hs.ForeColor = Color.Blue;
            Btt_chon1hs.Location = new Point(347, 193);
            Btt_chon1hs.Name = "Btt_chon1hs";
            Btt_chon1hs.Size = new Size(88, 33);
            Btt_chon1hs.TabIndex = 12;
            Btt_chon1hs.Text = ">";
            Btt_chon1hs.UseVisualStyleBackColor = false;
            Btt_chon1hs.Click += Btt_chon1hs_Click;
            // 
            // Btt_tra1hs
            // 
            Btt_tra1hs.BackColor = Color.FromArgb(128, 255, 255);
            Btt_tra1hs.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_tra1hs.ForeColor = Color.Blue;
            Btt_tra1hs.Location = new Point(347, 256);
            Btt_tra1hs.Name = "Btt_tra1hs";
            Btt_tra1hs.Size = new Size(88, 33);
            Btt_tra1hs.TabIndex = 13;
            Btt_tra1hs.Text = "<";
            Btt_tra1hs.UseVisualStyleBackColor = false;
            Btt_tra1hs.Click += Btt_tra1hs_Click;
            // 
            // Btt_chontatca
            // 
            Btt_chontatca.BackColor = Color.FromArgb(128, 255, 255);
            Btt_chontatca.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_chontatca.ForeColor = Color.Blue;
            Btt_chontatca.Location = new Point(347, 323);
            Btt_chontatca.Name = "Btt_chontatca";
            Btt_chontatca.Size = new Size(88, 33);
            Btt_chontatca.TabIndex = 14;
            Btt_chontatca.Text = ">>";
            Btt_chontatca.UseVisualStyleBackColor = false;
            Btt_chontatca.Click += Btt_chontatca_Click;
            // 
            // Btt_tratatca
            // 
            Btt_tratatca.BackColor = Color.FromArgb(128, 255, 255);
            Btt_tratatca.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_tratatca.ForeColor = Color.Blue;
            Btt_tratatca.Location = new Point(347, 382);
            Btt_tratatca.Name = "Btt_tratatca";
            Btt_tratatca.Size = new Size(88, 33);
            Btt_tratatca.TabIndex = 15;
            Btt_tratatca.Text = "<<";
            Btt_tratatca.UseVisualStyleBackColor = false;
            Btt_tratatca.Click += Btt_tratatca_Click;
            // 
            // LstVDSSINHVIEN
            // 
            LstVDSSINHVIEN.Columns.AddRange(new ColumnHeader[] { ColumnSTT1, ColumnMaSV1, ColumnHovaten1 });
            LstVDSSINHVIEN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LstVDSSINHVIEN.ForeColor = Color.FromArgb(0, 0, 192);
            LstVDSSINHVIEN.Location = new Point(6, 171);
            LstVDSSINHVIEN.Name = "LstVDSSINHVIEN";
            LstVDSSINHVIEN.Size = new Size(335, 273);
            LstVDSSINHVIEN.TabIndex = 16;
            LstVDSSINHVIEN.UseCompatibleStateImageBehavior = false;
            LstVDSSINHVIEN.View = View.Details;
            // 
            // ColumnSTT1
            // 
            ColumnSTT1.Text = "STT";
            // 
            // ColumnMaSV1
            // 
            ColumnMaSV1.Text = "Ma SV";
            // 
            // ColumnHovaten1
            // 
            ColumnHovaten1.Text = "Ho Va Ten";
            // 
            // LstVDSdachon
            // 
            LstVDSdachon.Columns.AddRange(new ColumnHeader[] { columnSTT2, columnMaSV2, columnHoVaTen2 });
            LstVDSdachon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LstVDSdachon.ForeColor = Color.FromArgb(0, 0, 192);
            LstVDSdachon.Location = new Point(449, 171);
            LstVDSdachon.Name = "LstVDSdachon";
            LstVDSdachon.Size = new Size(339, 273);
            LstVDSdachon.TabIndex = 17;
            LstVDSdachon.UseCompatibleStateImageBehavior = false;
            LstVDSdachon.View = View.Details;
            // 
            // columnSTT2
            // 
            columnSTT2.Text = "STT";
            // 
            // columnMaSV2
            // 
            columnMaSV2.Text = "Ma SV";
            // 
            // columnHoVaTen2
            // 
            columnHoVaTen2.Text = "Ho va Ten";
            // 
            // FrmQLSINHVIEN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(791, 444);
            Controls.Add(LstVDSdachon);
            Controls.Add(LstVDSSINHVIEN);
            Controls.Add(Btt_tratatca);
            Controls.Add(Btt_chontatca);
            Controls.Add(Btt_tra1hs);
            Controls.Add(Btt_chon1hs);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtTimKiem);
            Controls.Add(Btt_tim);
            Controls.Add(Txthovaten);
            Controls.Add(Txtmasv);
            Controls.Add(Btt_thoat);
            Controls.Add(Btt_xoa);
            Controls.Add(Btt_catnhat);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmQLSINHVIEN";
            Text = "FrmQLSINHVIEN";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Btt_catnhat;
        private Button Btt_xoa;
        private Button Btt_thoat;
        private TextBox Txtmasv;
        private TextBox Txthovaten;
        private Button Btt_tim;
        private TextBox TxtTimKiem;
        private Label label3;
        private Label label4;
        private Button Btt_chon1hs;
        private Button Btt_tra1hs;
        private Button Btt_chontatca;
        private Button Btt_tratatca;
        private ListView LstVDSSINHVIEN;
        private ListView LstVDSdachon;
        private ColumnHeader ColumnSTT1;
        private ColumnHeader ColumnMaSV1;
        private ColumnHeader ColumnHovaten1;
        private ColumnHeader columnSTT2;
        private ColumnHeader columnMaSV2;
        private ColumnHeader columnHoVaTen2;
    }
}
