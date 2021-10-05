using System;

namespace BAI_2._6_NULLABLE_TYPED
{

    #region Định nghĩa
    /*
    * 1. Từ khóa null
    *    + null là một giá trị cố định nó biểu thị không có đối tượng nào cả, có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).

         + null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...
    */

    /*
     *2. Sử dụng nullable
     *    + Nếu bạn muốn sử dụng các kiểu dữ liệu nguyên tố như int, float, double ... như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, có thể sử dụng như đối tượng ... thì khai báo nó có khả năng nullable, khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value, cách làm như sau:
     *    + Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu      
     */
    #endregion
    class Program
    {
        class ClassA
        {
            public void method1()
            {

            }
        }
        static void Main(string[] args)
        {
            #region Phần 1: Null

            ClassA classA1, classA2;
            classA1 = new ClassA();//Khơi tạo tham chiếu bằng 1 đối tượng
            classA2 = classA1;//ClassA2 được được gán classA1 tham chiếu đến cùng 1 đối tượng classA1
            classA2.method1();

            //classA1 = null;//ClassA1 đang không trỏ đến đối tượng nào cả
            classA1.method1();

            string s1 = null;
            int i = 10;//int là kiểu tham trị, nó thể gán giá trị biến i = 10
                       //int i2 = null;//Lỗi kiểu tham trị không thể gán null

            #endregion

            #region Phần 2 NULLABLE TYPED
            /*2.  NULLABLE TYPED
                + Cú pháp: 
                    - Nullable<T> tên biến;
                    - T? tên biến;
                + Cần gán gia trị cho biến khi khai báo nếu không sẽ bị lỗi và nên kiểm tra giá tị trước khi dùng bằng HasValue
                + Dùng phương thức GetValueOrDefault() để lấy giá mặc định của kiểu dữ liệu
                + Dùng toán tử ?? thực hiện gán Nullable Type cho Non-Nullable Type
                */
            Nullable<long> l1 = null;
            Nullable<long> l2 = 5;
            int? i3 = 20;
            int? i4 = null;
            int?[] arr = new int?[5];

            if (i4.HasValue)//Kiểm tra giá trị trước khi dùng
            {
                //Body code
            }

            Console.WriteLine(i3.GetValueOrDefault());//Giá trị mặc định là 0

            //Toán tử ?? thực hiện gán Nullable cho Non-Nullable
            int? temp9 = null;
            int temp10 = temp9 ?? 0;//temp10 = temp9 khi  temp9!= null, temp10 = 0 khi temp9 bị null

            #endregion
        }
    }
}
