namespace Danh_Muc_Nhan_Vien
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtmaKH = new TextBox();
            TxtTenKH = new TextBox();
            TxtSoTiet = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.SkyBlue;
            label1.Image = Properties.Resources.Bocchi_Christmas_Pfp;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(60, 48);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 0;
            label1.Text = "Ma KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.SkyBlue;
            label2.Image = Properties.Resources.Bocchi_Christmas_Pfp;
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
            label3.ForeColor = Color.LightSkyBlue;
            label3.Image = Properties.Resources.Bocchi_Christmas_Pfp;
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
            TxtmaKH.Location = new Point(146, 45);
            TxtmaKH.Name = "TxtmaKH";
            TxtmaKH.Size = new Size(239, 33);
            TxtmaKH.TabIndex = 3;
            // 
            // TxtTenKH
            // 
            TxtTenKH.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTenKH.Location = new Point(146, 102);
            TxtTenKH.Name = "TxtTenKH";
            TxtTenKH.Size = new Size(239, 33);
            TxtTenKH.TabIndex = 4;
            // 
            // TxtSoTiet
            // 
            TxtSoTiet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            TxtSoTiet.Location = new Point(147, 157);
            TxtSoTiet.Name = "TxtSoTiet";
            TxtSoTiet.Size = new Size(239, 33);
            TxtSoTiet.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(803, 248);
            dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.LightSkyBlue;
            button1.Image = Properties.Resources.Bocchi_Christmas_Pfp;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(509, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 47);
            button1.TabIndex = 7;
            button1.Text = "Them";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += them_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.LightSkyBlue;
            button2.Image = Properties.Resources.Bocchi_Christmas_Pfp;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(609, 97);
            button2.Name = "button2";
            button2.Size = new Size(102, 47);
            button2.TabIndex = 8;
            button2.Text = "Xoa";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Xoa_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button3.ForeColor = Color.LightSkyBlue;
            button3.Image = Properties.Resources.Bocchi_Christmas_Pfp;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(609, 31);
            button3.Name = "button3";
            button3.Size = new Size(102, 47);
            button3.TabIndex = 9;
            button3.Text = "Luu";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += luu_Click;
            // 
            // FormMonHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Bocchi_Christmas_Pfp;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(TxtSoTiet);
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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtmaKH;
        private TextBox TxtTenKH;
        private TextBox TxtSoTiet;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private BindingSource bindingSource1;
    }
}