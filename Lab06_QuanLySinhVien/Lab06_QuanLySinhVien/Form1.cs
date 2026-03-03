using static System.Net.Mime.MediaTypeNames;

namespace Lab06_QuanLySinhVien
{
    public partial class FrmQLSINHVIEN : Form
    {
        public FrmQLSINHVIEN()
        {
            InitializeComponent();
        }
        bool kiemTraMaSV(string ma)
        {
            for (int i = 0; i < LstVDSSINHVIEN.Items.Count; i++)
            {
                if (LstVDSSINHVIEN.Items[i].SubItems[1].Text == ma)
                {
                    return false;

                }
            }
            for (int i = 0; i < LstVDSdachon.Items.Count; i++)
            {
                if (LstVDSdachon.Items[i].SubItems[1].Text == ma)
                {
                    return false;

                }
            }
            return true;
        }
        private void tim(ListView lv, string text)
        {
            text = text.ToUpper();
            for (int i = 0; i < lv.Items.Count; i++)
            {
                string maSV = lv.Items[i].SubItems[1].Text.ToUpper();
                string hoTen = lv.Items[i].SubItems[2].Text.ToUpper();

                if (maSV.Contains(text) || hoTen.Contains(text))
                {
                    lv.Items[i].Selected = true;
                    lv.Items[i].EnsureVisible();
                    lv.Items[i].Focused = true;
                }
                else
                {
                    lv.Items[i].Selected = false;
                }
            }
        }
        private void thucHienTim()
        {
            tim(LstVDSSINHVIEN, TxtTimKiem.Text);
            TxtTimKiem.SelectAll();
            TxtTimKiem.Focus();
        }
        private void Btt_catnhat_Click(object sender, EventArgs e)
        {
            if (Txtmasv.Text.Trim() == "" || Txthovaten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
            }
            else if (kiemTraMaSV(Txtmasv.Text.Trim()) == false)
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại, vui lòng nhập lại!", "Thông báo");
                Txtmasv.SelectAll();
                Txtmasv.Focus();
            }
            else
            {
                int stt = LstVDSSINHVIEN.Items.Count + 1;

                ListViewItem li = new ListViewItem(stt.ToString());
                li.SubItems.Add(Txtmasv.Text.Trim());
                li.SubItems.Add(Txthovaten.Text.Trim());

                LstVDSSINHVIEN.Items.Add(li);
                Txtmasv.Text = "";
                Txthovaten.Text = "";
                Txtmasv.Focus();
            }
        }

        private void Btt_xoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < LstVDSSINHVIEN.Items.Count)
            {
                if (LstVDSSINHVIEN.Items[i].Selected == true)
                {
                    LstVDSSINHVIEN.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            danhSoThuTu(LstVDSSINHVIEN);
        }
        private void danhSoThuTu(ListView lv)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Text = (i + 1).ToString();
            }
        }

        private void Btt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                ListViewItem li = new ListViewItem(i.ToString());
                li.SubItems.Add("SV" + i);
                li.SubItems.Add("Shiori  " + i);

                LstVDSSINHVIEN.Items.Add(li);
            }

        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            thucHienTim();
        }

        private void TxtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                thucHienTim();
            }
        }

        private void Btt_chon1hs_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < LstVDSSINHVIEN.Items.Count)
            {
                if (LstVDSSINHVIEN.Items[i].Selected == true)
                {
                    ListViewItem li = LstVDSSINHVIEN.Items[i];
                    LstVDSSINHVIEN.Items.RemoveAt(i);
                    LstVDSdachon.Items.Add(li);
                }
                else
                {
                    i++;
                }
            }
            danhSoThuTu(LstVDSSINHVIEN);
        }

        private void Btt_tra1hs_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < LstVDSdachon.Items.Count)
            {
                if (LstVDSdachon.Items[i].Selected == true)
                {
                    ListViewItem li = LstVDSdachon.Items[i];
                    LstVDSdachon.Items.RemoveAt(i);
                    LstVDSSINHVIEN.Items.Add(li);
                }
                else
                {
                    i++;
                }
            }
            danhSoThuTu(LstVDSdachon);
        }

        private void Btt_chontatca_Click(object sender, EventArgs e)
        {
            while (LstVDSSINHVIEN.Items.Count > 0)
            {
                ListViewItem li = LstVDSSINHVIEN.Items[0];
                LstVDSSINHVIEN.Items.RemoveAt(0);
                LstVDSdachon.Items.Add(li);
            }
        }

        private void Btt_tratatca_Click(object sender, EventArgs e)
        {
            while (LstVDSdachon.Items.Count > 0)
            {
                ListViewItem li = LstVDSdachon.Items[0];
                LstVDSdachon.Items.RemoveAt(0);
                LstVDSSINHVIEN.Items.Add(li);
            }
        }
    }
}
