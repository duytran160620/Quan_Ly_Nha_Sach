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
        private DateTime ngaynhap;

        public DateTime NgayNhap
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
            this.ngaynhap = new DateTime();
        }
        public PhieuNhapSach_DTO(string maphieunhap, DateTime ngaynhap)
        {
            this.maphieunhap = maphieunhap;
            this.ngaynhap = ngaynhap;
        }
    }
}
