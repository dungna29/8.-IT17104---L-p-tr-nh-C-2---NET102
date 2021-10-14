using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._2_LINQ_CacCauLenh
{
    class NhanVien:IEqualityComparer<NhanVien>
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


        public bool Equals(NhanVien x, NhanVien y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Id == y.Id && x.MaNV == y.MaNV && x.TenNV == y.TenNV && x.Email == y.Email && x.Sdt == y.Sdt && x.DiaChi == y.DiaChi && x.QueQuan == y.QueQuan && x.ThanhPho == y.ThanhPho && x.TrangThai == y.TrangThai;
        }

        public int GetHashCode(NhanVien obj)
        {
            var hashCode = new HashCode();
            hashCode.Add(obj.Id);
            hashCode.Add(obj.MaNV);
            hashCode.Add(obj.TenNV);
            hashCode.Add(obj.Email);
            hashCode.Add(obj.Sdt);
            hashCode.Add(obj.DiaChi);
            hashCode.Add(obj.QueQuan);
            hashCode.Add(obj.ThanhPho);
            hashCode.Add(obj.TrangThai);
            return hashCode.ToHashCode();
        }
    }
}
