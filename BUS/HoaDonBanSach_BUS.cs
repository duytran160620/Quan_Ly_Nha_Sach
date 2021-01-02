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

        public bool insertHoaDon(HoaDonBanSach_DTO hd)
        {
            return HoaDonBanSach_DAO.Instance.insertHoaDon(hd);
        }
        public bool updateHoaDon(HoaDonBanSach_DTO hd)
        {
            return HoaDonBanSach_DAO.Instance.updateHoaDon(hd);
        }
        public bool deleteHoaDon(HoaDonBanSach_DTO hd)
        {
            return HoaDonBanSach_DAO.Instance.deleteHoaDon(hd);
        }
    }
}
