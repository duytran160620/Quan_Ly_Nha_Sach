using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class QuyDinh_DAO
    {
        private static QuyDinh_DAO instance;
        private QuyDinh_DAO()
        {
        }
        public static QuyDinh_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuyDinh_DAO();
                return QuyDinh_DAO.instance;
            }
            private set
            {
                QuyDinh_DAO.instance = value;
            }
        }

        public DataTable selectThamSoQD_1()
        {
            string query = "select SoLuongNhapToiThieu , SoLuongTonToiThieuDeNhap from QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable selectThamSoQD_2()
        {
            string query = "select TienNoToiDa , SoLuongTonToiThieuSauKhiBan from QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable selectThamSoQD_4()
        {
            string query = "select DuocThuVuotSoTienKhachHangDangNo from QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool updateQuyDinh(QuyDinh_DTO qd)
        {
            string query = "update QUYDINH set SoLuongNhapToiThieu = @soluongnhaptoithieu, SoLuongTonToiThieuDeNhap = @soluongtoithieudenhap, TienNoToiDa = @tiennotoida, SoLuongTonToiThieuSauKhiBan = @soluongtontoithieusaukhiban, DuocThuVuotSoTienKhachHangDangNo = @apdung";
            object[] parameters = new object[] 
            {
                qd.SoLuongNhapToiThieu,
                qd.SoLuongTonToiThieuDeNhap,
                qd.TienNoToiDa,
                qd.SoLuongTonToiThieuSauKhiBan,
                qd.DuocThuVuotSoTienKhachDangNo
            };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        
    }
}
