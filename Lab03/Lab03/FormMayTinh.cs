namespace Lab03
{
    public partial class FormMayTinh : Form
    {
        public FormMayTinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            double Tong = n + m;
            txtKetqua.Text = Tong.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            labelN.Text = "";
            labelM.Text = "";
            txtKetqua.Text = "";

        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSon.Text);
            double m = double.Parse(txtSom.Text);
            double Nhan = n * m;
            txtKetqua.Text = Nhan.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSon.Text);
            double m = double.Parse(txtSom.Text);
            if ( m  != 0)
            {
                double Tong = n / m;
                txtKetqua.Text = Tong.ToString();
            }
            else
            {
                txtKetqua.Text = "Khong the chia cho 0!";
            }
        }
    }
}
