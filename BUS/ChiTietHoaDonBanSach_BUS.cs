using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class ChiTietHoaDonBanSach_BUS
    {
        private static ChiTietHoaDonBanSach_BUS instance;
        private ChiTietHoaDonBanSach_BUS()
        {
        }
        public static ChiTietHoaDonBanSach_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoaDonBanSach_BUS();
                return ChiTietHoaDonBanSach_BUS.instance;
            }
            private set
            {
                ChiTietHoaDonBanSach_BUS.instance = value;
            }
        }

        public DataTable selectInfoChiTietHoaDonBanSachByMaHD(string mahd)
        {
            return ChiTietHoaDonBanSach_DAO.Instance.selectInfoChiTietHoaDonBanSachByMaHD(mahd);
        }
        public bool insertChiTietHoaDonBanSach(ChiTietHoaDonBanSach_DTO cthd)
        {
            if (cthd.MaSach != string.Empty && cthd.MaHoaDon != string.Empty)
                return ChiTietHoaDonBanSach_DAO.Instance.insertChiTietHoaDonBanSach(cthd);
            return false;
        }
        public bool updateChiTietHoaDonBanSach(ChiTietHoaDonBanSach_DTO cthd)
        {
            if (cthd.MaSach != string.Empty && cthd.MaHoaDon != string.Empty)
                return ChiTietHoaDonBanSach_DAO.Instance.updateChiTietHoaDonBanSach(cthd);
            return false;
        }
        public bool deleteChiTietHoaDonBanSach(ChiTietHoaDonBanSach_DTO cthd)
        {
            if (cthd.MaSach != string.Empty && cthd.MaHoaDon != string.Empty)
                return ChiTietHoaDonBanSach_DAO.Instance.deleteChiTietHoaDonBanSach(cthd);
            return false;
        }
    }
}
