using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._2_CLASS_GENERIC
{
    //T chỉ là kiểu dữ liệu
    class FpolyClassGeneric<T>
    {
        private T temp;

        public FpolyClassGeneric()
        {
            
        }

        public FpolyClassGeneric(T temp)
        {
            this.temp = temp;
        }

        public T Temp
        {
            get => temp;
            set => temp = value;
        }

        public T inRaManHinh()
        {
            Console.WriteLine(temp);
            return temp;
        }
    }
}
