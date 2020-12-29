using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
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
        private string tenkhachhang;

        public string TenKhachHang
        {
            get
            {
                return tenkhachhang;
            }
            set
            {
                tenkhachhang = value;
            }
        }
        private string email;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        private string sdt;

        public string SDT
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
        private string diachi;

        public string DiaChi
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
        private int tienno;

        public int TienNo
        {
            get
            {
                return tienno;
            }
            set
            {
                tienno = value;
            }
        }
        public KhachHang_DTO()
	    {
            this.makhachhang = "";
            this.tenkhachhang = "";
            this.email = "";
            this.sdt = "";
            this.diachi = "";
            this.tienno = 0;
	    }
        public KhachHang_DTO(string makhachhang, string tenkhachhang, string email, string sdt, string diachi, int tienno)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.email = email;
            this.sdt = sdt;
            this.diachi = diachi;
            this.tienno = tienno;
        }
    }
}
