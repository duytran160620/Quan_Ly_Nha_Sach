using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapSach_DTO
    {
        private string maphieunhap;

        public string MaPhieuNhap
        {
            get
            {
                return maphieunhap;
            }
            set
            {
                maphieunhap = value;
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
        private int soluongnhap;

        public int SoLuongNhap
        {
            get
            {
                return soluongnhap;
            }
            set
            {
                soluongnhap = value;
            }
        }
        public ChiTietPhieuNhapSach_DTO()
        {
            this.maphieunhap = "";
            this.masach = "";
            this.soluongnhap = 0;
        }
        public ChiTietPhieuNhapSach_DTO(string maphieunhap, string masach, int soluongnhap)
        {
            this.maphieunhap = maphieunhap;
            this.masach = masach;
            this.soluongnhap = soluongnhap;
        }
    }
}
