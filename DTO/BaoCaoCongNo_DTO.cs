using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoCongNo_DTO
    {
        private string mabaocaocongno;

        public string MaBaoCaoCongNo
        {
            get
            {
                return mabaocaocongno;
            }
            set
            {
                mabaocaocongno = value;
            }
        }
        private int thang;

        public int Thang
        {
            get
            {
                return thang;
            }
            set
            {
                thang = value;
            }
        }

        public BaoCaoCongNo_DTO()
        {
            this.mabaocaocongno = "";
            this.thang = 0;
        }

        public BaoCaoCongNo_DTO(string mabaocaocongno, int thang)
        {
            this.mabaocaocongno = mabaocaocongno;
            this.thang = thang;
        }
    }
}
