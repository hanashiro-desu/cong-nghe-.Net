namespace Lab09_QL_thư_viện
{
    partial class Frmthongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmthongke));
            Bttload = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvsachmuon = new DataGridView();
            tabPage2 = new TabPage();
            dgvdocgia = new DataGridView();
            tabPage3 = new TabPage();
            dgvthongke = new DataGridView();
            tabPage4 = new TabPage();
            dgvdocgiahethanthe = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsachmuon).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdocgia).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvthongke).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdocgiahethanthe).BeginInit();
            SuspendLayout();
            // 
            // Bttload
            // 
            Bttload.AutoEllipsis = true;
            Bttload.BackgroundImage = (Image)resources.GetObject("Bttload.BackgroundImage");
            Bttload.FlatStyle = FlatStyle.Flat;
            Bttload.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bttload.ForeColor = Color.LightBlue;
            Bttload.Image = (Image)resources.GetObject("Bttload.Image");
            Bttload.Location = new Point(761, 31);
            Bttload.Name = "Bttload";
            Bttload.Size = new Size(97, 38);
            Bttload.TabIndex = 1;
            Bttload.Text = "🔄 Load";
            Bttload.UseVisualStyleBackColor = true;
            Bttload.Click += Bttload_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 115);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(898, 465);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvsachmuon);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(890, 433);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sách đang được mượn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvsachmuon
            // 
            dgvsachmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsachmuon.Location = new Point(0, 6);
            dgvsachmuon.Name = "dgvsachmuon";
            dgvsachmuon.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvsachmuon.Size = new Size(870, 419);
            dgvsachmuon.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvdocgia);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(890, 433);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Độc giả còn nợ tiền";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvdocgia
            // 
            dgvdocgia.Location = new Point(5, 3);
            dgvdocgia.Name = "dgvdocgia";
            dgvdocgia.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvdocgia.Size = new Size(903, 424);
            dgvdocgia.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvthongke);
            tabPage3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(890, 433);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Thống kê sách mượn nhiều nhất";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvthongke
            // 
            dgvthongke.Location = new Point(8, 3);
            dgvthongke.Name = "dgvthongke";
            dgvthongke.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvthongke.Size = new Size(886, 430);
            dgvthongke.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvdocgiahethanthe);
            tabPage4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage4.Location = new Point(4, 28);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(890, 433);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Độc giả hết hạn thẻ trong 30 ngày";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvdocgiahethanthe
            // 
            dgvdocgiahethanthe.Location = new Point(0, 4);
            dgvdocgiahethanthe.Name = "dgvdocgiahethanthe";
            dgvdocgiahethanthe.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvdocgiahethanthe.Size = new Size(876, 426);
            dgvdocgiahethanthe.TabIndex = 1;
            // 
            // Frmthongke
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(890, 583);
            Controls.Add(tabControl1);
            Controls.Add(Bttload);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "Frmthongke";
            Tag = "Báo cáo thống kê";
            Text = "Báo cáo thống kê";
            Load += frmBaoCao_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsachmuon).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdocgia).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvthongke).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdocgiahethanthe).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Bttload;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvsachmuon;
        private TabPage tabPage2;
        private DataGridView dgvdocgia;
        private TabPage tabPage3;
        private DataGridView dgvthongke;
        private TabPage tabPage4;
        private DataGridView dgvdocgiahethanthe;
    }
}