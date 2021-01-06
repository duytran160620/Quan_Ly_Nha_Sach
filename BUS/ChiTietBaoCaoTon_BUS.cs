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
    public class ChiTietBaoCaoTon_BUS
    {
        private static ChiTietBaoCaoTon_BUS instance;
        private ChiTietBaoCaoTon_BUS()
        {
        }
        public static ChiTietBaoCaoTon_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietBaoCaoTon_BUS();
                return ChiTietBaoCaoTon_BUS.instance;
            }
            private set
            {
                ChiTietBaoCaoTon_BUS.instance = value;
            }
        }
        public bool setDateFormat()
        {
            return ChiTietBaoCaoTon_DAO.Instance.setDateFormat();
        }
        public DataTable selectCTBaoCaoTonByMaBaoCaoTon(string mabaocaoton)
        {
            return ChiTietBaoCaoTon_DAO.Instance.selectCTBaoCaoTonByMaBaoCaoTon(mabaocaoton);
        }
        public DataTable baoCaoTon(int thang, int nam)
        {
            return ChiTietBaoCaoTon_DAO.Instance.baoCaoTon(thang, nam);
        }
        public int tinhSoLuongTonCuoi(int tonDau, int phatSinh)
        {
            return tonDau - phatSinh;
        }
        public bool insertChiTietBaoCaoTon(ChiTietBaoCaoTon_DTO ct)
        {
            if (ct.MaBaoCaoTon != string.Empty && ct.MaSach != string.Empty)
                return ChiTietBaoCaoTon_DAO.Instance.insertChiTietBaoCaoTon(ct);
            return false;
        }
        public bool updateChiTietBaoCaoTon(ChiTietBaoCaoTon_DTO ct)
        {
            if (ct.MaBaoCaoTon != string.Empty && ct.MaSach != string.Empty)
                return ChiTietBaoCaoTon_DAO.Instance.updateChiTietBaoCaoTon(ct);
            return false;
        }
        public bool deleteChiTietBaoCaoTon(ChiTietBaoCaoTon_DTO ct)
        {
            if (ct.MaBaoCaoTon != string.Empty && ct.MaSach != string.Empty)
                return ChiTietBaoCaoTon_DAO.Instance.deleteChiTietBaoCaoTon(ct);
            return false;
        }
    }
}
