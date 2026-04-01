using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_LearnhowtouseKeyPreview
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Add(txtHoten.Text);
            txtHoten.Text = "";
            txtHoten.Focus();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count;
            for (int i = n - 1; i >= 0; i--)
                lstBandau.Items.Remove(lstBandau.SelectedItems[i]);
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count; 
            for (int i = 0; i <= n - 1; i++)
                lstKetqua.Items.Add(lstBandau.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.RemoveAt(j);
        }

        private void btTatcatraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstKetqua.Items.Add(lstBandau.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.Clear();
        }

        private void btPhaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count;
            for (int i = 0; i < n; i++)
                lstBandau.Items.Add(lstKetqua.SelectedItems[i].ToString());
            for (int i = n - 1; i >= 0; i--)
                lstKetqua.Items.RemoveAt(i);
        }

        private void btTatcaphaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstBandau.Items.Add(lstKetqua.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstKetqua.Items.Clear();
        }

        private void frmSinhvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
