using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonBanSach_DTO
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
        private int soluongban;

        public int SoLuongBan
        {
            get
            {
                return soluongban;
            }
            set
            {
                soluongban = value;
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
        public ChiTietHoaDonBanSach_DTO()
        {
            this.mahoadon = "";
            this.masach = "";
            this.soluongban = 0;
            this.dongiaban = 0;
        }
        public ChiTietHoaDonBanSach_DTO(string mahoadon, string masach, int soluongban, int dongiaban)
        {
            this.mahoadon = mahoadon;
            this.masach = masach;
            this.soluongban = soluongban;
            this.dongiaban = dongiaban;
        }
    }
}
