using BT_ThucHanh.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BT_ThucHanh
{
    public partial class FormDS_Khoa : Form
    {

        private StudentDbContext db = new StudentDbContext();
        public FormDS_Khoa()
        {
            InitializeComponent();
        }

        private void FormDmKhoa_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhoa();
        }

        private void LoadDanhSachKhoa()
        {
            // Lấy danh sách khoa và hiển thị lên DataGridView
            var dsKhoa = db.Khoas
                .Select(k => new
                {
                    k.Makhoa,
                    k.Tenkhoa
                }).ToList();

            dataGridView1.DataSource = dsKhoa;

            // Định dạng tiêu đề cột
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Makhoa"].HeaderText = "Mã Khoa";
                dataGridView1.Columns["Tenkhoa"].HeaderText = "Tên Khoa";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtmakhoa.Text) || string.IsNullOrEmpty(Txttenkhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Khoa và Tên Khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã khoa
            string maKhoa = Txttenkhoa.Text.Trim().ToUpper();
            if (db.Khoas.Any(k => k.Makhoa.Trim() == maKhoa))
            {
                MessageBox.Show("Mã khoa đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Khoas.Add(new Khoa
            {
                Makhoa = maKhoa,
                Tenkhoa = Txttenkhoa.Text.Trim()
            });

            db.SaveChanges();

            LoadDanhSachKhoa();
            LamMoiForm();
            MessageBox.Show("Thêm khoa mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtmakhoa.Text)) return;
            string maKhoa = Txtmakhoa.Text.Trim();
            Khoa? khoa = db.Khoas.FirstOrDefault(k => k.Makhoa.Trim() == maKhoa);
            if (khoa == null) { MessageBox.Show("Không tìm thấy Khoa!"); return; }

            khoa.Tenkhoa = Txttenkhoa.Text.Trim();
            db.SaveChanges();

            LoadDanhSachKhoa();
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtmakhoa.Text)) return;

            string ma = Txtmakhoa.Text.Trim();

            // Kiểm tra có sinh viên thuộc khoa này không — tránh lỗi FK
            bool coSV = db.SinhViens.Any(sv => sv.Makhoa.Trim() == ma);
            if (coSV)
            {
                MessageBox.Show($"Không thể xóa! Khoa '{Txttenkhoa.Text}' còn sinh viên đang theo học.",
                                "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cf = MessageBox.Show($"Xóa khoa '{Txttenkhoa.Text}'?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf != DialogResult.Yes) return;

            Khoa? khoa = db.Khoas.FirstOrDefault(k => k.Makhoa.Trim() == ma);
            if (khoa != null) { db.Khoas.Remove(khoa); db.SaveChanges(); }
            LoadDanhSachKhoa(); LamMoiForm();
            MessageBox.Show("Xóa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LamMoiForm()
        {
            Txtmakhoa.Clear();
            Txttenkhoa.Clear();
            Txtmakhoa.Enabled = true; // Cho phép nhập lại mã khi làm mới
            Txtmakhoa.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            Txtmakhoa.Text = dataGridView1.CurrentRow.Cells["MaKhoa"].Value?.ToString();
            Txttenkhoa.Text = dataGridView1.CurrentRow.Cells["TenKhoa"].Value?.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kw = Txttim.Text.Trim().ToLower();
            dataGridView1.DataSource = db.Khoas
                .Where(k => k.Tenkhoa.ToLower().Contains(kw) || k.Makhoa.ToLower().Contains(kw))
                .Select(k => new { k.Makhoa, k.Tenkhoa })
                .ToList();
        }
    }
}
