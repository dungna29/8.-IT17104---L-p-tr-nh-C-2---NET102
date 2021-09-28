using System;

namespace BAI_TAP_LAB_34
{
    class Program
    {
        /*
        * Viết 1 chương trình quản lý sinh viên tại FPOLY dựa theo các yêu cầu sau
           1.	Cấu trúc Project bao gồm:
                   a.	Program.Class (Bao gồm hàm main, menu, các hàm chức năng)
                   b.	Student.Class (Bao gồm các thuộc tính của đối tượng như: Ho, Ten, TenDem, MaSV, NamSinh, DiemCsharp, GioiTinh, QueQuan - Hàm ToString() hoặc inRaManHinh())
           2.	Các chức năng chương trình cần có:
                    .	THÊM – SỬA- XÓA SV
                   a.	THÊM 5 NGƯỜI TẠO SẴN VÀO TRONG DANH SÁCH
                   b.	TÌM KIẾM SV THEO MÃ SINHVIEN (Tìm kiếm tuyệt đối hoặc Gần đúng)
                   c.	LOAD TẤT CẢ TT SV 
           3.	Cấu trúc Project bao gồm kết thừa và phân chia các file tường minh hơn:
            .	Main.Class (Bao gồm hàm main, menu)
                   a.	Person.Class(Lớp cha - Bao gồm các thuộc tính: Ho, Ten, TenDem, NamSinh, GioiTinh, QueQuan - inRaManHinh())
                   b.	Student.Class (Bao gồm các thuộc tính của đối tượng như: MaSV,  DiemCsharp- kế thừa hàm inRaManHinh() từ lớp cha)
                   c.	StudentService.Class(Bao gồm các chức năng của bài toán)

        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
