namespace BT_ThucHanh
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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuChucNang = new ToolStripMenuItem();
            mnuSinhVien = new ToolStripMenuItem();
            mnuKhoa = new ToolStripMenuItem();
            mnuMonHoc = new ToolStripMenuItem();
            sep1 = new ToolStripSeparator();
            mnuNhapDiem = new ToolStripMenuItem();
            mnuKetQua = new ToolStripMenuItem();
            mnuHoTro = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileH = new ToolStripMenuItem();
            mnuTileV = new ToolStripMenuItem();
            sep2 = new ToolStripSeparator();
            mnuDongTat = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tsbSinhVien = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            tsbKhoa = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            tsbMonHoc = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            tsbNhapDiem = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            tsbKetQua = new ToolStripButton();
            tsbSep1 = new ToolStripSeparator();
            tsbThoat = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuChucNang, mnuHoTro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1099, 25);
            menuStrip1.TabIndex = 0;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuHeThong.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            mnuHeThong.ForeColor = Color.Indigo;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(78, 21);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(161, 22);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += menuThoat_Click;
            // 
            // mnuChucNang
            // 
            mnuChucNang.DropDownItems.AddRange(new ToolStripItem[] { mnuSinhVien, mnuKhoa, mnuMonHoc, sep1, mnuNhapDiem, mnuKetQua });
            mnuChucNang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            mnuChucNang.ForeColor = Color.Indigo;
            mnuChucNang.Name = "mnuChucNang";
            mnuChucNang.Size = new Size(86, 21);
            mnuChucNang.Text = "Chức năng";
            // 
            // mnuSinhVien
            // 
            mnuSinhVien.Name = "mnuSinhVien";
            mnuSinhVien.Size = new Size(167, 22);
            mnuSinhVien.Text = "👤 Sinh viên";
            mnuSinhVien.Click += menuSinhVien_Click;
            // 
            // mnuKhoa
            // 
            mnuKhoa.Name = "mnuKhoa";
            mnuKhoa.Size = new Size(167, 22);
            mnuKhoa.Text = "🏫 Khoa";
            mnuKhoa.Click += menuKhoa_Click;
            // 
            // mnuMonHoc
            // 
            mnuMonHoc.Name = "mnuMonHoc";
            mnuMonHoc.Size = new Size(167, 22);
            mnuMonHoc.Text = "📚 Môn học";
            mnuMonHoc.Click += menuMonHoc_Click;
            // 
            // sep1
            // 
            sep1.Name = "sep1";
            sep1.Size = new Size(164, 6);
            // 
            // mnuNhapDiem
            // 
            mnuNhapDiem.Name = "mnuNhapDiem";
            mnuNhapDiem.Size = new Size(167, 22);
            mnuNhapDiem.Text = "📝 Nhập điểm";
            mnuNhapDiem.Click += menuNhapDiem_Click;
            // 
            // mnuKetQua
            // 
            mnuKetQua.Name = "mnuKetQua";
            mnuKetQua.Size = new Size(167, 22);
            mnuKetQua.Text = "📊 Xem điểm";
            mnuKetQua.Click += menuKetQua_Click;
            // 
            // mnuHoTro
            // 
            mnuHoTro.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileH, mnuTileV, sep2, mnuDongTat });
            mnuHoTro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            mnuHoTro.ForeColor = Color.Indigo;
            mnuHoTro.Name = "mnuHoTro";
            mnuHoTro.Size = new Size(60, 21);
            mnuHoTro.Text = "Hỗ trợ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(249, 22);
            mnuCascade.Text = "Xếp tầng (Cascade)";
            mnuCascade.Click += menuCascade_Click;
            // 
            // mnuTileH
            // 
            mnuTileH.Name = "mnuTileH";
            mnuTileH.Size = new Size(249, 22);
            mnuTileH.Text = "Xếp ngang (Tile Horizontal)";
            mnuTileH.Click += menuTileH_Click;
            // 
            // mnuTileV
            // 
            mnuTileV.Name = "mnuTileV";
            mnuTileV.Size = new Size(249, 22);
            mnuTileV.Text = "Xếp dọc (Tile Vertical)";
            mnuTileV.Click += menuTileV_Click;
            // 
            // sep2
            // 
            sep2.Name = "sep2";
            sep2.Size = new Size(246, 6);
            // 
            // mnuDongTat
            // 
            mnuDongTat.Name = "mnuDongTat";
            mnuDongTat.Size = new Size(249, 22);
            mnuDongTat.Text = "Đóng tất cả";
            mnuDongTat.Click += menuDongTat_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackgroundImage = (Image)resources.GetObject("toolStrip1.BackgroundImage");
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, tsbSinhVien, toolStripButton2, tsbKhoa, toolStripButton3, tsbMonHoc, toolStripButton4, tsbNhapDiem, toolStripButton5, tsbKetQua, tsbSep1, tsbThoat });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1099, 26);
            toolStrip1.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.team_people_man_woman_group_icon_193939;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 23);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // tsbSinhVien
            // 
            tsbSinhVien.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSinhVien.Font = new Font("Segoe UI", 10F);
            tsbSinhVien.ForeColor = Color.Indigo;
            tsbSinhVien.Image = Properties.Resources.team_people_man_woman_group_icon_193939;
            tsbSinhVien.Name = "tsbSinhVien";
            tsbSinhVien.Padding = new Padding(6, 0, 6, 0);
            tsbSinhVien.Size = new Size(103, 23);
            tsbSinhVien.Text = "👤 Sinh viên";
            tsbSinhVien.Click += tsbSinhVien_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.user_person_people_6100;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 23);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // tsbKhoa
            // 
            tsbKhoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbKhoa.Font = new Font("Segoe UI", 10F);
            tsbKhoa.ForeColor = Color.Indigo;
            tsbKhoa.Name = "tsbKhoa";
            tsbKhoa.Padding = new Padding(6, 0, 6, 0);
            tsbKhoa.Size = new Size(79, 23);
            tsbKhoa.Text = "🏫 Khoa";
            tsbKhoa.Click += tsbKhoa_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.bookshelf_icon_icons_com_54414;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 23);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // tsbMonHoc
            // 
            tsbMonHoc.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbMonHoc.Font = new Font("Segoe UI", 10F);
            tsbMonHoc.ForeColor = Color.Indigo;
            tsbMonHoc.Name = "tsbMonHoc";
            tsbMonHoc.Padding = new Padding(6, 0, 6, 0);
            tsbMonHoc.Size = new Size(103, 23);
            tsbMonHoc.Text = "📚 Môn học";
            tsbMonHoc.Click += tsbMonHoc_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.competition_file_golfing_clipboard_golf_score_icon_266008;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 23);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // tsbNhapDiem
            // 
            tsbNhapDiem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbNhapDiem.Font = new Font("Segoe UI", 10F);
            tsbNhapDiem.ForeColor = Color.Indigo;
            tsbNhapDiem.Name = "tsbNhapDiem";
            tsbNhapDiem.Padding = new Padding(6, 0, 6, 0);
            tsbNhapDiem.Size = new Size(115, 23);
            tsbNhapDiem.Text = "📝 Nhập điểm";
            tsbNhapDiem.Click += tsbNhapDiem_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.check_list_clipboard_survey_checklist_icon_265628;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 23);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // tsbKetQua
            // 
            tsbKetQua.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbKetQua.Font = new Font("Segoe UI", 10F);
            tsbKetQua.ForeColor = Color.Indigo;
            tsbKetQua.Name = "tsbKetQua";
            tsbKetQua.Padding = new Padding(6, 0, 6, 0);
            tsbKetQua.Size = new Size(109, 23);
            tsbKetQua.Text = "📊 Xem điểm";
            tsbKetQua.Click += tsbKetQua_Click;
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 595);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ForeColor = Color.Indigo;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            Text = "Quản lý sinh viên";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuChucNang;
        private ToolStripMenuItem mnuSinhVien;
        private ToolStripMenuItem mnuKhoa;
        private ToolStripMenuItem mnuMonHoc;
        private ToolStripSeparator sep1;
        private ToolStripMenuItem mnuNhapDiem;
        private ToolStripMenuItem mnuKetQua;
        private ToolStripMenuItem mnuHoTro;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileH;
        private ToolStripMenuItem mnuTileV;
        private ToolStripSeparator sep2;
        private ToolStripMenuItem mnuDongTat;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbSinhVien;
        private ToolStripButton tsbKhoa;
        private ToolStripButton tsbMonHoc;
        private ToolStripButton tsbNhapDiem;
        private ToolStripButton tsbKetQua;
        private ToolStripSeparator tsbSep1;
        private ToolStripButton tsbThoat;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
    }
}
