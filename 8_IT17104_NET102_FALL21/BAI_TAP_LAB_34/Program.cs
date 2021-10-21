using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

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

            //Muốn đạt tối đa 10 điểm thì hãy thử ứng dụng 1 Delegate mà đã học.
        */
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";

        static void Main(string[] args)
        {
            var text = "Dungna29";
            Console.WriteLine(text);

            var cipher = Encrypt(text);
            Console.WriteLine(cipher);

            text = Decrypt(cipher);
            Console.WriteLine(text);

            Console.ReadKey();
        }

        public static string Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        public static string Decrypt(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
    }
}
