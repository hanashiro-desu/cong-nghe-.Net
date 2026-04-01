using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03
{
    public partial class Form570fx : Form
    {
        double so1 = 0, so2 = 0;
        double kq = 0;
        char pt;
        char error = 'E';
        public Form570fx()
        {
            InitializeComponent();
        }
        private void Btt0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Btt1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Btt2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Btt3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Btt4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Btt5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Btt6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Btt7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Btt8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Btt9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void Btttru_Click(object sender, EventArgs e)
        {
            pt = '-';
            so1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void Bttnhan_Click(object sender, EventArgs e)
        {
            pt = '*';
            so1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void Bttchia_Click(object sender, EventArgs e)
        {
            pt = '/';
            so1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }
        public void Tinh(double n1, double n2, char pt)
        {
            double kq = 0;
            switch (pt)
            {
                case '+':
                    kq = n1 + n2;
                    break;
                case '-':
                    kq = n1 - n2;
                    break;
                case '*':
                    kq = n1 * n2;
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        MessageBox.Show("Không thể thực hiện phép chia cho 0!");
                    }
                    else
                    {
                        kq = n1 / n2;
                    }
                    break;
            }
            textBox1.Text = kq.ToString();
        }
        private void Bttkq_Click(object sender, EventArgs e)
        {
            so2 = double.Parse(textBox1.Text);
            Tinh(so1, so2, pt);
        }
        private void Bttluachon_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(textBox1.Text);
            so1 *= -1;
            textBox1.Text = so1.ToString();
        }

        private void Bttcong_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
