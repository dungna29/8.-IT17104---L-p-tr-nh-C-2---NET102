using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    // Lớp cha sẽ chứa các thuộc tính chung và phương thức chung
    class MayTinh
    {
        // Phần 1: Các cần có của đối tượng
        private int id;
        private string ten;
        private double giaTien;
        private int soLuong;

        //Phần 2: Contructor
        //a) Contructor không tham số ctor + tab
        public MayTinh()
        {
            
        }
        //b) Contructor có tham số đối với các bạn cài Resharper Alt + Insert
        // Chuột phải class --> Quick Actions..... --> Generate Contructor
        public MayTinh(int id, string ten, double giaTien, int soLuong)
        {
            this.id = id;
            this.ten = ten;
            this.giaTien = giaTien;
            this.soLuong = soLuong;
        }

        //Phần 3: Property dùng để lấy và gán dữ liệu do các thuộc tính bị private
        // Bôi đen toàn bộ phần thuộc tính đối tượng --> Chuột phải --> Quick Actions -->Encapsulate fields số 1
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public double GiaTien
        {
            get => giaTien;
            set => giaTien = value;
        }

        public int SoLuong
        {
            get => soLuong;
            set => soLuong = value;
        }
        //Phần 4: Các Method của đối tượng
        public virtual void inRaManHinh()//từ khóa virtual giúp lớp con có thể kế thừa lại phương thức lớp cha
        {
            //cw +  tab để gọi in ra màn hình nhanh
            Console.WriteLine("Phương thức của lớp cha inRaManHinh()");
        }
    }
}
