namespace BT_ThucHanh
{
    partial class FormDS_Khoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDS_Khoa));
            label1 = new Label();
            label2 = new Label();
            Txtmakhoa = new TextBox();
            Txttenkhoa = new TextBox();
            dataGridView1 = new DataGridView();
            them = new Button();
            luu = new Button();
            xoa = new Button();
            Txttim = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.ForestGreen;
            label1.Image = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(31, 65);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Ma Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.ForestGreen;
            label2.Image = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(28, 122);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Ten Khoa";
            // 
            // Txtmakhoa
            // 
            Txtmakhoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Txtmakhoa.Location = new Point(147, 57);
            Txtmakhoa.Name = "Txtmakhoa";
            Txtmakhoa.Size = new Size(226, 33);
            Txtmakhoa.TabIndex = 2;
            // 
            // Txttenkhoa
            // 
            Txttenkhoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Txttenkhoa.Location = new Point(147, 118);
            Txttenkhoa.Name = "Txttenkhoa";
            Txttenkhoa.Size = new Size(226, 33);
            Txttenkhoa.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 309);
            dataGridView1.TabIndex = 4;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // them
            // 
            them.BackColor = Color.DarkSeaGreen;
            them.BackgroundImage = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            them.FlatStyle = FlatStyle.Flat;
            them.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            them.ForeColor = Color.ForestGreen;
            them.Image = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            them.ImageAlign = ContentAlignment.TopLeft;
            them.Location = new Point(392, 54);
            them.Name = "them";
            them.Size = new Size(101, 38);
            them.TabIndex = 5;
            them.Text = "➕ Them";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // luu
            // 
            luu.BackColor = Color.DarkSeaGreen;
            luu.BackgroundImage = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            luu.FlatStyle = FlatStyle.Flat;
            luu.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            luu.ForeColor = Color.ForestGreen;
            luu.Image = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            luu.ImageAlign = ContentAlignment.TopRight;
            luu.Location = new Point(147, 215);
            luu.Name = "luu";
            luu.Size = new Size(101, 38);
            luu.TabIndex = 6;
            luu.Text = "🔄 Sua";
            luu.UseVisualStyleBackColor = false;
            luu.Click += luu_Click;
            // 
            // xoa
            // 
            xoa.BackColor = Color.DarkSeaGreen;
            xoa.BackgroundImage = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            xoa.FlatStyle = FlatStyle.Flat;
            xoa.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            xoa.ForeColor = Color.ForestGreen;
            xoa.Image = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            xoa.ImageAlign = ContentAlignment.TopRight;
            xoa.Location = new Point(513, 54);
            xoa.Name = "xoa";
            xoa.Size = new Size(101, 38);
            xoa.TabIndex = 7;
            xoa.Text = "👉🏻🗑️ Xoa";
            xoa.UseVisualStyleBackColor = false;
            xoa.Click += xoa_Click;
            // 
            // Txttim
            // 
            Txttim.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Txttim.Location = new Point(147, 176);
            Txttim.Name = "Txttim";
            Txttim.Size = new Size(226, 33);
            Txttim.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSeaGreen;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.ForestGreen;
            label3.Image = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(31, 179);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 9;
            label3.Text = "Tu Khoa";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.BackgroundImage = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button1.ForeColor = Color.ForestGreen;
            button1.Image = Properties.Resources.z7485087587608_c689f6b9c2df8aea7f4658e61b54ef99;
            button1.ImageAlign = ContentAlignment.TopRight;
            button1.Location = new Point(272, 215);
            button1.Name = "button1";
            button1.Size = new Size(101, 38);
            button1.TabIndex = 10;
            button1.Text = "🔍 Tim";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormDS_Khoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(646, 565);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Txttim);
            Controls.Add(xoa);
            Controls.Add(luu);
            Controls.Add(them);
            Controls.Add(dataGridView1);
            Controls.Add(Txttenkhoa);
            Controls.Add(Txtmakhoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDS_Khoa";
            Text = "FormDS_Khoa";
            Load += FormDmKhoa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Txtmakhoa;
        private TextBox Txttenkhoa;
        private DataGridView dataGridView1;
        private Button them;
        private Button luu;
        private Button xoa;
        private TextBox Txttim;
        private Label label3;
        private Button button1;
    }
}