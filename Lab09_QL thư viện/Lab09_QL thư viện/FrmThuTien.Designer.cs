namespace Lab09_QL_thư_viện
{
    partial class FrmThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThuTien));
            label1 = new Label();
            Bttload = new Button();
            label3 = new Label();
            Cboxhoten = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            Btt_save = new Button();
            numbricstt = new NumericUpDown();
            lbltienno = new Label();
            cbbnhanvien = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numbricstt).BeginInit();
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
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "họ tên độc giả";
            // 
            // Bttload
            // 
            Bttload.BackColor = SystemColors.GradientActiveCaption;
            Bttload.BackgroundImage = (Image)resources.GetObject("Bttload.BackgroundImage");
            Bttload.BackgroundImageLayout = ImageLayout.Stretch;
            Bttload.FlatStyle = FlatStyle.Popup;
            Bttload.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Bttload.ForeColor = Color.LightSkyBlue;
            Bttload.Image = (Image)resources.GetObject("Bttload.Image");
            Bttload.ImageAlign = ContentAlignment.TopRight;
            Bttload.Location = new Point(772, 154);
            Bttload.Name = "Bttload";
            Bttload.Size = new Size(53, 37);
            Bttload.TabIndex = 7;
            Bttload.Text = "🔄 Load";
            Bttload.TextAlign = ContentAlignment.TopCenter;
            Bttload.UseVisualStyleBackColor = false;
            Bttload.Click += load_Click;
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
            label3.Location = new Point(26, 99);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 14;
            label3.Tag = "Han the";
            label3.Text = "tiền nợ";
            // 
            // Cboxhoten
            // 
            Cboxhoten.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cboxhoten.FormattingEnabled = true;
            Cboxhoten.Location = new Point(189, 45);
            Cboxhoten.Name = "Cboxhoten";
            Cboxhoten.Size = new Size(235, 33);
            Cboxhoten.TabIndex = 15;
            Cboxhoten.SelectedIndexChanged += Cboxhoten_SelectedIndexChanged;
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
            label5.Location = new Point(436, 99);
            label5.Name = "label5";
            label5.Size = new Size(152, 32);
            label5.TabIndex = 19;
            label5.Text = "nhân viên thu";
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
            label6.Location = new Point(436, 46);
            label6.Name = "label6";
            label6.Size = new Size(121, 32);
            label6.TabIndex = 18;
            label6.Text = "số tiền thu";
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
            Btt_save.Location = new Point(646, 154);
            Btt_save.Name = "Btt_save";
            Btt_save.Size = new Size(72, 37);
            Btt_save.TabIndex = 32;
            Btt_save.Text = "Save";
            Btt_save.TextAlign = ContentAlignment.TopCenter;
            Btt_save.UseVisualStyleBackColor = false;
            Btt_save.Click += Btt_save_Click;
            // 
            // numbricstt
            // 
            numbricstt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numbricstt.Location = new Point(709, 45);
            numbricstt.Name = "numbricstt";
            numbricstt.Size = new Size(120, 33);
            numbricstt.TabIndex = 34;
            // 
            // lbltienno
            // 
            lbltienno.AutoSize = true;
            lbltienno.BackColor = SystemColors.GradientActiveCaption;
            lbltienno.BorderStyle = BorderStyle.Fixed3D;
            lbltienno.FlatStyle = FlatStyle.Popup;
            lbltienno.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lbltienno.ForeColor = Color.LightSkyBlue;
            lbltienno.Image = (Image)resources.GetObject("lbltienno.Image");
            lbltienno.ImageAlign = ContentAlignment.MiddleLeft;
            lbltienno.Location = new Point(189, 99);
            lbltienno.Name = "lbltienno";
            lbltienno.Size = new Size(104, 32);
            lbltienno.TabIndex = 35;
            lbltienno.Tag = "Han the";
            lbltienno.Text = "lbltienno";
            // 
            // cbbnhanvien
            // 
            cbbnhanvien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbnhanvien.FormattingEnabled = true;
            cbbnhanvien.Location = new Point(594, 98);
            cbbnhanvien.Name = "cbbnhanvien";
            cbbnhanvien.Size = new Size(235, 33);
            cbbnhanvien.TabIndex = 36;
            // 
            // FrmThuTien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(837, 248);
            Controls.Add(cbbnhanvien);
            Controls.Add(lbltienno);
            Controls.Add(numbricstt);
            Controls.Add(Btt_save);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(Cboxhoten);
            Controls.Add(label3);
            Controls.Add(Bttload);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmThuTien";
            Text = "FormThuTien";
            Load += FormQLBC_Load;
            ((System.ComponentModel.ISupportInitialize)numbricstt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Bttload;
        private Label label3;
        private ComboBox Cboxhoten;
        private Label label5;
        private Label label6;
        private Button Btt_save;
        private NumericUpDown numbricstt;
        private Label lbltienno;
        private ComboBox cbbnhanvien;
    }
}