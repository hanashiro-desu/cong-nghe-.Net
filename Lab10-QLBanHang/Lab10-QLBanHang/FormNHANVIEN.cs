
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab09_QL_thư_viện
{
    public partial class FormNHANVIEN : Form
    {

        public FormNHANVIEN()
        {
            InitializeComponent();
        }

        private void FormSINHVIEN_Load(object sender, EventArgs e)
        {
            LoadComboBoxBangCap();
            LoadDanhSach();
        }

        private void LoadComboBoxBangCap()
        {
           
        }

        private void LoadDanhSach(string keyword = "")
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void Them_Click(object sender, EventArgs e)
        {
          
        }

        private void Sua_Click(object sender, EventArgs e)
        {

        }

        private void Btt_lammoi_Click(object sender, EventArgs e)
        {
            
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            
        }
        private void LamMoi()
        {
        }

        private void Btt_timkiem_Click(object sender, EventArgs e) => LoadDanhSach(txttimkiem.Text);

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
