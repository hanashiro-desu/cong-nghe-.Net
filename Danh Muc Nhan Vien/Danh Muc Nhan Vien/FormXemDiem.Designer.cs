namespace Danh_Muc_Nhan_Vien
{
    partial class FormXemDiem
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
            TxtKhoa = new TextBox();
            CBBMaSV = new ComboBox();
            sinhVienBindingSource = new BindingSource(components);
            studentDataSetBindingSource = new BindingSource(components);
            CBBTenSV = new ComboBox();
            BttXem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)sinhVienBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentDataSetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TxtKhoa
            // 
            TxtKhoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtKhoa.Location = new Point(327, 9);
            TxtKhoa.Name = "TxtKhoa";
            TxtKhoa.Size = new Size(185, 33);
            TxtKhoa.TabIndex = 0;
            // 
            // CBBMaSV
            // 
            CBBMaSV.DataSource = sinhVienBindingSource;
            CBBMaSV.DisplayMember = "MaSo";
            CBBMaSV.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBBMaSV.FormattingEnabled = true;
            CBBMaSV.Location = new Point(97, 6);
            CBBMaSV.Name = "CBBMaSV";
            CBBMaSV.Size = new Size(121, 33);
            CBBMaSV.TabIndex = 1;
            // 
            // sinhVienBindingSource
            // 
            sinhVienBindingSource.DataMember = "SinhVien";
            sinhVienBindingSource.DataSource = studentDataSetBindingSource;
            // 
            // studentDataSetBindingSource
            // 
            studentDataSetBindingSource.DataSource = typeof(StudentDataSet);
            studentDataSetBindingSource.Position = 0;
            // 
            // CBBTenSV
            // 
            CBBTenSV.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            CBBTenSV.FormattingEnabled = true;
            CBBTenSV.Location = new Point(97, 51);
            CBBTenSV.Name = "CBBTenSV";
            CBBTenSV.Size = new Size(212, 33);
            CBBTenSV.TabIndex = 2;
            // 
            // BttXem
            // 
            BttXem.FlatStyle = FlatStyle.Popup;
            BttXem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BttXem.ForeColor = Color.Maroon;
            BttXem.Image = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            BttXem.Location = new Point(381, 46);
            BttXem.Name = "BttXem";
            BttXem.Size = new Size(131, 34);
            BttXem.TabIndex = 3;
            BttXem.Text = "Xem";
            BttXem.UseVisualStyleBackColor = true;
            BttXem.Click += BttXem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Image = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 4;
            label1.Text = "Ma SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Image = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 5;
            label2.Text = "Ten SV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Maroon;
            label3.Image = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(255, 9);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 6;
            label3.Text = "Khoa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 274);
            dataGridView1.TabIndex = 7;
            // 
            // FormXemDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z7480811906129_ebf2af2f7fc8fc365b1abf44b54d07b4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(544, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BttXem);
            Controls.Add(CBBTenSV);
            Controls.Add(CBBMaSV);
            Controls.Add(TxtKhoa);
            Name = "FormXemDiem";
            Text = "FormXemDiem";
            Load += FormXemDiem_Load;
            ((System.ComponentModel.ISupportInitialize)sinhVienBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentDataSetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtKhoa;
        private ComboBox CBBMaSV;
        private ComboBox CBBTenSV;
        private Button BttXem;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private BindingSource sinhVienBindingSource;
        private BindingSource studentDataSetBindingSource;
    }
}