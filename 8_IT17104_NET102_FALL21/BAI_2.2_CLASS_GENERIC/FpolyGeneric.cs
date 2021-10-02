using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._2_CLASS_GENERIC
{
    class FpolyGeneric<G>
    {
        private G[] arrs;//Mảng ko xác định kiểu

        public FpolyGeneric(int size)//Khi khởi tạo lớp bắt buộc phải khởi kích thước mảng
        {
            arrs = new G[size];
        }

        public G[] Arrs
        {
            get => arrs;
            set => arrs = value;
        }
        //Phương thức thêm phần tử vào trong mảng
        public void addValueByIndex(int index, G value)
        {
            if (index < 0 || index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }

            arrs[index] = value;
        }
        //Phương thức lấy giá trị theo index
        public G getValueByIndex(int index)
        {
            if (index < 0 || index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return arrs[index];
        }
    }
}
