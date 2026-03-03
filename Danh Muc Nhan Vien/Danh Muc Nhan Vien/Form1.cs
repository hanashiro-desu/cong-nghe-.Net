namespace Danh_Muc_Nhan_Vien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "Tiara Basori ".ToString();
            item.SubItems.Add("23/12/2008");
            item.SubItems.Add("10012334 Yamasashi ".ToString());
            item.SubItems.Add("083123456789".ToString());
            LstTTC.Items.Add(item);
            ListViewItem item1 = new ListViewItem();
            item1.Text = "Kagamihara Nadeshiko ".ToString();
            item1.SubItems.Add("04/03/2006");
            item1.SubItems.Add("1001223 Shizouka ".ToString());
            item1.SubItems.Add("08312344787".ToString());
            LstTTC.Items.Add(item1);
            ListViewItem item2 = new ListViewItem();
            item2.Text = "Shima Rin".ToString();
            item2.SubItems.Add("01/10/2006");
            item2.SubItems.Add("1001111 Shizouka".ToString());
            item2.SubItems.Add("08328484956".ToString());
            LstTTC.Items.Add(item2);
            ListViewItem item3 = new ListViewItem();
            item3.Text = "Kirisaki Chitoge ".ToString();
            item3.SubItems.Add("07/06/1999");
            item3.SubItems.Add("1001112 Tokyo ".ToString());
            item3.SubItems.Add("08328848857".ToString());
            LstTTC.Items.Add(item3);
            ListViewItem item4 = new ListViewItem();
            item4.Text = "Kaoruko Waguri ".ToString();
            item4.SubItems.Add("22/07/2004");
            item4.SubItems.Add("1001245 Shibuya ".ToString());
            item4.SubItems.Add("08328848678".ToString());
            LstTTC.Items.Add(item4);
        }
        private void chonMotDong(object sender, EventArgs e)
        {
            if (LstTTC.SelectedItems.Count > 0)
            {
                try
                {
                    Txt_HoTen.Text = LstTTC.SelectedItems[0].SubItems[0].Text;
                    string ngayStr = LstTTC.SelectedItems[0].SubItems[1].Text;

                    // Parse v?i Culture c? ??nh
                    System.Globalization.CultureInfo cultureInfo =
                        new System.Globalization.CultureInfo("en-US");

                    if (DateTime.TryParseExact(ngayStr, "dd/MM/yyyy", cultureInfo,
                        System.Globalization.DateTimeStyles.None, out DateTime ngaySinh))

                        TbNgaySinh.Value = ngaySinh;
                    else
                    {
                        MessageBox.Show("??nh d?ng ngày không h?p l?: " + ngayStr);
                    }

                    Txt_Diachi.Text = LstTTC.SelectedItems[0].SubItems[2].Text;
                    Txt_DT.Text = LstTTC.SelectedItems[0].SubItems[3].Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("L?i: " + ex.Message);
                }
            }
        }

        private void Btt_Them_Click(object sender, EventArgs e)
        {
            if (Txt_HoTen.Text.Trim().Length > 0)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Txt_HoTen.Text; // Gán c?t ??u tiên là H? Tên

                // Thêm các thông tin ph? vào các c?t ti?p theo
                item.SubItems.Add(TbNgaySinh.Value.ToShortDateString());
                item.SubItems.Add(Txt_Diachi.Text);
                item.SubItems.Add(Txt_DT.Text);

                // ??a dòng v?a t?o vào ListView
                LstTTC.Items.Add(item);
            }
            else
            {
                // Hi?n th? thông báo n?u ?? tr?ng tên
                MessageBox.Show("Vui lòng nh?p h? và tên tr??c khi thêm");
            }
        }

        private void Btt_X_Click(object sender, EventArgs e)
        {
            // Ki?m tra n?u có dòng ?ang ???c ch?n trong ListView
            if (LstTTC.SelectedItems.Count > 0)
            {
                // Hi?n th? dialog xác nh?n
                DialogResult result = MessageBox.Show(
                    "B?n có ch?c ch?n mu?n xóa nhân viên này?",
                    "Xác nh?n xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // N?u ng??i dùng nh?n "Yes" m?i xóa
                if (result == DialogResult.Yes)
                {
                    // Xóa dòng ?ang ch?n kh?i ListView
                    LstTTC.Items.Remove(LstTTC.SelectedItems[0]);

                    // Xóa d? li?u trên form (reset các ô nh?p li?u)
                    Txt_HoTen.Text = "";
                    TbNgaySinh.Value = DateTime.Now;
                    Txt_Diachi.Text = "";
                    Txt_DT.Text = "";
                }
            }
            else
            {
                // Thông báo n?u ng??i dùng ch?a ch?n dòng nào ?? xóa
                MessageBox.Show("Vui lòng ch?n m?t nhân viên ?? xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btt_Sua_Click(object sender, EventArgs e)
        {
            if (LstTTC.SelectedItems.Count > 0)
            {
                LstTTC.SelectedItems[0].SubItems[0].Text = Txt_HoTen.Text;
                LstTTC.SelectedItems[0].SubItems[1].Text = TbNgaySinh.Value.ToString("dd/MM/yyyy");
                LstTTC.SelectedItems[0].SubItems[2].Text = Txt_Diachi.Text;
                LstTTC.SelectedItems[0].SubItems[3].Text = Txt_DT.Text;
            }
        }

        private void Btt_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "B?n có ch?c ch?n mu?n thoát ?ng d?ng?",
            "Xác nh?n thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2  // M?c ??nh ch?n "No"
        );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
