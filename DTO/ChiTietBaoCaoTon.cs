using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietBaoCaoTon_DTO
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
        private string masach;

        public string MaSach
        {
            get
            {
                return masach;
            }
            set
            {
                masach = value;
            }
        }
        private int soluongtondau;

        public int SoLuongTonDau
        {
            get
            {
                return soluongtondau;
            }
            set
            {
                soluongtondau = value;
            }
        }
        private int phatsinh;

        public int PhatSinh
        {
            get
            {
                return phatsinh;
            }
            set
            {
                phatsinh = value;
            }
        }
        private int soluongtoncuoi;

        public int SoLuongTonCuoi
        {
            get
            {
                return soluongtoncuoi;
            }
            set
            {
                soluongtoncuoi = value;
            }
        }
        public ChiTietBaoCaoTon_DTO()
        {
            this.mabaocaoton = "";
            this.masach = "";
            this.soluongtondau = 0;
            this.phatsinh = 0;
            this.soluongtoncuoi = 0;
        }
        public ChiTietBaoCaoTon_DTO(string mabaocaoton, string masach, int soluongtondau, int phatsinh, int soluongtoncuoi)
        {
            this.mabaocaoton = mabaocaoton;
            this.masach = masach;
            this.soluongtondau = soluongtondau;
            this.phatsinh = phatsinh;
            this.soluongtoncuoi = soluongtoncuoi;
        }
    }
}
