using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapSach_DTO
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
        private string ngaynhap;

        public string NgayNhap
        {
            get
            {
                return ngaynhap;
            }
            set
            {
                ngaynhap = value;
            }
        }
        public PhieuNhapSach_DTO()
        {
            this.maphieunhap = "";
            this.ngaynhap = "";
        }
        public PhieuNhapSach_DTO(string maphieunhap, string ngaynhap)
        {
            this.maphieunhap = maphieunhap;
            this.ngaynhap = ngaynhap;
        }
    }
}
