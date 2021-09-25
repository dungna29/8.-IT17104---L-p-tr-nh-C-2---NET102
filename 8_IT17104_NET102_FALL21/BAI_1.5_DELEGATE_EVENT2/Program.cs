using System;

namespace BAI_1._5_DELEGATE_EVENT2
{
    class Program
    {
        public delegate void SuKienNhap2So(int x, int y);

        class NguoiDung
        {
            public event SuKienNhap2So sukienNhapSo;

            public void nhap2So()
            {
                Console.WriteLine("Mời bạn nhập số thứ 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập số thứ 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                //Phát sự kiện
                sukienNhapSo.Invoke(a, b);
            }
        }

        class TinhToan
        {
            public void thiHanhTinhTong(NguoiDung nguoiDung)
            {
                //Phải sử dụng += hoặc -= để thực hiện phép gán
                nguoiDung.sukienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì sẽ thi hành tính tổng 2 số
            }

            private void tinhTong(int a, int b)
            {
                Console.WriteLine("Tổng: {0} + {1} = {2}", a, b, a + b);
            }
        }
        static void Main(string[] args)
        {
            //Phát đi sự kiện
            NguoiDung nguoiDung = new NguoiDung();

            //Nhận sự kiện
            TinhToan tinhToan = new TinhToan();
            tinhToan.thiHanhTinhTong(nguoiDung);

            //Thực thi
            nguoiDung.nhap2So();

        }
    }
}
