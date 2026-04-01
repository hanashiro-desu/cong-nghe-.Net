using BT_ThucHanh.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BT_ThucHanh
{
    public partial class FormMonHoc : Form
    {
        // Khởi tạo DbContext từ dự án BT_ThucHanh
        private StudentDbContext db = new StudentDbContext();

        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachMonHoc();
        }

        // ─── LOAD DANH SÁCH MÔN HỌC ───────────────────────────────────────────
        private void LoadDanhSachMonHoc()
        {
            var ds = db.Mons.Select(m => new
            {
                m.MaMh,
                m.TenMh,
                m.SoTiet
            }).ToList();

            dataGridView1.DataSource = ds;

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["MaMh"].HeaderText = "Mã môn học";
                dataGridView1.Columns["TenMh"].HeaderText = "Tên môn học";
                dataGridView1.Columns["SoTiet"].HeaderText = "Số tiết";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        // ─── THÊM MÔN HỌC ────────────────────────────────────────────────────
        private void them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtmaKH.Text) || string.IsNullOrEmpty(TxtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maMoi = TxtmaKH.Text.Trim().ToUpper();

            // Kiểm tra trùng mã
            if (db.Mons.Any(m => m.MaMh.Trim() == maMoi))
            {
                MessageBox.Show("Mã môn học này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mon mh = new Mon
            {
                MaMh = maMoi,
                TenMh = TxtTenKH.Text.Trim(),
                SoTiet = int.TryParse(Txttim.Text, out int st) ? st : 0 // Giả sử Txttim dùng để nhập số tiết
            };

            db.Mons.Add(mh);
            db.SaveChanges();

            LoadDanhSachMonHoc();
            LamMoiForm();
            MessageBox.Show("Thêm môn học thành công!", "Thông báo");
        }

        // ─── SỬA (LƯU) MÔN HỌC ────────────────────────────────────────────────
        private void luu_Click(object sender, EventArgs e)
        {
            string ma = TxtmaKH.Text.Trim();
            var mh = db.Mons.FirstOrDefault(m => m.MaMh.Trim() == ma);

            if (mh == null)
            {
                MessageBox.Show("Không tìm thấy môn học để cập nhật!", "Thông báo");
                return;
            }

            mh.TenMh = TxtTenKH.Text.Trim();
            mh.SoTiet = int.TryParse(Txttim.Text, out int st) ? st : 0;

            db.SaveChanges();
            LoadDanhSachMonHoc();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        // ─── TÌM KIẾM ─────────────────────────────────────────────────────────
        private void button4_Click(object sender, EventArgs e) // Giả sử button4 là nút Tìm Kiếm
        {
            string tuKhoa = TxtTenKH.Text.Trim().ToLower(); // Tìm kiếm theo tên nhập trong ô TxtTenKH

            var ketQua = db.Mons
                .Where(m => m.TenMh.ToLower().Contains(tuKhoa) || m.MaMh.ToLower().Contains(tuKhoa))
                .Select(m => new
                {
                    m.MaMh,
                    m.TenMh,
                    m.SoTiet
                }).ToList();

            dataGridView1.DataSource = ketQua;
        }

        // ─── LÀM MỚI FORM ────────────────────────────────────────────────────
        private void LamMoiForm()
        {
            TxtmaKH.Clear();
            TxtTenKH.Clear();
            Txttim.Clear();
            TxtmaKH.Enabled = true;
            TxtmaKH.Focus();
        }

        // ─── CHỌN DÒNG TRÊN GRID ─────────────────────────────────────────────
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var row = dataGridView1.CurrentRow;
            TxtmaKH.Text = row.Cells["MaMh"].Value?.ToString().Trim();
            TxtTenKH.Text = row.Cells["TenMh"].Value?.ToString().Trim();
            Txttim.Text = row.Cells["SoTiet"].Value?.ToString().Trim();

            TxtmaKH.Enabled = false; // Khóa mã môn khi chọn để sửa
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            TxtmaKH.Text = dataGridView1.CurrentRow.Cells["MaMh"].Value?.ToString();
            TxtTenKH.Text = dataGridView1.CurrentRow.Cells["TenMh"].Value?.ToString();

            if (int.TryParse(dataGridView1.CurrentRow.Cells["SoTiet"].Value?.ToString(), out int soTiet))
                numericUpDown1.Value = soTiet;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = TxtmaKH.Text.Trim();
            var mh = db.Mons.FirstOrDefault(m => m.MaMh.Trim() == ma);

            if (mh == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!");
                return;
            }

            // Kiểm tra ràng buộc khóa ngoại (đã có điểm chưa)
            bool coDiem = db.KetQuas.Any(kq => kq.MaMh.Trim() == ma);
            if (coDiem)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có dữ liệu điểm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận xóa môn: {mh.TenMh}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                db.Mons.Remove(mh);
                db.SaveChanges();
                LoadDanhSachMonHoc();
                LamMoiForm();
                MessageBox.Show("Xóa thành công!");
            }
        }
    }
}