using System;

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
            LaptopService laptopService = new LaptopService();
            // while (true)
            // {
                laptopService.getListLaptops();
                Console.WriteLine("===============================");
                laptopService.removeLaptop(2);
                Console.WriteLine("===============================");
                laptopService.getListLaptops();
            // }
        }
    }
}
