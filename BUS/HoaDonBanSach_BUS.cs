using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDonBanSach_BUS
    {
        private static HoaDonBanSach_BUS instance;
        private HoaDonBanSach_BUS()
        {

        }
        public static HoaDonBanSach_BUS Instance
        {
            get
            {
                if(instance == null)
                    instance = new HoaDonBanSach_BUS();
                return HoaDonBanSach_BUS.instance;
            }
            private set
            {
                HoaDonBanSach_BUS.instance = value;
            }
        }


        public DataTable selectAllHoaDon()
        {
            return HoaDonBanSach_DAO.Instance.selectAllHoaDon();
        }
        public DataTable selectMaHoaDon()
        {
            return HoaDonBanSach_DAO.Instance.selectMaHoaDon();
        }
        public DataTable selectMaKHByMaHD(string mahd)
        {
            if (mahd != string.Empty)
                return HoaDonBanSach_DAO.Instance.selectMaKHByMaHD(mahd);
            return null;
        }
        public DataTable selectInfoKhachHangByMaHD(string mahd)
        {
            if (mahd != string.Empty)
                return HoaDonBanSach_DAO.Instance.selectInfoKhachHangByMaHD(mahd);
            return null;
        }
        public bool insertHoaDon(HoaDonBanSach_DTO hd)
        {
            if(hd.MaHoaDon != string.Empty && hd.MaKhachHang != string.Empty)
                return HoaDonBanSach_DAO.Instance.insertHoaDon(hd);
            return false;
        }
        public bool updateHoaDon(HoaDonBanSach_DTO hd)
        {
            if (hd.MaHoaDon != string.Empty && hd.MaKhachHang != string.Empty)
                return HoaDonBanSach_DAO.Instance.updateHoaDon(hd);
            return false;
        }
        public bool deleteHoaDon(HoaDonBanSach_DTO hd)
        {
            if (hd.MaHoaDon != string.Empty && hd.MaKhachHang != string.Empty)
                return HoaDonBanSach_DAO.Instance.deleteHoaDon(hd);
            return false;
        }
    }
}
