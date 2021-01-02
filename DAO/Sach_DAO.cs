using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class Sach_DAO
    {
        private static Sach_DAO instance;
        private Sach_DAO()
        {
        
        }
        public static Sach_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Sach_DAO();
                return Sach_DAO.instance;
            }
            private set
            {
                Sach_DAO.instance = value;
            }
        }


        public int checkExistsMaSach(string masach)
        {
            string query = "select dbo.checkMaSachExists (@masach)";
            object[] parameters = new object[] { masach };
            return DataProvider.Instance.ExecuteScalar(query, parameters);
        }
        public DataTable selectMaSach()
        {
            string query = "select MaSach from SACH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable selectSoLuongTonBy(string masach)
        {
            string query = "select SoLuongTon from SACH where MaSach = @masach";
            object[] parameters = new object[] 
            {
                masach
            };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable selectAllDataBy(string  masach)
        {
            string query = "SELECT TenSach, TheLoai, TacGia, SoLuongTon, DonGiaBan FROM SACH where MaSach = @masach";
            object[] parameters = new object[] { masach };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public bool insertSach(Sach_DTO sach)
        {
            string query = "insert into SACH values(@masach, @tensach, @theloai, @tacgia, @soluong, @dongiaban)";
            object[] parameters = new object[] 
            {
                sach.MaSach,
                sach.TenSach,
                sach.TheLoai,
                sach.TacGia,
                sach.SoLuongTon,
                sach.DonGiaBan
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateSach(Sach_DTO sach)
        {
            string query = "update SACH set TenSach = @tensach, TheLoai = @theloai, TacGia = @tacgia , SoLuongTon = @soluong, DonGiaBan = @dongia where MaSach = @masach ";
            object[] parameters = new object[] 
            {
                sach.TenSach,
                sach.TheLoai,
                sach.TacGia,
                sach.SoLuongTon,
                sach.DonGiaBan,
                sach.MaSach
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteSach(Sach_DTO sach)
        {
            string query = "delete from SACH where MaSach = @masach";
            object[] parameters = new object[] 
            {
                sach.MaSach
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        
    }
}
