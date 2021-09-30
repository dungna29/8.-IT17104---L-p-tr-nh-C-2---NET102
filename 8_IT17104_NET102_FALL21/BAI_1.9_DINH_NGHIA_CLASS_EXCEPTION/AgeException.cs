using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._9_DINH_NGHIA_CLASS_EXCEPTION
{
    class AgeException:Exception
    {
        //prop + tab
        public int Age { get; set; }

        public AgeException(string? message, int age) : base(message)
        {
            Age = age;
        }

        public void ChiTietLoi()
        {
            Console.WriteLine("Tuổi của bạn là: {0} chưa đủ tuổi vào Club C# bao giờ 18 tuổi nhé.",Age);
          
        }
    }
}
