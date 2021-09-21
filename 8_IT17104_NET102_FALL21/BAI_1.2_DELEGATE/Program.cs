using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._2_DELEGATE
{
   
    class Program
    {
        #region Delegate
        /*
       * Định nghĩa:
           * ❑Delegate là một biến chứa tham chiếu đến phương thức cần thực thi.
             ❑Một delegate có thể trỏ tới một hoặc nhiều phương thức
             ❑Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi
             ❑
       * + Có thể khai báo trong namespace hoặc khai báo trong class
       * + Khi khai báo giống như khai báo một phương thức
       * + Công thức:
       *      <phạm vi truy cập> delegate <kiểu phương thức> <tên>(<Tham số>); 
       */
        //Khai báo 1 delegate
        public delegate void ThongBao(string noidung);
        static void ThongTin1(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("ThongTin1 + " + s);
            Console.ResetColor();
        }
        static void ThongTin2(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThongTin2+ " + s);
            Console.ResetColor();
        }


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            #region Phần 1: Khởi tạo delgate null

            Console.WriteLine("===Phần 1: Khởi tạo delegate ===");
            ThongBao thongBao = null;//Khởi tạo delegate = null
            thongBao = ThongTin2;//Gán phương thức cho delegate và delete sẽ có thể trỏ đến phương thức đó
            thongBao?.Invoke("Chào các bạn học delegate nhé");//?Dùng để kiểm tra xem delegate đó có bị null hay ko và ko null thì mới thực thi.
            #endregion

            #region Phần 2: Khởi tạo delegate
            Console.WriteLine("===Phần 2: Khởi tạo delegate===");
            ThongBao thongbao2 = new ThongBao(ThongTin1);
            thongbao2("Bạn đang học phần khởi tạo delegate");
            #endregion
        }
    }
}
