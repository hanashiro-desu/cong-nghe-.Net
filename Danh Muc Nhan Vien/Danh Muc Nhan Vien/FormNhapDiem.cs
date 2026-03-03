using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Danh_Muc_Nhan_Vien
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-CQIPA1K\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";
        SqlDataAdapter da;
        DataTable dtKetQua = new DataTable(); // DataTable chính cho bảng điểm
        DataTable dtSinhvien = new DataTable();
        DataTable dtMaMon = new DataTable();


        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu Sinh Viên nạp vào ComboBox
                SqlDataAdapter daSV = new SqlDataAdapter("SELECT MaSo, HoTen FROM SinhVien", connectionString);
                daSV.Fill(dtSinhvien);
                CBbMaso.DataSource = dtSinhvien;
                CBbMaso.DisplayMember = "MaSo";
                CBbMaso.ValueMember = "MaSo";

                CbbHoTen.DataSource = dtSinhvien;
                CbbHoTen.DisplayMember = "HoTen";

                // 2. Lấy dữ liệu Môn Học nạp vào ComboBox
                SqlDataAdapter daMH = new SqlDataAdapter("SELECT MaMH, TenMH FROM Mon", connectionString);
                daMH.Fill(dtMaMon);
                CbbMaMon.DataSource = dtMaMon;
                CbbMaMon.DisplayMember = "MaMH";
                CbbMaMon.ValueMember = "MaMH";

                CBBTenMon.DataSource = dtMaMon;
                CBBTenMon.DisplayMember = "TenMH";

            }
            catch (Exception ex) { MessageBox.Show("Lỗi load dữ liệu: " + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập số điểm!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Bước 1: Kiểm tra xem sinh viên này đã có điểm môn này chưa
                    string checkSql = "SELECT COUNT(*) FROM KetQua WHERE MaSo = @MaSo AND MaMH = @MaMH";
                    SqlCommand cmdCheck = new SqlCommand(checkSql, conn);
                    cmdCheck.Parameters.AddWithValue("@MaSo", CBbMaso.SelectedValue);
                    cmdCheck.Parameters.AddWithValue("@MaMH", CbbMaMon.SelectedValue);

                    int count = (int)cmdCheck.ExecuteScalar();

                    string finalSql;
                    if (count > 0)
                    {
                        // Bước 2a: Nếu đã có điểm thì CẬP NHẬT (Update)
                        finalSql = "UPDATE KetQua SET Diem = @Diem WHERE MaSo = @MaSo AND MaMH = @MaMH";
                    }
                    else
                    {
                        // Bước 2b: Nếu chưa có điểm thì THÊM MỚI (Insert)
                        finalSql = "INSERT INTO KetQua (MaSo, MaMH, Diem) VALUES (@MaSo, @MaMH, @Diem)";
                    }

                    SqlCommand cmdExec = new SqlCommand(finalSql, conn);
                    cmdExec.Parameters.AddWithValue("@MaSo", CBbMaso.SelectedValue);
                    cmdExec.Parameters.AddWithValue("@MaMH", CbbMaMon.SelectedValue);
                    cmdExec.Parameters.AddWithValue("@Diem", double.Parse(TxtDiem.Text));

                    cmdExec.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật điểm thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập điểm: " + ex.Message);
                }
            }
        }
    }
}
