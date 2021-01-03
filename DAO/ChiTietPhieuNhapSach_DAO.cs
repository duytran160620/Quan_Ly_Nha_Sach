using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChiTietPhieuNhapSach_DAO
    {
        private static ChiTietPhieuNhapSach_DAO instance;
        private ChiTietPhieuNhapSach_DAO(){}
        public static ChiTietPhieuNhapSach_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuNhapSach_DAO();
                return ChiTietPhieuNhapSach_DAO.instance;
            }
            private set
            {
                ChiTietPhieuNhapSach_DAO.instance = value;
            }
        }

        public DataTable selectInfoCTPhieuNhap(ChiTietPhieuNhapSach_DTO ctpn)
        {
            string query = "select sach.MaSach, ct.SoLuongNhap, sach.TenSach, sach.TheLoai, sach.TacGia,  sach.SoLuongTon, sach.DonGiaBan from CHITIETPHIEUNHAPSACH ct join SACH sach on ct.MaSach = sach.MaSach where ct.MaPhieuNhap = @mapn";
            object[] parameters = new object[] { ctpn.MaPhieuNhap};
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public bool insertChiTietPhieuNhapSach(ChiTietPhieuNhapSach_DTO ctpn)
        {
            string query = "INSERT INTO CHITIETPHIEUNHAPSACH VALUES (@mapn, @masach, @soluongnhap)";
            object[] parameters = new object[] 
            { 
                ctpn.MaPhieuNhap,
                ctpn.MaSach,
                ctpn.SoLuongNhap
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateChiTietPhieuNhapSach(ChiTietPhieuNhapSach_DTO ctpn)
        {
            string query = "UPDATE CHITIETPHIEUNHAPSACH SET  SoLuongNhap = @soluongnhap WHERE MaPhieuNhap = @mapn and MaSach = @masach";
            object[] parameters = new object[] 
            { 
                ctpn.SoLuongNhap,
                ctpn.MaPhieuNhap,
                ctpn.MaSach
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteChiTietPhieuNhapSach(ChiTietPhieuNhapSach_DTO ctpn)
        {
            string query = "delete from CHITIETPHIEUNHAPSACH where MaPhieuNhap = @mapn and MaSach = @masach";
            object[] parameters = new object[] 
            { 
                ctpn.MaPhieuNhap,
                ctpn.MaSach
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
