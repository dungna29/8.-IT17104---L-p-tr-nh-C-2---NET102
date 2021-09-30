using System;
using System.Text;

namespace BAI_1._9_DINH_NGHIA_CLASS_EXCEPTION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                dangKyClubCsharpFpoly("FPOLY", 17);
            }
            catch (FpolyException e)
            {
                Console.WriteLine(e.Message);
              
            }
            catch (AgeException e)
            { 
                Console.WriteLine(e.Message);
                e.ChiTietLoi();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void dangKyClubCsharpFpoly(string tenTruong, int tuoi)
        {
            if (tenTruong != "FPOLY")
            {
                FpolyException exception = new FpolyException("Bạn không thể tham gia vì không phải là sinh viên FPOLY");
                throw exception;
            }

            if (tuoi < 18)
            {
                throw new AgeException("Thông báo  AgeException:",tuoi);
            }

            Console.WriteLine("Chào mừng bạn đã đăng ký thành công Club C#");
        }
    }
}
