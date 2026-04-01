using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Danh_Muc_Nhan_Vien
{
    public partial class FormXemDiem : Form
    {
        public FormXemDiem()
        {
            InitializeComponent();
        }
        string connectionString = "Server=DESKTOP-CQIPA1K\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";
        SqlDataAdapter da;
        DataTable dtSinhvien = new DataTable();
        DataTable dtKhoa = new DataTable();
        BindingSource bs = new BindingSource();

        private void FormXemDiem_Load(object sender, EventArgs e)
        {
            try
            {
                // Truy vấn lấy cả MaSo, HoTen và TenKhoa
                string sqlSV = "SELECT MaSo, HoTen, TenKhoa FROM SinhVien, Khoa WHERE SinhVien.MaKhoa = Khoa.MaKhoa";
                SqlDataAdapter daSV = new SqlDataAdapter(sqlSV, connectionString);
                daSV.Fill(dtSinhvien);

                // Binding cho ComboBox Mã Số
                CBBMaSV.DataSource = dtSinhvien;
                CBBMaSV.DisplayMember = "MaSo";
                CBBMaSV.ValueMember = "MaSo";

                // Binding cho ComboBox Họ Tên (nếu bạn muốn hiện cả tên)
                CBBTenSV.DataSource = dtSinhvien;
                CBBTenSV.DisplayMember = "HoTen";

                // Binding cho TextBox Khoa (Tự động hiển thị khoa khi chọn SV)
                TxtKhoa.DataBindings.Add("Text", dtSinhvien, "TenKhoa");

                // Cấu hình lưới hiển thị điểm
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void BttXem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã số từ ComboBox đã chọn
                string maso = CBBMaSV.Text;

                // Truy vấn kết hợp bảng KetQua và Mon để lấy TenMH
                string sqlDiem = string.Format(
                    "SELECT Mon.TenMH as [Tên Môn Học], KetQua.Diem as [Điểm Số] " +
                    "FROM KetQua INNER JOIN Mon ON KetQua.MaMH = Mon.MaMH " +
                    "WHERE KetQua.MaSo = '{0}'", maso);

                SqlDataAdapter da = new SqlDataAdapter(sqlDiem, connectionString);
                DataTable dtDiem = new DataTable();
                da.Fill(dtDiem);

                // Hiển thị lên lưới
                dataGridView1.DataSource = dtDiem;

                if (dtDiem.Rows.Count == 0)
                    MessageBox.Show("Sinh viên này chưa có cột điểm nào.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn điểm: " + ex.Message);
            }
        }
    }
}
