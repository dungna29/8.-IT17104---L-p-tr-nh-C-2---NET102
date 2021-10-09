using System;

namespace BAI_3._0_BietThucLAMBDA
{
    class Program
    {
        #region Lambda
        /*
        * Biểu thức lambda còn gọi là biểu thức (Anonymous), một biểu thức khai báo giống phương thức nhưng thiếu tên. Cú pháp để khai báo biểu thức lambda là sử dụng toán dử => như sau:

           Công thức 1:
               (tham_số) => biểu_thức;

           Công thức 2:
           (tham_số) =>
               {
                  các câu lệnh
                  Sử dụng return nếu có giá trị trả về
               }            

        */

        //Ví dụ 1: Sử dụng Delegate với lambda
        delegate int TinhHieu(int a, int b);
        
        public static void Vidu1()
        {
            int a = 8, b = 2;
            TinhHieu tinhHieu = (int c, int d) =>
            {
                return c - d;
            };
            TinhHieu tinhHieu2 = (int c, int d) => c - d;//Cách 2
            Console.WriteLine(tinhHieu2(a, b));//Thực thi
        }

        //Ví dụ 2: Khai báo 1 phương thức kiểu lambda
        static double PhepChia(int x, int y) => x / y;

        //Ví dụ 3:
        public static void ViDu3()
        {
            int[] arrNumbers = { 11, 22, 33, 44, 55, 66 };
            //Cách 1:
            Array.ForEach(arrNumbers, delegate (int x) { Console.WriteLine(x + ""); });

            //Cách 2:
            Array.ForEach(arrNumbers, x => Console.WriteLine(x + " "));

            //Cách 3:
            foreach (var x in arrNumbers) Console.WriteLine(x + " ");

        }
        #endregion

        #region Một số quy tắc khi sử dụng lambda
        delegate void ChaoBan1(string name);
        delegate void ChaoBan2();
        delegate void ChaoBan3(string name1, string name2, string name3);
        delegate int TinhToan(int a, int b);
        delegate bool Check1(int a, int b);

        static void ViDu4()
        {
            //1. Không quan tâm đến kiểu dữ liệu đầu vào
            ChaoBan1 chao1 = (string temp) => { Console.WriteLine("Chào bạn " + temp); };
            ChaoBan1 chao2 = (temp) => { Console.WriteLine("Chào bạn " + temp); };

            //2. Để trống nếu không có tham số ()
            ChaoBan2 chao3 = () => { Console.WriteLine("Chào bạn"); };

            //3. Nếu chỉ có một tham số bỏ luôn dấu ()
            ChaoBan1 chao4 = temp => { Console.WriteLine("Chào bạn " + temp); };

            //4. Nếu có nhiều tham số ngăn cách bằng dấu ,
            ChaoBan3 chao5 = (x, y, z) => { Console.WriteLine("Chào" + x + y + z); };

            //5. Nếu phương thức chỉ có 1 câu lệnh thực thi bỏ dấu {}
            ChaoBan3 chao6 = (x, y, z) => Console.WriteLine("Chào" + x + y + z);

            //6. Đối với phương thức return
            TinhToan tinhToan = (x, y) => { return x + y; };
            Check1 check1 = (x, y) => { return x > 10 && y < 20; };
        }
        //Ngoài ra các bạn mở rộng kiến thức bằng cách search nhiều
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
