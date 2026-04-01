using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04_LearnhowtouseKeyPreview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = ImageIcons;
            TreeNode goc = treeView1.Nodes.Add("Ký tự đặc biệt");
            goc.ImageIndex = 2; // dựa trên index của image list (bắt đầu từ 0);
            goc.SelectedImageIndex = 2;

            TreeNode nodeCong = goc.Nodes.Add("+");
            TreeNode nodeTru = goc.Nodes.Add("-");
            TreeNode nodeNhan = goc.Nodes.Add("*");
            TreeNode nodeChia = goc.Nodes.Add("/");

            nodeCong.ImageIndex = 4;
            nodeTru.ImageIndex = 4;
            nodeNhan.ImageIndex = 4;
            nodeChia.ImageIndex = 4;

            nodeCong.SelectedImageIndex = 5;
            nodeTru.SelectedImageIndex = 5;
            nodeNhan.SelectedImageIndex = 5;
            nodeChia.SelectedImageIndex = 5;

            TreeNode gockytu = treeView1.Nodes.Add("Ký tự");
            gockytu.ImageIndex = 2;
            gockytu.SelectedImageIndex = 2;

            for (char i = 'a'; i <= 'z'; i++)
            {
                TreeNode kt = gockytu.Nodes.Add(i + "");
                kt.ImageIndex = 4;
                kt.SelectedImageIndex = 5;
            }

            TreeNode gocdayso = treeView1.Nodes.Add("Dãy số");
            gocdayso.ImageIndex = 2;
            gocdayso.SelectedImageIndex = 2;

            for (int i = 0; i <= 9; i++)
            {
                TreeNode kt = gocdayso.Nodes.Add(i.ToString());
                kt.ImageIndex = 4;
                kt.SelectedImageIndex = 5;
            }

        }
    }
}
