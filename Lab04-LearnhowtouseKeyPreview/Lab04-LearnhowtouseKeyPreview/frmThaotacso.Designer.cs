namespace Lab04_LearnhowtouseKeyPreview
{
    partial class frmThaotacso
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.btTang2 = new System.Windows.Forms.Button();
            this.btChonchandau = new System.Windows.Forms.Button();
            this.btLecuoi = new System.Windows.Forms.Button();
            this.btXoaphantudangchon = new System.Windows.Forms.Button();
            this.btXoaphantudau = new System.Windows.Forms.Button();
            this.btXoaphantucuoi = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.errSonguyen = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSonguyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap so nguyen:";
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSonguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonguyen.ForeColor = System.Drawing.Color.Red;
            this.txtSonguyen.Location = new System.Drawing.Point(149, 53);
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(242, 24);
            this.txtSonguyen.TabIndex = 1;
            this.txtSonguyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSonguyen.TextChanged += new System.EventHandler(this.txtSonguyen_TextChanged);
            this.txtSonguyen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSonguyen_KeyDown);
            this.txtSonguyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonguyen_KeyPress);
            // 
            // btCapnhat
            // 
            this.btCapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapnhat.ForeColor = System.Drawing.Color.Lime;
            this.btCapnhat.Location = new System.Drawing.Point(397, 51);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(99, 26);
            this.btCapnhat.TabIndex = 2;
            this.btCapnhat.Text = "Cat Nhat";
            this.btCapnhat.UseVisualStyleBackColor = false;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btXoaphantucuoi);
            this.groupBox2.Controls.Add(this.btXoaphantudau);
            this.groupBox2.Controls.Add(this.btXoaphantudangchon);
            this.groupBox2.Controls.Add(this.btLecuoi);
            this.groupBox2.Controls.Add(this.btChonchandau);
            this.groupBox2.Controls.Add(this.btTang2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(223, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 316);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuc nang";
            // 
            // lstKetqua
            // 
            this.lstKetqua.BackColor = System.Drawing.Color.NavajoWhite;
            this.lstKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKetqua.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 24;
            this.lstKetqua.Location = new System.Drawing.Point(12, 90);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(183, 316);
            this.lstKetqua.TabIndex = 5;
            // 
            // btTang2
            // 
            this.btTang2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btTang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTang2.Location = new System.Drawing.Point(38, 35);
            this.btTang2.Name = "btTang2";
            this.btTang2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btTang2.Size = new System.Drawing.Size(188, 26);
            this.btTang2.TabIndex = 6;
            this.btTang2.Text = "Tang moi phan tu len 2 ";
            this.btTang2.UseVisualStyleBackColor = false;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // btChonchandau
            // 
            this.btChonchandau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btChonchandau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChonchandau.Location = new System.Drawing.Point(38, 81);
            this.btChonchandau.Name = "btChonchandau";
            this.btChonchandau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btChonchandau.Size = new System.Drawing.Size(188, 26);
            this.btChonchandau.TabIndex = 7;
            this.btChonchandau.Text = "Chon so chan dau";
            this.btChonchandau.UseVisualStyleBackColor = false;
            this.btChonchandau.Click += new System.EventHandler(this.btChonchandau_Click);
            // 
            // btLecuoi
            // 
            this.btLecuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btLecuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLecuoi.Location = new System.Drawing.Point(38, 129);
            this.btLecuoi.Name = "btLecuoi";
            this.btLecuoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btLecuoi.Size = new System.Drawing.Size(188, 26);
            this.btLecuoi.TabIndex = 8;
            this.btLecuoi.Text = "Chon so le cuoi";
            this.btLecuoi.UseVisualStyleBackColor = false;
            this.btLecuoi.Click += new System.EventHandler(this.btLecuoi_Click);
            // 
            // btXoaphantudangchon
            // 
            this.btXoaphantudangchon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btXoaphantudangchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaphantudangchon.Location = new System.Drawing.Point(38, 176);
            this.btXoaphantudangchon.Name = "btXoaphantudangchon";
            this.btXoaphantudangchon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btXoaphantudangchon.Size = new System.Drawing.Size(188, 26);
            this.btXoaphantudangchon.TabIndex = 9;
            this.btXoaphantudangchon.Text = "Xoa phan tu dang chon";
            this.btXoaphantudangchon.UseVisualStyleBackColor = false;
            this.btXoaphantudangchon.Click += new System.EventHandler(this.btXoaphantudangchon_Click);
            // 
            // btXoaphantudau
            // 
            this.btXoaphantudau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btXoaphantudau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaphantudau.Location = new System.Drawing.Point(38, 223);
            this.btXoaphantudau.Name = "btXoaphantudau";
            this.btXoaphantudau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btXoaphantudau.Size = new System.Drawing.Size(188, 26);
            this.btXoaphantudau.TabIndex = 10;
            this.btXoaphantudau.Text = "Xoa phan tu dau";
            this.btXoaphantudau.UseVisualStyleBackColor = false;
            this.btXoaphantudau.Click += new System.EventHandler(this.btXoaphantudau_Click);
            // 
            // btXoaphantucuoi
            // 
            this.btXoaphantucuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btXoaphantucuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaphantucuoi.Location = new System.Drawing.Point(38, 267);
            this.btXoaphantucuoi.Name = "btXoaphantucuoi";
            this.btXoaphantucuoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btXoaphantucuoi.Size = new System.Drawing.Size(188, 26);
            this.btXoaphantucuoi.TabIndex = 11;
            this.btXoaphantucuoi.Text = "Xoa phan tu cuoi";
            this.btXoaphantucuoi.UseVisualStyleBackColor = false;
            this.btXoaphantucuoi.Click += new System.EventHandler(this.btXoaphantucuoi_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btKetthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKetthuc.ForeColor = System.Drawing.Color.Lime;
            this.btKetthuc.Location = new System.Drawing.Point(12, 417);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(484, 38);
            this.btKetthuc.TabIndex = 12;
            this.btKetthuc.Text = "Ket thuc";
            this.btKetthuc.UseVisualStyleBackColor = false;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // errSonguyen
            // 
            this.errSonguyen.ContainerControl = this;
            this.errSonguyen.RightToLeftChanged += new System.EventHandler(this.txtSonguyen_TextChanged);
            // 
            // frmThaotacso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(505, 461);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.label1);
            this.Name = "frmThaotacso";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmThaotacso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThaotacso_FormClosing);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errSonguyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.Button btXoaphantudau;
        private System.Windows.Forms.Button btXoaphantudangchon;
        private System.Windows.Forms.Button btLecuoi;
        private System.Windows.Forms.Button btChonchandau;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.Button btXoaphantucuoi;
        private System.Windows.Forms.Button btKetthuc;
        private System.Windows.Forms.ErrorProvider errSonguyen;
    }
}