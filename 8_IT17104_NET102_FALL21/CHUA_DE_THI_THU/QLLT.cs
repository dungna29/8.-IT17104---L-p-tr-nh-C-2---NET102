using System;
using System.Collections.Generic;
using System.IO;//phải import thư viện ở đây
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CHUA_DE_THI_THU
{
    class QLLT
    {
        private List<Laptop> _lstLaptops;
        private string _input;
        //Để lưu file đọc file cần 2 thứ
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string part = @"E:\Dungna29 Fpoly\8. Demo\Demo C#2\FALL21_Block1\8.-IT17104---L-p-tr-nh-C-2---NET102\8_IT17104_NET102_FALL21\CHUA_DE_THI_THU\data.bin";
        public QLLT()
        {
            _lstLaptops = new List<Laptop>();//Khởi tạo ngay List
        }

        public void add()
        {
            Console.WriteLine("Mời bạn nhập số lượng: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                var laptop = new Laptop();
                string temp;
                do
                {
                    Console.WriteLine("Mời nhập mã: ");
                    temp = Console.ReadLine();
                    Console.WriteLine(checkSo(temp));
                } while (!checkSo(temp));
                laptop.MaLapTop = Convert.ToInt32(temp);
                do
                {
                    Console.WriteLine("Mời nhập tên: ");
                    temp = Console.ReadLine();
                    Console.WriteLine(checkChu(temp));
                } while (!checkChu(temp));
                laptop.Ten = temp;
                Console.WriteLine("Mời nhập trọng lượng: ");
                laptop.TrongLuong = Convert.ToDouble(Console.ReadLine());
                _lstLaptops.Add(laptop);
            }
        }
        public void inDs()
        {
            foreach (var x in _lstLaptops)
            {
                x.InRaManHinh();
            }
        }

        //Trong trường hợp nhớ ra lưu file và đọc file
        public void saveFile()
        {
            _fs = new FileStream(part, FileMode.Create);
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, _lstLaptops);
            _fs.Close();
            Console.WriteLine("Ghi thành công");
        }
     
        public void openFile()
        {
            _fs = new FileStream(part, FileMode.Open);
            _bf = new BinaryFormatter();
            _lstLaptops = (List<Laptop>)_bf.Deserialize(_fs);//Đọc đối tượng lên và gán

            _fs.Close();
            Console.WriteLine("Mở thành công");
        }
        //Nếu lưu file đọc file khó quá thì chuyển sang làm LINQ
        public void xoaMaLapTop()
        {
            Console.WriteLine("Mời bạn nhập mã: ");
            _input = Console.ReadLine();
            _lstLaptops.RemoveAt(_lstLaptops.FindIndex(c=>c.MaLapTop==Convert.ToInt32(_input)));
        }

        public void locLaptop()
        {
            foreach (var x in _lstLaptops.Where(c=>c.TrongLuong > 50 && c.Ten.StartsWith("A")))
            {
                x.InRaManHinh();
            }
        }

        public void sort()
        {
            //Nếu chỉ sắp xếp không in ra
            _lstLaptops = _lstLaptops.OrderByDescending(c => c.MaLapTop).ToList();

            //Nếu sắp xếp và in ra
            foreach (var x in _lstLaptops.OrderByDescending(c => c.MaLapTop))
            {
                x.InRaManHinh();
            }
        }

        public bool checkSo(string text)
        {
            // return Regex.IsMatch(text, "^[0-9]*$");
             return Regex.IsMatch(text, "\\d+");
        }
        public bool checkChu(string text)
        {
             return Regex.IsMatch(text, "[a-zA-Z]+");
         //return Regex.IsMatch(text, "\\w+"); // bao gồm cả chữ lẫn số nhưng ko có ký tự
        }
        public void inDs3()
        {
            foreach (var x in openFileGeneric<Laptop>())
            {
                x.InRaManHinh();
            }
        }
        public List<T> openFileGeneric<T>()
        {
            List<T> lstT = new List<T>();
            _fs = new FileStream(part, FileMode.Open);
            _bf = new BinaryFormatter();
            lstT = (List<T>)_bf.Deserialize(_fs);//Đọc đối tượng lên và gán
            _fs.Close();
            return lstT;
            Console.WriteLine("Mở thành công");
        }
    }
}
