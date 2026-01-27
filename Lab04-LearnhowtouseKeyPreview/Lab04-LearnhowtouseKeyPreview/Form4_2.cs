using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_LearnhowtouseKeyPreview
{
    public partial class Form4_2 : Form
    {
        public Form4_2()
        {
            InitializeComponent();
        }
        private void GetPays()
        {
            // 1. Kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(Txtcustomer.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo");
                return;
            }

            // 2. Tính toán
            double total = 0;
            if (CheckB_Caovoi.Checked) total += 100000;
            if (CheckB_Taytrang.Checked) total += 1200000;
            if (CheckB_ChupH.Checked) total += 200000;

            total += ((int)numericUpFilling.Value * 80000);

            TxtTotal.Text = total.ToString("C0", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

        private void Btt_C_Click(object sender, EventArgs e)
        {
            GetPays();
        }

        private void Btt_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btt_themds_Click(object sender, EventArgs e)
        {
            string info = Txtcustomer.Text + " - " + TxtTotal.Text;
            LstBcustomer.Items.Add(info);
        }

        private void Btt_xoakhachhang_Click(object sender, EventArgs e)
        {
            if (LstBcustomer.SelectedIndex != -1)
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa khách hàng đã chọn hay không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    // Xóa mục tại vị trí đang chọn
                    LstBcustomer.Items.RemoveAt(LstBcustomer.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách để xóa!", "Thông báo");
            }
        }

        private void Btt_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Chọn nơi lưu danh sách khách hàng";
                saveFileDialog.DefaultExt = "txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                    // Khởi tạo StreamWriter để ghi vào tệp
                    using (StreamWriter writer = new StreamWriter(FileName))
                    {
                        foreach (var item in LstBcustomer.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("Đã lưu danh sách vào tệp thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
            }
        }

        private void Btt_upload_Click(object sender, EventArgs e)
        {
            // Khởi tạo hộp thoại mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Bộ lọc định dạng file 
            openFileDialog.Title = "Chọn tệp dữ liệu khách hàng để tải";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LstBcustomer.Items.Clear(); // Xóa danh sách hiện tại trước khi tải mới [cite: 435]

                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            LstBcustomer.Items.Add(line); // Nạp từng dòng vào ListBox [cite: 435]
                        }
                    }
                    MessageBox.Show("Đã tải dữ liệu từ tệp lên danh sách!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc tệp: " + ex.Message);
                }
            }
        }
    }
}
