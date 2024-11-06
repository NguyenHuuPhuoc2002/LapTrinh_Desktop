using QuanLyHinh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHinh.GUI
{
    public partial class FormHinhChuNhat_BoSung : Form
    {
        public HinhChuNhat HinhChuNhatKetQua {  get; private set; }
        public FormHinhChuNhat_BoSung()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            String vatLieu = txt_VatLieu.Text;
            double cd = Double.Parse(txt_CD.Text);
            double cr = Double.Parse(txt_CR.Text);

            var hcn = new HinhChuNhat();
            hcn.ID = random.Next(10000, 99999);
            hcn.VatLieu = vatLieu;
            hcn.ChieuDai = cd;
            hcn.ChieuRong = cr;

            this.HinhChuNhatKetQua = hcn;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
