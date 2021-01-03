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

        //public bool insertKhachHang(KhachHang_DTO kh)
        //{
        //    return true;
        //}
        //public bool updateKhachHang(KhachHang_DTO kh)
        //{
        //    return true;
        //}
        //public bool deleteKhachHang(KhachHang_DTO kh)
        //{
        //    return false;
        //}
    }
}
