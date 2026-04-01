namespace Lab09_QL_thư_viện
{
    partial class FrmDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDG));
            dgvDG = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            Txthovaten = new TextBox();
            label3 = new Label();
            Txtdiachi = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Txtemail = new TextBox();
            label7 = new Label();
            dtpdateofbirth = new DateTimePicker();
            Them = new Button();
            Sua = new Button();
            Xoa = new Button();
            Btt_timkiem = new Button();
            Btt_lammoi = new Button();
            lblMaSo = new Label();
            txttimkiem = new TextBox();
            label4 = new Label();
            label8 = new Label();
            txttienno = new TextBox();
            dtpngaylap = new DateTimePicker();
            label9 = new Label();
            dtpngayhethan = new DateTimePicker();
            Btt_giahan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDG).BeginInit();
            SuspendLayout();
            // 
            // dgvDG
            // 
            dgvDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDG.Location = new Point(0, 285);
            dgvDG.Margin = new Padding(3, 2, 3, 2);
            dgvDG.Name = "dgvDG";
            dgvDG.Size = new Size(1169, 249);
            dgvDG.TabIndex = 0;
            dgvDG.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.MediumPurple;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "MA SO ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.MediumPurple;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 3;
            label2.Text = "Ho va ten";
            // 
            // Txthovaten
            // 
            Txthovaten.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txthovaten.Location = new Point(127, 56);
            Txthovaten.Margin = new Padding(3, 2, 3, 2);
            Txthovaten.Name = "Txthovaten";
            Txthovaten.Size = new Size(221, 29);
            Txthovaten.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PeachPuff;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.MediumPurple;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 5;
            label3.Text = "Ngay sinh";
            // 
            // Txtdiachi
            // 
            Txtdiachi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txtdiachi.Location = new Point(529, 20);
            Txtdiachi.Margin = new Padding(3, 2, 3, 2);
            Txtdiachi.Name = "Txtdiachi";
            Txtdiachi.Size = new Size(221, 29);
            Txtdiachi.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumPurple;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.MediumPurple;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(412, 24);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 9;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PeachPuff;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.MediumPurple;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(412, 86);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // Txtemail
            // 
            Txtemail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txtemail.Location = new Point(529, 83);
            Txtemail.Margin = new Padding(3, 2, 3, 2);
            Txtemail.Name = "Txtemail";
            Txtemail.Size = new Size(221, 29);
            Txtemail.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PeachPuff;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.MediumPurple;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(393, 141);
            label7.Name = "label7";
            label7.Size = new Size(124, 25);
            label7.TabIndex = 12;
            label7.Text = "Ngày lập thẻ";
            // 
            // dtpdateofbirth
            // 
            dtpdateofbirth.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpdateofbirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpdateofbirth.Format = DateTimePickerFormat.Custom;
            dtpdateofbirth.Location = new Point(127, 95);
            dtpdateofbirth.Margin = new Padding(3, 2, 3, 2);
            dtpdateofbirth.Name = "dtpdateofbirth";
            dtpdateofbirth.Size = new Size(221, 29);
            dtpdateofbirth.TabIndex = 14;
            // 
            // Them
            // 
            Them.BackgroundImage = (Image)resources.GetObject("Them.BackgroundImage");
            Them.FlatStyle = FlatStyle.Popup;
            Them.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Them.ForeColor = Color.MediumPurple;
            Them.Image = (Image)resources.GetObject("Them.Image");
            Them.ImageAlign = ContentAlignment.MiddleRight;
            Them.Location = new Point(875, 38);
            Them.Margin = new Padding(3, 2, 3, 2);
            Them.Name = "Them";
            Them.Size = new Size(119, 36);
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
            Sua.ForeColor = Color.MediumPurple;
            Sua.Image = (Image)resources.GetObject("Sua.Image");
            Sua.ImageAlign = ContentAlignment.MiddleRight;
            Sua.Location = new Point(1028, 99);
            Sua.Margin = new Padding(3, 2, 3, 2);
            Sua.Name = "Sua";
            Sua.Size = new Size(115, 38);
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
            Xoa.ForeColor = Color.MediumPurple;
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.ImageAlign = ContentAlignment.MiddleRight;
            Xoa.Location = new Point(875, 99);
            Xoa.Margin = new Padding(3, 2, 3, 2);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(119, 37);
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
            Btt_timkiem.ForeColor = Color.MediumPurple;
            Btt_timkiem.Image = (Image)resources.GetObject("Btt_timkiem.Image");
            Btt_timkiem.ImageAlign = ContentAlignment.MiddleRight;
            Btt_timkiem.Location = new Point(972, 158);
            Btt_timkiem.Margin = new Padding(3, 2, 3, 2);
            Btt_timkiem.Name = "Btt_timkiem";
            Btt_timkiem.Size = new Size(115, 36);
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
            Btt_lammoi.ForeColor = Color.MediumPurple;
            Btt_lammoi.Image = (Image)resources.GetObject("Btt_lammoi.Image");
            Btt_lammoi.ImageAlign = ContentAlignment.MiddleRight;
            Btt_lammoi.Location = new Point(1028, 38);
            Btt_lammoi.Margin = new Padding(3, 2, 3, 2);
            Btt_lammoi.Name = "Btt_lammoi";
            Btt_lammoi.Size = new Size(115, 36);
            Btt_lammoi.TabIndex = 21;
            Btt_lammoi.Text = "🔄 Load";
            Btt_lammoi.UseVisualStyleBackColor = true;
            Btt_lammoi.Click += Btt_lammoi_Click;
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaSo.ForeColor = Color.MediumPurple;
            lblMaSo.Image = (Image)resources.GetObject("lblMaSo.Image");
            lblMaSo.Location = new Point(133, 18);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(85, 25);
            lblMaSo.TabIndex = 22;
            lblMaSo.Text = "lblMaSo";
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txttimkiem.Location = new Point(765, 165);
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
            label4.ForeColor = Color.MediumPurple;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(765, 127);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 24;
            label4.Text = "Tu Khoa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PeachPuff;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.MediumPurple;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(12, 141);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 25;
            label8.Text = "Tiền nợ ";
            // 
            // txttienno
            // 
            txttienno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txttienno.Location = new Point(127, 138);
            txttienno.Margin = new Padding(3, 2, 3, 2);
            txttienno.Name = "txttienno";
            txttienno.Size = new Size(221, 29);
            txttienno.TabIndex = 27;
            // 
            // dtpngaylap
            // 
            dtpngaylap.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpngaylap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpngaylap.Format = DateTimePickerFormat.Custom;
            dtpngaylap.Location = new Point(529, 141);
            dtpngaylap.Margin = new Padding(3, 2, 3, 2);
            dtpngaylap.Name = "dtpngaylap";
            dtpngaylap.Size = new Size(221, 29);
            dtpngaylap.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.PeachPuff;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.ForeColor = Color.MediumPurple;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(393, 199);
            label9.Name = "label9";
            label9.Size = new Size(130, 25);
            label9.TabIndex = 29;
            label9.Text = "Ngày hết hạn";
            // 
            // dtpngayhethan
            // 
            dtpngayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpngayhethan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpngayhethan.Format = DateTimePickerFormat.Custom;
            dtpngayhethan.Location = new Point(529, 196);
            dtpngayhethan.Margin = new Padding(3, 2, 3, 2);
            dtpngayhethan.Name = "dtpngayhethan";
            dtpngayhethan.Size = new Size(221, 29);
            dtpngayhethan.TabIndex = 30;
            // 
            // Btt_giahan
            // 
            Btt_giahan.BackgroundImage = (Image)resources.GetObject("Btt_giahan.BackgroundImage");
            Btt_giahan.FlatStyle = FlatStyle.Popup;
            Btt_giahan.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Btt_giahan.ForeColor = Color.MediumPurple;
            Btt_giahan.Image = (Image)resources.GetObject("Btt_giahan.Image");
            Btt_giahan.ImageAlign = ContentAlignment.MiddleRight;
            Btt_giahan.Location = new Point(765, 199);
            Btt_giahan.Margin = new Padding(3, 2, 3, 2);
            Btt_giahan.Name = "Btt_giahan";
            Btt_giahan.Size = new Size(115, 36);
            Btt_giahan.TabIndex = 31;
            Btt_giahan.Text = "Gia Han";
            Btt_giahan.UseVisualStyleBackColor = true;
            Btt_giahan.Click += Btt_giahan_Click;
            // 
            // FrmDG
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1169, 533);
            Controls.Add(Btt_giahan);
            Controls.Add(dtpngayhethan);
            Controls.Add(label9);
            Controls.Add(dtpngaylap);
            Controls.Add(txttienno);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txttimkiem);
            Controls.Add(lblMaSo);
            Controls.Add(Btt_lammoi);
            Controls.Add(Btt_timkiem);
            Controls.Add(Xoa);
            Controls.Add(Sua);
            Controls.Add(Them);
            Controls.Add(dtpdateofbirth);
            Controls.Add(label7);
            Controls.Add(Txtemail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Txtdiachi);
            Controls.Add(label3);
            Controls.Add(Txthovaten);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDG);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDG";
            Text = "FormDG";
            Load += FormSINHVIEN_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDG;
        private Label label1;
        private Label label2;
        private TextBox Txthovaten;
        private Label label3;
        private TextBox Txtdiachi;
        private Label label5;
        private Label label6;
        private TextBox Txtemail;
        private Label label7;
        private DateTimePicker dtpdateofbirth;
        private Button Them;
        private Button Sua;
        private Button Xoa;
        private Button Btt_timkiem;
        private Button Btt_lammoi;
        private Label lblMaSo;
        private TextBox txttimkiem;
        private Label label4;
        private Label label8;
        private TextBox txttienno;
        private DateTimePicker dtpngaylap;
        private Label label9;
        private DateTimePicker dtpngayhethan;
        private Button Btt_giahan;
    }
}