namespace QuanLyHinh.GUI
{
    partial class FormHinhTron_BoSung
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
            grpTron = new GroupBox();
            txt_BanKinh = new TextBox();
            label5 = new Label();
            txt_VatLieu = new TextBox();
            label6 = new Label();
            btnDongY = new Button();
            btnHuy = new Button();
            grpTron.SuspendLayout();
            SuspendLayout();
            // 
            // grpTron
            // 
            grpTron.Controls.Add(txt_BanKinh);
            grpTron.Controls.Add(label5);
            grpTron.Controls.Add(txt_VatLieu);
            grpTron.Controls.Add(label6);
            grpTron.Location = new Point(42, 52);
            grpTron.Margin = new Padding(3, 4, 3, 4);
            grpTron.Name = "grpTron";
            grpTron.Padding = new Padding(3, 4, 3, 4);
            grpTron.Size = new Size(366, 172);
            grpTron.TabIndex = 4;
            grpTron.TabStop = false;
            grpTron.Text = "Hình tròn";
            // 
            // txt_BanKinh
            // 
            txt_BanKinh.Location = new Point(125, 75);
            txt_BanKinh.Margin = new Padding(3, 4, 3, 4);
            txt_BanKinh.Name = "txt_BanKinh";
            txt_BanKinh.Size = new Size(190, 27);
            txt_BanKinh.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 80);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 0;
            label5.Text = "Bán kính:";
            // 
            // txt_VatLieu
            // 
            txt_VatLieu.Location = new Point(125, 36);
            txt_VatLieu.Margin = new Padding(3, 4, 3, 4);
            txt_VatLieu.Name = "txt_VatLieu";
            txt_VatLieu.Size = new Size(190, 27);
            txt_VatLieu.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 41);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "Vật liệu:";
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(109, 245);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(94, 29);
            btnDongY.TabIndex = 5;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(229, 245);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormHinhTron_BoSung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 318);
            Controls.Add(btnHuy);
            Controls.Add(btnDongY);
            Controls.Add(grpTron);
            Name = "FormHinhTron_BoSung";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormHinhTron_BoSung";
            grpTron.ResumeLayout(false);
            grpTron.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTron;
        private TextBox txt_BanKinh;
        private Label label5;
        private TextBox txt_VatLieu;
        private Label label6;
        private Button btnDongY;
        private Button btnHuy;
    }
}