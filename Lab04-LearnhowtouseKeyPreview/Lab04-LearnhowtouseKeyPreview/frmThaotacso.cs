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
    public partial class frmThaotacso : Form
    {
        public frmThaotacso()
        {
            InitializeComponent();
        }
        private int TimSoLeCuoi()
        {
            for (int i = lstKetqua.Items.Count - 1; i >= 0; i--)
            {
                int x = int.Parse(lstKetqua.Items[i].ToString());
                if (x % 2 == 1)
                {
                    return i; 
                }
            }
            return -1; 
        }

        private void txtSonguyen_TextChanged(object sender, EventArgs e)
        {
            Control ctrSonguyen = (Control)sender;
            if (ctrSonguyen.Text.Length > 0)
                if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
                    this.errSonguyen.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
                else
                    this.errSonguyen.Clear();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Add(txtSonguyen.Text);
            txtSonguyen.Clear();
            txtSonguyen.Focus();
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstKetqua.Items.Count; i++)
            {
                int x = int.Parse(lstKetqua.Items[i].ToString()) + 2;
                lstKetqua.Items[i] = x.ToString();
            }
        }

        private void btChonchandau_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetqua.Items[i].ToString();
                    lstKetqua.SelectedItem = s;
                    break; 
                }
            }
        }

        private void btLecuoi_Click(object sender, EventArgs e)
        {
            int vitri = TimSoLeCuoi();

            if (vitri == -1)
            {
                MessageBox.Show(
                    "Danh sách chưa có số lẻ.\nVui lòng nhập thêm số lẻ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtSonguyen.Focus();
            }
            else
            {
                lstKetqua.SelectedIndex = vitri;
            }
        }

        private void btXoaphantudangchon_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; 
            for (int i = n - 1; i >= 0; i--)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[i].ToString());
        }

        private void btXoaphantudau_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Remove(lstKetqua.Items[0].ToString());
        }

        private void btXoaphantucuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            lstKetqua.Items.Remove(lstKetqua.Items[n - 1].ToString());
        }

        private void frmThaotacso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }


        private void txtSonguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSonguyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCapnhat_Click(sender, e);
            }
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
