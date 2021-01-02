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
    public class Sach_BUS
    {
        private static Sach_BUS instance;
        private Sach_BUS()
        {
        
        }
        public static Sach_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new Sach_BUS();
                return Sach_BUS.instance;
            }
            private set
            {
                Sach_BUS.instance = value;
            }
        }

        public int checkIfExistsMaSach(string masach)
        {
            if (masach != "")
                return Sach_DAO.Instance.checkExistsMaSach(masach);
            return -1;
        }
        public DataTable selectMaSach()
        {
            return Sach_DAO.Instance.selectMaSach();
        }
        public DataTable selectSoLuongTonBy(string masach)
        {
            if(masach != "")
                return Sach_DAO.Instance.selectSoLuongTonBy(masach);
            return null;
        }
        public DataTable selectAllDataBy(string masach)
        {
            if (masach != "")
                return Sach_DAO.Instance.selectAllDataBy(masach);
            return null;
        }
        public bool insertSach(Sach_DTO sach)
        {
            if(sach.MaSach != string.Empty)
                return Sach_DAO.Instance.insertSach(sach);
            return false;
        }
        public bool updateSach(Sach_DTO sach)
        {
            if (sach.MaSach != string.Empty)
                return Sach_DAO.Instance.updateSach(sach);
            return false;
        }
        public bool deleteSach(Sach_DTO sach)
        {
            if (sach.MaSach != string.Empty)
            {
                return Sach_DAO.Instance.deleteSach(sach);
            }
            return false;
        }
    }
}
