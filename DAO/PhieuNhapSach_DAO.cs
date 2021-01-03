using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class PhieuNhapSach_DAO
    {
        private static PhieuNhapSach_DAO instance;
        private PhieuNhapSach_DAO() {}
        public static PhieuNhapSach_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapSach_DAO();
                return PhieuNhapSach_DAO.instance;
            }
            private set
            {
                PhieuNhapSach_DAO.instance = value;
            }
        }

        public DataTable selectAlllDataFromPhieuNhapSach()
        {
            return DataProvider.Instance.ExecuteQuery("select * from PHIEUNHAPSACH");
        }
        public bool insertPhieuNhapSach(PhieuNhapSach_DTO pn)
        {
            string query = "INSERT INTO PHIEUNHAPSACH VALUES (@mapn, @ngaynhap)";
            object[] parameters = new object[] 
            {
                pn.MaPhieuNhap,
                pn.NgayNhap
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updatePhieuNhapSach(PhieuNhapSach_DTO pn)
        {
            string query = "UPDATE PHIEUNHAPSACH SET NgayNhap = @ngaynhap WHERE MaPhieuNhap = @mapn";
            object[] parameters = new object[] 
            {
                pn.NgayNhap,
                pn.MaPhieuNhap
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deletePhieuNhapSach(PhieuNhapSach_DTO pn)
        {
            string query = "DELETE FROM PHIEUNHAPSACH WHERE PHIEUNHAPSACH.MaPhieuNhap = @mapn";
            object[] parameters = new object[] 
            {
                pn.MaPhieuNhap
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
