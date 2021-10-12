using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._2_LINQ_CacCauLenh
{
    class NhanVien
    {
        public int Id { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string QueQuan { get; set; }
        public string ThanhPho { get; set; }
        public bool TrangThai { get; set; }

       
        public void InRaManHinh()
        {
            Console.WriteLine($"{Id} | {MaNV} | {TenNV} | {Email} | {Sdt} | {DiaChi} | {ThanhPho} | {QueQuan} | {TrangThai}");
        }

    }
}
