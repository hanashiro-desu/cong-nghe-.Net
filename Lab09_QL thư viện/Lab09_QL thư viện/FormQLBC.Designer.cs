namespace Lab09_QL_thư_viện
{
    partial class FormQLBC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLBC));
            label1 = new Label();
            label2 = new Label();
            TxtmaBC = new TextBox();
            TxtTenBC = new TextBox();
            dgvQLBC = new DataGridView();
            Bttthem = new Button();
            Bttsua = new Button();
            Bttxoa = new Button();
            Bttluu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQLBC).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(63, 46);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Ma BC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(60, 102);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 1;
            label2.Text = "Ten BC";
            // 
            // TxtmaBC
            // 
            TxtmaBC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtmaBC.ForeColor = Color.SkyBlue;
            TxtmaBC.Location = new Point(146, 45);
            TxtmaBC.Name = "TxtmaBC";
            TxtmaBC.Size = new Size(239, 33);
            TxtmaBC.TabIndex = 3;
            // 
            // TxtTenBC
            // 
            TxtTenBC.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTenBC.ForeColor = Color.SkyBlue;
            TxtTenBC.Location = new Point(146, 102);
            TxtTenBC.Name = "TxtTenBC";
            TxtTenBC.Size = new Size(239, 33);
            TxtTenBC.TabIndex = 4;
            // 
            // dgvQLBC
            // 
            dgvQLBC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLBC.Location = new Point(0, 226);
            dgvQLBC.Name = "dgvQLBC";
            dgvQLBC.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvQLBC.Size = new Size(803, 227);
            dgvQLBC.TabIndex = 6;
            dgvQLBC.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Bttthem
            // 
            Bttthem.BackColor = SystemColors.GradientActiveCaption;
            Bttthem.FlatStyle = FlatStyle.Popup;
            Bttthem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Bttthem.ForeColor = Color.CadetBlue;
            Bttthem.Image = (Image)resources.GetObject("Bttthem.Image");
            Bttthem.Location = new Point(438, 102);
            Bttthem.Name = "Bttthem";
            Bttthem.Size = new Size(53, 37);
            Bttthem.TabIndex = 7;
            Bttthem.Text = "➕ Them";
            Bttthem.TextAlign = ContentAlignment.TopCenter;
            Bttthem.UseVisualStyleBackColor = false;
            Bttthem.Click += them_Click;
            // 
            // Bttsua
            // 
            Bttsua.BackColor = SystemColors.GradientActiveCaption;
            Bttsua.FlatStyle = FlatStyle.Flat;
            Bttsua.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Bttsua.ForeColor = Color.CadetBlue;
            Bttsua.Image = (Image)resources.GetObject("Bttsua.Image");
            Bttsua.Location = new Point(438, 48);
            Bttsua.Name = "Bttsua";
            Bttsua.Size = new Size(53, 35);
            Bttsua.TabIndex = 9;
            Bttsua.Text = "🚚 Luu";
            Bttsua.TextAlign = ContentAlignment.TopCenter;
            Bttsua.UseVisualStyleBackColor = false;
            Bttsua.Click += sua_Click;
            // 
            // Bttxoa
            // 
            Bttxoa.BackColor = SystemColors.GradientActiveCaption;
            Bttxoa.BackgroundImageLayout = ImageLayout.Center;
            Bttxoa.FlatStyle = FlatStyle.Popup;
            Bttxoa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Bttxoa.ForeColor = Color.CadetBlue;
            Bttxoa.Image = (Image)resources.GetObject("Bttxoa.Image");
            Bttxoa.ImageAlign = ContentAlignment.MiddleRight;
            Bttxoa.Location = new Point(525, 48);
            Bttxoa.Name = "Bttxoa";
            Bttxoa.Size = new Size(54, 35);
            Bttxoa.TabIndex = 13;
            Bttxoa.Text = "🗑️";
            Bttxoa.UseVisualStyleBackColor = false;
            Bttxoa.Click += Bttxoa_Click;
            // 
            // Bttluu
            // 
            Bttluu.BackColor = SystemColors.GradientActiveCaption;
            Bttluu.FlatStyle = FlatStyle.Flat;
            Bttluu.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Bttluu.ForeColor = Color.CadetBlue;
            Bttluu.Image = (Image)resources.GetObject("Bttluu.Image");
            Bttluu.ImageAlign = ContentAlignment.MiddleLeft;
            Bttluu.Location = new Point(525, 104);
            Bttluu.Name = "Bttluu";
            Bttluu.Size = new Size(53, 35);
            Bttluu.TabIndex = 14;
            Bttluu.Text = "🔄 ";
            Bttluu.UseVisualStyleBackColor = false;
            Bttluu.Click += Luu_Click;
            // 
            // FormQLBC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Bttluu);
            Controls.Add(Bttxoa);
            Controls.Add(Bttsua);
            Controls.Add(Bttthem);
            Controls.Add(dgvQLBC);
            Controls.Add(TxtTenBC);
            Controls.Add(TxtmaBC);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormQLBC";
            Text = "FormQLBC";
            Load += FormQLBC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLBC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtmaBC;
        private TextBox TxtTenBC;
        private DataGridView dgvQLBC;
        private Button Bttthem;
        private Button Bttsua;
        private Button Bttxoa;
        private Button Bttluu;
    }
}