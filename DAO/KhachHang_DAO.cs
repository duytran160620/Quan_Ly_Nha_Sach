using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class KhachHang_DAO
    {
        private static KhachHang_DAO instance;
        private KhachHang_DAO()
        {
        }
        public static KhachHang_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHang_DAO();
                return KhachHang_DAO.instance;
            }
            private set
            {
                KhachHang_DAO.instance = value;
            }
        }

        public DataTable selectDanhSachKhachHang()
        {
            return DataProvider.Instance.ExecuteQuery("select * from KHACHHANG");
        }
        public DataTable selectAllMaKhachHang()
        {
            string query = "select MaKhachHang from KHACHHANG";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable selectHoTenKhachHangByMaKH(string makh)
        {
            string query = "select TenKhachHang from KHACHHANG where MaKhachHang = @makh";
            object[] parameters = new object[] { makh };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable selectTienNoCuaKhachHangByMaKH(string makh)
        {
            string query = "select TienNo from KHACHHANG where MaKhachHang = @makh";
            object[] parameters = new object[] { makh };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable selectInfoKhachHangByMaKH(string makh)
        {
            string query = "select kh.TenKhachHang, kh.DiaChi, kh.Email, kh.SDT  from KHACHHANG kh where kh.MaKhachHang = @mkh";
            object[] parameters = new object[] { makh };
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool insertKhachHang(KhachHang_DTO kh)
        {
            string query = "insert into KHACHHANG values (@makh, @tenkh, @email, @sdt, @diachi, @tienno)";
            object[] parameters = new object[] 
            {
                kh.MaKhachHang,
                kh.TenKhachHang,
                kh.Email,
                kh.SDT,
                kh.DiaChi,
                kh.TienNo
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateKhachHang(KhachHang_DTO kh)
        {
            string query = "update KHACHHANG set TenKhachHang = @tenkh, Email = @email, SDT = @sdt, DiaChi = @dichi, TienNo = @tienno where MaKhachHang = @makh";
            object[] parameters = new object[] 
            {
                kh.TenKhachHang,
                kh.Email,
                kh.SDT,
                kh.DiaChi,
                kh.TienNo,
                kh.MaKhachHang
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteKhachHang(KhachHang_DTO kh)
        {
            string query = "delete from KHACHHANG where MaKhachHang = @makh";
            object[] parameters = new object[] 
            {
                kh.MaKhachHang
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateTienNoCuaKhSauKhiThanhToanNo(string makh)
        {
            string query = "update KHACHHANG set TienNo = 0 where MaKhachHang = @makh";
            object[] parameters = new object[] { makh };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
