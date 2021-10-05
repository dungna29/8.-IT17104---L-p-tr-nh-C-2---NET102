using System;

namespace BAI_2._5_IMPLICITLY_VA_DYNAMIC_TYPE
{
    class Program
    {
        /*
       * Phần 1: Implicitly,Dynamic
       *          1.1 Implicitly (KIỀU NGẦM ĐỊNH):
       *             ❑Khai báo biến kiểu ngầm định (khai báo không tường minh) là biến được khai báo mà không cần phải chỉ ra kiểu dữ liệu
                     ❑Kiểu dữ liệu của biến sẽ được xác định bởi trình biên dịch dựa vào biểu thức được gán khi khai báo biến
                     ❑Sử dụng từ khóa “var” khi khai báo và cần khởi tạo giá trị
                  1.2 Công thức:
                      var varialble_name = value;
                  1.3 Hạn chế:
                     + Không thể sử dụng từ khóa var bên ngoài phạm vi của một method
                     + Không thể khởi tạo giá trị là null.
                     + Biến phải được khởi tạo giá trị khi nó được khai báo 
                     + Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống        nhau
                     + Giá trị khởi tạo phải là một biểu thức. Giá trị khởi tạo     không được là một đối tượng hay tập hợp các giá trị. Nhưng nó có thể sử dụng toán tử new bởi một đối tượng hoặc tập hợp các giá trị.

                  2.1 Dynamic
                      Kiểu động - ngầm định - khai báo với từ khóa dynamic, thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy (khác với kiểu ngầm định var kiểu xác định ngay        thời điểm biên dịch)
       */
        static void Main(string[] args)
        {
            #region Phần 1: Impliciyly
            //1. Khai báo
            var a = 2;//Impliciyly
            int b = 9;//Explicitly
            //Ngoài ra var có thể trở thành rất nhiều kiểu dữ liệu khác nhau

            //2. Hạn chế khi khai báo và xảy ra lỗi
            //2.0 Không thể khởi tạo giá trị null
            //var temp1 = null;

            //2.1 Phải khởi tạo giá trị ngay cho nó khi khai báo
            //var temp1;

            //2.2 Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống nhau
            // var temp1 = 5;
            // temp1 = "1";

            //2.4 Giá trị khởi tạo phải là 1 biểu thức. Giá trị khởi tạo không được là 1 đối tượng hay tập giá trị. Nó có thể sử đụng toán tử new bởi 1 đối tượng hoặc tập giá trị khác
            //var arr = {5, 10, 8};
            var arr = new int[] {5, 10, 8};

            //2.5 Không thể khai báo var bên ngoài phương thức và cũng ko thể dùng nó làm tham số khi truyền vào của 1 phương thức
            #endregion

            #region Phần 2: Dynamic
            //1. Khai báo các kiểu dữ liệu giống như var
            dynamic x1;

            //Khai báo nặc danh
            var student = new
            {
                id = "PH00111",
                ten = "Nam",
                nganhHoc = "UDPM .NET"
            };
            //Gọi phương thức sử dụng tham số là dynamic
            method2(student,student.nganhHoc);
            #endregion
        }

        private dynamic a;

        static void method2(dynamic temp1,dynamic temp2)
        {
            Console.WriteLine(temp1.ten + " " + temp2);
        }

        //2.5 Không thể khai báo var bên ngoài phương thức và cũng ko thể dùng nó làm tham số khi truyền vào của 1 phương thức
        // static void method1(var a)
        // {
        //
        // }
    }
}
