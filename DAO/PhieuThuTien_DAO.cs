using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class PhieuThuTien_DAO
    {
        private static PhieuThuTien_DAO instance;
        private PhieuThuTien_DAO()
        {
        }
        public static PhieuThuTien_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuThuTien_DAO();
                return PhieuThuTien_DAO.instance;
            }
            private set
            {
                PhieuThuTien_DAO.instance = value;
            }
        }

        public int tinhSoTienThu(string mahd, string makh)
        {
            string query = "select dbo.tinhSoTienPhaiThu (@mahd, @makh)";
            object[] parameters = new object[] { mahd, makh };
            return DataProvider.Instance.ExecuteScalar(query, parameters);
        }
        public int thanhToanTienNoCuaKhachHang(string mahd, string makh)
        {
            string query = "select dbo.thanhToanTienNoChoKhachHang (@mahd, @makh)";
            object[] parameters = new object[] { mahd, makh };
            return DataProvider.Instance.ExecuteScalar(query, parameters);
        }
        public DataTable selectAllData()
        {
            return DataProvider.Instance.ExecuteQuery("select * from PHIEUTHUTIEN");
        }

        public bool insertPhieuThuTien(PhieuThuTien_DTO pt)
        {
            string query = "insert into PHIEUTHUTIEN values (@mapt, @makh, @ngaythutien, @sotienthu)";
            object[] parameters = new object[] 
            {
                pt.MaPhieuTien,
                pt.MaKhachHang,
                pt.NgayThuTien,
                pt.SoTienThu
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updatePhieuThuTien(PhieuThuTien_DTO pt)
        {
            string query = "update PHIEUTHUTIEN set MaKhachHang = @makh, NgayThuTien = @ngaythutien, SoTienThu = @sotienthu where MaPhieuThuTien = @mapt";
            object[] parameters = new object[] 
            {
                pt.MaKhachHang,
                pt.NgayThuTien,
                pt.SoTienThu,
                pt.MaPhieuTien
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deletePhieuThuTien(PhieuThuTien_DTO pt)
        {
            string query = "delete from PHIEUTHUTIEN where MaPhieuThuTien = @mapt";
            object[] parameters = new object[] 
            {
                pt.MaPhieuTien
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
