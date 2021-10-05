using System;

namespace BAI_2._3_GENERIC_COLLECTIONS
{
    class Program
    {   /*
         * Các Generic Collections đều được xây dựng bắt nguồn từ 1 Collections nào đó có sẵn. Vì thế với mỗi Collections đã học sẽ có một Generic tương ứng.           
           Một số Generic Collections được sử dụng phổ biến:
                1.   List<T>: Là một Collections giúp lưu trữ các phần tử liên tiếp (giống mảng) nhưng có khả năng tự mở rộng kích thước. Generic Collections này là sự thay thế cho ArrayList đã học.
                2.   Dictionary<Tkey, TValue>: Lớp lưu trữ dữ liệu dưới dạng cặp Key – Value. Khi đó ta sẽ truy xuất các phần tử trong danh sách này thông qua Key (thay vì thông qua chỉ số phần tử như mảng bình thường).    Generic Collections này là sự thay thế cho Hashtable đã học.
                3.   SortedDictionary<Tkey, TValue>: Là sự kêt hợp của List và Dictionary. Tức là dữ liệu sẽ lưu dưới dạng Key – Value. Ta có thể truy xuất các phần tử trong danh sách thông qua Key hoặc thông qua chỉ số phần tử. Đặc biệt là các phần tử trong danh sách này luôn được sắp xếp theo giá trị của Key. Generic Collections này là sự thay thế cho SortedList đã học.         
                4.   Stack<T>: Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc LIFO (Last In First Out). Generic Collections này là sự thay thế cho Stack đã học.
                5.   Queue<T>: Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc FIFO (First In First Out). Generic Collections là sự thay thế cho Queue đã học.
                6. LinkedList<T>: Lớp cho phép lưu trữ thao tác với dữ liệu
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
