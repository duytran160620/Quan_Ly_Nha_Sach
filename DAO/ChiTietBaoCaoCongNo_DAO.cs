using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class ChiTietBaoCaoCongNo_DAO
    {
        private static ChiTietBaoCaoCongNo_DAO instance;
        private ChiTietBaoCaoCongNo_DAO()
        {
        }
        public static ChiTietBaoCaoCongNo_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietBaoCaoCongNo_DAO();
                return ChiTietBaoCaoCongNo_DAO.instance;
            }
            private set
            {
                ChiTietBaoCaoCongNo_DAO.instance = value;
            }
        }

        public DataTable selectChiTietBaoCaoCongNoByMaBaoCao(string mabaocaocongno)
        {
            string query = "select ct.MaKhachHang, ct.SoNoDau, ct.PhatSinh, ct.SoNoCuoi from CHITIETBAOCAOCONGNO ct where ct.MaBaoCaoCongNo = @mabaocaocongno";
            object[] parameters = new object[] { mabaocaocongno };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable baoCaoCongNo(int thang, int nam)
        {
            string query = "SET DATEFORMAT dmy; select hd.MaKhachHang, kh.TienNo as SoNoDau, (sum(ct.SoLuongBan * ct.DonGiaBan) - ptt.SoTienThu) as PhatSinh, (kh.TienNo + (sum(ct.SoLuongBan * ct.DonGiaBan) - ptt.SoTienThu)) as SoNoCuoi from HOADONBANSACH hd join CHITIETHOADONBANSACH ct on hd.MaHoaDon = ct.MaHoaDon join PHIEUTHUTIEN ptt on hd.MaKhachHang = ptt.MaKhachHang join KHACHHANG kh on kh.MaKhachHang = ptt.MaKhachHang where month(hd.NgayLapHoaDon) = @thang and year(hd.NgayLapHoaDon) = @nam group by ptt.SoTienThu, hd.MaKhachHang, kh.TienNo";
            object[] parameters = new object[] { thang, nam };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable selectCTBaoCaoCongNobyMaBaoCao(string mabc)
        {
            string query = "select ct.MaKhachHang, ct.SoNoDau, ct.PhatSinh ,ct.SoNoCuoi from CHITIETBAOCAOCONGNO ct where ct.MaBaoCaoCongNo = @mabc";
            object[] parameters = new object[] { mabc };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public bool insertChiTietBaoCaoCongNo(ChiTietBaoCaoCongNo_DTO ct)
        {
            string query = "insert into CHITIETBAOCAOCONGNO values (@mabaocaocongno, @makh, @nodau, @phatsinh, @nocuoi)";
            object[] parameters = new object[]
            {
                ct.MaBaoCaoCongNo,
                ct.MaKhachHang,
                ct.SoNoDau,
                ct.PhatSinh,
                ct.SoNoCuoi,
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateChiTietBaoCaoCongNo(ChiTietBaoCaoCongNo_DTO ct)
        {
            string query = "update CHITIETBAOCAOCONGNO set SoNoDau = @nodau, PhatSinh = @phatsinh, SoNoCuoi = @toncuoi where MaBaoCaoCongNo = @mabaocaocongno and MaKhachHang = @makh";
            object[] parameters = new object[]
            {
                ct.SoNoDau,
                ct.PhatSinh,
                ct.SoNoCuoi,
                ct.MaBaoCaoCongNo,
                ct.MaKhachHang
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteChiTietBaoCaoCongNo(ChiTietBaoCaoCongNo_DTO ct)
        {
            string query = "delete from CHITIETBAOCAOCONGNO where MaBaoCaoCongNo = @mabaocaocongno and MaKhachHang = @makh";
            object[] parameters = new object[]
            {
                ct.MaBaoCaoCongNo,
                ct.MaKhachHang
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
