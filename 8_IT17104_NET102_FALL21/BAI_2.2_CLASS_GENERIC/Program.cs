using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_2._2_CLASS_GENERIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Ví dụ 1: Sử dụng 1 lớp Generic
             */
            FpolyClassGeneric<int> classGeneric = new FpolyClassGeneric<int>();
            classGeneric.Temp = 5;
            classGeneric.inRaManHinh();
            Console.WriteLine(classGeneric.inRaManHinh());

            /*
             * Ví dụ 2: Triển khai 1 đối tượng có 1 thuộc tính là mảng chưa xác kiểu dữ liệu
             * 1. Khai báo 1 mảng
             * 2. Nhập giá trị
             * 3. In tất cả phần tử trong mảng
             */
            Console.WriteLine("Mời bạn nhập số phần tử: ");
            int size = Convert.ToInt32(Console.ReadLine());
            FpolyGeneric<string> fpolyGenericName = new FpolyGeneric<string>(size);
            for (int i = 0; i < fpolyGenericName.Arrs.Length; i++)
            {
                Console.WriteLine($"Mời bạn nhập vào index [{i}]: ");
                fpolyGenericName.addValueByIndex(i,Console.ReadLine());
            }

            for (int i = 0; i < fpolyGenericName.Arrs.Length; i++)
            {
                Console.WriteLine(fpolyGenericName.getValueByIndex(i));
            }

            

        }
    }
}
