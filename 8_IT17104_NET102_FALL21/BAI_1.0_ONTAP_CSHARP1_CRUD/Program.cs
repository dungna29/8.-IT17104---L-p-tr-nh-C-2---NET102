using System;
using System.Net.Security;
using System.Text;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class Program
    {
        /*
         * Bài ôn tập về Quản Lý Laptop và PC bao gồm các chức năng:
         *      1. CRUD = Thêm sửa xóa đối tượng
         *      2. Tìm kiếm, Sắp xếp đối tượng
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            LaptopService laptopService = new LaptopService();
            while (true)
            {
                Console.WriteLine("Quản lý laptop");
                Console.WriteLine("Quản lý PC");
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. In ds");
                Console.WriteLine("5. Tìm kiếm");
                Console.WriteLine("Mời bạn chọn chức năng");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //laptopService.inputDataLaptop() = 1 đối tượng laptop
                        Laptop laptop = laptopService.inputDataLaptop();
                        Console.WriteLine(laptopService.addLaptop(laptop)); //Thêm đối tượng bằng cách truyền đối tượng vào trong phương thức
                        //Tại sao lại phải in ra cả phương thức vì phương thức thêm là dạng phương thức trả về 1 string.
                        break;
                    case "2":
                        //Bước 1: Tìm ID cần sửa
                        Console.WriteLine("Mời bạn nhập ID");
                        input = Console.ReadLine();
                        //Nên thực hiện kiểm tra ID tồn tại
                        //Bước 2: Fill lại data mới cho đối tượng muốn sửa
                        Laptop laptopCanSua = laptopService.inputDataLaptop();
                        //Sau khi fill xong data phải gán lại cái ID cũ cho đối tượng
                        laptopCanSua.Id = Convert.ToInt32(input);
                        Console.WriteLine(laptopService.editLaptop(laptopCanSua));
                        break;
                    case "3":
                        Console.WriteLine("Mời bạn nhập ID");
                        input = Console.ReadLine();
                        Console.WriteLine(laptopService.removeLaptop(Convert.ToInt32(input)));
                        break;
                    case "4":
                        laptopService.getListLaptops();
                        break;
                    case "5":
                        Console.WriteLine("Mời bạn nhập tên hoặc nsx");
                        input = Console.ReadLine();
                        laptopService.findLaptop(input, input);
                        break;
                }
            }
        }
    }
}
