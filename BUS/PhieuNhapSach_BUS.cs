using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class PhieuNhapSach_BUS
    {
        /// <summary>
        /// Start Singleton
        /// </summary>
        private static PhieuNhapSach_BUS instance;
        private PhieuNhapSach_BUS()
        {
        }
        public static PhieuNhapSach_BUS Instance
        {
            get
            {
                if (instance == null)
                    PhieuNhapSach_BUS.instance = new PhieuNhapSach_BUS();
                return PhieuNhapSach_BUS.instance;
            }
            private set
            {
                PhieuNhapSach_BUS.instance = value;
            }
        }
        /// <summary>
        /// End Singleton
        /// </summary>
        /// 

        
        public void loadAllPhieuNhapSach(DataGridView data)
        {
            
            data.DataSource = PhieuNhapSach_DAO.Instance.selectAlllDataFromPhieuNhapSach();
        }
        public bool insertPhieuNhapSach(PhieuNhapSach_DTO pn)
        {
            if (pn.MaPhieuNhap != "")
                return PhieuNhapSach_DAO.Instance.insertPhieuNhapSach(pn);
            return false;
        }
        public bool updatePhieuNhapSach(PhieuNhapSach_DTO pn)
        {
            if (pn.MaPhieuNhap != "")
                return PhieuNhapSach_DAO.Instance.updatePhieuNhapSach(pn);
            return false;
        }
        public bool deletePhieuNhapSach(PhieuNhapSach_DTO pn)
        {
            if (pn.MaPhieuNhap != "")
                return PhieuNhapSach_DAO.Instance.deletePhieuNhapSach(pn);
            return false;
        }
    }
}
