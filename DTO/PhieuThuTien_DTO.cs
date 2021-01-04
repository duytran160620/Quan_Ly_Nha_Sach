using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuTien_DTO
    {
        private string maphieutien;

        public string MaPhieuTien
        {
            get
            {
                return maphieutien;
            }
            set
            {
                maphieutien = value;
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
        private string ngaythutien;

        public string NgayThuTien
        {
            get
            {
                return ngaythutien;
            }
            set
            {
                ngaythutien = value;
            }
        }
        private int sotienthu;

        public int SoTienThu
        {
            get
            {
                return sotienthu;
            }
            set
            {
                sotienthu = value;
            }
        }
        public PhieuThuTien_DTO()
        {
            this.maphieutien = "";
            this.makhachhang = "";
            this.ngaythutien = "";
            this.sotienthu = 0;
        }
        public PhieuThuTien_DTO(string maphieutien, string makhachhang, string ngaythutien, int sotienthu)
        {
            this.maphieutien = maphieutien;
            this.makhachhang = makhachhang;
            this.ngaythutien = ngaythutien;
            this.sotienthu = sotienthu;
        }
    }
}
