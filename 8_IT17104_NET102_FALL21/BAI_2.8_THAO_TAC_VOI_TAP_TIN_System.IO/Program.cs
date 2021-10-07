using System;
using System.IO;
using System.Text;

namespace BAI_2._8_THAO_TAC_VOI_TAP_TIN_System.IO
{
    class Program
    {

        #region Phần 1: THAO TÁC VỚI TẬP TIN VÀ THƯ MỤC
        /*
         * 1. SYSTEM.IO NAMESPACE
         *      + ❑System.IO Namespace có các lớp khác nhau được sử dụng để thực hiện nhiều hoạt động với các tập tin, chẳng hạn như việc tạo và xóa các tập tin, đọc hoặc viết vào một tập tin, đóng một tập tin.
                + ❑Một tập tin là một tập hợp các dữ liệu được lưu trữ trong một đĩa với một tên cụ thể và một đường dẫn thư mục. Khi một tập tin được mở để đọc hoặc viết, nó sẽ trở thành một luồng tin.
           2.System.IO namespace có nhiều lớp đa dạng mà được sử dụng để thực hiện các hoạt động khác nhau với File, như tạo và xóa file, đọc và ghi một File, đóng một File, …    
                + Bảng sau hiển thị một số lớp non-abstract được sử dụng phổ biến trong System.IO namespace trong C#:
                       - BinaryReader	Đọc dữ liệu gốc (primitive data) từ một binary stream
                       - BinaryWriter	Ghi dữ liệu gốc trong định dạng nhị phân
                       - BufferedStream	Một nơi lưu giữ tạm thời cho một stream
                       - Directory	Giúp ích trong việc thao tác một cấu trúc thư mục
                       - DirectoryInfo	Được sử dụng để thực hiện các hoạt động trên các thư mục
                       - DriveInfo	Cung cấp thông tin cho các Drive
                       - File	Giúp ích trong việc thao tác các File
                       - FileInfo	Được sử dụng để thực hiện các hoạt động trên các File
                       - FileStream	Được sử dụng để đọc và ghi bất kỳ vị trí nào trong một File
                       - MemoryStream	Được sử dụng để truy cập ngẫu nhiên tới stream được lưu giữ trong bộ nhớ
                       - Path	Thực hiện các hoạt động trên thông tin path
                       - StreamReader	Được sử dụng để đọc các ký tự từ một stream
                       - StreamWriter	Được sử dụng để ghi các ký tự tới một stream
                       - StringReader	Được sử dụng để đọc từ một string buffer
                       - StringWriter	Được sử dụng để ghi vào một string buffer  
         */


        #endregion

        #region DiskPartition & DirectoryInfo

        static void DiskPartition()
        {
            do
            {
                DriveInfo[] di = DriveInfo.GetDrives();

                Console.WriteLine("Total Partitions");
                Console.WriteLine("---------------------");
                foreach (DriveInfo items in di)
                {
                    Console.WriteLine(items.Name);
                }
                Console.Write("\nEnter the Partition::");
                string ch = Console.ReadLine();

                DriveInfo dInfo = new DriveInfo(ch);

                Console.WriteLine("\n");

                Console.WriteLine("Drive Name::{0}", dInfo.Name);
                Console.WriteLine("Total Space::{0}", dInfo.TotalSize);
                Console.WriteLine("Free Space::{0}", dInfo.TotalFreeSpace);
                Console.WriteLine("Drive Format::{0}", dInfo.DriveFormat);
                Console.WriteLine("Volume Label::{0}", dInfo.VolumeLabel);
                Console.WriteLine("Drive Type::{0}", dInfo.DriveType);
                Console.WriteLine("Root dir::{0}", dInfo.RootDirectory);
                Console.WriteLine("Ready::{0}", dInfo.IsReady);

            } while (true);
        }

