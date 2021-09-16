using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    //Nơi code các chức năng cho đối tượng Laptop
    class LaptopService
    {
        //Toàn bộ biến toàn cục phải được khai báo trên đầu class và có _
        private List<Laptop> _lstLapTops;
        private Laptop _laptop;
        private string _input;
        public LaptopService()//Contructor là thành phần chạy đầu tiên khi khởi tạo Class
        {
            _lstLapTops = new List<Laptop>
            {
                new Laptop()
                {
                    Id = 1,
                    NXs ="Apple",
                    Ten = "Macbook Pro",
                    GiaTien = 500,
                    SoLuong = 30,
                    TrongLuong = 2.0
                },
                new Laptop()
                {
                    Id = 2,
                    NXs ="Apple",
                    Ten = "Macbook Air",
                    GiaTien = 200,
                    SoLuong = 25,
                    TrongLuong = 1.5
                },
                new Laptop()
                {
                    Id = 2,
                    NXs ="Sony",
                    Ten = "Sony Vaio",
                    GiaTien = 200,
                    SoLuong = 50,
                    TrongLuong = 2.5
                }
            };
           
        }
        //Quản lý 1 đối tượng: CRUD

        #region Phương thêm kiểu học ở C#1 các bạn tham khảo nếu vẫn muốn code cách cũ
        public void addLaptopCsharp1()
        {
            _laptop = new Laptop();
            //Lấy ra khóa id có số lớn nhất + 1
            _laptop.Id = _lstLapTops.Max(c => c.Id) + 1;
            Console.WriteLine("Mời bạn nhập tên: ");
            _laptop.Ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập số lượng: ");
            _laptop.SoLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập nhà sản xuất: ");
            _laptop.NXs = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập trọng lượng: ");
            _laptop.TrongLuong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập giá: ");
            _laptop.GiaTien = Convert.ToDouble(Console.ReadLine());
            //Sau khi fill data vào đối tượng thì phải add đối tượng đó vào List
            _lstLapTops.Add(_laptop);
        }


        #endregion
        //Phương thức thêm laptop kiểu trả về có tham số là 1 obj
        public string addLaptop(Laptop laptop)
        {
            if (laptop!= null)
            {
                _lstLapTops.Add(laptop);
                return "Thêm thành công";
            }
            return "Thêm không thành công";
        }
        public string editLaptop(Laptop laptop)
        {
            if (laptop != null)
            {
                //Bước 1: Tìm đến đối tượng cần sửa và gán lại giá trị mới cho nó
                for (int i = 0; i < _lstLapTops.Count; i++)
                {
                    if (_lstLapTops[i].Id == laptop.Id)
                    {
                        _lstLapTops[i] = laptop;//Gán lại giá trị mới
                    }
                }
                //Cách ngắn hơn dùng LINQ trên 1 dòng code
                //_lstLapTops[_lstLapTops.FindIndex(c => c.Id == laptop.Id)] = laptop;
                return "Sửa thành công";
            }
            return "Sửa không thành công";
        }
        public string removeLaptop(int id)
        {
            _laptop = _lstLapTops.FirstOrDefault(c => c.Id == id);//Tìm đối tượng theo id
            if (_laptop != null)
            {
                _lstLapTops.Remove(_laptop);
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }
        public void findLaptop(string ten,string nsx)//Tìm kiếm gần đúng theo tên hoặc sản xuất
        {
            foreach (var x in _lstLapTops.Where(c=>c.Ten.ToLower().StartsWith(ten.ToLower()) || c.NXs.ToLower().StartsWith(nsx.ToLower())))
            {
                x.inRaManHinh();
            }
        }
        public void getListLaptops()//Lấy full danh sách sản phẩm
        {
            foreach (var x in _lstLapTops)
            {
                x.inRaManHinh();
            }
        }
        public Laptop inputDataLaptop()
        {
            _laptop = new Laptop();
            _laptop.Id = _lstLapTops.Max(c => c.Id) + 1;
            Console.WriteLine("Mời bạn nhập tên: ");
            _laptop.Ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập số lượng: ");
            _laptop.SoLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập nhà sản xuất: ");
            _laptop.NXs = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập trọng lượng: ");
            _laptop.TrongLuong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập giá: ");
            _laptop.GiaTien = Convert.ToDouble(Console.ReadLine());
            return _laptop;
        }
    }
}
