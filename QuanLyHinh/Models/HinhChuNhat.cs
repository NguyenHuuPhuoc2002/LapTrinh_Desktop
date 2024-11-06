using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinh.Models
{
    public class HinhChuNhat : Hinh
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public override double DienTich => ChieuDai * ChieuRong;
        public override double ChuVi => 2 * (ChieuDai + ChieuRong);

        public override string ToString()
        {
            return $"{ThongTinTomTat} Chu vi {ChuVi:F2}";
        }

        public override string ThongTinTomTat => $"Hình chữ nhật ID={ID} {VatLieu} kích thước {ChieuDai:F2}x{ChieuRong:F2}";
    }
}
