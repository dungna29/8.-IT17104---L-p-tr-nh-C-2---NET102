using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._4_PARTIAL_CLASS_METHOD
{
    class ClassNested
    {
        /*
     * Trong C# nó cho phép bạn khai báo một lớp (class), giao diện (interface), cấu trúc (struct) trong thân một lớp khác - chúng được gọi là kiểu lồng nhau (Nested Type)
     */
        public class ClassD
        {
            private string variable1;

            public ClassD()
            {
                
            }

            public ClassD(string variable1)
            {
                this.variable1 = variable1;
            }

            public string Variable1
            {
                get => variable1;
                set => variable1 = value;
            }

            public void method1()
            {

            }
        }
    }
}
