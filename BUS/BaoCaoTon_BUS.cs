using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BaoCaoTon_BUS
    {
        private static BaoCaoTon_BUS instance;
        private BaoCaoTon_BUS()
        {
        }
        public static BaoCaoTon_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoTon_BUS();
                return BaoCaoTon_BUS.instance;
            }
            private set
            {
                BaoCaoTon_BUS.instance = value;
            }
        }

        public DataTable selectAllBaoCaoTon()
        {
            return BaoCaoTon_DAO.Instance.selectAllBaoCaoTon();
        }
        public bool insertBaoCaoTon(BaoCaoTon_DTO bc)
        {
            if (bc.MaBaoCaoTon != string.Empty)
                return BaoCaoTon_DAO.Instance.insertBaoCaoTon(bc);
            return false;    
        }
        public bool updateBaoCaoTon(BaoCaoTon_DTO bc)
        {
            if (bc.MaBaoCaoTon != string.Empty)
                return BaoCaoTon_DAO.Instance.updateBaoCaoTon(bc);
            return false;
        }
        public bool deleteBaoCaoTon(BaoCaoTon_DTO bc)
        {
            if (bc.MaBaoCaoTon != string.Empty)
                return BaoCaoTon_DAO.Instance.deleteBaoCaoTon(bc);
            return false;
        }
    }
}
