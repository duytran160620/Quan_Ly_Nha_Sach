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
        private int nam;

        public int Nam
        {
            get
            {
                return nam;
            }
            set
            {
                nam = value;
            }
        }
        public BaoCaoCongNo_DTO()
        {
            this.mabaocaocongno = "";
            this.thang = 0;
            this.nam = 0;
        }

        public BaoCaoCongNo_DTO(string mabaocaocongno, int thang, int nam)
        {
            this.mabaocaocongno = mabaocaocongno;
            this.thang = thang;
            this.nam = nam;
        }
    }
}
