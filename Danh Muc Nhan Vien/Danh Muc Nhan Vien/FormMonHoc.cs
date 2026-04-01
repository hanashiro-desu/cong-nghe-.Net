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
    public partial class FormMonHoc : Form
    {
        string connectionString = "Server=DESKTOP-CQIPA1K\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";
        SqlDataAdapter da;
        DataTable dtMonHoc = new DataTable();
        BindingSource bs = new BindingSource();
        bool isAdding = false;

        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Nạp dữ liệu trực tiếp 
                // Lưu ý: Đảm bảo bảng trong SQL là 'Mon' hoặc 'MonHoc' cho khớp.
                da = new SqlDataAdapter("SELECT * FROM Mon", connectionString);
                new SqlCommandBuilder(da);

                dtMonHoc.Clear();
                da.Fill(dtMonHoc);
                bs.DataSource = dtMonHoc;
                dataGridView1.DataSource = bs;

                // 2. Tối ưu hiển thị 
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // 3. Việt hóa tiêu đề
                if (dataGridView1.Columns.Count > 0)
                {
                    if (dataGridView1.Columns.Contains("MaMH")) dataGridView1.Columns["MaMH"].HeaderText = "Mã Môn Học";
                    if (dataGridView1.Columns.Contains("TenMH")) dataGridView1.Columns["TenMH"].HeaderText = "Tên Môn Học";
                    if (dataGridView1.Columns.Contains("SoTiet")) dataGridView1.Columns["SoTiet"].HeaderText = "Số Tiết";
                }

                // 4. Binding dữ liệu
                TxtmaKH.DataBindings.Clear();
                TxtTenKH.DataBindings.Clear();
                TxtSoTiet.DataBindings.Clear();

                TxtmaKH.DataBindings.Add("Text", bs, "MaMH", true);
                TxtTenKH.DataBindings.Add("Text", bs, "TenMH", true);
                TxtSoTiet.DataBindings.Add("Text", bs, "SoTiet", true);

                TxtmaKH.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            isAdding = true;
            bs.AddNew();
            TxtmaKH.ReadOnly = false;
            TxtmaKH.Focus();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (bs.Current == null) return;

            DataRowView currentView = (DataRowView)bs.Current;
            string maMH = currentView["MaMH"].ToString();

            if (MessageBox.Show($"Xác nhận xóa môn học {maMH}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // Kiểm tra ràng buộc khóa ngoại 
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sqlCheck = "SELECT COUNT(*) FROM KetQua WHERE MaMH = @ma";
                        SqlCommand cmd = new SqlCommand(sqlCheck, conn);
                        cmd.Parameters.AddWithValue("@ma", maMH);

                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Không thể xóa! Môn học này đã có điểm trong bảng Kết Quả.", "Lỗi ràng buộc");
                            return;
                        }
                    }

                    bs.RemoveCurrent();
                    new SqlCommandBuilder(da);
                    da.Update(dtMonHoc);
                    MessageBox.Show("Đã xóa môn học thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    // Reset dữ liệu nếu lỗi
                    dtMonHoc.Clear();
                    da.Fill(dtMonHoc);
                }
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {

            this.Validate();
            bs.EndEdit();


            DataRowView current = (DataRowView)bs.Current;
            if (current == null || current["MaMH"] == DBNull.Value || string.IsNullOrWhiteSpace(current["MaMH"].ToString()))
            {
                MessageBox.Show("Mã Môn Học không được để trống!");
                return;
            }

            try
            {
                new SqlCommandBuilder(da);
                da.Update(dtMonHoc);

                MessageBox.Show("Lưu dữ liệu thành công!");
                isAdding = false;
                TxtmaKH.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi CSDL: " + ex.Message);
                dtMonHoc.RejectChanges();
                isAdding = false;
                TxtmaKH.ReadOnly = true;
            }
        }
    }
}