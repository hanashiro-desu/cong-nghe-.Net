namespace Lab10_QLBanHang
{
    partial class FormSANPHAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSANPHAM));
            label1 = new Label();
            label2 = new Label();
            Txttensanpham = new TextBox();
            Them = new Button();
            Sua = new Button();
            Xoa = new Button();
            Btt_timkiem = new Button();
            Btt_lammoi = new Button();
            lblMaSo = new Label();
            txttimkiem = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Cbbdanhmuc = new ComboBox();
            Rtbmota = new RichTextBox();
            Txtdongia = new TextBox();
            Txtsltontrongkho = new TextBox();
            dgvSANPHAM = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSANPHAM).BeginInit();
            SuspendLayout();
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
            label1.Location = new Point(161, 22);
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
            label2.Location = new Point(161, 60);
            label2.Name = "label2";
            label2.Size = new Size(138, 27);
            label2.TabIndex = 3;
            label2.Text = "Ten San Pham";
            // 
            // Txttensanpham
            // 
            Txttensanpham.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txttensanpham.Location = new Point(324, 58);
            Txttensanpham.Margin = new Padding(3, 2, 3, 2);
            Txttensanpham.Name = "Txttensanpham";
            Txttensanpham.Size = new Size(219, 29);
            Txttensanpham.TabIndex = 4;
            // 
            // Them
            // 
            Them.BackgroundImage = (Image)resources.GetObject("Them.BackgroundImage");
            Them.FlatStyle = FlatStyle.Popup;
            Them.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Them.ForeColor = Color.OrangeRed;
            Them.ImageAlign = ContentAlignment.TopCenter;
            Them.Location = new Point(863, 14);
            Them.Margin = new Padding(3, 2, 3, 2);
            Them.Name = "Them";
            Them.Size = new Size(102, 38);
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
            Sua.ImageAlign = ContentAlignment.TopCenter;
            Sua.Location = new Point(1022, 64);
            Sua.Margin = new Padding(3, 2, 3, 2);
            Sua.Name = "Sua";
            Sua.Size = new Size(106, 38);
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
            Xoa.Location = new Point(863, 64);
            Xoa.Margin = new Padding(3, 2, 3, 2);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(102, 38);
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
            Btt_timkiem.ImageAlign = ContentAlignment.MiddleRight;
            Btt_timkiem.Location = new Point(1022, 113);
            Btt_timkiem.Margin = new Padding(3, 2, 3, 2);
            Btt_timkiem.Name = "Btt_timkiem";
            Btt_timkiem.Size = new Size(106, 40);
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
            Btt_lammoi.ImageAlign = ContentAlignment.TopCenter;
            Btt_lammoi.Location = new Point(1022, 14);
            Btt_lammoi.Margin = new Padding(3, 2, 3, 2);
            Btt_lammoi.Name = "Btt_lammoi";
            Btt_lammoi.Size = new Size(106, 38);
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
            lblMaSo.Location = new Point(324, 21);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(85, 25);
            lblMaSo.TabIndex = 22;
            lblMaSo.Text = "lblMaSo";
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txttimkiem.Location = new Point(863, 166);
            txttimkiem.Margin = new Padding(3, 2, 3, 2);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(265, 29);
            txttimkiem.TabIndex = 23;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            txttimkiem.KeyDown += txttimkiem_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PeachPuff;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Chocolate;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(863, 122);
            label4.Name = "label4";
            label4.Size = new Size(86, 27);
            label4.TabIndex = 24;
            label4.Text = "Tu Khoa";
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
            label3.Location = new Point(161, 102);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 25;
            label3.Text = "Danh mục";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PeachPuff;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.Chocolate;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.TopLeft;
            label5.Location = new Point(161, 146);
            label5.Name = "label5";
            label5.Size = new Size(89, 27);
            label5.TabIndex = 26;
            label5.Text = "Đơn giá ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PeachPuff;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.Chocolate;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.TopLeft;
            label6.Location = new Point(577, 22);
            label6.Name = "label6";
            label6.Size = new Size(132, 27);
            label6.TabIndex = 27;
            label6.Text = "Số lượng tồn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PeachPuff;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.Chocolate;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.TopLeft;
            label7.Location = new Point(577, 60);
            label7.Name = "label7";
            label7.Size = new Size(66, 27);
            label7.TabIndex = 28;
            label7.Text = "Mô tả";
            // 
            // Cbbdanhmuc
            // 
            Cbbdanhmuc.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbbdanhmuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cbbdanhmuc.FormattingEnabled = true;
            Cbbdanhmuc.Location = new Point(324, 102);
            Cbbdanhmuc.Name = "Cbbdanhmuc";
            Cbbdanhmuc.Size = new Size(219, 29);
            Cbbdanhmuc.TabIndex = 29;
            Cbbdanhmuc.SelectedIndexChanged += Cbbdanhmuc_SelectedIndexChanged;
            // 
            // Rtbmota
            // 
            Rtbmota.Location = new Point(577, 90);
            Rtbmota.Name = "Rtbmota";
            Rtbmota.Size = new Size(268, 96);
            Rtbmota.TabIndex = 32;
            Rtbmota.Text = "";
            // 
            // Txtdongia
            // 
            Txtdongia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txtdongia.Location = new Point(324, 146);
            Txtdongia.Margin = new Padding(3, 2, 3, 2);
            Txtdongia.Name = "Txtdongia";
            Txtdongia.Size = new Size(219, 29);
            Txtdongia.TabIndex = 33;
            // 
            // Txtsltontrongkho
            // 
            Txtsltontrongkho.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Txtsltontrongkho.Location = new Point(715, 22);
            Txtsltontrongkho.Margin = new Padding(3, 2, 3, 2);
            Txtsltontrongkho.Name = "Txtsltontrongkho";
            Txtsltontrongkho.Size = new Size(130, 29);
            Txtsltontrongkho.TabIndex = 34;
            // 
            // dgvSANPHAM
            // 
            dgvSANPHAM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSANPHAM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSANPHAM.Location = new Point(2, 227);
            dgvSANPHAM.Name = "dgvSANPHAM";
            dgvSANPHAM.Size = new Size(1174, 214);
            dgvSANPHAM.TabIndex = 35;
            dgvSANPHAM.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // FormSANPHAM
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1169, 440);
            Controls.Add(dgvSANPHAM);
            Controls.Add(Txtsltontrongkho);
            Controls.Add(Txtdongia);
            Controls.Add(Rtbmota);
            Controls.Add(Cbbdanhmuc);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txttimkiem);
            Controls.Add(lblMaSo);
            Controls.Add(Btt_lammoi);
            Controls.Add(Btt_timkiem);
            Controls.Add(Xoa);
            Controls.Add(Sua);
            Controls.Add(Them);
            Controls.Add(Txttensanpham);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSANPHAM";
            Text = "FormNHANVIEN";
            Load += FormSANPHAM_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSANPHAM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox Txttensanpham;
        private Button Them;
        private Button Sua;
        private Button Xoa;
        private Button Btt_timkiem;
        private Button Btt_lammoi;
        private Label lblMaSo;
        private TextBox txttimkiem;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox Cbbdanhmuc;
        private RichTextBox Rtbmota;
        private TextBox Txtdongia;
        private TextBox Txtsltontrongkho;
        private DataGridView dgvSANPHAM;
    }
}