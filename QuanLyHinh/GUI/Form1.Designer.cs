namespace QuanLyHinh.GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnNapDanhSach = new ToolStripButton();
            btnXoa = new ToolStripButton();
            tbtnThem = new ToolStripDropDownButton();
            hìnhChữNhậtToolStripMenuItem = new ToolStripMenuItem();
            hìnhTrònToolStripMenuItem = new ToolStripMenuItem();
            grpCN = new GroupBox();
            txtCN_ChieuRong = new TextBox();
            label3 = new Label();
            txtCN_ChieuDai = new TextBox();
            label2 = new Label();
            txtCN_VatLieu = new TextBox();
            label1 = new Label();
            grpTron = new GroupBox();
            txtT_BanKinh = new TextBox();
            label5 = new Label();
            txtT_VatLieu = new TextBox();
            label6 = new Label();
            bsHinh = new BindingSource(components);
            gridHinh = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colVatLieu = new DataGridViewTextBoxColumn();
            colThongTin = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolStrip1.SuspendLayout();
            grpCN.SuspendLayout();
            grpTron.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsHinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridHinh).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNapDanhSach, btnXoa, tbtnThem });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1097, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNapDanhSach
            // 
            btnNapDanhSach.Image = (Image)resources.GetObject("btnNapDanhSach.Image");
            btnNapDanhSach.ImageTransparentColor = Color.Magenta;
            btnNapDanhSach.Name = "btnNapDanhSach";
            btnNapDanhSach.Size = new Size(131, 24);
            btnNapDanhSach.Text = "Nạp danh sách";
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(59, 24);
            btnXoa.Text = "Xoá";
            btnXoa.Click += btnXoa_Click;
            // 
            // tbtnThem
            // 
            tbtnThem.DropDownItems.AddRange(new ToolStripItem[] { hìnhChữNhậtToolStripMenuItem, hìnhTrònToolStripMenuItem });
            tbtnThem.Image = (Image)resources.GetObject("tbtnThem.Image");
            tbtnThem.ImageTransparentColor = Color.Magenta;
            tbtnThem.Name = "tbtnThem";
            tbtnThem.Size = new Size(80, 24);
            tbtnThem.Text = "Thêm";
            tbtnThem.ToolTipText = "\r\n";
            // 
            // hìnhChữNhậtToolStripMenuItem
            // 
            hìnhChữNhậtToolStripMenuItem.Name = "hìnhChữNhậtToolStripMenuItem";
            hìnhChữNhậtToolStripMenuItem.Size = new Size(189, 26);
            hìnhChữNhậtToolStripMenuItem.Text = "Hình Chữ Nhật";
            hìnhChữNhậtToolStripMenuItem.Click += hìnhChữNhậtToolStripMenuItem_Click;
            // 
            // hìnhTrònToolStripMenuItem
            // 
            hìnhTrònToolStripMenuItem.Name = "hìnhTrònToolStripMenuItem";
            hìnhTrònToolStripMenuItem.Size = new Size(189, 26);
            hìnhTrònToolStripMenuItem.Text = "Hình Tròn";
            hìnhTrònToolStripMenuItem.Click += hìnhTrònToolStripMenuItem_Click;
            // 
            // grpCN
            // 
            grpCN.Controls.Add(txtCN_ChieuRong);
            grpCN.Controls.Add(label3);
            grpCN.Controls.Add(txtCN_ChieuDai);
            grpCN.Controls.Add(label2);
            grpCN.Controls.Add(txtCN_VatLieu);
            grpCN.Controls.Add(label1);
            grpCN.Location = new Point(42, 47);
            grpCN.Margin = new Padding(3, 4, 3, 4);
            grpCN.Name = "grpCN";
            grpCN.Padding = new Padding(3, 4, 3, 4);
            grpCN.Size = new Size(366, 172);
            grpCN.TabIndex = 3;
            grpCN.TabStop = false;
            grpCN.Text = "Hình chữ nhật";
            // 
            // txtCN_ChieuRong
            // 
            txtCN_ChieuRong.Location = new Point(125, 113);
            txtCN_ChieuRong.Margin = new Padding(3, 4, 3, 4);
            txtCN_ChieuRong.Name = "txtCN_ChieuRong";
            txtCN_ChieuRong.Size = new Size(190, 27);
            txtCN_ChieuRong.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 117);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 0;
            label3.Text = "Chiều rộng:";
            // 
            // txtCN_ChieuDai
            // 
            txtCN_ChieuDai.Location = new Point(125, 75);
            txtCN_ChieuDai.Margin = new Padding(3, 4, 3, 4);
            txtCN_ChieuDai.Name = "txtCN_ChieuDai";
            txtCN_ChieuDai.Size = new Size(190, 27);
            txtCN_ChieuDai.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 79);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "Chiều dài:";
            // 
            // txtCN_VatLieu
            // 
            txtCN_VatLieu.Location = new Point(125, 36);
            txtCN_VatLieu.Margin = new Padding(3, 4, 3, 4);
            txtCN_VatLieu.Name = "txtCN_VatLieu";
            txtCN_VatLieu.Size = new Size(190, 27);
            txtCN_VatLieu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Vật liệu:";
            // 
            // grpTron
            // 
            grpTron.Controls.Add(txtT_BanKinh);
            grpTron.Controls.Add(label5);
            grpTron.Controls.Add(txtT_VatLieu);
            grpTron.Controls.Add(label6);
            grpTron.Location = new Point(42, 47);
            grpTron.Margin = new Padding(3, 4, 3, 4);
            grpTron.Name = "grpTron";
            grpTron.Padding = new Padding(3, 4, 3, 4);
            grpTron.Size = new Size(366, 172);
            grpTron.TabIndex = 3;
            grpTron.TabStop = false;
            grpTron.Text = "Hình tròn";
            // 
            // txtT_BanKinh
            // 
            txtT_BanKinh.Location = new Point(125, 75);
            txtT_BanKinh.Margin = new Padding(3, 4, 3, 4);
            txtT_BanKinh.Name = "txtT_BanKinh";
            txtT_BanKinh.Size = new Size(190, 27);
            txtT_BanKinh.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 79);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 0;
            label5.Text = "Bán kính:";
            // 
            // txtT_VatLieu
            // 
            txtT_VatLieu.Location = new Point(125, 36);
            txtT_VatLieu.Margin = new Padding(3, 4, 3, 4);
            txtT_VatLieu.Name = "txtT_VatLieu";
            txtT_VatLieu.Size = new Size(190, 27);
            txtT_VatLieu.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 40);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "Vật liệu:";
            // 
            // bsHinh
            // 
            bsHinh.CurrentChanged += bsHinh_CurrentChanged;
            // 
            // gridHinh
            // 
            gridHinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHinh.Columns.AddRange(new DataGridViewColumn[] { colID, colVatLieu, colThongTin });
            gridHinh.Location = new Point(24, 244);
            gridHinh.Name = "gridHinh";
            gridHinh.RowHeadersWidth = 51;
            gridHinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridHinh.Size = new Size(1049, 481);
            gridHinh.TabIndex = 4;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "Mã Số";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 200;
            // 
            // colVatLieu
            // 
            colVatLieu.DataPropertyName = "VatLieu";
            colVatLieu.HeaderText = "Vật Liệu";
            colVatLieu.MinimumWidth = 6;
            colVatLieu.Name = "colVatLieu";
            colVatLieu.Width = 200;
            // 
            // colThongTin
            // 
            colThongTin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colThongTin.DataPropertyName = "ThongTinTomTat";
            colThongTin.HeaderText = "Thông Tin";
            colThongTin.MinimumWidth = 6;
            colThongTin.Name = "colThongTin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 749);
            Controls.Add(gridHinh);
            Controls.Add(grpTron);
            Controls.Add(grpCN);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            grpCN.ResumeLayout(false);
            grpCN.PerformLayout();
            grpTron.ResumeLayout(false);
            grpTron.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsHinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridHinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton btnNapDanhSach;
        private ToolStripButton btnXoa;
        private GroupBox grpCN;
        private TextBox txtCN_VatLieu;
        private Label label1;
        private TextBox txtCN_ChieuRong;
        private Label label3;
        private TextBox txtCN_ChieuDai;
        private Label label2;
        private GroupBox grpTron;
        private TextBox txtT_BanKinh;
        private Label label5;
        private TextBox txtT_VatLieu;
        private Label label6;
        private BindingSource bsHinh;
        private DataGridView gridHinh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colVatLieu;
        private DataGridViewTextBoxColumn colThongTin;
        private ToolStripDropDownButton tbtnThem;
        private ToolStripMenuItem hìnhChữNhậtToolStripMenuItem;
        private ToolStripMenuItem hìnhTrònToolStripMenuItem;
    }
}
