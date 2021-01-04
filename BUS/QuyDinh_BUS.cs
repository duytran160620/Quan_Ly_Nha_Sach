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

        public int checkQD_1(int soluongnhap, int soluongton)
        {
            DataTable dt = QuyDinh_DAO.Instance.selectThamSoQD_1();
            foreach (DataRow row in dt.Rows)
            {
                int soluongnhaptoithieu = int.Parse(row["SoLuongNhapToiThieu"].ToString());
                int soluongtontoithieudenhap = int.Parse(row["SoLuongTonToiThieuDeNhap"].ToString());
                if (soluongnhap <= soluongnhaptoithieu && soluongton <= soluongtontoithieudenhap)
                {
                    return 1;
                }
                else if (soluongnhap >= soluongnhaptoithieu && soluongton >= soluongtontoithieudenhap)
                {
                    return 2;
                }
                else if(soluongnhap >= soluongnhaptoithieu && soluongton <= soluongtontoithieudenhap)
                {
                    return 3;
                }
            }
            return -1;
        }
        public bool checkTienNoCuaKhachHang(int tienno)
        {
            DataTable dt = QuyDinh_DAO.Instance.selectThamSoQD_2();
            foreach (DataRow row in dt.Rows)
            {
                int tiennotoida = int.Parse(row["TienNoToiDa"].ToString());
                if(tienno <= tiennotoida)
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkSoLuongTonSauKhiBan(int soluongton)
        {
            DataTable dt = QuyDinh_DAO.Instance.selectThamSoQD_2();
            foreach (DataRow row in dt.Rows)
            {
                int soluongtonsaukhiban = int.Parse(row["SoLuongTonToiThieuSauKhiBan"].ToString());
                if (soluongton >= soluongtonsaukhiban)
                {
                    return true;
                }
            }
            return false;
        }
        public int checkQD_2(int tienoKH, int soluongton)
        {
            DataTable dt = QuyDinh_DAO.Instance.selectThamSoQD_2();
            foreach (DataRow row in dt.Rows)
            {
                int tiennotoida = int.Parse(row["TienNoToiDa"].ToString());
                int soluongtonsaukhiban = int.Parse(row["SoLuongTonToiThieuSauKhiBan"].ToString());
                if (tienoKH >= tiennotoida && soluongton >= soluongtonsaukhiban)
                {
                    return 1;
                }
                else if(tienoKH <= tiennotoida && soluongton <= soluongtonsaukhiban)
                {
                    return 2;
                }
                else if(tienoKH <= tiennotoida && soluongton >= soluongtonsaukhiban)
                {
                    return 3;
                }
            }
            return -1;
        }
        public bool ifUseQD_4()
        {
            DataTable dt = selectThamSoQD_4();
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToBoolean(row["DuocThuVuotSoTienKhachHangDangNo"].ToString()) == true)// sử dụng quy định 4
                {
                    return true;
                }
            }
            return false; //không sử dụng quy định 4
        }
        public bool checkQD_4(int sotienthu, int sotiendangno)
        {
            if(ifUseQD_4())
            {
                if(sotienthu <= sotiendangno)
                {
                    return true;
                }
            }
            return false;
        }
        public DataTable selectThamSoQD_1()
        {
            return QuyDinh_DAO.Instance.selectThamSoQD_1();
        }
        public DataTable selectThamSoQD_2()
        {
            return QuyDinh_DAO.Instance.selectThamSoQD_2();
        }
        public DataTable selectThamSoQD_4()
        {
            return QuyDinh_DAO.Instance.selectThamSoQD_4();
        }
    }
}
