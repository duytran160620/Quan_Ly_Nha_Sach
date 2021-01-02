using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class QuyDinh_BUS
    {
        private static QuyDinh_BUS instance;
        private QuyDinh_BUS()
        {
        }
        public static QuyDinh_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuyDinh_BUS();
                return QuyDinh_BUS.instance;
            }
            private set
            {
                QuyDinh_BUS.instance = value;
            }
        }

        public DataTable selectThamSoQD_1()
        {
            return QuyDinh_DAO.Instance.selectThamSoQD_1();
        }
    }
}
