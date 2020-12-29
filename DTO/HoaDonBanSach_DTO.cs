using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBanSach_DTO
    {
        private string mahoadon;

        public string MaHoaDon
        {
            get
            {
                return mahoadon;
            }
            set
            {
                mahoadon = value;
            }
        }
        private DateTime ngaylaphoadon;

        public DateTime NgayLapHoaDon
        {
            get
            {
                return ngaylaphoadon;
            }
            set
            {
                ngaylaphoadon = value;
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
        public HoaDonBanSach_DTO()
        {
            this.mahoadon = "";
            this.makhachhang = "";
            this.ngaylaphoadon = new DateTime();
        }
        public HoaDonBanSach_DTO(string mahoadon, DateTime ngaylaphoadon, string makhachhang)
        {
            this.mahoadon = mahoadon;
            this.makhachhang = makhachhang;
            this.ngaylaphoadon = ngaylaphoadon;
        }
    }
}
