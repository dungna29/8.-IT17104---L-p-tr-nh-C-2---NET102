using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._2_LINQ_CacCauLenh
{
    class SanPham
    {
        public int Id { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MauSac { get; set; }
        public double TrongLuong { get; set; }
        public int KickThuoc { get; set; }
        public double GiaNhap { get; set; }
        public double GiaBan { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public string MoTa { get; set; }
        public int IdTheLoai { get; set; }
        public int IdNhanVien { get; set; }


      

        public void InRaManHinh()
        {
            Console.WriteLine($"{Id} | {MaSP} | {TenSP} | {MauSac} | {TrongLuong} | {KickThuoc} | {GiaNhap} | {GiaBan} | {NgayTao} | {TrangThai} | {MoTa} | {IdTheLoai} | {IdNhanVien}");
        }
    }
}
