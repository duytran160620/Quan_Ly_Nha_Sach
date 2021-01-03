﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class KhachHang_BUS
    {
        private static KhachHang_BUS instance;
        private KhachHang_BUS()
        {
        }
        public static KhachHang_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHang_BUS();
                return KhachHang_BUS.instance;
            }
            private set
            {
                KhachHang_BUS.instance = value;
            }
        }


        public DataTable selectAllMaKhachHang()
        {
            return KhachHang_DAO.Instance.selectAllMaKhachHang();
        }
        public DataTable selectTenKhachHangByMaKH(string makh)
        {
            if (makh != "")
                return KhachHang_DAO.Instance.selectHoTenKhachHangByMaKH(makh);
            return null;
        }
        public DataTable selectTienNoCuaKhachhangByMaKH(string makh)
        {
            if (makh != string.Empty)
                return KhachHang_DAO.Instance.selectTienNoCuaKhachHangByMaKH(makh);
            return null;
        }
    }
}
