using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._4_PARTIAL_CLASS_METHOD
{
    partial class ClassA
    {
        public string variableA { get; set; }
        public int variableB { get; set; }

        public void method1()
        {
            Console.WriteLine("Đây là phương thức 1");
        }

        /*
         * Phương thức Partial khai báo, phương thức này không có thân code
         * Bạn cũng có thể dùng từ khóa partial trong khai báo các phương thức, tuy nhiên mục đích chỉ là chia chia làm hai nơi, một nơi như là khai báo một nơi là triển khai code, và phương thức phải trả về kiểu void. 
         */
        public partial void method3();
    }
}
