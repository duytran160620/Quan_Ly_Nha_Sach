using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoTon_DTO
    {
        private string mabaocaoton;

        public string MaBaoCaoTon
        {
            get
            {
                return mabaocaoton;
            }
            set
            {
                mabaocaoton = value;
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

        public BaoCaoTon_DTO()
        {
            this.mabaocaoton = "";
            this.thang = 0;
        }
        public BaoCaoTon_DTO(string mabaocaoton, int thang)
        {
            this.mabaocaoton = mabaocaoton;
            this.thang = thang;
        }
    }
}
