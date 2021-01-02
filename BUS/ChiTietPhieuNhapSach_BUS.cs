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
    public class ChiTietPhieuNhapSach_BUS
    {
        private static ChiTietPhieuNhapSach_BUS instance;
        private ChiTietPhieuNhapSach_BUS(){}
        public static ChiTietPhieuNhapSach_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuNhapSach_BUS();
                return ChiTietPhieuNhapSach_BUS.instance;
            }
            private set
            {
                ChiTietPhieuNhapSach_BUS.instance = value;
            }
        }

        public DataTable selectInfoCTPhieuNhap(ChiTietPhieuNhapSach_DTO ctpn)
        {
            if (ctpn.MaPhieuNhap != "")
                return ChiTietPhieuNhapSach_DAO.Instance.selectInfoCTPhieuNhap(ctpn);
            return null;
        }
        public bool checkQD_1(int soluongnhap)
        {
            DataTable dt = QuyDinh_BUS.Instance.selectThamSoQD_1();
            foreach (DataRow item in dt.Rows)
            {
                int soluongnhaptoithieu = int.Parse(item["SoLuongNhapToiThieu"].ToString());
                if (soluongnhap >= soluongnhaptoithieu)
                {
                    return true;
                }
            }
            return false;
        }
        public bool insertChiTietPhieuNhapSach(ChiTietPhieuNhapSach_DTO ctpn) 
        {
               if(checkQD_1(ctpn.SoLuongNhap))
                   return ChiTietPhieuNhapSach_DAO.Instance.insertChiTietPhieuNhapSach(ctpn);
            return false;
        }
        public bool updateChiTietPhieuNhapSach(ChiTietPhieuNhapSach_DTO ctpn)
        {
            if (checkQD_1(ctpn.SoLuongNhap))
                return ChiTietPhieuNhapSach_DAO.Instance.updateChiTietPhieuNhapSach(ctpn);
            return false;
        }
        public bool deleteChiTietPhieuNhapSach(ChiTietPhieuNhapSach_DTO ctpn)
        {
            if (ctpn.MaPhieuNhap != "" && ctpn.MaSach != "")
                return ChiTietPhieuNhapSach_DAO.Instance.deleteChiTietPhieuNhapSach(ctpn);
            return false;
        }
    }
}
