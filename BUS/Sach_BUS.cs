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

        public DataTable selectDanhSachDauSach()
        {
            return Sach_DAO.Instance.selectDanhSachDauSach();
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
        public DataTable searchByMaSach(string input)
        {
            return Sach_DAO.Instance.searchByMaSach(input);
        }
        public DataTable searchByTenSach(string input)
        {
            return Sach_DAO.Instance.searchByTenSach(input);
        }
        public DataTable searchByTheLoai(string input)
        {
            return Sach_DAO.Instance.searchByTheLoai(input);
        }
        public DataTable  searchByTacGia(string input)
        {
            return Sach_DAO.Instance.searchByTacGia(input);
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
        public bool updateSoLuongTonSauKhiBan(string masach, int soluongdaban)
        {
            return Sach_DAO.Instance.updateSoLuongTonSauKhiBan(masach, soluongdaban);
        }
        public bool updateSoLuongTonSauKhiBanKhongThanhCong(string masach, int soluongdaban)
        {
            return Sach_DAO.Instance.updateSoLuongTonSauKhiBanKhongThanhCong(masach, soluongdaban);
        }
        public bool updateSoLuongTonSauKhiNhap(string masach, int soluongnhap)
        {
            return Sach_DAO.Instance.updateSoLuongTonSauKhiNhap(masach, soluongnhap);
        }
    }
}
