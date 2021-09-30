using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._9_DINH_NGHIA_CLASS_EXCEPTION
{
    class FpolyException:Exception
    {

        public FpolyException(string? message) : base(message)
        {
        }
    }
}
