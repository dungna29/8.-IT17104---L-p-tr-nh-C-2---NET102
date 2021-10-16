using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;

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
            LINQ_Distinct();
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
            List<dynamic> lstString = new List<dynamic>() { 9, "chín", 7, "bẩy" };

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
            var lst1 = _lsSanPhams.OrderBy(c => c.MauSac).ThenBy(c => c.GiaBan);
            var lst2 = _lsSanPhams.OrderBy(c => c.TenSP).ThenByDescending(c => c.GiaNhap);
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
            List<string> lstName = new List<string> { "A", "A", "A", "NHAM", "NHAM", "NAM", "NAM" };
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
                    GiaNhap = g.Sum(c => c.GiaNhap),
                };
            foreach (var x in lstTempSP2)
            {
                Console.WriteLine(x.IdTheLoai + " " + x.GiaNhap);
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
                    Id = g.Count(c => c.MauSac == g.Key.MauSac)
                };
            var lstColorLambda = _lsSanPhams.GroupBy(c => new { c.MauSac }).Select(g => new SanPham()
            { MauSac = g.Key.MauSac, GiaBan = g.Sum(c => c.GiaBan) });
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

        #region 5. Join

        static void LINQ_JOIN()
        {
            //Hiển thị thông tin sản phẩm bao gồm (MÃ, TÊN, MẦU, THỂ LOẠI)
            var lstSP =
                from a in _lsSanPhams //Truy vấn vào 1 mảng
                join b in _lstTheLoais //Inner join
                on a.IdTheLoai equals b.Id// So sánh khóa phụ bảng này với khóa chính bảng kia
                join c in _lstNhanViens
                on a.IdNhanVien equals c.Id
                where a.TrangThai //Chỉ hiển thị những sản phẩm đang hoạt động
                select new //Select ra các cột do lập trình viên tự định nghĩa
                {
                    MaSP = a.MaSP,//a của Sản phẩm
                    TenSP = a.TenSP,
                    MauSac = a.MauSac,
                    TenTheLoai = b.TenTheLoai,//b của bảng thể loại
                    TenNV = c.TenNV

                };


            var lst2 = _lsSanPhams.Where(c => c.TrangThai).Join(_lstTheLoais, a => a.IdTheLoai, b => b.Id, (a, b) => new { a, b }).Join(_lstNhanViens, c => c.a.IdNhanVien, d => d.Id, (c, d) => new
            { c, d }).Select(e => new
            {
                MaSP = e.c.a.MaSP,
                TenSP = e.c.a.TenSP,
                MauSac = e.c.a.MauSac,
                TenTheLoai = e.c.b.TenTheLoai,
                TenNV = e.d.TenNV
            });
            foreach (var x in lst2)
            {
                Console.WriteLine($"{x.MaSP} | {x.TenSP} | {x.MauSac} | {x.TenTheLoai} | {x.TenNV}");
            }

        }


        #endregion

        #region 6. Select

        static void LINQ_SELECT()
        {
            List<NhanVien> lst=
                (from a in _lstNhanViens
                where a.TenNV.Length < 4
                select a).ToList(); //1 tập đối tượng

            var lst1=
                (from a in _lstNhanViens
                where a.TenNV.Length < 4
                select a).ToList();//Trả ra 1 tập đối tượng

            var lst2 =
                from a in _lstNhanViens
                where a.TenNV.Length < 4
                select a.TenNV;//Trả ra 1 tập Tên Nhân Viên
            var lst3 =
                (from a in _lstNhanViens
                where a.TenNV.Length < 4
                select a).FirstOrDefault();//Trả ra 1 đối tượng

            foreach (var x in _lstNhanViens.Select(c=>c.TenNV))
            {
                //Có thể in ra 1 tập List String tên nhan viên
                Console.WriteLine(x);
            }

            Console.WriteLine("======");
            foreach (var x in _lstNhanViens.SelectMany(c => c.Sdt))
            {
                //Có thể in ra 1 tập List String tên nhan viên
                Console.WriteLine(x);
            }

            var temp1 = _lstNhanViens.Select(c => c.TenNV);
            var temp2 = _lstNhanViens.SelectMany(c => c.TenNV);

        }


        #endregion

        #region 7. ALL/ANY

        static void LINQ_ALL_ANY()
        {
            //All: Kiểm tra xem tất cả các phần tử trong dãy có thỏa mãn thì trả ra true
            //Any: Kiểm tra xem tất cả các phần tử trong dãy chỉ cần có thỏa mãn thì trả ra true
            var temp1 = _lstNhanViens.All(c => c.MaNV == "Dungna29");
            var temp2 = _lsSanPhams.Any(c => c.GiaBan > 100000000);
            Console.WriteLine("ALL = " + temp1);
            Console.WriteLine("Any = " + temp2);

            //Contain kiểm tra cả 1 đối tượng có tồn tại hay ko
            //Tạo ra 1 đối tượng để so sánh
            NhanVien nv1 = new NhanVien()
            {
                Id = 1, MaNV = "Dungna29", TenNV = "Dũng", Email = "dungna219@gmail.com", Sdt = "0912345678",
                DiaChi = null, ThanhPho = "HN", QueQuan = "HN", TrangThai = true
            };
            var temp3 = _lstNhanViens.Contains(nv1, new NhanVien());//So sánh 1 đối tượng có các thuộc tính tương đồng.
            foreach (var x in _lstNhanViens)
            {
                if (x.Id == nv1.Id)//Phải chấm so sánh tất cả các thuộc tính bên trong
                {
                    Console.WriteLine("tìm thấy rồi");
                }
            }
            Console.WriteLine("Contains obj = " + temp3);
        }


        #endregion

        #region 8. Hàm Tổng Hợp Arrgreation - SUM - MIN - MAX - COUNT - AVERAGE

        static void LINQ_HAMTONGHOP()
        {
            //Đếm số lượng nhân viên đang ở HN
            var soLuongNVHN = _lstNhanViens.Count(c => c.ThanhPho == "HN");

            //Tính giá trung bình các máy bán ra ở cửa hàng
            var giaTB = _lsSanPhams.Average(c => c.GiaBan);

            //Tìm ra sản phẩm có giá bán lớn nhất ở cửa hàng
            var spMAX = _lsSanPhams.Max(c => c.GiaBan);
           
        }

        #endregion

        #region 9. Firt và FirtOrDefault (Ngoài ra tìm hiểu thêm Last, LastOrDefault, ElementAt,ElementAtOrDefault, Single, SingleOrDefault)

        static void LINQ_FirtOrDefault()
        {
            //Chỉ trả ra 1 giá trị đầu tiên của 1 tập giá trị
            //First: Trả về phần tử đầu tiền của tập giá trị mà thỏa mãn điều kiện
            //FirstOrrDefault Trả về phần tử đầu tiền của tập giá trị mà thỏa mãn điều kiện còn không thì sẽ trả về mặc định là null.
            SanPham sp = new SanPham();
            // sp = _lsSanPhams.Where(c=>c.Id == 11).FirstOrDefault();
            // var temp2 = _lsSanPhams.Where(c => c.Id == 10).First();
            // sp.InRaManHinh();
            // temp2.InRaManHinh();

            List<int> lst = new List<int>() {2, 4,5,7, 6};
            Console.WriteLine(lst.FirstOrDefault(c => c % 2 != 0));// = 0
            Console.WriteLine(lst.First(c=>c % 2 !=0));// = Lỗi

            Console.WriteLine(lst.LastOrDefault(c=>c % 2 !=0));//=7

            List<int> lst1 = new List<int>() { 2, 4, 5,6 };
            Console.WriteLine(lst1.SingleOrDefault(c=>c % 2 !=0));//= 5 Những nếu xuất hiện nhiều hơn 1 số lẻ sẽ chết


            //Console.WriteLine(lst.ElementAt(11));//Chết vì nằm ngoài index
            Console.WriteLine(lst.ElementAtOrDefault(11));//Sẽ lấy ra giá trị mặc định 0
        }
        #endregion

        #region 10. Concat

        static void LINQ_CONCAT()
        {
            /*
             * Concat dùng để nối 2 chuỗi và trả về 1 tập hợp chuỗi mới
             */
            List<string> lstName1 = new List<string>() {"DŨNG", "NHUNG"};
            List<string> lstName2 = new List<string>() {"HÙNG", "HOÀNG"};
            
            var lsttemp = lstName1.Concat(lstName2);
            foreach (var x in lsttemp)
            {
                Console.WriteLine(x);
            }

            //Concat 1 List đối tượng
            List<SanPham> lstSP1 = new List<SanPham>
            {
                new SanPham
                {
                    Id = 111, MaSP = "SP1", TenSP = "Iphone 1", MauSac = "Đen", TrongLuong = 900.5, KickThuoc = 5,
                    GiaNhap = 7000000, GiaBan = 14000000, NgayTao = new DateTime(2021, 12, 5), TrangThai = true,
                    MoTa = null, IdTheLoai = 1, IdNhanVien = 1
                },
                new SanPham
                {
                    Id = 111, MaSP = "SP1", TenSP = "Iphone 1", MauSac = "Đen", TrongLuong = 900.5, KickThuoc = 5,
                    GiaNhap = 7000000, GiaBan = 14000000, NgayTao = new DateTime(2021, 12, 5), TrangThai = true,
                    MoTa = null, IdTheLoai = 1, IdNhanVien = 1
                },
            };
            foreach (var x in _lsSanPhams.Concat(lstSP1))
            {
                x.InRaManHinh();
            }
            var lstID = _lsSanPhams.Select(c => c.Id).Concat(lstSP1.Select(c => c.Id));
        }
        #endregion

        #region Distinct - Trả về 1 tập giá trị không lặp

        static void LINQ_Distinct()
        {
            List<string> lstString = new List<string>() {"A", "A", "A", "B", "B", "C", "D"};
            foreach (var x in lstString.Distinct())
            {
                Console.WriteLine(x);//=A,B,C,D
            }

            foreach (var x in _lstNhanViens.Distinct(new NhanVien()))
            {
                x.InRaManHinh();
            }

            // Except
            List<SanPham> lstSP1 = new List<SanPham>
            {
                new SanPham
                {
                    Id = 111, MaSP = "SP1", TenSP = "Iphone 1", MauSac = "Đen", TrongLuong = 900.5, KickThuoc = 5,
                    GiaNhap = 7000000, GiaBan = 14000000, NgayTao = new DateTime(2021, 12, 5), TrangThai = true,
                    MoTa = null, IdTheLoai = 1, IdNhanVien = 1
                },
                new SanPham
                {
                    Id = 111, MaSP = "SP1", TenSP = "Iphone 1", MauSac = "Đen", TrongLuong = 900.5, KickThuoc = 5,
                    GiaNhap = 7000000, GiaBan = 14000000, NgayTao = new DateTime(2021, 12, 5), TrangThai = true,
                    MoTa = null, IdTheLoai = 1, IdNhanVien = 1
                },
                new SanPham{Id = 2,MaSP = "SP2",TenSP = "Iphone 2",MauSac = "Đỏ",TrongLuong = 1000,KickThuoc = 6,GiaNhap = 8000000,GiaBan = 15000000,NgayTao = new DateTime(2021, 10, 5),TrangThai = true,MoTa = null,IdTheLoai = 1,IdNhanVien = 2},
            };
            var lstSPTem = lstSP1.Except(_lsSanPhams);
            foreach (var x in lstSPTem)
            {
                x.InRaManHinh();
            }
            Console.WriteLine("==============");
            List<string> lstString1 = new List<string>() { "1", "2", "3", "4"};
            List<string> lstString2 = new List<string>() { "4", "5", "6", "7"};
            foreach (var x in lstString1.Except(lstString2))
            {
                Console.WriteLine(x);
            }
        }


        #endregion
    }
}
