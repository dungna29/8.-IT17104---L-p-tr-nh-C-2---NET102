using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._9_DocGhiDoiTuong
{
    class VaccineService
    {
        private List<Vaccine> _lstVaccines;
        private FileStream _fs;
        private BinaryFormatter _bf;

        public VaccineService()
        {
            _lstVaccines = new List<Vaccine>();
        }
        //Ghi dữ liệu vào file thì phải biết file đó nằm ở đâu và dữ liệu muốn ghi vào là dữ liệu nào
        public void ghiFile(string path,List<Vaccine> lstVaccines)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();//Khởi tạo
            _bf.Serialize(_fs, lstVaccines);//Serialize Tuần tự hóa hoặc tuần tự hóa là quá trình dịch cấu trúc dữ liệu hoặc trạng thái đối tượng sang định dạng có thể được lưu trữ hoặc truyền và tái tạo lại sau này.
            _fs.Close();
        }

        public void docFile(string path)
        {
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();//Khởi tạo
            var data = _bf.Deserialize(_fs);//Đọc đối tượng lên
            _lstVaccines = new List<Vaccine>();
            _lstVaccines =(List<Vaccine>) data;//Gán lại list Object cho List Vaccine
            _fs.Close();
        }

        public List<Vaccine> GetLstVaccines()
        {
            return _lstVaccines;
        }
    }
}
