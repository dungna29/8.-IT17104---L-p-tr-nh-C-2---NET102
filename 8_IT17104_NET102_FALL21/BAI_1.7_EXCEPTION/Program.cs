using System;
using System.Text;

namespace BAI_1._7_EXCEPTION
{
    class Program
    {
        #region EXCEPTION - Xử lý ngoại lệ: try + tab
        /*
        * ❑ Exception là các vấn đề phát sinh trong quá trình thực hiện chương trình như: không đọc được tập tin, kiểu dữ liệu sai…
          ❑ Các exception được sinh ra bởi .NET framework CLR hoặc lập trình viên
          ❑ Xử lý ngoại lệ trong C# được xây dựng chủ yếu trên bốn từ khoá try, catch, finally và throw
                              try
                              {                              
                                   //Các câu lệnh
                              }
                              catch (Exception a)
                              {
                                    //Phần code để xử lý lỗi hoặc đơn giản chỉ là show ra lỗi

                              }
                              finally
                              {
                                   //Một khối finally được sử dụng để thực thi một tập hợp lệnh đã cho, dù có hay không một exception đươc ném hoặc không được ném.
                              }
           Một số Exception class thường gặp:
               - Exception [Lớp cơ bản của mọi ngoại lệ.]          
               - SystemException [Lớp cơ bản của mọi ngoại lệ phát ra tại thời điểm chạy của chương trình.]           
               - IndexOutOfRangeException [Được ném ra tại thời điểm chạy khi truy cập vào một phần tử của mảng với chỉ số không đúng.]           
               - NullReferenceException [Ném ra tại thời điểm chạy khi một đối tượng null được tham chiếu.]
               - AccessViolationException [Ném ra tại thời điểm chạy khi tham chiếu vào vùng bộ nhớ không hợp lệ.]
               - InvalidOperationException [Ném ra bởi phương thức khi ở trạng thái không hợp lệ.]           
               - ArgumentException [Lớp cơ bản cho các ngoại lệ liên quan tới đối số (Argument).]
               - ArgumentNullException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức mà không cho phép thông số null truyền vào.]
               - ArgumentOutOfRangeException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức khi một đối số không thuộc phạm vi cho phép truyền vào nó.]
               - ExternalException [Lớp cơ bản cho các ngoại lệ xẩy ra hoặc đến từ môi trường bên ngoài.]
               - COMException [Lớp này mở rộng từ ExternalException, ngoại lệ đóng gói thông tin COM.]
               - SEHException [Lớp này mở rộng từ ExternalException, nó tóm lược các ngoại lệ từ Win32.]
        */
        //Ví dụ 1: Đối với số nguyên chia cho 0 sẽ phát sinh lỗi
        public static void Vidu1()
        {
            int a = 5, b = 0, c;
            c = a / b;
            Console.WriteLine(c);// System.DivideByZeroException: Attempted to divide by zero.
            Console.WriteLine("Kế thúc chương trình");
        }  
        public static void Vidu2()
        {
            int a = 5, b = 0, c;
            try
            {
                c = a / b;
                Console.WriteLine(c);// System.DivideByZeroException: Attempted to divide by zero.
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Các lỗi xảy ra ");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Name);
            }
            Console.WriteLine("Kế thúc chương trình");
        }


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Vidu2();
        }
    }
}
