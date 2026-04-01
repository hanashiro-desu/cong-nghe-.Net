using Lab09_QL_thư_viện.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Lab09_QL_thư_viện
{
    public partial class FormQLBC : Form
    {
        // Khởi tạo DbContext từ dự án BT_ThucHanh
        private QLThuVienContext db = new QLThuVienContext();

        public FormQLBC()
        {
            InitializeComponent();
        }

        // ─── LOAD DANH SÁCH MÔN HỌC ───────────────────────────────────────────
        private void LoadDanhSach(string keyword = "")
        {
            var query = db.Bangcaps.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim().ToLower();
                query = query.Where(b => b.TenBangCap.ToLower().Contains(kw));
            }
            var ds = query.Select(b => new
            {
                b.MaBangCap,
                b.TenBangCap
            }).ToList();

            dgvQLBC.DataSource = ds;

            if (dgvQLBC.Columns.Count > 0)
            {
                dgvQLBC.Columns["MaBangCap"].HeaderText = "Mã bằng cấp";
                dgvQLBC.Columns["TenBangCap"].HeaderText = "Tên bằng cấp";
                dgvQLBC.Columns["TenBangCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTenBC.Text))
            {
                MessageBox.Show("Tên bằng cấp không được để trống!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            db.Bangcaps.Add(new Bangcap
            {
                TenBangCap = TxtTenBC.Text.Trim()
            });

            db.SaveChanges();
            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }


       
        private void LamMoi()
        {
            TxtmaBC.Clear();
            TxtTenBC.Clear();
            TxtTenBC.Tag = null;
            TxtTenBC.Focus();
        }

        private void FormQLBC_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (TxtTenBC.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bằng cấp cần sửa từ danh sách!", "Thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtTenBC.Text))
            {
                MessageBox.Show("Tên bằng cấp không được để trống!", "Thông báo"); // 
                return;
            }

            int maBc = (int)TxtTenBC.Tag;
            var bc = db.Bangcaps.FirstOrDefault(b => b.MaBangCap == maBc);

            if (bc != null)
            {
                bc.TenBangCap = TxtTenBC.Text.Trim();

                db.SaveChanges();
                LoadDanhSach();

                TxtTenBC.Text = "";
                TxtTenBC.Tag = null;

                MessageBox.Show("Cập nhật bằng cấp thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy bằng cấp cần sửa!", "Thông báo");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLBC.CurrentRow == null) return;
            DataGridViewRow row = dgvQLBC.CurrentRow;
            TxtmaBC.Text = row.Cells["MaBangCap"].Value?.ToString();
            TxtTenBC.Text = row.Cells["TenBangCap"].Value?.ToString();
            TxtTenBC.Tag = row.Cells["MaBangCap"].Value;
        }


        private void Luu_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSach();
        }

        private void Bttxoa_Click(object sender, EventArgs e)
        {
            if (TxtTenBC.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bằng cấp cần xóa từ danh sách!", "Thông báo");
                return;
            }

            int maBc = (int)TxtTenBC.Tag;
            bool dangDuocSuDung = db.Nhanviens.Any(nv => nv.MaBangCap == maBc);

            if (dangDuocSuDung)
            {
                MessageBox.Show("Không thể xóa! Bằng cấp này đang có nhân viên sử dụng.",
                    "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa bằng cấp '{TxtTenBC.Text}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {

                    var bc = db.Bangcaps.FirstOrDefault(b => b.MaBangCap == maBc);
                    if (bc != null)
                    {
                        db.Bangcaps.Remove(bc);
                        db.SaveChanges();

                        LoadDanhSach();
                        LamMoi();
                        MessageBox.Show("Xóa bằng cấp thành công!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }
    }
}