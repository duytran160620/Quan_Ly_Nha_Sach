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
    public class PhieuThuTien_BUS
    {
        private static PhieuThuTien_BUS instance;
        private PhieuThuTien_BUS()
        {
        }
        public static PhieuThuTien_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuThuTien_BUS();
                return PhieuThuTien_BUS.instance;
            }
            private set
            {
                PhieuThuTien_BUS.instance = value;
            }
        }
        public DataTable selectAllData()
        {
            return PhieuThuTien_DAO.Instance.selectAllData();
        }
        public int tinhSoTienThu(string mahd, string makh)
        {
            return PhieuThuTien_DAO.Instance.tinhSoTienThu(mahd, makh);
        }
        public int thanhToanTienNoCuaKhachHang(string mahd, string makh)
        {
            return PhieuThuTien_DAO.Instance.thanhToanTienNoCuaKhachHang(mahd, makh);
        }
        public bool insertPhieuThuTien(PhieuThuTien_DTO pt)
        {
            if (pt.MaPhieuTien != string.Empty && pt.MaKhachHang != string.Empty)
                return PhieuThuTien_DAO.Instance.insertPhieuThuTien(pt);
            return false;
        }
        public bool updatePhieuThuTien(PhieuThuTien_DTO pt)
        {
            if (pt.MaPhieuTien != string.Empty && pt.MaKhachHang != string.Empty)
                return PhieuThuTien_DAO.Instance.updatePhieuThuTien(pt);
            return false;
        }
        public bool deletePhieuThuTien(PhieuThuTien_DTO pt)
        {
            if (pt.MaPhieuTien != string.Empty && pt.MaKhachHang != string.Empty)
                return PhieuThuTien_DAO.Instance.deletePhieuThuTien(pt);
            return false;
        }
        
    }
}
