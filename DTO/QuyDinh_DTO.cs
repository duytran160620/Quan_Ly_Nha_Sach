using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyDinh_DTO
    {
        private int soluongnhaptoithieu;

        public int SoLuongNhapToiThieu
        {
            get
            {
                return soluongnhaptoithieu;
            }
            set
            {
                soluongnhaptoithieu = value;
            }
        }
        private int soluongtontoithieudenhap;

        public int SoLuongTonToiThieuDeNhap
        {
            get
            {
                return soluongtontoithieudenhap;
            }
            set
            {
                soluongtontoithieudenhap = value;
            }
        }
        private int tiennotoida;

        public int TienNoToiDa
        {
            get
            {
                return tiennotoida;
            }
            set
            {
                tiennotoida = value;
            }
        }
        private int soluongtontoithieusaukhiban;

        public int SoLuongTonToiThieuSauKhiBan
        {
            get
            {
                return soluongtontoithieusaukhiban;
            }
            set
            {
                soluongtontoithieusaukhiban = value;
            }
        }
        private bool duocthuvuotsotienkhachdangno;

        public bool DuocThuVuotSoTienKhachDangNo
        {
            get
            {
                return duocthuvuotsotienkhachdangno;
            }
            set
            {
                duocthuvuotsotienkhachdangno = value;
            }
        }
    }
}
