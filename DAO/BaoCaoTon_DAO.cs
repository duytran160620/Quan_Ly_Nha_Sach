using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class BaoCaoTon_DAO
    {
        private static BaoCaoTon_DAO instance;
        private BaoCaoTon_DAO()
        {
        }
        public static BaoCaoTon_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoTon_DAO();
                return BaoCaoTon_DAO.instance;
            }
            private set
            {
                BaoCaoTon_DAO.instance = value;
            }
        }

        public DataTable selectAllBaoCaoTon()
        {
            return DataProvider.Instance.ExecuteQuery("select * from BAOCAOTON");
        }
        public bool insertBaoCaoTon(BaoCaoTon_DTO bc)
        {
            string query = "insert into BAOCAOTON values (@mabaccaoton, @thang, @nam)";
            object[] parameters = new object[] 
            {
                bc.MaBaoCaoTon,
                bc.Thang,
                bc.Nam
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateBaoCaoTon(BaoCaoTon_DTO bc)
        {
            string query = "update BAOCAOTON set Thang = @thang, Nam = @nam where MaBaoCaoTon = @mabaocaoton";
            object[] parameters = new object[] 
            {
                bc.Thang,
                bc.Nam,
                bc.MaBaoCaoTon
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteBaoCaoTon(BaoCaoTon_DTO bc)
        {
            string query = "delete from BAOCAOTON where MaBaoCaoTon = @mabaocaoton";
            object[] parameters = new object[] 
            {
                bc.MaBaoCaoTon
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
