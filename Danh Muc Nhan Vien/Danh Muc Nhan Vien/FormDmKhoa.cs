using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Danh_Muc_Nhan_Vien
{
    public partial class FormDmKhoa : Form
    {
        string connectionString = "Server=DESKTOP-CQIPA1K\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";
        SqlDataAdapter da;
        DataTable dtKhoa = new DataTable();
        BindingSource bs = new BindingSource();
        bool isAdding = false;

        public FormDmKhoa()
        {
            InitializeComponent();
        }

        private void FormDmKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
            // Thiết lập DataGridView hiển thị đẹp hơn
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true; // Không cho sửa trực tiếp trên lưới

            // Ban đầu khóa MaKhoa vì đang ở chế độ duyệt/sửa
            Txtmakhoa.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                dtKhoa.Clear();
                da = new SqlDataAdapter("SELECT * FROM Khoa", connectionString);
                da.Fill(dtKhoa);
                bs.DataSource = dtKhoa;
                dataGridView1.DataSource = bs;

                // Binding
                Txtmakhoa.DataBindings.Clear();
                Txttenkhoa.DataBindings.Clear();
                Txtmakhoa.DataBindings.Add("Text", bs, "MaKhoa", true);
                Txttenkhoa.DataBindings.Add("Text", bs, "TenKhoa", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            isAdding = true;
            bs.AddNew();
            Txtmakhoa.ReadOnly = false; // Mở khóa để nhập mã mới
            Txtmakhoa.Focus();
        }

        private void luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu trống
                if (string.IsNullOrWhiteSpace(Txtmakhoa.Text) || string.IsNullOrWhiteSpace(Txttenkhoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã Khoa và Tên Khoa!");
                    return;
                }

                bs.EndEdit();
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Update(dtKhoa);

                MessageBox.Show("Đã lưu thành công!");

                // Sau khi lưu xong, quay lại chế độ đọc
                isAdding = false;
                Txtmakhoa.ReadOnly = true;
            }
            catch (Exception ex)
            {
                // Nếu lỗi do trùng mã (Primary Key) hoặc vấn đề khác
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                LoadData(); // Nạp lại dữ liệu để hủy dòng lỗi
                isAdding = false;
                Txtmakhoa.ReadOnly = true;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (bs.Current == null) return;

            // Lấy mã khoa từ dòng hiện tại của BindingSource thay vì lấy từ TextBox 
            // để đảm bảo chính xác dữ liệu dưới DB
            DataRowView currentRS = (DataRowView)bs.Current;
            string makhoa = currentRS["MaKhoa"].ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa khoa {makhoa}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        // Kiểm tra sinh viên
                        string checkSql = "SELECT COUNT(*) FROM SinhVien WHERE MaKhoa = @ma";
                        using (SqlCommand cmd = new SqlCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ma", makhoa);
                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show($"Không thể xóa! Khoa này đang có {count} sinh viên đang theo học.");
                                return;
                            }
                        }
                    }

                    // Thực hiện xóa
                    bs.RemoveCurrent();
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Update(dtKhoa);
                    MessageBox.Show("Đã xóa khoa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống khi xóa: " + ex.Message);
                    LoadData();
                }
            }
        }
    }
}