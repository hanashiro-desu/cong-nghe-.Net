using Lab09_QL_thư_viện.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab09_QL_thư_viện
{
    public partial class FormSACH : Form
    {

        private QLThuVienContext db = new QLThuVienContext();
        public FormSACH()
        {
            InitializeComponent();
        }

        private void FormSINHVIEN_Load(object sender, EventArgs e) => LoadDanhSach();
        private void LoadDanhSach(string keyword = "")
        {
            var query = db.Saches.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim().ToLower();
                query = query.Where(s => s.TenSach.ToLower().Contains(kw) ||
                                         s.TacGia.ToLower().Contains(kw) ||
                                         s.NhaXuatBan.ToLower().Contains(kw));
            }

            var ds = query.Select(s => new
            {
                s.MaSach,
                s.TenSach,
                s.TacGia,
                s.NamXuatBan,
                s.NhaXuatBan,
                s.TriGia,
                s.NgayNhap
            }).ToList();

            dgvSACH.DataSource = ds;

            if (dgvSACH.Columns.Count > 0)
            {
                dgvSACH.Columns["MaSach"].HeaderText = "Mã sách";
                dgvSACH.Columns["TenSach"].HeaderText = "Tên sách";
                dgvSACH.Columns["TacGia"].HeaderText = "Tác giả";
                dgvSACH.Columns["NamXuatBan"].HeaderText = "Năm XB";
                dgvSACH.Columns["NhaXuatBan"].HeaderText = "NXB";
                dgvSACH.Columns["TriGia"].HeaderText = "Trị giá";
                dgvSACH.Columns["NgayNhap"].HeaderText = "Ngày nhập";

                // Format Trị giá N0 VNĐ và Ngày nhập
                dgvSACH.Columns["TriGia"].DefaultCellStyle.Format = "N0";
                dgvSACH.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void LoadDanhSachSinhVien()
        {

        }


        private void Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtsach.Text))
            {
                MessageBox.Show("Tên sách không được để trống!", "Thông báo");
                return;
            }
            if (!int.TryParse(Txtnamxb.Text, out int namXB) || namXB < 1900 || namXB > 2099)
            {
                MessageBox.Show("Năm xuất bản phải từ 1900 đến 2099!", "Thông báo");
                return;
            }

            // 3. Xử lý chuỗi định dạng "N0 VNĐ" trước khi Parse Trị giá
            // Loại bỏ "VNĐ", dấu phân cách hàng nghìn (,) và khoảng trắng
            string cleanPrice = textBoxtrigia.Text.Replace("VNĐ", "").Replace(",", "").Trim();

            if (!double.TryParse(cleanPrice, out double trigia) || trigia < 0)
            {
                MessageBox.Show("Trị giá phải là số và không được âm!", "Thông báo");
                return;
            }

            var moi = new Sach
            {
                TenSach = Txtsach.Text.Trim(),
                TacGia = Txttacgia.Text.Trim(),
                NamXuatBan = namXB,
                NhaXuatBan = txtnxb.Text.Trim(),
                TriGia = trigia,
                NgayNhap = dtpngaynhan.Value
            };

            db.Saches.Add(moi);
            db.SaveChanges();

            // 5. Cập nhật lại giao diện
            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Thêm sách thành công!", "Thông báo");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (Txtsach.Tag == null) return;

            int maSach = (int)Txtsach.Tag;

            // Kiểm tra sách có trong CHITIETPHIEUMUON không (.Any())
            if (db.Phieumuonsaches.Any(ct => ct.MaPhieuMuon == maSach))
            {
                MessageBox.Show("Không thể xóa! Sách này đã có trong dữ liệu mượn sách.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var s = db.Saches.Find(maSach);
                if (s != null)
                {
                    db.Saches.Remove(s);
                    db.SaveChanges();
                    LoadDanhSach();
                    LamMoi();
                    MessageBox.Show("Xóa thành công!");
                }
            }
        }
        private void LamMoi()
        {
            lblMaSo.Text = "";
            Txtsach.Clear();
            Txttacgia.Clear();
            Txttacgia.Clear();
            Txtnamxb.Clear();
            textBoxtrigia.Clear();
            dtpngaynhan.Value = DateTime.Now;
            Txtsach.Tag = null;
            txttimkiem.Clear();
            Txtsach.Focus();
        }
        private void Btt_timkiem_Click(object sender, EventArgs e)
        {
            LoadDanhSach(txttimkiem.Text);
        }

        private void Btt_lammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSach();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (Txtsach.Tag == null) return;
            int maSach = (int)Txtsach.Tag;
            var s = db.Saches.Find(maSach);
            if (s != null)
            {
                if (string.IsNullOrWhiteSpace(Txtsach.Text))
                {
                    MessageBox.Show("Tên sách không được để trống!", "Thông báo");
                    return;
                }
                if (!int.TryParse(Txtnamxb.Text, out int namXB) || namXB < 1900 || namXB > 2099)
                {
                    MessageBox.Show("Năm xuất bản phải trong khoảng 1900-2099!", "Thông báo");
                    return;
                }

                // 3. Xử lý chuỗi định dạng "N0 VNĐ" trước khi Parse Trị giá
                string cleanPrice = textBoxtrigia.Text.Replace("VNĐ", "").Replace(",", "").Trim();

                if (!double.TryParse(cleanPrice, out double triGia) || triGia < 0)
                {
                    MessageBox.Show("Trị giá phải là số và không được âm!", "Thông báo");
                    return;
                }
                s.TenSach = Txtsach.Text.Trim();
                s.TacGia = Txttacgia.Text.Trim();
                s.NamXuatBan = namXB;
                s.NhaXuatBan = txtnxb.Text.Trim(); // Gán nhà xuất bản
                s.TriGia = triGia;
                s.NgayNhap = dtpngaynhan.Value;
                db.SaveChanges();
                LoadDanhSach();
                MessageBox.Show("Cập nhật sách thành công!", "Thông báo");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSACH.CurrentRow == null) return;

            DataGridViewRow row = dgvSACH.CurrentRow;

            lblMaSo.Text = row.Cells["MaSach"].Value?.ToString();
            Txtsach.Text = row.Cells["TenSach"].Value?.ToString();
            Txttacgia.Text = row.Cells["TacGia"].Value?.ToString();
            Txtnamxb.Text = row.Cells["NamXuatBan"].Value?.ToString();
            txtnxb.Text = row.Cells["NhaXuatBan"].Value?.ToString();
            if (row.Cells["TriGia"].Value != null && double.TryParse(row.Cells["TriGia"].Value.ToString(), out double triGia))
            {

                textBoxtrigia.Text = triGia.ToString("N0") + " VNĐ";
            }
            string? nn = row.Cells["NgayNhap"].Value?.ToString();
            if (DateTime.TryParse(nn, out DateTime ngayNhap))
            {
                dtpngaynhan.Value = ngayNhap;
            }
            else
            {
                dtpngaynhan.Value = DateTime.Now;
            }
            Txtsach.Tag = row.Cells["MaSach"].Value;
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDanhSach(txttimkiem.Text);
        }
    }
}
