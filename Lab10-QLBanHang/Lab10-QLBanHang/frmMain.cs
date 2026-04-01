using Lab10_QLBanHang.Models;
using System;
using System.Windows.Forms;

namespace Lab10_QLBanHang
{ 
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

      
        private void MoFormCon(Form formCon)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formCon.GetType())
                {
                    f.Activate();
                    return;
                }
            }
            formCon.MdiParent = this;
            formCon.Show();
        }

        private void tsbThoat_Click(object sender, EventArgs e) => Thoat();

        private void Thoat()
        {
            var cf = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cf == DialogResult.Yes) Application.Exit();
        }

        private void cascadeXếpChồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void xếpNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void xếpDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsbnhanvien_Click(object sender, EventArgs e)
        {
          

        }

        private void tsbbangcap_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbsach_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbdocgia_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbmuonvatra_Click(object sender, EventArgs e)
        {
           
            
        }

        private void mnu_baocao_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuDongTat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát hệ thống không?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void tsbtra_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbmuon_Click(object sender, EventArgs e)
        {
           
        }
    }
}
