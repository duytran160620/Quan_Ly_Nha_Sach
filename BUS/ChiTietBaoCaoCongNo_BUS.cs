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
        public DataTable selectTongHoaDonVaSoTienThu(string makh, int thang, int nam)
        {
            return ChiTietBaoCaoCongNo_DAO.Instance.selectTongHoaDonVaSoTienThu(makh, thang, nam);
        }
        public int tinhPhatSinhTra(int tienNoDau, int tongHoaDon, int soTienThu)
        {
            if(tienNoDau == 0 && tongHoaDon == soTienThu) // khách hàng này không nợ nhà sách
            {
                return 0;// tiền nợ đầu = 0
            }
            else if(tienNoDau == 0 && tongHoaDon > soTienThu) // khách hàng này có nợ nhà sách, nhưng đã thanh toán nợ
            {
                return tongHoaDon - soTienThu; // = số tiền nợ cũ đã trả
            }
            else if(tienNoDau > 0 && tongHoaDon == soTienThu) // khách hàng này có nơ nhưng không thanh toán
            {
                return tienNoDau; // tiền nợ duầ = tiền nợ cuối
            }
            return -1;
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
