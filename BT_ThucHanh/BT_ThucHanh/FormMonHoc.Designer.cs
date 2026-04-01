namespace BT_ThucHanh
{
    partial class FormMonHoc
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtmaKH = new TextBox();
            TxtTenKH = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            Txttim = new TextBox();
            button4 = new Button();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.SteelBlue;
            label1.Image = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(60, 48);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 0;
            label1.Text = "Ma KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Image = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(60, 105);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 1;
            label2.Text = "Ten KH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.SteelBlue;
            label3.Image = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(60, 160);
            label3.Name = "label3";
            label3.Size = new Size(81, 30);
            label3.TabIndex = 2;
            label3.Text = "So Tiet";
            // 
            // TxtmaKH
            // 
            TxtmaKH.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtmaKH.ForeColor = Color.SkyBlue;
            TxtmaKH.Location = new Point(146, 45);
            TxtmaKH.Name = "TxtmaKH";
            TxtmaKH.Size = new Size(239, 33);
            TxtmaKH.TabIndex = 3;
            // 
            // TxtTenKH
            // 
            TxtTenKH.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTenKH.ForeColor = Color.SkyBlue;
            TxtTenKH.Location = new Point(146, 102);
            TxtTenKH.Name = "TxtTenKH";
            TxtTenKH.Size = new Size(239, 33);
            TxtTenKH.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(803, 227);
            dataGridView1.TabIndex = 6;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.BackgroundImage = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.SteelBlue;
            button1.Image = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            button1.Location = new Point(376, 183);
            button1.Name = "button1";
            button1.Size = new Size(53, 37);
            button1.TabIndex = 7;
            button1.Text = "➕ Them";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += them_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.BackgroundImage = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button3.ForeColor = Color.SteelBlue;
            button3.Image = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            button3.Location = new Point(376, 141);
            button3.Name = "button3";
            button3.Size = new Size(53, 35);
            button3.TabIndex = 9;
            button3.Text = "🚚 Luu";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += luu_Click;
            // 
            // Txttim
            // 
            Txttim.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Txttim.ForeColor = Color.SkyBlue;
            Txttim.Location = new Point(491, 45);
            Txttim.Name = "Txttim";
            Txttim.Size = new Size(239, 33);
            Txttim.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.BackgroundImage = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button4.ForeColor = Color.SteelBlue;
            button4.Image = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(642, 146);
            button4.Name = "button4";
            button4.Size = new Size(88, 47);
            button4.TabIndex = 10;
            button4.Text = "🕵🏻 Tim";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.SteelBlue;
            label4.Image = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(391, 47);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 11;
            label4.Text = "Tu Khoa";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.ForeColor = Color.SkyBlue;
            numericUpDown1.Location = new Point(147, 160);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 33);
            numericUpDown1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.BackgroundImage = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.SteelBlue;
            button2.Image = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(642, 84);
            button2.Name = "button2";
            button2.Size = new Size(88, 47);
            button2.TabIndex = 13;
            button2.Text = "🗑️";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormMonHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.z7485087561879_1d77b8befb37a39b927523e80b702f19;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Txttim);
            Controls.Add(TxtTenKH);
            Controls.Add(TxtmaKH);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "FormMonHoc";
            Text = "FormMonHoc";
            Load += FormMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtmaKH;
        private TextBox TxtTenKH;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private TextBox Txttim;
        private Button button4;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Button button2;
    }
}