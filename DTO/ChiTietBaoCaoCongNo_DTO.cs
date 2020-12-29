using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietBaoCaoCongNo_DTO
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
        private string makhachhang;

        public string MaKhachHang
        {
            get
            {
                return makhachhang;
            }
            set
            {
                makhachhang = value;
            }
        }
        private int sonodau;

        public int SoNoDau
        {
            get
            {
                return sonodau;
            }
            set
            {
                sonodau = value;
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
        private int sonocuoi;

        public int SoNoCuoi
        {
            get
            {
                return sonocuoi;
            }
            set
            {
                sonocuoi = value;
            }
        }

        public ChiTietBaoCaoCongNo_DTO()
        {
            this.mabaocaocongno = "";
            this.makhachhang = "";
            this.sonodau = 0;
            this.phatsinh = 0;
            this.sonocuoi = 0;
        }
        public ChiTietBaoCaoCongNo_DTO(string mabaocaocongno, string makhachhang, int sonodau, int phatsinh, int sonocuoi)
        {
            this.mabaocaocongno = mabaocaocongno;
            this.makhachhang = makhachhang;
            this.sonodau = sonodau;
            this.phatsinh = phatsinh;
            this.sonocuoi = sonocuoi;
        }
    }
}
