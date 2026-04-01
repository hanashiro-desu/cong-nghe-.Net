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
    public partial class FrmDG : Form
    {

        private QLThuVienContext db = new QLThuVienContext();
        public FrmDG()
        {
            InitializeComponent();
        }

        private void FormSINHVIEN_Load(object sender, EventArgs e) => LoadDanhSach();
        private void LoadDanhSach(string keyword = "")
        {
            var query = db.Docgia.AsNoTracking().AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim().ToLower();
                query = query.Where(d => d.HoTenDocGia.ToLower().Contains(kw) ||
                                         d.Email.ToLower().Contains(kw) ||
                                         d.DiaChi.ToLower().Contains(kw));
            }
            var ds = query.Select(d => new
            {
                d.MaDocGia,
                d.HoTenDocGia,
                d.NgaySinh,
                d.DiaChi,
                d.Email,
                d.NgayLapThe,
                d.NgayHetHan,
                d.TienNo
            }).ToList();

            dgvDG.DataSource = ds;

            if (dgvDG.Columns.Count > 0)
            {
                dgvDG.Columns["MaDocGia"].HeaderText = "Mã";
                dgvDG.Columns["HoTenDocGia"].HeaderText = "Họ tên";
                dgvDG.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvDG.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDG.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvDG.Columns["Email"].HeaderText = "Email";
                dgvDG.Columns["NgayLapThe"].HeaderText = "Ngày lập thẻ";
                dgvDG.Columns["NgayLapThe"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDG.Columns["NgayHetHan"].HeaderText = "Ngày hết hạn";
                dgvDG.Columns["NgayHetHan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDG.Columns["TienNo"].HeaderText = "Tiền nợ";
                dgvDG.Columns["TienNo"].DefaultCellStyle.Format = "N0"; // Định dạng số 
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txthovaten.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo");
                return;
            }
            if (dtpngayhethan.Value <= dtpngaylap.Value)
            {
                MessageBox.Show("Ngày hết hạn phải lớn hơn ngày lập thẻ!", "Thông báo");
                return;
            }

            Docgium dg = new Docgium
            {
                HoTenDocGia = Txthovaten.Text.Trim(),
                NgaySinh = dtpdateofbirth.Value,
                DiaChi = Txtdiachi.Text.Trim(),
                Email = Txtemail.Text.Trim(),
                NgayLapThe = dtpngaylap.Value,
                NgayHetHan = dtpngayhethan.Value,
                TienNo = 0
            };

            db.Docgia.Add(dg);
            db.SaveChanges();
            LoadDanhSach();
            LamMoi();
            MessageBox.Show("Thêm độc giả thành công!");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblMaSo.Text, out int maDg))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!", "Thông báo");
                return;
            }
            var dg = db.Docgia.Find(maDg);
            if (dg == null) return;

            // 3. Kiểm tra các ràng buộc trước khi xóa
            // Kiểm tra xem độc giả có đang mượn sách không
            if (db.Phieumuonsaches.Any(p => p.MaDocGia == maDg))
            {
                MessageBox.Show("Không thể xóa! Độc giả này đang có phiếu mượn sách.",
                    "Lỗi vi phạm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra nợ tiền (Sử dụng thuộc tính TienNo trong Database của em)
            if (dg.TienNo > 0)
            {
                MessageBox.Show($"Không thể xóa! Độc giả này còn nợ {dg.TienNo:N0} VNĐ.",
                    "Lỗi tài chính", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Xác nhận xóa
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                db.Docgia.Remove(dg);
                db.SaveChanges();

                // 5. Làm mới giao diện
                LoadDanhSach();
                LamMoi(); // Hàm này để xóa trắng các TextBox và lblMaSo
                MessageBox.Show("Đã xóa độc giả thành công!");
            }
        }
        private void LamMoi()
        {
            lblMaSo.Text = "";
            Txthovaten.Clear();
            Txtdiachi.Clear();
            Txtemail.Clear();
            txttienno.Clear();
            dtpdateofbirth.Value = dtpngayhethan.Value = dtpngaylap.Value = DateTime.Now;
            Txthovaten.Tag = null;
            txttimkiem.Clear();
            Txthovaten.Focus();
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
            if (!int.TryParse(lblMaSo.Text, out int maDg))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa từ danh sách!", "Thông báo");
                return;
            }

            var dg = db.Docgia.Find(maDg);

            if (dg != null)
            {
                // 3. Ràng buộc dữ liệu đầu vào (Validation)
                if (string.IsNullOrWhiteSpace(Txthovaten.Text))
                {
                    MessageBox.Show("Họ tên không được để trống!");
                    return;
                }

                // 4. Gán giá trị mới từ giao diện vào đối tượng
                dg.HoTenDocGia = Txthovaten.Text.Trim();
                dg.NgaySinh = dtpdateofbirth.Value;
                dg.DiaChi = Txtdiachi.Text.Trim();
                dg.Email = Txtemail.Text.Trim();
                dg.NgayLapThe = dtpngaylap.Value;
                dg.NgayHetHan = dtpngayhethan.Value;

                // 5. Lưu và cập nhật giao diện
                db.SaveChanges();
                LoadDanhSach();
                MessageBox.Show("Cập nhật thông tin độc giả thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu độc giả!", "Lỗi");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDG.CurrentRow == null) return;
            DataGridViewRow row = dgvDG.CurrentRow;
            lblMaSo.Text = row.Cells["MaDocGia"].Value?.ToString();
            Txthovaten.Text = row.Cells["HoTenDocGia"].Value?.ToString();
            Txtdiachi.Text = row.Cells["DiaChi"].Value?.ToString();
            Txtemail.Text = row.Cells["Email"].Value?.ToString();
            if (row.Cells["NgaySinh"].Value is DateTime ns) dtpdateofbirth.Value = ns;
            if (row.Cells["NgayLapThe"].Value is DateTime nlt) dtpngaylap.Value = nlt;
            if (row.Cells["NgayHetHan"].Value is DateTime nhh) dtpngayhethan.Value = nhh;
            txttienno.Text = string.Format("{0:N0} VNĐ", row.Cells["TienNo"].Value);
            Txthovaten.Tag = row.Cells["MaDocGia"].Value;
        }

        private void Btt_giahan_Click(object sender, EventArgs e)
        {
            if (Txthovaten.Tag == null) return;
            int maDg = (int)Txthovaten.Tag;
            var dg = db.Docgia.Find(maDg);

            if (dg != null)
            {
                dg.NgayHetHan = dg.NgayHetHan?.AddYears(1);
                db.SaveChanges();
                LoadDanhSach();
                MessageBox.Show("Gia hạn thẻ thành công thêm 1 năm!");
            }
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDanhSach(txttimkiem.Text);
        }
    }
}
