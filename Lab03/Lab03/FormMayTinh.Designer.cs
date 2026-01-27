namespace Lab03
{
    partial class FormMayTinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelN = new Label();
            labelKQ = new Label();
            labelM = new Label();
            txtSon = new TextBox();
            txtSom = new TextBox();
            txtKetqua = new TextBox();
            btCong = new Button();
            btTru = new Button();
            btNhan = new Button();
            btChia = new Button();
            btXoa = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(105, 19);
            label1.Name = "label1";
            label1.Size = new Size(401, 42);
            label1.TabIndex = 0;
            label1.Text = "Thuc Hien Cac Phep Tinh";
            label1.Click += label1_Click;
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelN.Location = new Point(105, 89);
            labelN.Name = "labelN";
            labelN.Size = new Size(102, 24);
            labelN.TabIndex = 1;
            labelN.Text = "Nhap so N";
            labelN.Click += label2_Click;
            // 
            // labelKQ
            // 
            labelKQ.AutoSize = true;
            labelKQ.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKQ.Location = new Point(105, 253);
            labelKQ.Name = "labelKQ";
            labelKQ.Size = new Size(87, 24);
            labelKQ.TabIndex = 2;
            labelKQ.Text = "Ket Qua";
            // 
            // labelM
            // 
            labelM.AutoSize = true;
            labelM.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelM.Location = new Point(101, 172);
            labelM.Name = "labelM";
            labelM.Size = new Size(106, 24);
            labelM.TabIndex = 3;
            labelM.Text = "Nhap so M";
            // 
            // txtSon
            // 
            txtSon.Location = new Point(235, 89);
            txtSon.Name = "txtSon";
            txtSon.Size = new Size(245, 23);
            txtSon.TabIndex = 4;
            txtSon.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSom
            // 
            txtSom.Location = new Point(235, 173);
            txtSom.Name = "txtSom";
            txtSom.Size = new Size(245, 23);
            txtSom.TabIndex = 5;
            txtSom.TextAlign = HorizontalAlignment.Right;
            // 
            // txtKetqua
            // 
            txtKetqua.BackColor = SystemColors.Info;
            txtKetqua.ForeColor = SystemColors.InfoText;
            txtKetqua.Location = new Point(235, 253);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.ReadOnly = true;
            txtKetqua.Size = new Size(245, 23);
            txtKetqua.TabIndex = 6;
            txtKetqua.TextAlign = HorizontalAlignment.Right;
            // 
            // btCong
            // 
            btCong.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCong.Location = new Point(48, 317);
            btCong.Name = "btCong";
            btCong.Size = new Size(83, 33);
            btCong.TabIndex = 7;
            btCong.Text = "+";
            btCong.UseMnemonic = false;
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btTru
            // 
            btTru.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTru.Location = new Point(148, 317);
            btTru.Name = "btTru";
            btTru.Size = new Size(76, 33);
            btTru.TabIndex = 8;
            btTru.Text = "-";
            btTru.UseVisualStyleBackColor = true;
            // 
            // btNhan
            // 
            btNhan.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNhan.Location = new Point(235, 317);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(85, 33);
            btNhan.TabIndex = 9;
            btNhan.Text = "*";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btChia
            // 
            btChia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btChia.Location = new Point(336, 317);
            btChia.Name = "btChia";
            btChia.Size = new Size(89, 33);
            btChia.TabIndex = 10;
            btChia.Text = "/";
            btChia.UseVisualStyleBackColor = true;
            btChia.Click += btChia_Click;
            // 
            // btXoa
            // 
            btXoa.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.Location = new Point(440, 317);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(87, 33);
            btXoa.TabIndex = 11;
            btXoa.Text = "Xoa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btThoat
            // 
            btThoat.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThoat.Location = new Point(544, 317);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(87, 33);
            btThoat.TabIndex = 12;
            btThoat.Text = "Thoat";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // FormMayTinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(695, 406);
            Controls.Add(btThoat);
            Controls.Add(btXoa);
            Controls.Add(btChia);
            Controls.Add(btNhan);
            Controls.Add(btTru);
            Controls.Add(btCong);
            Controls.Add(txtKetqua);
            Controls.Add(txtSom);
            Controls.Add(txtSon);
            Controls.Add(labelM);
            Controls.Add(labelKQ);
            Controls.Add(labelN);
            Controls.Add(label1);
            Name = "FormMayTinh";
            Text = "FormMayTinh";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelN;
        private Label labelKQ;
        private Label labelM;
        private TextBox txtSon;
        private TextBox txtSom;
        private TextBox txtKetqua;
        private Button btCong;
        private Button btTru;
        private Button btNhan;
        private Button btChia;
        private Button btXoa;
        private Button btThoat;
    }
}
