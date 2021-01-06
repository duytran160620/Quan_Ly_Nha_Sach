using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class BaoCaoCongNo_DAO
    {
        private static BaoCaoCongNo_DAO instance;
        private BaoCaoCongNo_DAO()
        {
        }
        public static BaoCaoCongNo_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoCongNo_DAO();
                return BaoCaoCongNo_DAO.instance;
            }
            private set
            {
                BaoCaoCongNo_DAO.instance = value;
            }
        }

        public DataTable selectAllBaoCaoTon()
        {
            return DataProvider.Instance.ExecuteQuery("select * from BAOCAOCONGNO");
        }
        public bool insertBaoCaoCongNo(BaoCaoCongNo_DTO bc)
        {
            string query = "insert into BAOCAOCONGNO values (@mabaccaocongno, @thang, @nam)";
            object[] parameters = new object[] 
            {
                bc.MaBaoCaoCongNo,
                bc.Thang,
                bc.Nam
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateBaoCaoCongNo(BaoCaoCongNo_DTO bc)
        {
            string query = "update BAOCAOCONGNO set Thang = @thang, Nam = @nam where MaBaoCaoCongNo = @mabaccaocongno";
            object[] parameters = new object[] 
            {
                bc.Thang,
                bc.Nam,
                bc.MaBaoCaoCongNo
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteBaoCaoCongNo(BaoCaoCongNo_DTO bc)
        {
            string query = "delete from BAOCAOCONGNO where MaBaoCaoCongNo = @mabaccaocongno";
            object[] parameters = new object[] 
            {
                bc.MaBaoCaoCongNo
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
