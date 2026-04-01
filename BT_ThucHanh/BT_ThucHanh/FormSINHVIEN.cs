using BT_ThucHanh.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BT_ThucHanh
{
    public partial class FormSINHVIEN : Form
    {

        private StudentDbContext db = new StudentDbContext();
        public FormSINHVIEN()
        {
            InitializeComponent();
        }

        private void FormSINHVIEN_Load(object sender, EventArgs e)
        {
            LoadComboBoxGioiTinh();
            LoadComboBoxKhoa();
            LoadDanhSachSinhVien();

        }
        // ─── LOAD COMBOBOX GIỚI TÍNH ───
        private void LoadComboBoxGioiTinh()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Nam");
            comboBox2.Items.Add("Nữ");
            comboBox2.SelectedIndex = 0;

        }
        // ─── LOAD COMBOBOX KHOA TỪ DATABASE ───
        private void LoadComboBoxKhoa()
        {
            // EF Core: dùng .Include() để load navigation property nếu cần
            comboBox1.DataSource = db.Khoas.ToList();
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "MaKhoa";
        }

        private void LoadDanhSachSinhVien()
        {
            // EF Core: dùng .Include() để load dữ liệScaffold-DbContext "Server=DESKTOP-CQIPA1K\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Forceu từ bảng liên quan (KHOA)
            var ds = db.SinhViens
              .Include(sv => sv.MakhoaNavigation) // Load thông tin khoa
            .Select(sv => new
            {
                sv.MaSo,
                sv.HoTen,
                NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                GioiTinh = sv.GioiTinh == true ? "Nam" : "Nữ",
                sv.DiaChi,
                sv.DienThoai,
                TenKhoa = sv.MakhoaNavigation != null ? sv.MakhoaNavigation.Tenkhoa.Trim() : ""
            }).ToList();

            dataGridView1.DataSource = ds;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["MaSo"].HeaderText = "Mã số";
                dataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
                dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
                dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dataGridView1.Columns["DienThoai"].HeaderText = "Điện thoại";
                dataGridView1.Columns["TenKhoa"].HeaderText = "Khoa";
            }
        }
       

        private void Them_Click(object sender, EventArgs e)
        {
            // ── Validate ──
            if (string.IsNullOrEmpty(Txthoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                Txthoten.Focus();
                return;
            }

            //── Tạo object SinhVien — KHÔNG set MaSo (IDENTITY tự tăng) ──
            SinhVien svMoi = new SinhVien
            {
                HoTen = Txthoten.Text.Trim(),
                NgaySinh = dateTimePicker1.Value,
                GioiTinh = comboBox2.SelectedItem.ToString() == "Nam",
                DiaChi = Txtdiachi.Text.Trim(),
                DienThoai = int.TryParse(Txtsdt.Text, out int sdt) ? sdt : null,
                Makhoa = comboBox1.SelectedValue?.ToString()
            };

            db.SinhViens.Add(svMoi);
            db.SaveChanges();

            LoadDanhSachSinhVien();

            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblMaSo.Text, out int maSo))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!"); return;
            }

            var cf = MessageBox.Show(
            $"Xóa sinh viên: {Txthoten.Text}?\nLưu ý: điểm của SV này cũng bị xóa!",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (cf != DialogResult.Yes) return;

            // Bắt buộc xóa KetQua trước (ràng buộc FK)
            var kqs = db.KetQuas.Where(kq => kq.MaSo == maSo).ToList();
            db.KetQuas.RemoveRange(kqs);
            SinhVien? sv = db.SinhViens.Find(maSo);
            if (sv != null) db.SinhViens.Remove(sv);
            db.SaveChanges();
            LoadDanhSachSinhVien();
            MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btt_timkiem_Click(object sender, EventArgs e)
        {
            string kw = textBox1.Text.Trim().ToLower();
            var kq = db.SinhViens
            .Include(sv => sv.MakhoaNavigation)
            .Where(sv => sv.HoTen.ToLower().Contains(kw)
                       || (sv.DiaChi != null && sv.DiaChi.ToLower().Contains(kw)))
            .Select(sv => new
            {
                sv.MaSo,
                sv.HoTen,
                NgaySinh = sv.NgaySinh.HasValue
                           ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                GioiTinh = sv.GioiTinh == true ? "Nam" : "Nữ",
                sv.DiaChi,
                sv.DienThoai,
                TenKhoa = sv.MakhoaNavigation != null
                          ? sv.MakhoaNavigation.Tenkhoa.Trim() : ""
            }).ToList();

            dataGridView1.DataSource = kq;
        }

        private void Btt_lammoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LoadDanhSachSinhVien();
        }
        private void LamMoiForm()
        {
            lblMaSo.Text = "";
            Txthoten.Clear(); Txtdiachi.Clear(); Txtsdt.Clear();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            Txthoten.Focus();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblMaSo.Text, out int maSo))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!"); return;
            }

            SinhVien? sv = db.SinhViens.Find(maSo);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy!"); return;
            }

            sv.HoTen = Txthoten.Text.Trim();
            sv.NgaySinh = dateTimePicker1.Value;
            sv.GioiTinh = comboBox2.SelectedItem.ToString() == "Nam";
            sv.DiaChi = Txtdiachi.Text.Trim();
            sv.DienThoai = int.TryParse(Txtsdt.Text, out int sdt) ? sdt : null;
            sv.Makhoa = comboBox1.SelectedValue?.ToString();

            db.SaveChanges();
            LoadDanhSachSinhVien();
            MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            DataGridViewRow row = dataGridView1.CurrentRow;

            lblMaSo.Text = row.Cells["MaSo"].Value?.ToString();
            Txthoten.Text = row.Cells["HoTen"].Value?.ToString();
            Txtdiachi.Text = row.Cells["DiaChi"].Value?.ToString();
            Txtsdt.Text = row.Cells["DienThoai"].Value?.ToString();

            string? ns = row.Cells["NgaySinh"].Value?.ToString();
            if (DateTime.TryParseExact(ns, "dd/MM/yyyy",
                null, System.Globalization.DateTimeStyles.None, out DateTime ngay))
                dateTimePicker1.Value = ngay;

            comboBox2.SelectedItem = row.Cells["GioiTinh"].Value?.ToString() == "Nam" ? "Nam" : "Nữ";

            string? tenKhoa = row.Cells["TenKhoa"].Value?.ToString().Trim();
            foreach (Khoa k in comboBox1.Items)
                if (k.Tenkhoa.Trim() == tenKhoa) { comboBox2.SelectedItem = k; break; }
        }
    }
}
