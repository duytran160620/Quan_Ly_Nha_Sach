﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class HoaDonBanSach_DAO
    {
        private static HoaDonBanSach_DAO instance;
        private HoaDonBanSach_DAO()
        {

        }
        public static HoaDonBanSach_DAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new HoaDonBanSach_DAO();
                return HoaDonBanSach_DAO.instance;
            }
            private set
            {
                HoaDonBanSach_DAO.instance = value;
            }
        }

        public DataTable selectAllHoaDon()
        {
            string query = "select * from HOADONBANSACH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool insertHoaDon(HoaDonBanSach_DTO hd)
        {
            string query = "insert into HOADONBANSACH values (@mahd, @ngaylap, @makh)";
            object[] parameters = new object[] 
            { 
                hd.MaHoaDon,
                hd.NgayLapHoaDon,
                hd.MaKhachHang
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool updateHoaDon(HoaDonBanSach_DTO hd)
        {
            string query = "update HOADONBANSACH set NgayLapHoaDon = @ngaylap, MaKhachHang = @makh where MaHoaDon = @mahd";
            object[] parameters = new object[] 
            { 
                hd.NgayLapHoaDon,
                hd.MaKhachHang,
                hd.MaHoaDon
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public bool deleteHoaDon(HoaDonBanSach_DTO hd)
        {
            string query = "delete from HOADONBANSACH where MaHoaDon = @mahd and MaKhachHang = @makh";
            object[] parameters = new object[] 
            { 
                hd.MaHoaDon,
                hd.MaKhachHang
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
