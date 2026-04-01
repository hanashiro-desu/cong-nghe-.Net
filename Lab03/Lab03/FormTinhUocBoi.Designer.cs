namespace Lab03
{
    partial class FormTinhUocBoi
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
            GroupBox = new GroupBox();
            TxtB = new TextBox();
            TxtA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rdbBSCNN = new RadioButton();
            rdbUSCLN = new RadioButton();
            groupBox2 = new GroupBox();
            BtnThoat = new Button();
            BtnBoqua = new Button();
            Btntim = new Button();
            TxtKetqua = new TextBox();
            GroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.BackColor = Color.FromArgb(128, 128, 255);
            GroupBox.Controls.Add(TxtB);
            GroupBox.Controls.Add(TxtA);
            GroupBox.Controls.Add(label2);
            GroupBox.Controls.Add(label1);
            GroupBox.Location = new Point(12, 26);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(572, 177);
            GroupBox.TabIndex = 0;
            GroupBox.TabStop = false;
            GroupBox.Text = "Nhap";
            GroupBox.Enter += groupBox1_Enter;
            // 
            // TxtB
            // 
            TxtB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtB.Location = new Point(77, 111);
            TxtB.Name = "TxtB";
            TxtB.Size = new Size(454, 35);
            TxtB.TabIndex = 3;
            TxtB.TextAlign = HorizontalAlignment.Right;
            TxtB.TextChanged += TxtB_TextChanged;
            // 
            // TxtA
            // 
            TxtA.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtA.Location = new Point(77, 37);
            TxtA.Name = "TxtA";
            TxtA.Size = new Size(454, 35);
            TxtA.TabIndex = 2;
            TxtA.TextAlign = HorizontalAlignment.Right;
            TxtA.TextChanged += TxtA_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 111);
            label2.Name = "label2";
            label2.Size = new Size(33, 32);
            label2.TabIndex = 1;
            label2.Text = "B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(34, 32);
            label1.TabIndex = 0;
            label1.Text = "A:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 128, 255);
            groupBox1.Controls.Add(rdbBSCNN);
            groupBox1.Controls.Add(rdbUSCLN);
            groupBox1.Location = new Point(590, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(149, 171);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chon";
            // 
            // rdbBSCNN
            // 
            rdbBSCNN.AutoSize = true;
            rdbBSCNN.Location = new Point(24, 71);
            rdbBSCNN.Name = "rdbBSCNN";
            rdbBSCNN.Size = new Size(64, 19);
            rdbBSCNN.TabIndex = 1;
            rdbBSCNN.TabStop = true;
            rdbBSCNN.Text = "BSCNN";
            rdbBSCNN.UseVisualStyleBackColor = true;
            // 
            // rdbUSCLN
            // 
            rdbUSCLN.AutoSize = true;
            rdbUSCLN.Location = new Point(24, 31);
            rdbUSCLN.Name = "rdbUSCLN";
            rdbUSCLN.Size = new Size(62, 19);
            rdbUSCLN.TabIndex = 0;
            rdbUSCLN.TabStop = true;
            rdbUSCLN.Text = "USCLN";
            rdbUSCLN.UseVisualStyleBackColor = true;
            rdbUSCLN.CheckedChanged += rdbUSCLN_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Blue;
            groupBox2.Controls.Add(BtnThoat);
            groupBox2.Controls.Add(BtnBoqua);
            groupBox2.Controls.Add(Btntim);
            groupBox2.Controls.Add(TxtKetqua);
            groupBox2.Location = new Point(13, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(727, 132);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ket Qua";
            // 
            // BtnThoat
            // 
            BtnThoat.Location = new Point(529, 83);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(101, 34);
            BtnThoat.TabIndex = 7;
            BtnThoat.Text = "Thoat";
            BtnThoat.UseVisualStyleBackColor = true;
            BtnThoat.Click += BtnThoat_Click;
            // 
            // BtnBoqua
            // 
            BtnBoqua.Location = new Point(309, 83);
            BtnBoqua.Name = "BtnBoqua";
            BtnBoqua.Size = new Size(101, 34);
            BtnBoqua.TabIndex = 6;
            BtnBoqua.Text = "Bo Qua";
            BtnBoqua.UseVisualStyleBackColor = true;
            BtnBoqua.Click += BtnBoqua_Click;
            // 
            // Btntim
            // 
            Btntim.Location = new Point(76, 83);
            Btntim.Name = "Btntim";
            Btntim.Size = new Size(101, 34);
            Btntim.TabIndex = 5;
            Btntim.Text = "Tim";
            Btntim.UseVisualStyleBackColor = true;
            Btntim.Click += Btntim_Click;
            // 
            // TxtKetqua
            // 
            TxtKetqua.BackColor = SystemColors.ActiveCaption;
            TxtKetqua.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtKetqua.Location = new Point(76, 33);
            TxtKetqua.Name = "TxtKetqua";
            TxtKetqua.ReadOnly = true;
            TxtKetqua.Size = new Size(454, 35);
            TxtKetqua.TabIndex = 4;
            TxtKetqua.TextAlign = HorizontalAlignment.Right;
            // 
            // FormTinhUocBoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(756, 380);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(GroupBox);
            Name = "FormTinhUocBoi";
            Text = "FormTinhUocBoi";
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox;
        private TextBox TxtB;
        private TextBox TxtA;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnThoat;
        private Button BtnBoqua;
        private Button Btntim;
        private TextBox TxtKetqua;
        private RadioButton rdbBSCNN;
        private RadioButton rdbUSCLN;
    }
}