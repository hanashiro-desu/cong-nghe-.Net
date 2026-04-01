using Lab10_QLBanHang.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab10_QLBanHang
{
    public partial class FormSANPHAM : Form
    {

        QLBanHangContext db = new QLBanHangContext();
        public FormSANPHAM()
        {
            InitializeComponent();
        }
        private void LoadComboBoxDanhMuc()
        {
            var dsDanhMuc = db.Sanphams
                .AsNoTracking() // ✔ yêu cầu #1
                .Select(x => x.DanhMuc)
                .Distinct()
                .ToList();

            Cbbdanhmuc.Items.Clear();
            Cbbdanhmuc.Items.Add("Tất cả");

            foreach (var dm in dsDanhMuc)
                Cbbdanhmuc.Items.Add(dm);

            Cbbdanhmuc.SelectedIndex = -1;
        }
        private void LoadDanhSach(string keyword = "")
        {

            IQueryable<Sanpham> query = db.Sanphams
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.ToLower();
                query = query.Where(x =>
                    x.TenSp.ToLower().Contains(kw) ||
                    x.DanhMuc.ToLower().Contains(kw));
            }

            var ds = query
                .Select(sp => new
                {
                    sp.MaSp,
                    sp.TenSp,
                    sp.DanhMuc,
                    DonGia = sp.DonGia.ToString(),
                    sp.SoLuongTon,
                    sp.MoTa
                })
                .ToList();

            dgvSANPHAM.DataSource = ds;

            if (dgvSANPHAM.Columns.Count > 0)
            {
                dgvSANPHAM.Columns["MaSp"].HeaderText = "Mã SP";
                dgvSANPHAM.Columns["TenSp"].HeaderText = "Tên sản phẩm";
                dgvSANPHAM.Columns["DanhMuc"].HeaderText = "Danh mục";

                dgvSANPHAM.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvSANPHAM.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvSANPHAM.Columns["SoLuongTon"].HeaderText = "Tồn kho";
                dgvSANPHAM.Columns["MoTa"].HeaderText = "Mô tả";
            }

            // ✔ cảnh báo tồn kho
            foreach (DataGridViewRow row in dgvSANPHAM.Rows)
            {
                if (row.Cells["SoLuongTon"].Value != null &&
                    Convert.ToInt32(row.Cells["SoLuongTon"].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(Txttensanpham.Text))
            {
                MessageBox.Show("Tên sản phẩm không được trống!");
                return false;
            }

            if (!double.TryParse(Txtdongia.Text, out double gia) || gia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                return false;
            }

            if (!int.TryParse(Txtsltontrongkho.Text, out int sl) || sl < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return false;
            }

            return true;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Sanpham sp = new Sanpham
            {
                TenSp = Txttensanpham.Text.Trim(),
                DanhMuc = Cbbdanhmuc.Text.Trim(),
                DonGia = double.Parse(Txtdongia.Text),
                SoLuongTon = int.Parse(Txtsltontrongkho.Text),
                MoTa = Rtbmota.Text.Trim()
            };

            db.Sanphams.Add(sp);
            db.SaveChanges();

            LoadDanhSach();
            LamMoi();

            MessageBox.Show("Thêm sản phẩm thành công!");
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblMaSo.Text, out int maSP))
            {
                MessageBox.Show("Chọn sản phẩm cần sửa!");
                return;
            }

            if (!ValidateInput()) return;

            var sp = db.Sanphams.Find(maSP);

            if (sp != null)
            {
                sp.TenSp = Txttensanpham.Text.Trim();
                sp.DanhMuc = Cbbdanhmuc.Text.Trim();
                sp.DonGia = double.Parse(Txtdongia.Text);
                sp.SoLuongTon = int.Parse(Txtsltontrongkho.Text);
                sp.MoTa = Rtbmota.Text.Trim();

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
            if (!int.TryParse(lblMaSo.Text, out int maSP))
            {
                MessageBox.Show("Chọn sản phẩm cần xóa!");
                return;
            }

            // 
            bool coLienQuan = db.Chitietdhs.Any(x => x.MaSp == maSP);

            if (coLienQuan)
            {
                MessageBox.Show("Không thể xóa! Sản phẩm đã có trong đơn hàng.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?",
                "Xác nhận", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                var sp = db.Sanphams.Find(maSP);

                if (sp != null)
                {
                    db.Sanphams.Remove(sp);
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
            Txttensanpham.Clear();
            Cbbdanhmuc.SelectedIndex = -1;
            Txtdongia.Clear();
            Txtsltontrongkho.Clear();
            Rtbmota.Clear();
            txttimkiem.Clear();
            Txttensanpham.Focus();
        }


        private void FormSANPHAM_Load(object sender, EventArgs e)
        {
            dgvSANPHAM.AutoGenerateColumns = true;
            LoadComboBoxDanhMuc();
            LoadDanhSach();
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadDanhSach(txttimkiem.Text);
                txttimkiem.Clear();
            }
        }

        private void Btt_timkiem_Click(object sender, EventArgs e)
        {
            LoadDanhSach(txttimkiem.Text);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSach(txttimkiem.Text);
        }

        private void Cbbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string danhMuc = Cbbdanhmuc.SelectedItem.ToString();

            IQueryable<Sanpham> query = db.Sanphams
                .AsNoTracking()
                .AsQueryable();

            if (danhMuc != "Tất cả")
            {
                query = query.Where(x => x.DanhMuc == danhMuc);
            }

            var ds = query
                .Select(sp => new
                {
                    sp.MaSp,
                    sp.TenSp,
                    sp.DanhMuc,
                    DonGia = sp.DonGia.ToString(),
                    sp.SoLuongTon,
                    sp.MoTa
                })
                .ToList();

            dgvSANPHAM.DataSource = ds;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSANPHAM.CurrentRow == null) return;

            DataGridViewRow row = dgvSANPHAM.CurrentRow;

            lblMaSo.Text = row.Cells["MaSp"].Value?.ToString();
            Txttensanpham.Text = row.Cells["TenSp"].Value?.ToString();
            Cbbdanhmuc.Text = row.Cells["DanhMuc"].Value?.ToString();
            if (row.Cells["DonGia"].Value != null &&
            double.TryParse(row.Cells["DonGia"].Value.ToString(), out double donGia))
            {
                Txtdongia.Text = donGia.ToString("N0") + " VNĐ";
            }
            Txtsltontrongkho.Text = row.Cells["SoLuongTon"].Value?.ToString();
            Rtbmota.Text = row.Cells["MoTa"].Value?.ToString();
        }
    }
}
