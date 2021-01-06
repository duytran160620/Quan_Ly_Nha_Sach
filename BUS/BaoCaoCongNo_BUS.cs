using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class BaoCaoCongNo_BUS
    {
        private static BaoCaoCongNo_BUS instance;
        private BaoCaoCongNo_BUS()
        {
        }
        public static BaoCaoCongNo_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoCongNo_BUS();
                return BaoCaoCongNo_BUS.instance;
            }
            private set
            {
                BaoCaoCongNo_BUS.instance = value;
            }
        }

        public DataTable selectAllBaoCaoCongNo()
        {
            return BaoCaoCongNo_DAO.Instance.selectAllBaoCaoTon();
        }
        public bool insertBaoCaoCongNo(BaoCaoCongNo_DTO bc)
        {
            if (bc.MaBaoCaoCongNo != string.Empty)
                return BaoCaoCongNo_DAO.Instance.insertBaoCaoCongNo(bc);
            return false;
        }
        public bool updateBaoCaoCongNo(BaoCaoCongNo_DTO bc)
        {
            if (bc.MaBaoCaoCongNo != string.Empty)
                return BaoCaoCongNo_DAO.Instance.updateBaoCaoCongNo(bc);
            return false;
        }
        public bool deleteBaoCaoCongNo(BaoCaoCongNo_DTO bc)
        {
            if (bc.MaBaoCaoCongNo != string.Empty)
                return BaoCaoCongNo_DAO.Instance.deleteBaoCaoCongNo(bc);
            return false;
        }
    }
}
