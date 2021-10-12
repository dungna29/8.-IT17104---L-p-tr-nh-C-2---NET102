using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace BAI_3._2_LINQ_CacCauLenh
{
    class Program
    {
        private static ServiceAll _sv = new ServiceAll();
        private static List<NhanVien> _lstNhanViens;
        private static List<TheLoai> _lstTheLoais;
        private static List<SanPham> _lsSanPhams;
        public Program()
        {
            _lstNhanViens = _sv.GetListNhanViens();
            _lstTheLoais = _sv.GetListTheLoais();
            _lsSanPhams = _sv.GetListSanPhams();
        }
        static void Main(string[] args)
        {
            //Gọi các ví dụ về lý thuyết lên để chạy
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program program = new Program();//Khi khởi tạo thì các List trên sẽ có giá trị
            LINQ_GROUPBY();
        }

        #region 1. Where điều kiện lọc

        static void LINQ_WHERE()
        {
            //1. Lấy danh sách những người có số điện thoại Viettel 098
            var lstSdt =
                (from a in _lstNhanViens
                 where a.Sdt.StartsWith("098") || a.Sdt.StartsWith("08")
                 select a).ToList();// = List

            var lstsdtLambda = _lstNhanViens.Where(c => c.Sdt.StartsWith("098") || c.Sdt.StartsWith("08"));

            foreach (var x in _lstNhanViens.Where(c => c.Sdt.StartsWith("098") || c.Sdt.StartsWith("08")))
            {
                x.InRaManHinh();
            }
            foreach (var x in lstSdt)
            {
                x.InRaManHinh();
            }
        }


        #endregion

        #region 2. Toán tử OfType để lọc các kiểu dữ liệu

        static void LINQ_OfType()
        {
            List<dynamic> lstString = new List<dynamic>(){9,"chín",7,"bẩy"};

            var lst1 =
                from a in lstString.OfType<string>()
                select a;  
            var lst2 =
                from a in lstString.OfType<int>()
                select a;
            Console.WriteLine("lstString.OfType<string>");
            foreach (var x in lst1)
            {
                Console.WriteLine(x);
            } 
            Console.WriteLine("lstString.OfType<int>");
            foreach (var x in lst2)
            {
                Console.WriteLine(x);
            }

        }

        #endregion

        #region 3. Orderby dùng sắp xếp ngược xuôi và mặc định là ASC theo 1 điều kiện cụ thể

        static void LINQ_Orderby()
        {
            var lstTemp =
                from a in _lsSanPhams
                orderby a.TenSP descending // asc và desc
                select a;
            var lstTemp2 = _lsSanPhams.OrderBy(c => c.GiaBan);
        }

        //ThenBy đi với Orderby giúp mở rộng để sắp xếp thêm nhiều cột hơn cùng lúc
        static void LINQ_ThenBy()
        {
            var lst1 = _lsSanPhams.OrderBy(c => c.MauSac).ThenBy(c=>c.GiaBan);
            var lst2 = _lsSanPhams.OrderBy(c => c.TenSP).ThenByDescending(c=>c.GiaNhap);
            foreach (var x in _lsSanPhams)
            {
                x.InRaManHinh();
            }

            Console.WriteLine("================");
            foreach (var x in lst1)
            {
                x.InRaManHinh();
            }
        }


        #endregion

        #region 4. Group By nhóm các phần giống nhau

        static void LINQ_GROUPBY()
        {
            List<string> lstName = new List<string> { "A","A","A","NHAM","NHAM","NAM","NAM"};
            var temp =
                from a in lstName
                group a by a
                into g
                select g.Key;// Nhóm các String giống nhua
            foreach (var x in temp)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");

            var lstTempSP1 = 
                from a in _lsSanPhams
                group a by a.IdTheLoai
                into g
                select g.Key;

            var lstTempSP2 =
                from a in _lsSanPhams
                group a by new
                {
                    //Nhóm nhiều cột lại
                    a.IdTheLoai,
                    //a.GiaNhap
                } into g
                    select new SanPham()
                    {
                        IdTheLoai = g.Key.IdTheLoai,
                        GiaNhap = g.Sum(c=>c.GiaNhap),
                    };
            foreach (var x in lstTempSP2)
            {
                Console.WriteLine(x.IdTheLoai +" " + x.GiaNhap);
            }
            //Viết tính tổng tiền giá bán của tất cả các điện thoại bởi các mầu khác nhau
            var lstColor =
                from a in _lsSanPhams
                group a by new
                {
                    a.MauSac
                }
                into g
                select new SanPham()
                {
                    MauSac = g.Key.MauSac,
                    GiaBan = g.Sum(c => c.GiaBan),
                    Id = g.Count(c=>c.MauSac ==g.Key.MauSac)
                };
            var lstColorLambda = _lsSanPhams.GroupBy(c => new {c.MauSac}).Select(g => new SanPham()
                {MauSac = g.Key.MauSac, GiaBan = g.Sum(c => c.GiaBan)});
            foreach (var x in lstColor)
            {
                Console.WriteLine(x.MauSac + " = " + x.GiaBan + " = " + x.Id);
            }
            //Khi sử dụng Groupby về bản chất nhóm các bản ghi giống nhau theo các cột được chỉ định và sẽ tạo thành các bản ghi mới.

            var lstColorANONYMOUs =
                from a in _lsSanPhams
                group a by new
                {
                    a.MauSac,
                }
                into g
                select new
                {
                    Mau = g.Key.MauSac,
                    TongGiaBan = g.Sum(c => c.GiaBan),
                    SoLuong = g.Count(c => c.MauSac == g.Key.MauSac)
                };//List nặc danh và tự tạo ra các cột theo đầu bài
            foreach (var x in lstColorANONYMOUs)
            {
                Console.WriteLine(x.Mau + " = " + x.TongGiaBan + " = " + x.SoLuong);
            }

        }


        #endregion
    }
}
