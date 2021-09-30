using System;
using System.Text;

namespace BAI_1._8_DinhNghia_EXCEPTION
{
    class Program
    {
        #region Phần 1: Định nghĩa ra 1 EXCEPTION bên trong 1 phương thức
        static void dangKyClubCsharpFpoly(string tenTruong,int tuoi)
        {
            if (tenTruong != "FPOLY")
            {
                Exception exception = new Exception("Bạn không thể tham gia vì không phải là sinh viên FPOLY");
                throw exception;
            }

            if (tuoi<18)
            {
                throw new Exception("Bạn chưa đủ tuổi vào Club C# bao giờ 18 tuổi nhé.");
            }

            Console.WriteLine("Chào mừng bạn đã đăng ký thành công Club C#");
        }


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                dangKyClubCsharpFpoly("BK",17);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
