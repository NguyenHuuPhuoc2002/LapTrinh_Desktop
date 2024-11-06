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
    public partial class FormHinhTron_BoSung : Form
    {
        public HinhTron HinhTronKetQua { get; private set; }
        public FormHinhTron_BoSung()
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
            double bk = Double.Parse(txt_BanKinh.Text);

            var hcn = new HinhTron();
            hcn.ID = random.Next(10000, 99999);
            hcn.VatLieu = vatLieu;
            hcn.BanKinh = bk;

            this.HinhTronKetQua = hcn;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
