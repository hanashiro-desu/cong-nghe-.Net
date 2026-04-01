using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab03
{
    public partial class FormBT03_SecurityPanel : Form
    {
        public FormBT03_SecurityPanel()
        {
            InitializeComponent();
        }

        private void Bttenter_Click(object sender, EventArgs e)
        {
            string code = TxtSecurityCode.Text;
            string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string message;

            switch (code)
            {
                case "1645":
                case "1689":
                    message = time + " Technician";
                    break;

                case "8345":
                    message = time + " Custodian";
                    break;

                case "9998":
                case "1006":
                case "1008":
                    message = time + " Scientist";
                    break;

                default:
                    message = time + " Restricted Access!";
                    break;
            }

            lbxAccessLog.Items.Add(message);
            SaveFile(message);
            TxtSecurityCode.Clear();
        }

        private void BttC_Click(object sender, EventArgs e)
        {
            TxtSecurityCode.Clear();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TxtSecurityCode.Text += btn.Text;
        }

        private void FormBT03_SecurityPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu là phím số 0–9
            if (char.IsDigit(e.KeyChar))
            {
                TxtSecurityCode.Text += e.KeyChar;
            }
            // Nếu nhấn #
            else if (e.KeyChar == '#')
            {
                Bttenter.PerformClick();
            }
            // Nếu nhấn C hoặc c
            else if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                BttC.PerformClick();
            }
        }
        public void SaveFile(string message)
        {
            try
            {
                string path = "D:\\HOC TAP\\Lab03\\logintime.txt";

                // Mở file ở chế độ ghi tiếp (Append)
                FileStream output = new FileStream(path, FileMode.Append, FileAccess.Write);

                StreamWriter writer = new StreamWriter(output);

                writer.WriteLine(message);

                writer.Close();
                output.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
