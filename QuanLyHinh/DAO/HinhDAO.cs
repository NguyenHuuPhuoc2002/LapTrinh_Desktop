using QuanLyHinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinh.DAO
{
    public class HinhDAO
    {
        private String FilePath { get; set; }

        public HinhDAO(string filepath) { 
            this.FilePath = filepath;
        }

        public List<Hinh> ReadHinhFromFile()
        {
            var hinhList = new List<Hinh>();

            var lines = File.ReadAllLines(this.FilePath);

            foreach (var line in lines)
            {
                // 0   1           2          3              4
                // ID| Loại hình | vật liệu | kích thước 1 | kích thước 2
                var parts = line.Split('|');
                var id = int.Parse(parts[0]);
                var loaiHinh = parts[1].Trim();
                var vatLieu = parts[2].Trim();
                double kichThuoc1 = double.Parse(parts[3]);
                double kichThuoc2 = parts.Length > 4 ? double.Parse(parts[4]) : 0;

                //Hinh hinh = loaiHinh switch
                //{
                //    "T" => new HinhTron { ID = id, VatLieu = vatLieu, BanKinh = kichThuoc1 },
                //    "HCN" => new HinhChuNhat { ID = id, VatLieu = vatLieu, ChieuDai = kichThuoc1, ChieuRong = kichThuoc2 },
                //    _ => null
                //};
                Hinh hinh = null;

                if (loaiHinh == "T")
                {
                    hinh = new HinhTron
                    {
                        ID = id,
                        VatLieu = vatLieu,
                        BanKinh = kichThuoc1
                    };
                }
                else if (loaiHinh == "HCN")
                {
                    hinh = new HinhChuNhat
                    {
                        ID = id,
                        VatLieu = vatLieu,
                        ChieuDai = kichThuoc1,
                        ChieuRong = kichThuoc2
                    };
                }

                if (hinh != null) 
                    hinhList.Add(hinh);
            }

            return hinhList;
        }

        public void SaveHinhToFile(List<Hinh> hinhList)
        {
            using var writer = new StreamWriter(this.FilePath);
            foreach (var hinh in hinhList)
            {
                //string line = hinh switch
                //{
                //    HinhTron h => $"{h.ID}|T|{h.VatLieu}|{h.BanKinh}",
                //    HinhChuNhat h => $"{h.ID}|HCN|{h.VatLieu}|{h.ChieuDai}|{h.ChieuRong}",
                //    _ => ""
                //};
                string line;
                if (hinh is HinhTron)
                {
                    var h = (HinhTron)hinh;
                    line = $"{h.ID}|T|{h.VatLieu}|{h.BanKinh}";
                }
                else
                {
                    var h = (HinhChuNhat)hinh;
                    line = $"{h.ID}|HCN|{h.VatLieu}|{h.ChieuDai}|{h.ChieuRong}";
                }

                writer.WriteLine(line);
            }
        }
    }
}