        static void DirectoryInfo1()
        {
            //DirectoryInfo chứa một tập hợp các phương thức để tạo, xóa, di chuyển và liệt kê trên các thư mục và thư mục con.
            DirectoryInfo di = new DirectoryInfo(@"D:\");

            Console.WriteLine("*******Direcotry Informations*******\n\n");
            Console.WriteLine("Full Name={0}", di.FullName);
            Console.WriteLine("Root={0}", di.Root);
            Console.WriteLine("Attributes={0}", di.Attributes);
            Console.WriteLine("Creation Time={0}", di.CreationTime);
            Console.WriteLine("Name={0}", di.Name);
            Console.WriteLine("Parent={0}", di.Parent);

            //Create
            // DirectoryInfo di = new DirectoryInfo(@"D:\temp\xyz");
            // di.Create();

            //DirectoryInfo di=new DirectoryInfo(@"D:\");  
            //di.CreateSubdirectory("ajay");
            //di.CreateSubdirectory(@"ajay\ajay11");

        }
        static void DirectoryInfo2()
        {
            //Create
            // DirectoryInfo di = new DirectoryInfo(@"D:\temp\xyz");
            // di.Create();

            //CreateSubdirectory
            //DirectoryInfo di=new DirectoryInfo(@"D:\");  
            //di.CreateSubdirectory("ajay");
            //di.CreateSubdirectory(@"ajay\ajay11");

            //Delete
            // DirectoryInfo di = new DirectoryInfo(@"d:\abc");
            // Console.WriteLine("Name:{0}", di.FullName);
            //
            // Console.Write("Are you sure to Delete:");
            // string str = Console.ReadLine();
            // if (str == "y")
            // {
            //     Directory.Delete(@"d:\abc", true);
            // }
            // Console.Write("Deleted.....");
        }

        #endregion

        #region FileRead & FileStream

        static void FileReadWriteAllText()
        {
            string path = @"F:\Google Driver Dungna29FPT\8. Demo\Demo C#2\SM21_Block1\7.-IT16312-L-p-tr-nh-C-2-NET102-P207_Lab\7_IT16312_NET102\BAI_2.7_THAO_TAC_VOI_TAP_TIN_System.IO\Text1.txt";
            Console.WriteLine(File.ReadAllText(path));

            string temp = "Hoc C# vui khong?";
            File.WriteAllText(path, temp);
            Console.WriteLine(File.ReadAllText(path));
        }

        static void FileStream()
        {
            #region Tham khảo các phương thức
            /*
             * Methods                          Description            
            Read()/ ReadByte()              Read a sequence of bytes from the current stream.
            Write()/WriteByte()             Write a sequence of bytes to the current stream.
            Seek()                          Sets the position in the current stream.
            Position()                      Determine the current position in the current stream.
            Length()                        Return the length of the stream in bytes.
            Flush()                         Updates the underlying data source with the current state of the buffer and then clears the buffer.
            Close()                         Closes the current stream and releases any associated stream resources.
             */
            #endregion
            //FileStream chỉ có thể đọc hoặc ghi một byte hoặc một mảng byte. Bạn sẽ được yêu cầu mã hóa kiểu System.String thành một mảng byte tương ứng. Không gian tên System.Text xác định một kiểu mã hóa được đặt tên cung cấp các thành viên mã hóa và giải mã chuỗi thành một mảng byte. Sau khi được mã hóa, mảng byte được lưu giữ trong một tệp có phương thức FileStream.Write (). Để đọc lại các byte vào bộ nhớ, bạn phải đặt lại vị trí bên trong của luồng và gọi phương thức ReadByte (). Cuối cùng, bạn hiển thị mảng byte thô và chuỗi đã giải mã ra bảng điều khiển.
            using (FileStream fs = new FileStream(@"D:\dungna.doc", FileMode.Create))
            {
                string msg = "Hoc C# co kho khong 2021";
                byte[] byteArray = Encoding.Default.GetBytes(msg);
                fs.Write(byteArray, 0, byteArray.Length);
                fs.Position = 0;

                byte[] rFile = new byte[byteArray.Length];

                for (int i = 0; i < byteArray.Length; i++)
                {
                    rFile[i] = (byte)fs.ReadByte();//Đọc lên theo kiểu byte
                    Console.WriteLine(rFile[i]);
                }

                Console.WriteLine(Encoding.Default.GetString(rFile));
                fs.Close();//Đóng luồng
            }
        }

        #endregion

        #region BinaryReader & BinaryWriter

        #region Các phương thức
        /*
         * Write  - Write the value to current stream   - BinaryWriter
         * Seek   - Set the position in the current stream   - BinaryWriter
           Close  - Close the binary reader   - BinaryWriter
           Flush  - Flush the binary stream   - BinaryWriter
           PeekChar  - Return the next available character without advancing the position in the stream   - BinaryReader
           Read   - Read a specified set of bytes or characters and store them in the incoming array.   - BinaryReader
         */
        #endregion

        static void BinaryWriter()
        {
            //Lớp BinaryReader và Writer cho phép bạn đọc và ghi các kiểu dữ liệu rời rạc vào một dòng bên dưới ở định dạng nhị phân
            // writing   
            FileInfo fi = new FileInfo("champu.dat");
            using (BinaryWriter bw = new BinaryWriter(fi.OpenWrite()))
            {
                int x = 007;
                string str = "hello champu ,one day you will become doomkatu";

                bw.Write(x);
                bw.Write(str);
            }

            //Reading  
            FileInfo f = new FileInfo("champu.dat");
            using (BinaryReader br = new BinaryReader(fi.OpenRead()))
            {
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
            }
            Console.ReadLine();
        }

        #endregion

        #region StringReader & StringWriter

        static void StringWriterStringReader()
        {
            //StringWriter và StringReader để xử lý thông tin dạng văn bản như một dòng các ký tự trong bộ nhớ. Điều này có thể hữu ích khi bạn muốn nối thông tin dựa trên ký tự vào bộ đệm

            // writing   
            using (StringWriter sw = new StringWriter())
            {
                sw.WriteLine("helloooooooooooooooooooo");

                // Reading  
                using (StringReader sr = new StringReader(sw.ToString()))
                {
                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(input);
                    }
                }
            }
        }


        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
