using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class ChiTietBaoCaoTon_DAO
    {
        private static ChiTietBaoCaoTon_DAO instance;
        private ChiTietBaoCaoTon_DAO()
        {
        }
        public static ChiTietBaoCaoTon_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietBaoCaoTon_DAO();
                return ChiTietBaoCaoTon_DAO.instance;
            }
            private set
            {
                ChiTietBaoCaoTon_DAO.instance = value;
            }
        }

        public bool setDateFormat()
        {
            return DataProvider.Instance.setFormatDate();
        }
        public DataTable selectCTBaoCaoTonByMaBaoCaoTon(string mabaocaoton)
        {
            string query = "select ct.MaSach, ct.SoLuongTonDau, ct.PhatSinh, ct.SoLuongTonCuoi from CHITIETBAOCAOTON ct where MaBaoCaoTon = @mabaocaoton";
            object[] parameters = new object[] { mabaocaoton };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable baoCaoTon(int thang, int nam)
        {
            string query = "set DATEFORMAT dmy; select  ct.MaSach, s.SoLuongTon as SoLuongTonDau , sum(ct.SoLuongBan) as PhatSinh, (s.SoLuongTon - sum(ct.SoLuongBan)) as SoLuongTonCuoi from HOADONBANSACH hd join CHITIETHOADONBANSACH ct on hd.MaHoaDon = ct.MaHoaDon join SACH s on s.MaSach = ct.MaSach where month(hd.NgayLapHoaDon) = @thang and year(hd.NgayLapHoaDon) = @nam group by ct.MaSach, s.SoLuongTon";
            object[] parameters = new object[] 
            { 
                thang,
                nam
            };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        
        public bool insertChiTietBaoCaoTon(ChiTietBaoCaoTon_DTO ct)
        {
            string query = "insert into CHITIETBAOCAOTON values (@mabaocaoton, @masach, @tondau, @phatsinh, @toncuoi)";
            object[] parameters = new object[] 
            {
                ct.MaBaoCaoTon,
                ct.MaSach,
                ct.SoLuongTonDau,
                ct.PhatSinh,
                ct.SoLuongTonCuoi
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateChiTietBaoCaoTon(ChiTietBaoCaoTon_DTO ct)
        {
            string query = "update CHITIETBAOCAOTON set SoLuongTonDau = @tondau, PhatSinh = @phatsinh, SoLuongTonCuoi = @toncuoi where MaBaoCaoTon = @mabaocaoton and MaSach = @masach";
            object[] parameters = new object[] 
            {
                ct.SoLuongTonDau,
                ct.PhatSinh,
                ct.SoLuongTonCuoi,
                ct.MaBaoCaoTon,
                ct.MaSach
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteChiTietBaoCaoTon(ChiTietBaoCaoTon_DTO ct)
        {
            string query = "delete from CHITIETBAOCAOTON where MaBaoCaoTon = @mabaocaoton and MaSach = @masach";
            object[] parameters = new object[] 
            {
                ct.MaBaoCaoTon,
                ct.MaSach
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
