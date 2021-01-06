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
    public class ChiTietBaoCaoCongNo_BUS
    {
        private static ChiTietBaoCaoCongNo_BUS instance;
        private ChiTietBaoCaoCongNo_BUS()
        {
        }
        public static ChiTietBaoCaoCongNo_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietBaoCaoCongNo_BUS();
                return ChiTietBaoCaoCongNo_BUS.instance;
            }
            private set
            {
                ChiTietBaoCaoCongNo_BUS.instance = value;
            }
        }

        public DataTable selectChiTietBaoCaoCongNoByMaBaoCao(string mabaocaocongno)
        {
            return ChiTietBaoCaoCongNo_DAO.Instance.selectChiTietBaoCaoCongNoByMaBaoCao(mabaocaocongno);
        }
        
        public bool insertChiTietBaoCaoCongNo(ChiTietBaoCaoCongNo_DTO ct)
        {
            if (ct.MaBaoCaoCongNo != string.Empty && ct.MaKhachHang != string.Empty)
                return ChiTietBaoCaoCongNo_DAO.Instance.insertChiTietBaoCaoCongNo(ct);
            return false;
        }
        public bool updateChiTietBaoCaoCongNo(ChiTietBaoCaoCongNo_DTO ct)
        {
            if (ct.MaBaoCaoCongNo != string.Empty && ct.MaKhachHang != string.Empty)
                return ChiTietBaoCaoCongNo_DAO.Instance.updateChiTietBaoCaoCongNo(ct);
            return false;
        }
        public bool deleteChiTietBaoCaoCongNo(ChiTietBaoCaoCongNo_DTO ct)
        {
            if (ct.MaBaoCaoCongNo != string.Empty && ct.MaKhachHang != string.Empty)
                return ChiTietBaoCaoCongNo_DAO.Instance.deleteChiTietBaoCaoCongNo(ct);
            return false;
        }
    }
}
