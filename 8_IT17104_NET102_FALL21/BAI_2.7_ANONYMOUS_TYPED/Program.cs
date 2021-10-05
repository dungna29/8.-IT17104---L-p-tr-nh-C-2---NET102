using System;
using System.Text;

namespace BAI_2._7_ANONYMOUS_TYPED
{
    class Program
    {

        #region ANONYMOUS TYPED
        /*
         * Phần 1:  Định nghĩa:
             * ❑Kiểu ẩn danh (Anonymous Type) cung cấp một cách thuận tiện để đóng gói (encapsulate) một tập các thuộc tính chỉ đọc (read-only properties) vào một đối tượng mà không cần phải xác định rõ ràng loại (type) của nó ngay lúc viết code
             * ❑Cho phép tạo type mới (user-defined) mà không cần xác định tên của nó
               ❑Tạo các type ẩn danh này bằng cách sử dụng toán tử new

           Phần 2: ANONYMOUS METHOD
            ❑Phương thức vô danh (anonymous method) là một phương thức:
               ❖Không cần khai báo tên phương thức khi định nghĩa phương thức
               ❖Có thể khai báo trực tiếp ở chỗ cần dùng, không cần định nghĩa trước
               ❖Đươc dùng như tham số của deleg

            ❑Một số giới hạn Anonymous methods
                ❖Không khái báo được các lệnh goto, break or continue bên trong phương thức
                ❖Không truy cập được các tham số ref hoặc out bên ngoài
                ❖Phải được dùng kết hợp với delegate
         */
        #endregion
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Phần 1: Khai báo Anonymous và Anonymous lồng nhau
             */
            var svUdpm = new
            {
                id = 1,
                ten ="Dũng",
                lop = "PT0703"
            };
            Console.WriteLine($"{svUdpm.id} | {svUdpm.ten}");
            var svUdpm1 = new
            {
                id = 1,
                ten = "Dũng",
                lop = "PT0703",
                diachi = new
                {
                    soNha = 12,
                    duong = "Tay Ho"
                }
            };
            Console.WriteLine($"{svUdpm1.id} | {svUdpm1.diachi.duong}");

            /*
             * Phần 2: Phương thức nặc danh
             */
            // Method1 = Nhẽ ra phải gán cho delegate này 1 phương thức
            Method1 method1 = delegate(int i)
            {
                //Có thể gọi các biến cục bộ ngoài phương thức nặc danh này dùng như bình thường.
                Console.WriteLine("Đây là phương nặc danh. Giá trị = " +  i);
            };
            method1(1999);
        }
        //Khai báo phương thức delegate
        public delegate void Method1(int a);
    }
}
