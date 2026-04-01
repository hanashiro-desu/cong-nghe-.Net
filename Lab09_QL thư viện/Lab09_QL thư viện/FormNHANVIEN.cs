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
    public partial class FormNHANVIEN : Form
    {

        private QLThuVienContext db = new QLThuVienContext();
        public FormNHANVIEN()
        {
            InitializeComponent();
        }

        private void FormSINHVIEN_Load(object sender, EventArgs e)
        {
            LoadComboBoxBangCap();
            LoadDanhSach();
        }

        private void LoadComboBoxBangCap()
        {
            var dsBangCap = db.Bangcaps.AsNoTracking().ToList();
            cbbtenbangcap.DataSource = dsBangCap;
            cbbtenbangcap.DisplayMember = "TenBangCap";
            cbbtenbangcap.ValueMember = "MaBangCap";
        }

        private void LoadDanhSach(string keyword = "")
        {
            // Sử dụng Include để lấy tên bằng cấp từ bảng liên quan
            var query = db.Nhanviens.Include(n => n.MaBangCapNavigation).AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim().ToLower();
                query = query.Where(n => n.HoTenNhanVien.ToLower().Contains(kw) ||
                                         n.DiaChi.ToLower().Contains(kw));
            }

            var ds = query.Select(n => new
            {
                n.MaNhanVien,
                n.HoTenNhanVien,
                n.NgaySinh,
                n.DiaChi,
                n.DienThoai,
                TenBangCap = n.MaBangCapNavigation.TenBangCap // Lấy tên từ bảng BangCap
            }).ToList();

            dgvNHANVIEN.DataSource = ds;

            // Định dạng DataGridView
            if (dgvNHANVIEN.Columns.Count > 0)
            {
                dgvNHANVIEN.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvNHANVIEN.Columns["HoTenNhanVien"].HeaderText = "Họ tên";
                dgvNHANVIEN.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvNHANVIEN.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvNHANVIEN.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvNHANVIEN.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgvNHANVIEN.Columns["TenBangCap"].HeaderText = "Bằng cấp";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNHANVIEN.CurrentRow == null) return;

            DataGridViewRow row = dgvNHANVIEN.CurrentRow;
            lblMaSo.Text = row.Cells["MaNhanVien"].Value?.ToString();
            Txthoten.Text = row.Cells["HoTenNhanVien"].Value?.ToString();
            Txtdiachi.Text = row.Cells["DiaChi"].Value?.ToString();
            Txtsdt.Text = row.Cells["DienThoai"].Value?.ToString();
            string? ns = row.Cells["NgaySinh"].Value?.ToString();
            if (DateTime.TryParseExact(ns, "dd/MM/yyyy",
                null, System.Globalization.DateTimeStyles.None, out DateTime ngay))
                dtpngaysinh.Value = ngay;

            // Đổ lại ComboBox bằng cấp
            cbbtenbangcap.Text = row.Cells["TenBangCap"].Value?.ToString();

            // Lưu ID vào Tag để Sửa/Xóa
            string? tenBangCap = row.Cells["TenBangCap"].Value?.ToString().Trim();
            foreach (Bangcap k in cbbtenbangcap.Items)
                if (k.TenBangCap.Trim() == tenBangCap) { cbbtenbangcap.SelectedItem = k; break; }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txthoten.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo");
                Txthoten.Focus();
                return;
            }

            Nhanvien nv = new Nhanvien
            {
                HoTenNhanVien = Txthoten.Text.Trim(),
                NgaySinh = dtpngaysinh.Value,
                DiaChi = Txtdiachi.Text.Trim(),
                DienThoai = Txtsdt.Text.Trim(),
                MaBangCap = (int)cbbtenbangcap.SelectedValue
            };

            db.Nhanviens.Add(nv);
            db.SaveChanges();
            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Thêm nhân viên thành công!");
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblMaSo.Text, out int maSo))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            var nv = db.Nhanviens.Find(maSo);

            if (nv != null)
            {
                nv.HoTenNhanVien = Txthoten.Text.Trim();
                nv.NgaySinh = dtpngaysinh.Value;
                nv.DiaChi = Txtdiachi.Text.Trim();
                nv.DienThoai = Txtdiachi.Text.Trim();
                nv.MaBangCap = (int)cbbtenbangcap.SelectedValue;

                db.SaveChanges();
                LoadDanhSach();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void Btt_lammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSach();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra mã số từ Label
            if (!int.TryParse(lblMaSo.Text, out int maSo))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra ràng buộc dữ liệu 
            // Nếu nhân viên đã có dữ liệu trong bảng Phieuthutiens thì không được xóa (để tránh lỗi liên kết)
            bool coDuLieuLienQuan = db.Phieuthutiens.Any(p => p.MaNhanVien == maSo);
            if (coDuLieuLienQuan)
            {
                MessageBox.Show("Không thể xóa! Nhân viên này đã có lịch sử lập phiếu thu tiền.",
                    "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Xác nhận từ người dùng trước khi thực hiện hành động nguy hiểm
            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên có mã {maSo} không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 4. Tìm đối tượng trong DB
                var nv = db.Nhanviens.Find(maSo);

                if (nv != null)
                {
                    try
                    {
                        // 5. Thực hiện xóa và lưu thay đổi
                        db.Nhanviens.Remove(nv);
                        db.SaveChanges();

                        // 6. Cập nhật lại giao diện
                        LoadDanhSach(); // Hàm load lại DataGridView
                        LamMoi();       // Hàm xóa trắng các TextBox/Label

                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi hệ thống",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LamMoi()
        {
            lblMaSo.Text = "";
            Txthoten.Clear();
            Txtdiachi.Clear();
            Txtsdt.Clear();
            dtpngaysinh.Value = DateTime.Now;
            Txthoten.Tag = null;
            txttimkiem.Clear();
            Txthoten.Focus();
        }

        private void Btt_timkiem_Click(object sender, EventArgs e) => LoadDanhSach(txttimkiem.Text);

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDanhSach(txttimkiem.Text);
        }
    }
}
