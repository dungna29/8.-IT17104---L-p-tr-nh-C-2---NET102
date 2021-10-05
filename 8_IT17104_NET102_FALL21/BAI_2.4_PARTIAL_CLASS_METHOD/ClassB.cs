using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._4_PARTIAL_CLASS_METHOD
{
    partial class ClassA//Class A nằm trong file ClassB.cs
    {
        public string variableC { get; set; }
        public int variableD { get; set; }

        public void method2()
        {
            Console.WriteLine("Đây là phương thức 2");
        }
        public partial void method3()
        {
            Console.WriteLine("Đây là phương thức 3");
        }
    }
}
