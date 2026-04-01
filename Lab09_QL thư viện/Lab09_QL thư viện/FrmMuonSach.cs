using Lab09_QL_thư_viện.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Lab09_QL_thư_viện
{
    public partial class FrmMuonSach : Form
    {
        // Khởi tạo DbContext từ dự án BT_ThucHanh
        private QLThuVienContext db = new QLThuVienContext();
        List<Docgium> dsDocGia;
        List<Sach> dsSach;
        List<Sach> dsSachChon = new List<Sach>();
        public FrmMuonSach()
        {
            InitializeComponent();
        }
        private void LoadDocGia()
        {
            dsDocGia = db.Docgia.AsNoTracking().ToList();

            Cboxmadocgia.DataSource = dsDocGia;
            Cboxmadocgia.DisplayMember = "MaDocGia";
            Cboxmadocgia.ValueMember = "MaDocGia";

            cbbten.DataSource = dsDocGia.ToList();
            cbbten.DisplayMember = "HoTenDocGia";

            cbbhanthe.DataSource = dsDocGia.ToList();
            cbbhanthe.DisplayMember = "NgayHetHan";

            cbbhanthe.Format += (s, e) =>
            {
                if (e.ListItem is DateTime dt)
                    e.Value = dt.ToString("dd/MM/yyyy");
            };

        }

        private void LoadSach()
        {
            dsSach = db.Saches.AsNoTracking().ToList();

            cbbmasach.DataSource = dsSach;
            cbbmasach.DisplayMember = "MaSach";
            cbbmasach.DisplayMember = "MaSach";

            cbbtensach.DataSource = dsSach.ToList();
            cbbtensach.DisplayMember = "TenSach";

            cbbtacgia.DataSource = dsSach.ToList();
            cbbtacgia.DisplayMember = "TacGia";
        }
        private void LoadPhieuMuon()
        {
            var data = db.Phieumuonsaches
                  .Include(p => p.MaDocGiaNavigation)
                  .Include(p => p.MaSaches)
                  .AsNoTracking()
                  .Select(p => new
                  {
                      p.MaPhieuMuon,
                      p.NgayMuon,
                      TenDocGia = p.MaDocGiaNavigation.HoTenDocGia,
                      SoSach = p.MaSaches.Count()
                  })
                  .OrderByDescending(p => p.NgayMuon)
                  .ToList();

            dgvDSmuon.DataSource = data;

            if (dgvDSmuon.Columns["MaPhieuMuon"] != null)
                dgvDSmuon.Columns["MaPhieuMuon"].Visible = false;

            dgvDSmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void them_Click(object sender, EventArgs e)
        {
            var s = cbbmasach.SelectedItem as Sach;
            if (s == null)
            {
                MessageBox.Show("Chưa chọn sách!");
                return;
            }

            if (dsSachChon.Any(x => x.MaSach == s.MaSach))
            {
                MessageBox.Show("Sách đã có!");
                return;
            }

            dsSachChon.Add(s);

            LoadSachChon();
        }

        private void FormQLBC_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            LoadSach();
            LoadPhieuMuon();

            Cboxmadocgia.SelectedIndexChanged += Cboxmadocgia_SelectedIndexChanged;
            cbbmasach.SelectedIndexChanged += cbbmasach_SelectedIndexChanged;
            dgvDSmuon.CellClick += dgvPhieuMuon_CellContentClick;
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var value = dgvDSmuon.Rows[e.RowIndex].Cells["MaPhieuMuon"].Value;
            if (value == null) return;

            int maPhieu = (int)value;

            LoadChiTiet(maPhieu);
        }
        private void LoadChiTiet(int maPhieu)
        {
            var data = db.Phieumuonsaches
                 .Where(p => p.MaPhieuMuon == maPhieu)
                 .SelectMany(p => p.MaSaches)
                 .Select(s => new
                 {
                     s.MaSach,
                     s.TenSach,
                     s.TacGia,
                     s.NhaXuatBan
                 })
                 .ToList();

            dgvPhieuMuon.DataSource = data;
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Cboxmadocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dg = Cboxmadocgia.SelectedItem as Docgium;

            if (dg != null)
            {
                cbbten.Text = dg.HoTenDocGia;
                cbbhanthe.Text = dg.NgayHetHan?.ToString("dd/MM/yyyy");
            }

        }

        private void cbbmasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = cbbmasach.SelectedItem as Sach;

            if (s != null)
            {
                cbbtensach.Text = s.TenSach;
                cbbtacgia.Text = s.TacGia;
            }
        }
        private void LoadSachChon()
        {
            dgvchitietphieu.DataSource = null;

            dgvchitietphieu.DataSource = dsSachChon.Select(x => new
            {
                x.MaSach,
                x.TenSach,
                x.TacGia
            }).ToList();

            dgvchitietphieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Btt_save_Click(object sender, EventArgs e)
        {
            try
            {
                var dg = Cboxmadocgia.SelectedItem as Docgium;

                if (dg == null)
                {
                    MessageBox.Show("Chưa chọn độc giả!");
                    return;
                }

                if (dsSachChon.Count == 0)
                {
                    MessageBox.Show("Chưa có sách để mượn!");
                    return;
                }

                int maDocGia = dg.MaDocGia;

                var docGia = db.Docgia.FirstOrDefault(d => d.MaDocGia == maDocGia);

                //  1. Hết hạn
                if (!docGia.NgayHetHan.HasValue || docGia.NgayHetHan < DateTime.Today)
                {
                    MessageBox.Show("Thẻ hết hạn!");
                    return;
                }

                //  2. Nợ tiền
                if (docGia.TienNo > 0)
                {
                    MessageBox.Show($"Còn nợ {docGia.TienNo:N0} VNĐ");
                    return;
                }

                //  3. Số sách tối đa
                int maxSach = db.Thamsos
                    .Where(t => t.TenThamSo == "SoSachMuonToiDa")
                    .Select(t => t.GiaTri)
                    .FirstOrDefault() ?? 3;

                int dangMuon = db.Phieumuonsaches
                    .Where(p => p.MaDocGia == maDocGia)
                    .SelectMany(p => p.MaSaches)
                    .Count();

                if (dangMuon + dsSachChon.Count > maxSach)
                {
                    MessageBox.Show("Vượt quá số sách cho phép!");
                    return;
                }

                //  4. Sách đang mượn
                foreach (var item in dsSachChon)
                {
                    bool daMuon = db.Phieumuonsaches
                        .Any(p => p.MaSaches.Any(s => s.MaSach == item.MaSach));

                    if (daMuon)
                    {
                        MessageBox.Show($"Sách '{item.TenSach}' đang được mượn!");
                        return;
                    }
                }

                //  TẠO PHIẾU
                var phieu = new Phieumuonsach
                {
                    NgayMuon = DateTime.Now,
                    MaDocGia = maDocGia
                };

                //  ADD nhiều sách
                foreach (var item in dsSachChon)
                {
                    var sach = db.Saches.Find(item.MaSach);
                    phieu.MaSaches.Add(sach);
                }

                db.Phieumuonsaches.Add(phieu);
                db.SaveChanges();

                MessageBox.Show("Lưu phiếu mượn thành công!");

                //  reset
                dsSachChon.Clear();
                dgvchitietphieu.DataSource = null;

                LoadPhieuMuon();
                dgvchitietphieu.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Btt_xoa_Click(object sender, EventArgs e)
        {
            if (dgvchitietphieu.CurrentRow == null) return;

            int maSach = (int)dgvchitietphieu.CurrentRow.Cells["MaSach"].Value;

            var item = dsSachChon.FirstOrDefault(x => x.MaSach == maSach);

            if (item != null)
                dsSachChon.Remove(item);


            LoadSachChon();
        }
    }
}