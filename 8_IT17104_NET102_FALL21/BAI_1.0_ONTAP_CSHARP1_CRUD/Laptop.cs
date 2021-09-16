using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    /*
     * 1. Tạo ra 1 đối tượng Laptop
     * 2. Trong class gồm 3:
     *      Phần 1: Thuộc tính
     *      Phần 2: Contructor phải có 2 loại có tham số và không tham số
     *      Phần 3: Property
     *      Phần 4: Method
     *
     * Mục đích kế thừa: Dùng để kế thừa các thuộc tính và phương thức có sẵn của lớp cha
     */
    class Laptop:MayTinh
    {
        //Phần 1: Khai báo các thuộc tính mà đối tượng cần
        //Khi kế thừa lớp con chỉ còn lại các thuộc tính đặc trưng riêng để miêu tả rõ hơn về đối tượng
        private double trongLuong;
        private string nXS;

        //Phần 2: Contructor dùng để khởi tạo 1 đối tượng
        //a) Contructor không tham số ctor + tab
        public Laptop()
        {
            
        }
        //Contructor có tham số dùng để tạo 1 đối tượng có giá trị ban đầu
        //b) Contructor có tham số đối với các bạn cài Resharper Alt + Insert
        // Chuột phải class con--> Quick Actions..... --> Generate Contructor 
        // Sau khi có Contrucotr bao gồm cả của lớp cha sẽ tiến hành bôi đen toàn bộ thuộc tính của class con Chuột phải --> Quick Actions..... --> Add param... vào contructor
        public Laptop(int id, string ten, double giaTien, int soLuong, double trongLuong, string nXs) : base(id, ten, giaTien, soLuong)
        {
            this.trongLuong = trongLuong;
            nXS = nXs;
            //this: Tham chiếu đến thuộc tính và phương thức của lớp hiện tại
            //base: Tham chiếu đến thuộc tính và phương thức của lớp cha
        }

        //Phần 3: Triển khai property của đối tượng
        public double TrongLuong
        {
            get => trongLuong;
            set => trongLuong = value;
        }

        public string NXs
        {
            get => nXS;
            set => nXS = value;
        }
        //Phần 4: Phương riêng của đối tượng hoặc kế thừa từ lớp cha
        //Chuột phải vào lớp con chọn -->Quick Action -->  Generate override chỉ chọn phương thức kế thừa
        //Ghi đè (Overriding): Là lớp con sẽ kế thừa phương thức lớp cha và được phép code lại bên trong với nghiệp vụ khác. Nhưng phải giống lớp cha về kiểu phương thức, tên phương thức và tham số truyền vào
        public override void inRaManHinh()
        {
            //base.inRaManHinh();
            Console.WriteLine("ID: {0} Tên: {1} Giá Tiền: {2} Số lượng: {3} Trọng Lượng: {4} NXS: {5}", Id, Ten, GiaTien, SoLuong, trongLuong,nXS);
        }
    }
}
