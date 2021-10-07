using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._9_DocGhiDoiTuong
{
    [Serializable]
    public class Vaccine
    {
        private string mVc;
        private string tenVc;
        private bool status;

        public Vaccine()
        {

        }

        public Vaccine(string mVc, string tenVc, bool status)
        {
            this.mVc = mVc;
            this.tenVc = tenVc;
            this.status = status;
        }

        public string MVc
        {
            get => mVc;
            set => mVc = value;
        }

        public string TenVc
        {
            get => tenVc;
            set => tenVc = value;
        }

        public bool Status
        {
            get => status;
            set => status = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine($"{MVc} {TenVc} {(status == true ? "Hoạt động" : "Không hoạt động")}");
        }
    }
}
