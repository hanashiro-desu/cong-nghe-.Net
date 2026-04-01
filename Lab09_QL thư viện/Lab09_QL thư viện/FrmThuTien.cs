using Lab09_QL_thư_viện.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Lab09_QL_thư_viện
{
    public partial class FrmThuTien : Form
    {
        // Khởi tạo DbContext từ dự án BT_ThucHanh
        private QLThuVienContext db = new QLThuVienContext();
        public FrmThuTien()
        {
            InitializeComponent();
        }
        private void LoadDocGia()
        {
            var ds = db.Docgia
                .Where(d => d.TienNo > 0)
                .Select(d => new
                {
                    d.MaDocGia,
                    HienThi = d.HoTenDocGia + " - Nợ: " + d.TienNo.ToString("N0") + " VNĐ",
                    d.TienNo
                })
                .AsNoTracking()
                .ToList();

            Cboxhoten.DataSource = null;
            Cboxhoten.DataSource = ds;
            Cboxhoten.DisplayMember = "HienThi";
            Cboxhoten.ValueMember = "MaDocGia";
            Cboxhoten.SelectedIndex = -1;
        }

        private void LoadNhanVien()
        {
            var ds = db.Nhanviens
                .Select(n => new
                {
                    n.MaNhanVien,
                    n.HoTenNhanVien
                })
                .AsNoTracking()
                .ToList();

            cbbnhanvien.DataSource = ds;
            cbbnhanvien.DisplayMember = "HoTenNhanVien";
            cbbnhanvien.ValueMember = "MaNhanVien";
        }
        private void FormQLBC_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            LoadNhanVien();

            numbricstt.Minimum = 0;
            numbricstt.ThousandsSeparator = true;
        }
        private void LamMoi()
        {
            Cboxhoten.SelectedIndex = -1;
            cbbnhanvien.SelectedIndex = -1;
            numbricstt.Value = 0;
            lbltienno.Text = "0 VNĐ";
        }
        private void Btt_save_Click(object sender, EventArgs e)
        {
            if (Cboxhoten.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn độc giả!");
                return;
            }

            if (cbbnhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }
            int maDocGia = (int)Cboxhoten.SelectedValue;
            int maNv = (int)cbbnhanvien.SelectedValue;
            decimal soTienThu = numbricstt.Value;

            var dg = db.Docgia.Find(maDocGia);
            if (dg == null) return;

            decimal tienNo = Convert.ToDecimal(dg.TienNo);

            // kiểm tra
            if (soTienThu > tienNo)
            {
                MessageBox.Show("Số tiền thu không được vượt quá tiền nợ!");
                return;
            }

            // tạo phiếu
            Phieuthutien pt = new Phieuthutien
            {
                MaDocGia = maDocGia,
                MaNhanVien = maNv,
                SoTienNo = dg.TienNo,
                SoTienThu = (double)soTienThu
            };

            db.Phieuthutiens.Add(pt);

            // cập nhật nợ
            dg.TienNo = (double)(tienNo - soTienThu);

            db.SaveChanges();

            MessageBox.Show("Lập phiếu thu thành công!");

            LamMoi();
            LoadDocGia(); // reload lại danh sách nợ
        }

        private void load_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDocGia();
        }

        private void Cboxhoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cboxhoten.SelectedIndex == -1)
            {
                lbltienno.Text = "0 VNĐ";
                return;
            }

            // Lấy dữ liệu từ ComboBox
            dynamic dg = Cboxhoten.SelectedItem;

            decimal tienNo = Convert.ToDecimal(dg.TienNo);

            // Hiển thị format N0 + VNĐ
            lbltienno.Text = tienNo.ToString("N0") + " VNĐ";

            // Giới hạn số tiền thu
            numbricstt.Maximum = tienNo;
            numbricstt.Value = 0;
        }
    }
}