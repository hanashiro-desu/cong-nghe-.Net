using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab03
{
    public partial class FormTinhUocBoi : Form
    {
        public FormTinhUocBoi()
        {
            InitializeComponent();
        }
        private int USCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int tam = b;
                b = a % b;
                a = tam;
            }
            return a;
        }
        private int BSCNN(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            return Math.Abs(a * b) / USCLN(a, b);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btntim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(TxtA.Text);
                int b = int.Parse(TxtB.Text);

                // Kiểm tra RadioButton nào đang được chọn
                if (rdbUSCLN.Checked)
                {
                    TxtKetqua.Text = USCLN(a, b).ToString();
                }
                else if (rdbBSCNN.Checked)
                {
                    TxtKetqua.Text = BSCNN(a, b).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi dữ liệu");
            }
        }

        private void BtnBoqua_Click(object sender, EventArgs e)
        {
            TxtA.Text = "";
            TxtB.Text = "";
            TxtKetqua.Text = "";
            rdbUSCLN.Checked = false;
            rdbBSCNN.Checked = false;
        }

        private void rdbUSCLN_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
