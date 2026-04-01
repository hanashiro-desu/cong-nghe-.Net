namespace Danh_Muc_Nhan_Vien
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            TbNgaySinh = new DateTimePicker();
            Txt_Diachi = new TextBox();
            Txt_DT = new TextBox();
            Txt_HoTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            LstTTC = new ListView();
            columnHoTen = new ColumnHeader();
            columnNgaySinh = new ColumnHeader();
            columnDiaChi = new ColumnHeader();
            columnSDT = new ColumnHeader();
            Btt_Them = new Button();
            Btt_X = new Button();
            Btt_Sua = new Button();
            Btt_Thoat = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(199, 9);
            label1.Name = "label1";
            label1.Size = new Size(579, 65);
            label1.TabIndex = 0;
            label1.Text = "DANH MUC NHAN VIEN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(7, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "Ho Ten";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngay Sinh";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCoral;
            groupBox1.Controls.Add(TbNgaySinh);
            groupBox1.Controls.Add(Txt_Diachi);
            groupBox1.Controls.Add(Txt_DT);
            groupBox1.Controls.Add(Txt_HoTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Brown;
            groupBox1.Location = new Point(9, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(955, 108);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin Chi Tiet";
            // 
            // TbNgaySinh
            // 
            TbNgaySinh.CalendarForeColor = Color.Brown;
            TbNgaySinh.CalendarMonthBackground = Color.Brown;
            TbNgaySinh.CalendarTitleForeColor = Color.Brown;
            TbNgaySinh.Format = DateTimePickerFormat.Custom;
            TbNgaySinh.Location = new Point(160, 71);
            TbNgaySinh.Name = "TbNgaySinh";
            TbNgaySinh.Size = new Size(326, 27);
            TbNgaySinh.TabIndex = 6;
            // 
            // Txt_Diachi
            // 
            Txt_Diachi.Location = new Point(669, 73);
            Txt_Diachi.Name = "Txt_Diachi";
            Txt_Diachi.Size = new Size(268, 27);
            Txt_Diachi.TabIndex = 8;
            // 
            // Txt_DT
            // 
            Txt_DT.Location = new Point(669, 26);
            Txt_DT.Name = "Txt_DT";
            Txt_DT.Size = new Size(268, 27);
            Txt_DT.TabIndex = 7;
            // 
            // Txt_HoTen
            // 
            Txt_HoTen.Location = new Point(160, 26);
            Txt_HoTen.Name = "Txt_HoTen";
            Txt_HoTen.Size = new Size(326, 27);
            Txt_HoTen.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(563, 76);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 4;
            label5.Text = "Dia Chi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(563, 29);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 3;
            label4.Text = "Dien Thoai";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightCoral;
            groupBox2.Controls.Add(LstTTC);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Brown;
            groupBox2.Location = new Point(12, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(952, 304);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thong Tin Chung";
            // 
            // LstTTC
            // 
            LstTTC.BackColor = Color.FromArgb(255, 192, 128);
            LstTTC.Columns.AddRange(new ColumnHeader[] { columnHoTen, columnNgaySinh, columnDiaChi, columnSDT });
            LstTTC.ForeColor = Color.Brown;
            LstTTC.FullRowSelect = true;
            LstTTC.GridLines = true;
            LstTTC.Location = new Point(4, 32);
            LstTTC.Name = "LstTTC";
            LstTTC.Size = new Size(942, 266);
            LstTTC.TabIndex = 0;
            LstTTC.UseCompatibleStateImageBehavior = false;
            LstTTC.View = View.Details;
            LstTTC.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHoTen
            // 
            columnHoTen.Text = "Ho va Ten";
            columnHoTen.Width = 100;
            // 
            // columnNgaySinh
            // 
            columnNgaySinh.Text = "Ngay Sinh";
            // 
            // columnDiaChi
            // 
            columnDiaChi.Text = "Dia Chi";
            // 
            // columnSDT
            // 
            columnSDT.Text = "So Dien Thoai";
            // 
            // Btt_Them
            // 
            Btt_Them.BackColor = Color.MistyRose;
            Btt_Them.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_Them.ForeColor = Color.Brown;
            Btt_Them.Location = new Point(6, 14);
            Btt_Them.Name = "Btt_Them";
            Btt_Them.Size = new Size(78, 41);
            Btt_Them.TabIndex = 6;
            Btt_Them.Text = "Them";
            Btt_Them.UseVisualStyleBackColor = false;
            Btt_Them.Click += Btt_Them_Click;
            // 
            // Btt_X
            // 
            Btt_X.BackColor = Color.MistyRose;
            Btt_X.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_X.ForeColor = Color.Brown;
            Btt_X.Location = new Point(90, 14);
            Btt_X.Name = "Btt_X";
            Btt_X.Size = new Size(78, 41);
            Btt_X.TabIndex = 7;
            Btt_X.Text = "Xoa";
            Btt_X.UseVisualStyleBackColor = false;
            Btt_X.Click += Btt_X_Click;
            // 
            // Btt_Sua
            // 
            Btt_Sua.BackColor = Color.MistyRose;
            Btt_Sua.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_Sua.ForeColor = Color.Brown;
            Btt_Sua.Location = new Point(194, 14);
            Btt_Sua.Name = "Btt_Sua";
            Btt_Sua.Size = new Size(78, 41);
            Btt_Sua.TabIndex = 8;
            Btt_Sua.Text = "Sua";
            Btt_Sua.UseVisualStyleBackColor = false;
            Btt_Sua.Click += Btt_Sua_Click;
            // 
            // Btt_Thoat
            // 
            Btt_Thoat.BackColor = Color.MistyRose;
            Btt_Thoat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Btt_Thoat.ForeColor = Color.Brown;
            Btt_Thoat.Location = new Point(296, 14);
            Btt_Thoat.Name = "Btt_Thoat";
            Btt_Thoat.Size = new Size(78, 41);
            Btt_Thoat.TabIndex = 9;
            Btt_Thoat.Text = "Thoat";
            Btt_Thoat.UseVisualStyleBackColor = false;
            Btt_Thoat.Click += Btt_Thoat_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightCoral;
            groupBox3.Controls.Add(Btt_Thoat);
            groupBox3.Controls.Add(Btt_Sua);
            groupBox3.Controls.Add(Btt_X);
            groupBox3.Controls.Add(Btt_Them);
            groupBox3.Location = new Point(583, 191);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(381, 68);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(976, 566);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FrmDSNHANVIEN";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private ListView LstTTC;
        private DateTimePicker TbNgaySinh;
        private TextBox Txt_Diachi;
        private TextBox Txt_DT;
        private TextBox Txt_HoTen;
        private Button Btt_Them;
        private Button Btt_X;
        private Button Btt_Sua;
        private Button Btt_Thoat;
        private GroupBox groupBox3;
        private ColumnHeader columnHoTen;
        private ColumnHeader columnNgaySinh;
        private ColumnHeader columnDiaChi;
        private ColumnHeader columnSDT;
    }
}
