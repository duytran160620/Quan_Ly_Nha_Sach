using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nha_Sach
{
    public partial class FormMenuQuanLyNhaSach : Form
    {
        public FormMenuQuanLyNhaSach()
        {
            InitializeComponent();
            
        }

        private void btnLapPhieuNhapSach_Click(object sender, EventArgs e)
        {
            FormPhieuNhapSach pn = new FormPhieuNhapSach();
            pn.Show();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDonBanSach hd = new FormHoaDonBanSach();
            hd.Show();
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            FormTimKiemSach timkiem = new FormTimKiemSach();
            timkiem.Show();
        }

        private void btnLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            FormPhieuThuTien thutien = new FormPhieuThuTien();
            thutien.Show();
        }

        private void btnQuanLyKH_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang kh = new FormQuanLyKhachHang();
            kh.Show();
        }

        private void btnBaoCaoTon_Click(object sender, EventArgs e)
        {
            FormBaoCaoTon baocaoton = new FormBaoCaoTon();
            baocaoton.Show();
        }

        private void btnCongNo_Click(object sender, EventArgs e)
        {
            FormBaoCaoCongNo congno = new FormBaoCaoCongNo();
            congno.Show();
        }

        private void btnThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            FormThayDoiQuyDinh quydinh = new FormThayDoiQuyDinh();
            quydinh.Show();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            FormQuanLySach sach = new FormQuanLySach();
            sach.Show();
        }
    }
}
