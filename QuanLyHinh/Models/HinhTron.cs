using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinh.Models
{
    public class HinhTron : Hinh
    {
        public double BanKinh { get; set; }

        public override double DienTich => Math.PI * BanKinh * BanKinh;
        public override double ChuVi => 2 * Math.PI * BanKinh;

        public override string ToString()
        {
            return $"{ThongTinTomTat} Chu vi {ChuVi:F2}";
        }

        public override string ThongTinTomTat => $"Hình tròn ID={ID} {VatLieu} Bán kính {BanKinh}";
    }
}
