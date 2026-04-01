namespace Lab09_QL_thư_viện
{
    partial class FormNHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNHANVIEN));
            dgvNHANVIEN = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            Txthoten = new TextBox();
            label3 = new Label();
            Txtdiachi = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Txtsdt = new TextBox();
            label7 = new Label();
            dtpngaysinh = new DateTimePicker();
            cbbtenbangcap = new ComboBox();
            Them = new Button();
            Sua = new Button();
            Xoa = new Button();
            Btt_timkiem = new Button();
            Btt_lammoi = new Button();
            lblMaSo = new Label();
            txttimkiem = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNHANVIEN).BeginInit();
            SuspendLayout();
            // 
            // dgvNHANVIEN
            // 
            dgvNHANVIEN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNHANVIEN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNHANVIEN.Location = new Point(0, 187);
            dgvNHANVIEN.Margin = new Padding(3, 2, 3, 2);
            dgvNHANVIEN.Name = "dgvNHANVIEN";
            dgvNHANVIEN.Size = new Size(1169, 224);
            dgvNHANVIEN.TabIndex = 0;
            dgvNHANVIEN.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Chocolate;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(7, 21);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 2;
            label1.Text = "MA SO NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Chocolate;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(7, 60);
            label2.Name = "label2";
            label2.Size = new Size(77, 27);
            label2.TabIndex = 3;
            label2.Text = "Ho Ten";
            // 
            // Txthoten
            // 
            Txthoten.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txthoten.Location = new Point(119, 56);
            Txthoten.Margin = new Padding(3, 2, 3, 2);
            Txthoten.Name = "Txthoten";
            Txthoten.Size = new Size(221, 29);
            Txthoten.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PeachPuff;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Chocolate;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(7, 99);
            label3.Name = "label3";
            label3.Size = new Size(102, 27);
            label3.TabIndex = 5;
            label3.Text = "Ngay sinh";
            // 
            // Txtdiachi
            // 
            Txtdiachi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txtdiachi.Location = new Point(523, 21);
            Txtdiachi.Margin = new Padding(3, 2, 3, 2);
            Txtdiachi.Name = "Txtdiachi";
            Txtdiachi.Size = new Size(185, 29);
            Txtdiachi.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PeachPuff;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.Chocolate;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(412, 24);
            label5.Name = "label5";
            label5.Size = new Size(76, 27);
            label5.TabIndex = 9;
            label5.Text = "Dia Chi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PeachPuff;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.Chocolate;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(412, 86);
            label6.Name = "label6";
            label6.Size = new Size(49, 27);
            label6.TabIndex = 10;
            label6.Text = "SDT";
            // 
            // Txtsdt
            // 
            Txtsdt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txtsdt.Location = new Point(523, 83);
            Txtsdt.Margin = new Padding(3, 2, 3, 2);
            Txtsdt.Name = "Txtsdt";
            Txtsdt.Size = new Size(185, 29);
            Txtsdt.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PeachPuff;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.Chocolate;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.TopRight;
            label7.Location = new Point(384, 146);
            label7.Name = "label7";
            label7.Size = new Size(135, 27);
            label7.TabIndex = 12;
            label7.Text = "Ten Bang Cap";
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpngaysinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpngaysinh.Format = DateTimePickerFormat.Custom;
            dtpngaysinh.Location = new Point(119, 95);
            dtpngaysinh.Margin = new Padding(3, 2, 3, 2);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(221, 29);
            dtpngaysinh.TabIndex = 14;
            // 
            // cbbtenbangcap
            // 
            cbbtenbangcap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbtenbangcap.FormattingEnabled = true;
            cbbtenbangcap.Location = new Point(523, 146);
            cbbtenbangcap.Margin = new Padding(3, 2, 3, 2);
            cbbtenbangcap.Name = "cbbtenbangcap";
            cbbtenbangcap.Size = new Size(185, 29);
            cbbtenbangcap.TabIndex = 16;
            // 
            // Them
            // 
            Them.BackgroundImage = (Image)resources.GetObject("Them.BackgroundImage");
            Them.FlatStyle = FlatStyle.Popup;
            Them.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Them.ForeColor = Color.OrangeRed;
            Them.Image = (Image)resources.GetObject("Them.Image");
            Them.ImageAlign = ContentAlignment.TopCenter;
            Them.Location = new Point(777, 18);
            Them.Margin = new Padding(3, 2, 3, 2);
            Them.Name = "Them";
            Them.Size = new Size(120, 38);
            Them.TabIndex = 17;
            Them.Text = "+ Them";
            Them.UseVisualStyleBackColor = true;
            Them.Click += Them_Click;
            // 
            // Sua
            // 
            Sua.BackgroundImage = (Image)resources.GetObject("Sua.BackgroundImage");
            Sua.FlatStyle = FlatStyle.Popup;
            Sua.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Sua.ForeColor = Color.DarkOrange;
            Sua.Image = (Image)resources.GetObject("Sua.Image");
            Sua.ImageAlign = ContentAlignment.TopCenter;
            Sua.Location = new Point(923, 74);
            Sua.Margin = new Padding(3, 2, 3, 2);
            Sua.Name = "Sua";
            Sua.Size = new Size(127, 46);
            Sua.TabIndex = 18;
            Sua.Text = "✍ Sua";
            Sua.UseVisualStyleBackColor = true;
            Sua.Click += Sua_Click;
            // 
            // Xoa
            // 
            Xoa.BackgroundImage = (Image)resources.GetObject("Xoa.BackgroundImage");
            Xoa.FlatStyle = FlatStyle.Popup;
            Xoa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Xoa.ForeColor = Color.ForestGreen;
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.Location = new Point(777, 74);
            Xoa.Margin = new Padding(3, 2, 3, 2);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(120, 46);
            Xoa.TabIndex = 19;
            Xoa.Text = "🗑️ Xoa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Btt_timkiem
            // 
            Btt_timkiem.BackgroundImage = (Image)resources.GetObject("Btt_timkiem.BackgroundImage");
            Btt_timkiem.FlatStyle = FlatStyle.Popup;
            Btt_timkiem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Btt_timkiem.ForeColor = Color.Chocolate;
            Btt_timkiem.Image = (Image)resources.GetObject("Btt_timkiem.Image");
            Btt_timkiem.ImageAlign = ContentAlignment.MiddleRight;
            Btt_timkiem.Location = new Point(1030, 129);
            Btt_timkiem.Margin = new Padding(3, 2, 3, 2);
            Btt_timkiem.Name = "Btt_timkiem";
            Btt_timkiem.Size = new Size(127, 41);
            Btt_timkiem.TabIndex = 20;
            Btt_timkiem.Text = "🔎 Tim Kiem";
            Btt_timkiem.UseVisualStyleBackColor = true;
            Btt_timkiem.Click += Btt_timkiem_Click;
            // 
            // Btt_lammoi
            // 
            Btt_lammoi.BackgroundImage = (Image)resources.GetObject("Btt_lammoi.BackgroundImage");
            Btt_lammoi.FlatStyle = FlatStyle.Popup;
            Btt_lammoi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Btt_lammoi.ForeColor = Color.Firebrick;
            Btt_lammoi.Image = (Image)resources.GetObject("Btt_lammoi.Image");
            Btt_lammoi.ImageAlign = ContentAlignment.TopCenter;
            Btt_lammoi.Location = new Point(923, 16);
            Btt_lammoi.Margin = new Padding(3, 2, 3, 2);
            Btt_lammoi.Name = "Btt_lammoi";
            Btt_lammoi.Size = new Size(127, 38);
            Btt_lammoi.TabIndex = 21;
            Btt_lammoi.Text = "🔄 Load";
            Btt_lammoi.UseVisualStyleBackColor = true;
            Btt_lammoi.Click += Btt_lammoi_Click;
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaSo.ForeColor = Color.IndianRed;
            lblMaSo.Image = (Image)resources.GetObject("lblMaSo.Image");
            lblMaSo.ImageAlign = ContentAlignment.TopCenter;
            lblMaSo.Location = new Point(119, 21);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(85, 25);
            lblMaSo.TabIndex = 22;
            lblMaSo.Text = "lblMaSo";
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txttimkiem.Location = new Point(826, 141);
            txttimkiem.Margin = new Padding(3, 2, 3, 2);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(185, 29);
            txttimkiem.TabIndex = 23;
            txttimkiem.KeyDown += txttimkiem_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PeachPuff;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Chocolate;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(725, 145);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 24;
            label4.Text = "Tu Khoa";
            // 
            // FormNHANVIEN
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1169, 407);
            Controls.Add(label4);
            Controls.Add(txttimkiem);
            Controls.Add(lblMaSo);
            Controls.Add(Btt_lammoi);
            Controls.Add(Btt_timkiem);
            Controls.Add(Xoa);
            Controls.Add(Sua);
            Controls.Add(Them);
            Controls.Add(cbbtenbangcap);
            Controls.Add(dtpngaysinh);
            Controls.Add(label7);
            Controls.Add(Txtsdt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Txtdiachi);
            Controls.Add(label3);
            Controls.Add(Txthoten);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvNHANVIEN);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormNHANVIEN";
            Text = "FormNHANVIEN";
            Load += FormSINHVIEN_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNHANVIEN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNHANVIEN;
        private Label label1;
        private Label label2;
        private TextBox Txthoten;
        private Label label3;
        private TextBox Txtdiachi;
        private Label label5;
        private Label label6;
        private TextBox Txtsdt;
        private Label label7;
        private DateTimePicker dtpngaysinh;
        private ComboBox cbbtenbangcap;
        private Button Them;
        private Button Sua;
        private Button Xoa;
        private Button Btt_timkiem;
        private Button Btt_lammoi;
        private Label lblMaSo;
        private TextBox txttimkiem;
        private Label label4;
    }
}