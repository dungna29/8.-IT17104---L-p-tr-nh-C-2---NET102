using System;
using System.Collections;

namespace BAI_2._0_COLLECTION
{
    class Program
    {
        #region Phần 1: COLLECTION LÀ GÌ?
        /*
         * ❑Collection là lớp hỗ trợ lưu trữ, quản lý và thao tác với các đối tượng linh hoạt.
           ❑Có thể lưu trữ một tập hợp đối tượng thuộc nhiều kiểu khác nhau.
           ❑Hỗ trợ rất nhiều phương thức để thao tác với tập hợp như: tìm kiếm, sắp xếp, đảo ngược, . . .
           ❑Là một mảng có kích thước động:
               ❖Không cần khai báo kích thước khi khởi tạo.
               ❖Có thể tăng giảm số lượng phần tử trong mảng một cách linh hoạt
         */


        #endregion

        #region Phần 2: Các  Collection thông dụng C#

        /*
         * 1. ArrayList:  Lớp cho phép lưu trữ và quản lý các phần tử giống mảng. Tuy nhiên, không giống như trong mảng, ta có thể thêm hoặc xoá phần tử một cách linh hoạt và có thể tự điều chỉnh kích cỡ một cách tự động.
         * 2. List: List là 1 Generic Collections đưa ra như một sự thay thế ArrayList vì thế về khái niệm cũng như sử dụng nó hoàn toàn giống với ArrayList. 
         * 3. HashTable: Lớp lưu trữ dữ liệu dưới dạng cặp Key – Value. Khi đó ta sẽ truy xuất các phần tử trong danh sách này thông qua Key (thay vì thông qua chỉ số phần tử như mảng bình thường).
         * 4. SortedList: Là sự kêt hợp của ArrayList và HashTable. Tức là dữ liệu sẽ lưu dưới dạng Key – Value. Ta có thể truy xuất các phần tử trong danh sách thông qua Key hoặc thông qua chỉ số phần tử. Đặc biệt là các phần tử trong danh sách này luôn được sắp xếp theo giá trị của Key.
         * 5. Stack:  Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc LIFO (Last In First Out).
         * 6. Queue:   Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc FIFO (First In First Out).
         * 7. BitArray: Lớp cho phép lưu trữ và quản lý một danh sách các bit. Giống mảng các phần tử kiểu bool với true biểu thị cho bit 1 và false biểu thị cho bit 0. Ngoài ra BitArray còn hỗ trợ một số phương thức cho việc tính toán trên bit.  
         */

        #endregion

        #region Phần 3: HashTable  
        /*
         * - Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
         * - Vì Key và Value đều là kiểu object nên ta có thể lưu trữ được mọi kiểu dữ liệu từ những kiểu cơ sở đến kiểu phức tạp (class).
           
           Một số thuộc tính và phương thức hỗ trợ sẵn trong Hashtable: 
                - Count  Trả về 1 số nguyên là số phần tử hiện có trong Hashtable.           
                - Keys  Trả về 1 danh sách chứa các Key trong Hashtable.           
                - Values  Trả về 1 danh sách chứa các Value trong Hashtable.
                - Add(object Key, object Value)  Thêm 1 cặp Key - Value vào Hashtable.
           
                - Clear()  Xoá tất cả các phần tử trong Hashtable.           
                - Clone()  Tạo 1 bản sao từ Hashtable hiện tại.           
                - ContainsKey(object Key) Kiểm tra đối tượng Key có tồn tại trong Hashtable hay không.           
                - ContainsValue(object Value)  Kiểm tra đối tượng Value có tồn tại trong Hashtable hay không.           
                - CopyTo(Array array, int Index)  Thực hiện sao chép tất cả phần tử trong Hashtable sang mảng một chiều array từ vị trí Index của array. Lưu ý: array phải là mảng các object hoặc mảng các DictionaryEntry.           
                - Remove(object Key)  Xoá đối tượng có Key xuất hiện đầu tiên trong Hashtable.

         */
        static void DungnaHashTable()
        {

            // khởi tạo 1 Hashtable
            Hashtable Hash1 = new Hashtable();

            // khởi tạo 1 Hashtable và chỉ định Capacity ban đầu là 10
            Hashtable Hash2 = new Hashtable(10);

            //Ngoài ra bạn cũng có thể khởi tạo 1 Hashtable chứa các phần tử được sao chép từ một Hashtable khác:
            Hashtable Hash3 = new Hashtable(Hash1);

            //Thêm giá trị vào Hashtable
            Hash1.Add("dog", "chó");
            Hash1.Add("cat", "mèo");
            Hash1.Add("fpoly", "FPT POLYTECHNIC");

            Hash2.Add(1, "Dũng");
            Hash2.Add(2, "Thụ");
            Hash2.Add(3, "Trang");

            //Cách lấy 1 phần tử ra
            Console.WriteLine("=============");
            Console.WriteLine(Hash1["fpoly"]);

            /* 
            * In các phần tử trong Hashtable.
            * Vì mỗi phần tử là 1 DictionaryEntry nên ta chỉ định kiểu dữ liệu cho item là DictionaryEntry luôn.
            * Thử in ra màn hình cặp Key - Value của mỗi phần tử được duyệt.
            */
            Console.WriteLine("=============");
            Console.WriteLine("\nHash1 Count: " + Hash1.Count);
            foreach (DictionaryEntry x in Hash1)
            {
                Console.WriteLine(x.Key + "\t" + x.Value);
            }

            Console.WriteLine("=============");
            Console.WriteLine("\nHash2 Count: " + Hash1.Count);
            foreach (DictionaryEntry x in Hash2)
            {
                Console.WriteLine(x.Key + "\t" + x.Value);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
