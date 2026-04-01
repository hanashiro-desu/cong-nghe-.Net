using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Danh_Muc_Nhan_Vien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormSINHVIEN f = new FormSINHVIEN();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FormDmKhoa f = new FormDmKhoa();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            FormMonHoc f = new FormMonHoc();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            FormNhapDiem f = new FormNhapDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            FormXemDiem f = new FormXemDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            // Logic thoát chương trình
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
