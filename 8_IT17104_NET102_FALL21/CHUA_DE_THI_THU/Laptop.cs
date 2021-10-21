using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUA_DE_THI_THU
{
    [Serializable]//Chưa code cần code cái gì là phải code ngay cái này
    class Laptop
    {
        private int maLapTop;
        private string ten;
        private double trongLuong;

        public Laptop()
        {
            
        }

        public Laptop(int maLapTop, string ten, double trongLuong)
        {
            this.maLapTop = maLapTop;
            this.ten = ten;
            this.trongLuong = trongLuong;
        }

        public int MaLapTop
        {
            get => maLapTop;
            set => maLapTop = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public double TrongLuong
        {
            get => trongLuong;
            set => trongLuong = value;
        }

        public void InRaManHinh()
        {
            Console.WriteLine($"{maLapTop} {ten} {trongLuong}");
        }
    }
}
