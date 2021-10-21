using System;
using System.Text;

namespace CHUA_DE_THI_THU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            QLLT ql = new QLLT();
            string _input;
            do
            {
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. inDs");
                Console.WriteLine("3. Lưu");
                Console.WriteLine("4. Mở");
                Console.WriteLine("5. Xóa");
                Console.WriteLine("6. Lọc");
                Console.WriteLine("7. Sort");
                Console.WriteLine("8. Thoát");
                Console.WriteLine("Mời chọn: ");
                _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        ql.add();
                        break;
                    case "2":
                        ql.inDs();
                        break;
                    case "3":
                        ql.saveFile();
                        break;
                    case "4":
                        ql.openFile();
                        break;
                    case "5":
                        ql.xoaMaLapTop();
                        break;
                    case "6":
                        ql.locLaptop();
                        break;
                    case "7":
                        ql.sort();
                        break;
                    case "8":
                        return;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
