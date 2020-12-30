using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach_DTO
    {
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

        private string tensach;

        public string TenSach
        {
            get
            {
                return tensach;
            }
            set
            {
                tensach = value;
            }
        }
        private string theloai;

        public string TheLoai
        {
            get
            {
                return theloai;
            }
            set
            {
                theloai = value;
            }
        }
        private string tacgia;

        public string TacGia
        {
            get
            {
                return tacgia;
            }
            set
            {
                tacgia = value;
            }
        }
        private int soluongton;

        public int SoLuongTon
        {
            get
            {
                return soluongton;
            }
            set
            {
                soluongton = value;
            }
        }
        private int dongiaban;

        public int DonGiaBan
        {
            get
            {
                return dongiaban;
            }
            set
            {
                dongiaban = value;
            }
        }
        public Sach_DTO()
        {
            this.masach = "";
            this.tensach = "";
            this.theloai = "";
            this.tacgia = "";
            this.soluongton = 0;
            this.dongiaban = 0;
        }
        public Sach_DTO(string masach, string tensach, string theloai, string tacgia, int soluongton, int dongiaban)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.theloai = theloai;
            this.tacgia = tacgia;
            this.soluongton = soluongton;
            this.dongiaban = dongiaban;
        }

    }
}
