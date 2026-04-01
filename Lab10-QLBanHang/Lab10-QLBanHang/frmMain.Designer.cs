namespace Lab10_QLBanHang
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mnu_hotro = new MenuStrip();
            mnudanhmuc = new ToolStripMenuItem();
            bằngCấpToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            sáchToolStripMenuItem = new ToolStripMenuItem();
            mnuHethong = new ToolStripMenuItem();
            sep2 = new ToolStripSeparator();
            mnuDongTat = new ToolStripMenuItem();
            mnu_muontra = new ToolStripMenuItem();
            phiếuMượnToolStripMenuItem = new ToolStripMenuItem();
            thuTiềnToolStripMenuItem = new ToolStripMenuItem();
            mnu_docgia = new ToolStripMenuItem();
            mnu_baocao = new ToolStripMenuItem();
            hToolStripMenuItem = new ToolStripMenuItem();
            cascadeXếpChồngToolStripMenuItem = new ToolStripMenuItem();
            xếpNgangToolStripMenuItem = new ToolStripMenuItem();
            xếpDọcToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tsbbangcap = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            tsbnhanvien = new ToolStripButton();
            tsbSep1 = new ToolStripSeparator();
            tsbThoat = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            tsbsach = new ToolStripLabel();
            toolStripButton4 = new ToolStripButton();
            tsbdocgia = new ToolStripLabel();
            toolStripButton5 = new ToolStripButton();
            tsbmuonvatra = new ToolStripLabel();
            mnu_hotro.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnu_hotro
            // 
            mnu_hotro.BackgroundImage = (Image)resources.GetObject("mnu_hotro.BackgroundImage");
            mnu_hotro.BackgroundImageLayout = ImageLayout.Center;
            mnu_hotro.Items.AddRange(new ToolStripItem[] { mnudanhmuc, mnuHethong, mnu_muontra, mnu_docgia, mnu_baocao, hToolStripMenuItem });
            mnu_hotro.Location = new Point(0, 0);
            mnu_hotro.Name = "mnu_hotro";
            mnu_hotro.Padding = new Padding(7, 2, 0, 2);
            mnu_hotro.Size = new Size(1237, 24);
            mnu_hotro.TabIndex = 0;
            // 
            // mnudanhmuc
            // 
            mnudanhmuc.BackgroundImage = (Image)resources.GetObject("mnudanhmuc.BackgroundImage");
            mnudanhmuc.DropDownItems.AddRange(new ToolStripItem[] { bằngCấpToolStripMenuItem, nhânViênToolStripMenuItem, sáchToolStripMenuItem });
            mnudanhmuc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            mnudanhmuc.ForeColor = Color.Indigo;
            mnudanhmuc.Image = (Image)resources.GetObject("mnudanhmuc.Image");
            mnudanhmuc.Name = "mnudanhmuc";
            mnudanhmuc.Size = new Size(103, 20);
            mnudanhmuc.Text = "Danh Mục";
            // 
            // bằngCấpToolStripMenuItem
            // 
            bằngCấpToolStripMenuItem.Image = (Image)resources.GetObject("bằngCấpToolStripMenuItem.Image");
            bằngCấpToolStripMenuItem.Name = "bằngCấpToolStripMenuItem";
            bằngCấpToolStripMenuItem.Size = new Size(143, 22);
            bằngCấpToolStripMenuItem.Text = "Bằng cấp";
            bằngCấpToolStripMenuItem.Click += tsbbangcap_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Image = (Image)resources.GetObject("nhânViênToolStripMenuItem.Image");
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(143, 22);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += tsbnhanvien_Click;
            // 
            // sáchToolStripMenuItem
            // 
            sáchToolStripMenuItem.Image = (Image)resources.GetObject("sáchToolStripMenuItem.Image");
            sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            sáchToolStripMenuItem.Size = new Size(143, 22);
            sáchToolStripMenuItem.Text = "Sách";
            sáchToolStripMenuItem.Click += tsbsach_Click;
            // 
            // mnuHethong
            // 
            mnuHethong.BackgroundImage = (Image)resources.GetObject("mnuHethong.BackgroundImage");
            mnuHethong.DropDownItems.AddRange(new ToolStripItem[] { sep2, mnuDongTat });
            mnuHethong.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            mnuHethong.ForeColor = Color.Indigo;
            mnuHethong.Image = (Image)resources.GetObject("mnuHethong.Image");
            mnuHethong.Name = "mnuHethong";
            mnuHethong.Size = new Size(101, 20);
            mnuHethong.Text = "Hệ thống ";
            // 
            // sep2
            // 
            sep2.Name = "sep2";
            sep2.Size = new Size(149, 6);
            // 
            // mnuDongTat
            // 
            mnuDongTat.Name = "mnuDongTat";
            mnuDongTat.Size = new Size(152, 22);
            mnuDongTat.Text = "Đóng tất cả";
            mnuDongTat.Click += mnuDongTat_Click;
            // 
            // mnu_muontra
            // 
            mnu_muontra.BackgroundImage = (Image)resources.GetObject("mnu_muontra.BackgroundImage");
            mnu_muontra.DropDownItems.AddRange(new ToolStripItem[] { phiếuMượnToolStripMenuItem, thuTiềnToolStripMenuItem });
            mnu_muontra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            mnu_muontra.ForeColor = Color.Indigo;
            mnu_muontra.Image = (Image)resources.GetObject("mnu_muontra.Image");
            mnu_muontra.Name = "mnu_muontra";
            mnu_muontra.Size = new Size(109, 20);
            mnu_muontra.Text = "Mượn - Trả";
            // 
            // phiếuMượnToolStripMenuItem
            // 
            phiếuMượnToolStripMenuItem.Image = (Image)resources.GetObject("phiếuMượnToolStripMenuItem.Image");
            phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            phiếuMượnToolStripMenuItem.Size = new Size(154, 22);
            phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            phiếuMượnToolStripMenuItem.Click += tsbmuon_Click;
            // 
            // thuTiềnToolStripMenuItem
            // 
            thuTiềnToolStripMenuItem.Image = (Image)resources.GetObject("thuTiềnToolStripMenuItem.Image");
            thuTiềnToolStripMenuItem.Name = "thuTiềnToolStripMenuItem";
            thuTiềnToolStripMenuItem.Size = new Size(154, 22);
            thuTiềnToolStripMenuItem.Text = "Thu tiền";
            thuTiềnToolStripMenuItem.Click += tsbtra_Click;
            // 
            // mnu_docgia
            // 
            mnu_docgia.BackgroundImage = (Image)resources.GetObject("mnu_docgia.BackgroundImage");
            mnu_docgia.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            mnu_docgia.Image = (Image)resources.GetObject("mnu_docgia.Image");
            mnu_docgia.Name = "mnu_docgia";
            mnu_docgia.Size = new Size(92, 20);
            mnu_docgia.Text = "Độc giả ";
            mnu_docgia.Click += tsbdocgia_Click;
            // 
            // mnu_baocao
            // 
            mnu_baocao.BackgroundImage = (Image)resources.GetObject("mnu_baocao.BackgroundImage");
            mnu_baocao.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            mnu_baocao.Image = (Image)resources.GetObject("mnu_baocao.Image");
            mnu_baocao.Name = "mnu_baocao";
            mnu_baocao.Size = new Size(93, 20);
            mnu_baocao.Text = "Báo cáo";
            mnu_baocao.Click += mnu_baocao_Click;
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("hToolStripMenuItem.BackgroundImage");
            hToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeXếpChồngToolStripMenuItem, xếpNgangToolStripMenuItem, xếpDọcToolStripMenuItem });
            hToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            hToolStripMenuItem.Image = (Image)resources.GetObject("hToolStripMenuItem.Image");
            hToolStripMenuItem.Name = "hToolStripMenuItem";
            hToolStripMenuItem.Size = new Size(77, 20);
            hToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // cascadeXếpChồngToolStripMenuItem
            // 
            cascadeXếpChồngToolStripMenuItem.Image = (Image)resources.GetObject("cascadeXếpChồngToolStripMenuItem.Image");
            cascadeXếpChồngToolStripMenuItem.Name = "cascadeXếpChồngToolStripMenuItem";
            cascadeXếpChồngToolStripMenuItem.Size = new Size(148, 22);
            cascadeXếpChồngToolStripMenuItem.Text = "Xếp chồng";
            cascadeXếpChồngToolStripMenuItem.Click += cascadeXếpChồngToolStripMenuItem_Click;
            // 
            // xếpNgangToolStripMenuItem
            // 
            xếpNgangToolStripMenuItem.Image = (Image)resources.GetObject("xếpNgangToolStripMenuItem.Image");
            xếpNgangToolStripMenuItem.Name = "xếpNgangToolStripMenuItem";
            xếpNgangToolStripMenuItem.Size = new Size(148, 22);
            xếpNgangToolStripMenuItem.Text = "Xếp ngang";
            xếpNgangToolStripMenuItem.Click += xếpNgangToolStripMenuItem_Click;
            // 
            // xếpDọcToolStripMenuItem
            // 
            xếpDọcToolStripMenuItem.Image = (Image)resources.GetObject("xếpDọcToolStripMenuItem.Image");
            xếpDọcToolStripMenuItem.Name = "xếpDọcToolStripMenuItem";
            xếpDọcToolStripMenuItem.Size = new Size(148, 22);
            xếpDọcToolStripMenuItem.Text = "Xếp dọc";
            xếpDọcToolStripMenuItem.Click += xếpDọcToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackgroundImage = (Image)resources.GetObject("toolStrip1.BackgroundImage");
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, tsbbangcap, toolStripButton2, tsbnhanvien, tsbSep1, tsbThoat, toolStripButton3, tsbsach, toolStripButton4, tsbdocgia, toolStripButton5, tsbmuonvatra });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1237, 26);
            toolStrip1.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 23);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // tsbbangcap
            // 
            tsbbangcap.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbbangcap.Font = new Font("Segoe UI", 10F);
            tsbbangcap.ForeColor = Color.Indigo;
            tsbbangcap.Name = "tsbbangcap";
            tsbbangcap.Padding = new Padding(6, 0, 6, 0);
            tsbbangcap.Size = new Size(81, 23);
            tsbbangcap.Text = "Bằng cấp";
            tsbbangcap.Click += tsbbangcap_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 23);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // tsbnhanvien
            // 
            tsbnhanvien.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbnhanvien.Font = new Font("Segoe UI", 10F);
            tsbnhanvien.ForeColor = Color.Indigo;
            tsbnhanvien.Name = "tsbnhanvien";
            tsbnhanvien.Padding = new Padding(6, 0, 6, 0);
            tsbnhanvien.Size = new Size(87, 23);
            tsbnhanvien.Text = "Nhân viên";
            tsbnhanvien.Click += tsbnhanvien_Click;
            // 
            // tsbSep1
            // 
            tsbSep1.Name = "tsbSep1";
            tsbSep1.Size = new Size(6, 26);
            // 
            // tsbThoat
            // 
            tsbThoat.Alignment = ToolStripItemAlignment.Right;
            tsbThoat.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbThoat.Font = new Font("Segoe UI", 10F);
            tsbThoat.Name = "tsbThoat";
            tsbThoat.Padding = new Padding(6, 0, 6, 0);
            tsbThoat.Size = new Size(83, 23);
            tsbThoat.Text = "➡️ Thoát";
            tsbThoat.Click += tsbThoat_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 23);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // tsbsach
            // 
            tsbsach.Name = "tsbsach";
            tsbsach.Size = new Size(32, 23);
            tsbsach.Text = "Sách";
            tsbsach.Click += tsbsach_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 23);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // tsbdocgia
            // 
            tsbdocgia.Name = "tsbdocgia";
            tsbdocgia.Size = new Size(50, 23);
            tsbdocgia.Text = "Độc giả ";
            tsbdocgia.Click += tsbdocgia_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 23);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // tsbmuonvatra
            // 
            tsbmuonvatra.Name = "tsbmuonvatra";
            tsbmuonvatra.Size = new Size(66, 23);
            tsbmuonvatra.Text = "Mượn - Trả";
            tsbmuonvatra.Click += tsbmuonvatra_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 560);
            Controls.Add(toolStrip1);
            Controls.Add(mnu_hotro);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            ForeColor = Color.Indigo;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = mnu_hotro;
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmMain";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            mnu_hotro.ResumeLayout(false);
            mnu_hotro.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnu_hotro;
        private ToolStripMenuItem mnudanhmuc;
        private ToolStripMenuItem mnuHethong;
        private ToolStripSeparator sep2;
        private ToolStripMenuItem mnuDongTat;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbbangcap;
        private ToolStripButton tsbnhanvien;
        private ToolStripSeparator tsbSep1;
        private ToolStripButton tsbThoat;
        private ToolStripLabel tsbsach;
        private ToolStripMenuItem mnu_muontra;
        private ToolStripMenuItem mnu_docgia;
        private ToolStripMenuItem mnu_baocao;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripLabel tsbmuonvatra;
        private ToolStripMenuItem bằngCấpToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripMenuItem phiếuMượnToolStripMenuItem;
        private ToolStripMenuItem thuTiềnToolStripMenuItem;
        private ToolStripMenuItem cascadeXếpChồngToolStripMenuItem;
        private ToolStripMenuItem xếpNgangToolStripMenuItem;
        private ToolStripMenuItem xếpDọcToolStripMenuItem;
        private ToolStripLabel tsbdocgia;
    }
}
