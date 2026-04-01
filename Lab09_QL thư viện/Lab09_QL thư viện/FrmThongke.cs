using Lab09_QL_thư_viện.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_QL_thư_viện
{
    public partial class Frmthongke : Form
    {
        private QLThuVienContext db = new QLThuVienContext();
        public Frmthongke()
        {
            InitializeComponent();
        }
        private void LoadTatCaBaoCao()
        {
            LoadBaoCaoSachDangMuon();
            LoadBaoCaoDocGiaNo();
            LoadBaoCaoTopSach();
            LoadBaoCaoTheSapHetHan();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            LoadTatCaBaoCao();
        }
        private void LoadBaoCaoSachDangMuon()
        {
            var dsSachMuon = db.Phieumuonsaches
                               .AsNoTracking()
                               .SelectMany(p => p.MaSaches.Select(s => new
                               {
                                   s.TenSach,
                                   s.TacGia,
                                   TenDocGia = p.MaDocGiaNavigation.HoTenDocGia,
                                   NgayMuon = p.NgayMuon, // Giữ kiểu DateTime để sort
                                   NgayMuonHienThi = p.NgayMuon.ToString("dd/MM/yyyy")
                               }))
                               .OrderByDescending(x => x.NgayMuon) // Mới nhất xếp trên
                               .Select(x => new
                               {
                                   x.TenSach,
                                   x.TacGia,
                                   x.TenDocGia,
                                   NgayMuon = x.NgayMuonHienThi
                               })
                               .ToList();

            dgvsachmuon.DataSource = dsSachMuon;
            if (dgvsachmuon.Columns.Count > 0)
            {
                dgvsachmuon.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvsachmuon.Columns["TacGia"].HeaderText = "Tác Giả";
                dgvsachmuon.Columns["TenDocGia"].HeaderText = "Độc Giả Đang Mượn";
                dgvsachmuon.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            }
        }
        private void LoadBaoCaoDocGiaNo()
        {
            var dsDocGiaNo = db.Docgia
                               .Where(d => d.TienNo > 0)
                               .OrderByDescending(d => d.TienNo) // Nợ nhiều nhất lên đầu
                               .Select(d => new
                               {
                                   d.HoTenDocGia,
                                   d.DiaChi,
                                   NgayHetHan = d.NgayHetHan.HasValue ? d.NgayHetHan.Value.ToString("dd/MM/yyyy") : "",
                                   d.TienNo
                               })
                               .ToList();

            dgvdocgia.DataSource = dsDocGiaNo;
            if (dgvdocgia.Columns.Count > 0)
            {
                dgvdocgia.Columns["HoTenDocGia"].HeaderText = "Họ Tên";
                dgvdocgia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvdocgia.Columns["NgayHetHan"].HeaderText = "Ngày Hết Hạn";

                dgvdocgia.Columns["TienNo"].HeaderText = "Tiền Nợ (VNĐ)";
                dgvdocgia.Columns["TienNo"].DefaultCellStyle.Format = "N0";
                dgvdocgia.Columns["TienNo"].DefaultCellStyle.ForeColor = Color.Red;
            }
        }
        private void LoadBaoCaoTopSach()
        {
            var topSach = db.Saches
                            .Select(s => new
                            {
                                s.TenSach,
                                s.TacGia,
                                // Đếm xem cuốn sách này xuất hiện trong bao nhiêu phiếu mượn
                                SoLanMuon = s.MaPhieuMuons.Count()
                            })
                            .OrderByDescending(s => s.SoLanMuon)
                            .Take(10) // Lấy đúng 10 dòng đầu tiên
                            .ToList();

            dgvthongke.DataSource = topSach;
            if (dgvthongke.Columns.Count > 0)
            {
                dgvthongke.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvthongke.Columns["TacGia"].HeaderText = "Tác Giả";
                dgvthongke.Columns["SoLanMuon"].HeaderText = "Số Lần Được Mượn";
            }
        }
        private void LoadBaoCaoTheSapHetHan()
        {
            DateTime homNay = DateTime.Today;
            DateTime baMuoiNgayToi = homNay.AddDays(30);

            var sapHetHan = db.Docgia
                              .Where(d => d.NgayHetHan.HasValue &&
                                          d.NgayHetHan.Value.Date >= homNay &&
                                          d.NgayHetHan.Value.Date <= baMuoiNgayToi)
                              .OrderBy(d => d.NgayHetHan) // Ai sắp hết hạn trước thì xếp trên
                              .Select(d => new
                              {
                                  d.HoTenDocGia,
                                  NgayHetHan = d.NgayHetHan.Value.ToString("dd/MM/yyyy"),
                                  d.Email
                              })
                              .ToList();

            dgvdocgiahethanthe.DataSource = sapHetHan;
            if (dgvdocgiahethanthe.Columns.Count > 0)
            {
                dgvdocgiahethanthe.Columns["HoTenDocGia"].HeaderText = "Họ Tên Độc Giả";
                dgvdocgiahethanthe.Columns["NgayHetHan"].HeaderText = "Ngày Hết Hạn";
                dgvdocgiahethanthe.Columns["Email"].HeaderText = "Email Liên Hệ";
            }
        }

        private void Bttload_Click(object sender, EventArgs e)
        {
            LoadTatCaBaoCao();
        }
    }
}
