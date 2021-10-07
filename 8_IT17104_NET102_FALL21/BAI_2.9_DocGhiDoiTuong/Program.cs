using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_2._9_DocGhiDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string filePath = @"E:\Dungna29 Fpoly\8. Demo\Demo C#2\FALL21_Block1\8.-IT17104---L-p-tr-nh-C-2---NET102\8_IT17104_NET102_FALL21\BAI_2.9_DocGhiDoiTuong\data.bin";
            List<Vaccine> fakeList = new List<Vaccine>
            {
                new Vaccine("VN1","NANO COVAC",true),
                new Vaccine("VN2","NANO1 COVAC",true),
                new Vaccine("VN3","NANO2 COVAC",false),
            };
            VaccineService vs = new VaccineService();
            vs.ghiFile(filePath,fakeList);
            Console.WriteLine("Ghi file thành công");
            vs.docFile(filePath);
            foreach (var x in vs.GetLstVaccines())
            {
                x.inRaManHinh();
            }
        }
    }
}
