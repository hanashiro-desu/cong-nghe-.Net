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
    public partial class FormSINHVIEN : Form
    {

        string connectionString = "Server=DESKTOP-CQIPA1K\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";
        SqlDataAdapter da;
        DataTable dtSinhvien = new DataTable();
        DataTable dtKhoa = new DataTable();
        BindingSource bs = new BindingSource();
        public FormSINHVIEN()
        {
            InitializeComponent();
        }

        private void FormSINHVIEN_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Đọc dữ liệu từ SQL
            SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT MaKhoa, TenKhoa FROM Khoa", connectionString);
            daKhoa.Fill(dtKhoa);
            comboBox1.DataSource = dtKhoa;
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "MaKhoa";
                // 2. Gán dữ liệu vào BindingSource (vật trung gian)
                da = new SqlDataAdapter("SELECT * FROM SinhVien", connectionString);

                // QUAN TRỌNG: Dòng này tự động tạo lệnh INSERT, UPDATE, DELETE
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                da.Fill(dtSinhvien);

                // --- BƯỚC 3: Thiết lập BindingSource ---
                bs.DataSource = dtSinhvien;
                dataGridView1.DataSource = bs;

                // --- BƯỚC 4: Binding dữ liệu vào các ô TextBox/Date/Combo ---
                // Xóa binding cũ để tránh lỗi nếu hàm Load chạy lại (ít khi xảy ra nhưng an toàn)
                Txtmasv.DataBindings.Clear();
                Txthoten.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                Txtdiachi.DataBindings.Clear();
                Txtsdt.DataBindings.Clear();
                comboBox1.DataBindings.Clear();
                radioButton1.DataBindings.Clear();

                // Tham số: "Thuộc tính control", nguồn dữ liệu, "Tên cột trong SQL", format, update mode
                Txtmasv.DataBindings.Add("Text", bs, "MaSo", true);
                Txthoten.DataBindings.Add("Text", bs, "HoTen", true);
                dateTimePicker1.DataBindings.Add("Value", bs, "NgaySinh", true);
                Txtdiachi.DataBindings.Add("Text", bs, "DiaChi", true);
                Txtsdt.DataBindings.Add("Text", bs, "DienThoai", true);

                // Binding ComboBox: Khi chọn grid, combo tự nhảy theo MaKhoa
                comboBox1.DataBindings.Add("SelectedValue", bs, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

                // Binding RadioButton:
                // Giả sử cột GioiTinh trong SQL là bit (True=Nam, False=Nữ)
                // Ta chỉ cần bind cho nút Nam, nút Nữ sẽ tự đảo ngược bằng code sự kiện bên dưới
                radioButton1.DataBindings.Add("Checked", bs, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);

                // Logic hiển thị: Khi nút Nam thay đổi, nút Nữ sẽ ngược lại
                radioButton1.CheckedChanged += (s, args) => { radioButton2.Checked = !radioButton1.Checked; };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Focused)
            {
                DataRowView currentView = (DataRowView)bs.Current;
                currentView["GioiTinh"] = radioButton1.Checked;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Focused)
            {
                DataRowView currentView = (DataRowView)bs.Current;
                currentView["GioiTinh"] = !radioButton2.Checked;
            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kết thúc việc chỉnh sửa
                bs.EndEdit();

                // 2. Sử dụng SQLCommandBuilder để tạo update
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                // 3. Cập nhật thay đổi xuống Database
                da.Update(dtSinhvien);
                MessageBox.Show("Đã lưu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi CSDL: " + ex.Message);

                // Nạp lại dữ liệu để xóa các dòng lỗi trên giao diện
                dtSinhvien.Clear();
                da.Fill(dtSinhvien);
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            bs.AddNew();

            // Thiết lập giá trị mặc định cho dòng mới (nếu cần)
            if (bs.Current != null)
            {
                DataRowView currentRow = (DataRowView)bs.Current;
                currentRow["GioiTinh"] = true; // Mặc định là Nam
                currentRow["NgaySinh"] = DateTime.Now;
                // Mặc định chọn khoa đầu tiên
                if (dtKhoa.Rows.Count > 0)
                    currentRow["MaKhoa"] = dtKhoa.Rows[0]["MaKhoa"];
            }

            // Đưa con trỏ về ô nhập liệu đầu tiên
            bs.ResetCurrentItem();
            Txthoten.Focus();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DataRowView currentRow = (DataRowView)bs.Current;
            if (currentRow == null) return;

            string maSV = currentRow["MaSo"].ToString();
            string tenSV = currentRow["HoTen"].ToString();

            DialogResult result = MessageBox.Show($"Xóa sinh viên {tenSV} sẽ xóa toàn bộ điểm liên quan. Bạn có chắc chắn?",
                                                 "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        // 1. Xóa dữ liệu ở bảng con (KetQua) trước bằng SQL thuần
                        string sqlDeleteKetQua = "DELETE FROM KetQua WHERE MaSo = @ma";
                        SqlCommand cmd = new SqlCommand(sqlDeleteKetQua, conn);
                        cmd.Parameters.AddWithValue("@ma", maSV);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Bây giờ mới xóa ở bảng chính (SinhVien) qua BindingSource
                    bs.RemoveCurrent();
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Update(dtSinhvien);

                    MessageBox.Show("Đã xóa sinh viên và các dữ liệu liên quan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    dtSinhvien.Clear();
                    da.Fill(dtSinhvien);
                }
            }
        }
    }
}
