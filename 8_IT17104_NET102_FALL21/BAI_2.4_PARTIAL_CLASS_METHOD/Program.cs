using System;

namespace BAI_2._4_PARTIAL_CLASS_METHOD
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Phần 1: Sử dụng Partial Class
             * Khi sử dụng đối tượng Class A hoàn toàn bình thường như các class khác nhưng nó được phân tách thành 2 file.
             */
            ClassA classA = new ClassA();
            classA.variableA = "";
            classA.variableB = 1;
            classA.variableC = "";
            classA.variableD = 2;
            classA.method1();
            classA.method2();
            classA.method3();
            /*
             * Phần 2: Sử dụng Class lồng nhau Nested
             ** Lớp Nested được khai báo, định nghĩa trong lớp Container, nếu phạm vị lớp public, thì bên ngoài sử dụng lớp con này bằng cách chỉ rõ Container.Nested
             */
            ClassNested.ClassD  classD= new ClassNested.ClassD();
            classD.Variable1 = "";
            classD.method1();
        }
    }
}
