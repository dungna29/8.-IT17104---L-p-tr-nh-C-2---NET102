using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class MayTinhDeBan:MayTinh
    {
        //Phần 1: Khai báo các thuộc tính mà đối tượng cần
        private string loaiVoCase;

        //Phần 2: Contructor
        public MayTinhDeBan()
        {
            
        }

        public MayTinhDeBan(int id, string ten, double giaTien, int soLuong, string loaiVoCase) : base(id, ten, giaTien, soLuong)
        {
            this.loaiVoCase = loaiVoCase;
        }

        //Phần 3: Property
        public string LoaiVoCase
        {
            get => loaiVoCase;
            set => loaiVoCase = value;
        }

        //Phần 4: Các Method của đối tượng
        public override void inRaManHinh()
        {
            Console.WriteLine("ID: {0} Tên: {1} Giá Tiền: {2} Số lượng: {3} Vỏ Case: {4}",Id,Ten,GiaTien,SoLuong,loaiVoCase);
        }

    }
}
