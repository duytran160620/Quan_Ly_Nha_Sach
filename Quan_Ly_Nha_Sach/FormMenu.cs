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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            FormPhieuNhapSach phieuNhapSach = new FormPhieuNhapSach();
            phieuNhapSach.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDonBanSach hoaDon = new FormHoaDonBanSach();
            hoaDon.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiemSach timKiem = new FormTimKiemSach();
            timKiem.Show();
        }

        private void btnPhieuThuTien_Click(object sender, EventArgs e)
        {
            FormPhieuThuTien thuTien = new FormPhieuThuTien();
            thuTien.Show();
        }

        private void btnQuanLyKH_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang khachHang = new FormQuanLyKhachHang();
            khachHang.Show();
        }

        private void btnBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            FormBaoCaoCongNo congNo = new FormBaoCaoCongNo();
            congNo.Show();
        }

        private void btnBaoCaoTon_Click(object sender, EventArgs e)
        {
            FormBaoCaoTon baoCaoTon = new FormBaoCaoTon();
            baoCaoTon.Show();
        }

        private void btnThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            FormThayDoiQuyDinh quyDinh = new FormThayDoiQuyDinh();
            quyDinh.Show();
        }
    }
}
