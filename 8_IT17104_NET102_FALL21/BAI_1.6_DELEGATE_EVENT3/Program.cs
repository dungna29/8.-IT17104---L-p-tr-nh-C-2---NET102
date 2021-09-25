using System;

namespace BAI_1._6_DELEGATE_EVENT3
{
    class Program
    {
        /*
    * Ngoài ra trong C# có sẵn chuẩn tạo ra sẵn sự kiện Delegate
    */
        class NguoiDung
        {
            public event EventHandler sukienNhapSo;//Tương đương delegate void ten(object sender, EventArgs e)

            public void nhap2So()
            {
                Console.WriteLine("Mời bạn nhập số thứ 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập số thứ 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                //Phát sự kiện
                sukienNhapSo.Invoke(this,new NguoiDung1(a,b));
            }
        }

        class NguoiDung1:EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }
            
            public NguoiDung1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class TinhToan
        {
            public void thiHanhTinhTong(NguoiDung nguoiDung)
            {
                //Phải sử dụng += hoặc -= để thực hiện phép gán
                nguoiDung.sukienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì sẽ thi hành tính tổng 2 số
            }

            private void tinhTong(object sender, EventArgs e)
            {
                NguoiDung1 nguoiDung1 =(NguoiDung1) e;
                Console.WriteLine("Tổng: {0} + {1} = {2}", nguoiDung1.a, nguoiDung1.b, nguoiDung1.a + nguoiDung1.b);
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
