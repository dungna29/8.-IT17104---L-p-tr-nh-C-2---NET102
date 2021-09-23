using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_1._3_DELEGATE_ACTION_FUNC
{
    class Program
    {
        #region  Bài Action, Predicate, Func: Delegate - Generic(Sử dụng sẵn tham số Generic để khai báo)
        /*
         Thay vì chúng ta phải khai báo định nghĩa trước delegate thì chúng ta sẽ sử dụng 3 kiểu dưới đây khai báo cho nhanh.
          Action, Predicate, Func (Viết tắt là APF là cho nhanh) trong C#
            + Action: Action<T in1, T in2, …>. Action tương đương 1 delegate với kiểu trả về là void, với in1, in2 là các params nhận vào.

            + Predicate: Predicate<T in>. Predicate tương đương 1 delegate với kiểu trả về là bool, với in là các param nhận vào. Predicate chỉ có thể nhận vào 1 param duy nhất.

            + Func: Func<T in1, T in2, … , T result>. Function tương đương 1 delegate với kiểu trả về do ta khai báo (result), in1, in2 là các params nhận vào. Func bắt buộc phải trả ra giá trị, không thể trả void.


            Bảng so sánh cách khai báo bằng delegate cùng với cách khai báo tương ứng bằng Action, Predicate, Func:

            delegate void VoidDelegate(int input1, bool input2)	- Action<int, bool>	
            
            delegate bool BoolDelegate(int input1)	-  Predicate<int>	|| Func<int, bool>

            delegate int intDelegate(bool input2)	- Func<bool, int>
            
            delegate void HelloWorldDelegate()	- Action

            delegate bool HelloWorldBoolDelegate()	- Predicate -  Func<bool>

        */


        #endregion
        static void ThongTin1(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("ThongTin1 + " + s);
            Console.ResetColor();
        }
        static void ThongTin2(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThongTin2 + " + s);
            Console.ResetColor();
        } 
        static void ThongTin3(string s, int a)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("ThongTin3 + " + s);
            Console.ResetColor();
        }

        static int phepTru(int a, int b)
        {
            return a - b;
        }

        static bool checkChuVietHoa(string str)
        {
            // dung == DUNG
            return str.Equals(str.ToUpper());
        }

        static void Main(string[] args)
        {
           
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            List<string> lstString;
            List<int> lstString1;
            List<double> lstString2;
            #region Phần 1: Action
            Action action;//Tương đương như delegate void TenDelegate();
            Action<string, int> action1;//Tương đương như delegate void TenDelegate(string a, int b);
            Action<string> action2;//Tương đương như delegate void TenDelegate(string a);
            //action = ThongTin1; Lỗi bởi nó chỉ có thể gán cho các phương thức void nhưng không có tham số truyền vào
            action2 = ThongTin1;
            action2("Đây là Action");
            action2?.Invoke("Đây là Action sử dụng Invoke");
            #endregion

            #region Phần 2: Predicate

            Console.WriteLine("====Phần 2: Predicate");//Làm việc với cả các phương có kiểu trả về true và false
            Predicate<string> predicate;//Tương đương như delegate bool TenDelegate(string a);
            predicate = checkChuVietHoa;
            Console.WriteLine("String sau co viet hoa hay khong = " + predicate.Invoke("fPT"));

            #endregion

            #region Phần 3: Func khai báo với các phương thức trả về
            Console.WriteLine("====Phần 3: Func khai báo với các phương thức trả về");
            //THAM SỐ CUỐI CÙNG CHÍNH LÀ KIỂU TRẢ VỀ CỦA PHƯƠNG THỨC
            Func<int, int, int> func;//Tương đương như delegate int TenDelegate(int a,int b);
            func = phepTru;
            Console.WriteLine("Tổng 2 số: 5 - 5 = " + func.Invoke(5,5));
            Func<string, int, double> func2;//Tương đương như delegate double TenDelegate(string a,int b);
            func2 = tenPhuongThuc;
            Func<string, string, string> func3;//Tương đương như delegate string TenDelegate(string a,string b);
            //Viết 2 phương thức để có thể gán cho func2 và func3
            #endregion
        }

        static double tenPhuongThuc(string a, int b)
        {
            return 0;
        }

    }
}
