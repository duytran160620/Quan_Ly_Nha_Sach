using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class ChiTietHoaDonBanSach_DAO
    {
        private static ChiTietHoaDonBanSach_DAO instance;
        private ChiTietHoaDonBanSach_DAO()
        {
        }
        public static ChiTietHoaDonBanSach_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoaDonBanSach_DAO();
                return ChiTietHoaDonBanSach_DAO.instance;
            }
            private set
            {
                ChiTietHoaDonBanSach_DAO.instance = value;
            }
        }

        public DataTable selectInfoChiTietHoaDonBanSachByMaHD(string mahd)
        {
            string query = "select s.MaSach, s.TenSach, s.TheLoai, s.TacGia, cthd.SoLuongBan, cthd.DonGiaBan from CHITIETHOADONBANSACH cthd join SACH s on cthd.MaSach = s.MaSach where cthd.MaHoaDon = @mahd";
            object[] parameters = new object[] { mahd };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public bool insertChiTietHoaDonBanSach(ChiTietHoaDonBanSach_DTO cthd)
        {
            string query = "insert into CHITIETHOADONBANSACH values (@mahd, @masach, @soluongban, @dongiaban)";
            object[] parameters = new object[] 
            {
                cthd.MaHoaDon,
                cthd.MaSach,
                cthd.SoLuongBan,
                cthd.DonGiaBan
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateChiTietHoaDonBanSach(ChiTietHoaDonBanSach_DTO cthd)
        {
            string query = "update CHITIETHOADONBANSACH set SoLuongBan = @soluongban , DonGiaBan = @dongiaban where MaHoaDon = @mahd and MaSach = @masach";
            object[] parameters = new object[] 
            {
                cthd.SoLuongBan,
                cthd.DonGiaBan,
                cthd.MaHoaDon,
                cthd.MaSach
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteChiTietHoaDonBanSach(ChiTietHoaDonBanSach_DTO cthd)
        {
            string query = "delete from CHITIETHOADONBANSACH where MaHoaDon = @mahd and MaSach = @masach";
            object[] parameters = new object[] 
            {
                cthd.MaHoaDon,
                cthd.MaSach
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        

    }
}
