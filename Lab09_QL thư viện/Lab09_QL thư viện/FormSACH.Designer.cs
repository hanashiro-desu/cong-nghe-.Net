namespace Lab09_QL_thư_viện
{
    partial class FormSACH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSACH));
            dgvSACH = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            Txtsach = new TextBox();
            label3 = new Label();
            Txttacgia = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Txtnamxb = new TextBox();
            label7 = new Label();
            dtpngaynhan = new DateTimePicker();
            Them = new Button();
            Sua = new Button();
            Xoa = new Button();
            Btt_timkiem = new Button();
            Btt_lammoi = new Button();
            lblMaSo = new Label();
            txttimkiem = new TextBox();
            label4 = new Label();
            label8 = new Label();
            txtnxb = new TextBox();
            textBoxtrigia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSACH).BeginInit();
            SuspendLayout();
            // 
            // dgvSACH
            // 
            dgvSACH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSACH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSACH.Location = new Point(0, 187);
            dgvSACH.Margin = new Padding(3, 2, 3, 2);
            dgvSACH.Name = "dgvSACH";
            dgvSACH.Size = new Size(1169, 203);
            dgvSACH.TabIndex = 0;
            dgvSACH.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 2;
            label1.Text = "MA SO sach";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkBlue;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 3;
            label2.Text = "Ten Sach";
            // 
            // Txtsach
            // 
            Txtsach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txtsach.Location = new Point(127, 56);
            Txtsach.Margin = new Padding(3, 2, 3, 2);
            Txtsach.Name = "Txtsach";
            Txtsach.Size = new Size(221, 29);
            Txtsach.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkBlue;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.DarkBlue;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 5;
            label3.Text = "Ngay nhan";
            // 
            // Txttacgia
            // 
            Txttacgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txttacgia.Location = new Point(523, 21);
            Txttacgia.Margin = new Padding(3, 2, 3, 2);
            Txttacgia.Name = "Txttacgia";
            Txttacgia.Size = new Size(185, 29);
            Txttacgia.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkBlue;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(412, 24);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 9;
            label5.Text = "Tac Gia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkBlue;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.DarkBlue;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(412, 86);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 10;
            label6.Text = "Nam XB";
            // 
            // Txtnamxb
            // 
            Txtnamxb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txtnamxb.Location = new Point(523, 83);
            Txtnamxb.Margin = new Padding(3, 2, 3, 2);
            Txtnamxb.Name = "Txtnamxb";
            Txtnamxb.Size = new Size(185, 29);
            Txtnamxb.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkBlue;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.DarkBlue;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(412, 145);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 12;
            label7.Text = "NXB";
            // 
            // dtpngaynhan
            // 
            dtpngaynhan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpngaynhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpngaynhan.Format = DateTimePickerFormat.Custom;
            dtpngaynhan.Location = new Point(127, 95);
            dtpngaynhan.Margin = new Padding(3, 2, 3, 2);
            dtpngaynhan.Name = "dtpngaynhan";
            dtpngaynhan.Size = new Size(221, 29);
            dtpngaynhan.TabIndex = 14;
            // 
            // Them
            // 
            Them.BackgroundImage = (Image)resources.GetObject("Them.BackgroundImage");
            Them.FlatStyle = FlatStyle.Popup;
            Them.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Them.ForeColor = Color.DarkBlue;
            Them.Image = (Image)resources.GetObject("Them.Image");
            Them.ImageAlign = ContentAlignment.TopCenter;
            Them.Location = new Point(777, 18);
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
            Sua.ForeColor = Color.DarkBlue;
            Sua.Image = (Image)resources.GetObject("Sua.Image");
            Sua.Location = new Point(923, 82);
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
            Xoa.ForeColor = Color.DarkBlue;
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.ImageAlign = ContentAlignment.TopCenter;
            Xoa.Location = new Point(777, 83);
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
            Btt_timkiem.ForeColor = Color.DarkBlue;
            Btt_timkiem.Image = (Image)resources.GetObject("Btt_timkiem.Image");
            Btt_timkiem.ImageAlign = ContentAlignment.MiddleRight;
            Btt_timkiem.Location = new Point(1042, 138);
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
            Btt_lammoi.ForeColor = Color.DarkBlue;
            Btt_lammoi.Image = (Image)resources.GetObject("Btt_lammoi.Image");
            Btt_lammoi.ImageAlign = ContentAlignment.TopCenter;
            Btt_lammoi.Location = new Point(923, 18);
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
            lblMaSo.ForeColor = Color.DarkBlue;
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
            label4.BackColor = Color.DarkBlue;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.DarkBlue;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(725, 145);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 24;
            label4.Text = "Tu Khoa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkBlue;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.DarkBlue;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(12, 141);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 25;
            label8.Text = "Trị giá";
            // 
            // txtnxb
            // 
            txtnxb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtnxb.Location = new Point(523, 145);
            txtnxb.Margin = new Padding(3, 2, 3, 2);
            txtnxb.Name = "txtnxb";
            txtnxb.Size = new Size(185, 29);
            txtnxb.TabIndex = 26;
            // 
            // textBoxtrigia
            // 
            textBoxtrigia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxtrigia.Location = new Point(127, 138);
            textBoxtrigia.Margin = new Padding(3, 2, 3, 2);
            textBoxtrigia.Name = "textBoxtrigia";
            textBoxtrigia.Size = new Size(221, 29);
            textBoxtrigia.TabIndex = 27;
            // 
            // FormSACH
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1169, 390);
            Controls.Add(textBoxtrigia);
            Controls.Add(txtnxb);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txttimkiem);
            Controls.Add(lblMaSo);
            Controls.Add(Btt_lammoi);
            Controls.Add(Btt_timkiem);
            Controls.Add(Xoa);
            Controls.Add(Sua);
            Controls.Add(Them);
            Controls.Add(dtpngaynhan);
            Controls.Add(label7);
            Controls.Add(Txtnamxb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Txttacgia);
            Controls.Add(label3);
            Controls.Add(Txtsach);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSACH);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSACH";
            Text = "FormSACH";
            Load += FormSINHVIEN_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSACH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSACH;
        private Label label1;
        private Label label2;
        private TextBox Txtsach;
        private Label label3;
        private TextBox Txttacgia;
        private Label label5;
        private Label label6;
        private TextBox Txtnamxb;
        private Label label7;
        private DateTimePicker dtpngaynhan;
        private Button Them;
        private Button Sua;
        private Button Xoa;
        private Button Btt_timkiem;
        private Button Btt_lammoi;
        private Label lblMaSo;
        private TextBox txttimkiem;
        private Label label4;
        private Label label8;
        private TextBox txtnxb;
        private TextBox textBoxtrigia;
    }
}