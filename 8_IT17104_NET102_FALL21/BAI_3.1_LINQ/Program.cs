using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Channels;

namespace BAI_3._1_LINQ
{
    class Program
    {
        #region LINQ là gì
        /*
       *  LINQ: Language Integrated Query
       *  Định nghĩa:  ngôn ngữ truy vấn tích hợp - nó tích hợp cú pháp truy vấn (gần giống các câu lệnh SQL) vào bên trong ngôn ngữ lập trình C#, cho nó khả năng truy cập các nguồn dữ liệu khác nhau (SQL Db, XML, List ...) với cùng cú pháp.

       * Ưu điểm:
       * ➢Ưu điểm lớn nhất của Linq đó chính là sự mạch lạc trong code, xậy dựng nhanh, ít gây lỗi
         ➢Linq cung cấp nhiều phương thức trong truy vấn dữ liệu, nếu cùng một chức năng, khi sử dụng truy vẫn thuần có thể phải code nhiều gấp 2, 3 lần khi sử dụng linq (tùy ứng dụng)
         ➢Cách tiếp cận khai báo giúp truy vấn dễ hiểu và gọn hơn

       * Nhược điểm:
       *➢Tốc độ chậm nếu viết linq không khéo

          Linq query systax:
                              from object in datasource
                              where condition
                              select object

          from: Từ nguồn dữ liệu mà truy vấn sẽ thực hiện
          in: bên trong nguồi giá trị nào
          datasource: tập giá trị nguồn
          where: lọc dữ liệu theo điều kiện condition
          select object: Lấy ra kết quả có thể là giá trị hoặc tập giá trị

          Ngoài ra chúng ta cũng thấy việc áp dụng lambda cơ bản với những câu lọc dữ liệu ngắn sẽ đơn giản nhưng khi join vào nhiều datasource sẽ không dễ đọc với người chưa có kinh nghiệm
       */


        #endregion
        static void Main(string[] args)
        {
            string[] arrName = { "Hoa", "Trang", "Dũng", "Long", "Mạnh", "Hoàng", "Tùng", "Lan" };
            List<int> arrNumber = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            //Ví dụ 1: Lấy ra những người có tên bắt đầu bằng chữ T
            // var lstNameChuT = (from a in arrName
            //     where a.StartsWith("T")
            //     select a).ToList();
            foreach (var x in arrName.ToList().Where(c=>c.StartsWith("T")))
            {
                Console.WriteLine(x + " ");
            }

            //Ví dụ 2: Lấy danh sách các số chẵn trong List số trên
            var lstSoChan = from a in arrNumber
                where a % 2 == 0
                select a;

            var sortNumber = from a in arrNumber
                orderby a // mặc định là ASC
                select a;

            var sortNumber1 = from a in arrNumber
                orderby a ascending 
                select a;
        }
    }
}
