namespace QuanLyHinh.GUI
{
    partial class FormHinhChuNhat_BoSung
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
            grbAddHCN = new GroupBox();
            label8 = new Label();
            txt_CR = new TextBox();
            txt_CD = new TextBox();
            label11 = new Label();
            txt_VatLieu = new TextBox();
            label12 = new Label();
            btnDongY = new Button();
            btnHuy = new Button();
            grbAddHCN.SuspendLayout();
            SuspendLayout();
            // 
            // grbAddHCN
            // 
            grbAddHCN.Controls.Add(label8);
            grbAddHCN.Controls.Add(txt_CR);
            grbAddHCN.Controls.Add(txt_CD);
            grbAddHCN.Controls.Add(label11);
            grbAddHCN.Controls.Add(txt_VatLieu);
            grbAddHCN.Controls.Add(label12);
            grbAddHCN.Location = new Point(40, 55);
            grbAddHCN.Margin = new Padding(3, 4, 3, 4);
            grbAddHCN.Name = "grbAddHCN";
            grbAddHCN.Padding = new Padding(3, 4, 3, 4);
            grbAddHCN.Size = new Size(366, 172);
            grbAddHCN.TabIndex = 5;
            grbAddHCN.TabStop = false;
            grbAddHCN.Text = "Hình chữ nhật";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 114);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 2;
            label8.Text = "Chiều rộng:";
            // 
            // txt_CR
            // 
            txt_CR.Location = new Point(125, 113);
            txt_CR.Margin = new Padding(3, 4, 3, 4);
            txt_CR.Name = "txt_CR";
            txt_CR.Size = new Size(190, 27);
            txt_CR.TabIndex = 1;
            // 
            // txt_CD
            // 
            txt_CD.Location = new Point(125, 75);
            txt_CD.Margin = new Padding(3, 4, 3, 4);
            txt_CD.Name = "txt_CD";
            txt_CD.Size = new Size(190, 27);
            txt_CD.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 81);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 0;
            label11.Text = "Chiều dài:";
            // 
            // txt_VatLieu
            // 
            txt_VatLieu.Location = new Point(125, 36);
            txt_VatLieu.Margin = new Padding(3, 4, 3, 4);
            txt_VatLieu.Name = "txt_VatLieu";
            txt_VatLieu.Size = new Size(190, 27);
            txt_VatLieu.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 42);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 0;
            label12.Text = "Vật liệu:";
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(111, 265);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(94, 29);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(231, 265);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormHinhChuNhat_BoSung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 342);
            Controls.Add(btnHuy);
            Controls.Add(btnDongY);
            Controls.Add(grbAddHCN);
            Name = "FormHinhChuNhat_BoSung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHinhChuNhat_BoSung";
            grbAddHCN.ResumeLayout(false);
            grbAddHCN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbAddHCN;
        private Label label8;
        private TextBox txt_CR;
        private TextBox txt_CD;
        private Label label11;
        private TextBox txt_VatLieu;
        private Label label12;
        private Button btnDongY;
        private Button btnHuy;
    }
}