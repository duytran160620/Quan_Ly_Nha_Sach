using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace Quan_Ly_Nha_Sach
{
    public partial class FormThayDoiQuyDinh : Form
    {
        public FormThayDoiQuyDinh()
        {
            InitializeComponent();
            loadAllQuyDinhCu();
        }

        void loadAllQuyDinhCu()
        {
            DataTable dt1 = QuyDinh_BUS.Instance.selectThamSoQD_1();
            DataTable dt2 = QuyDinh_BUS.Instance.selectThamSoQD_2();
            DataTable dt3 = QuyDinh_BUS.Instance.selectThamSoQD_4();

            foreach (DataRow row in dt1.Rows)
            {
                txtSLNhapToiThieuCu.Text = row["SoLuongNhapToiThieu"].ToString();
                txtSLToiThieuDeNhapCu.Text = row["SoLuongTonToiThieuDeNhap"].ToString();
            }
            foreach (DataRow row in dt2.Rows)
            {
                txtTienNoToiDaCu.Text = row["TienNoToiDa"].ToString();
                txtSLTonToiThieuSauKhiBanCu.Text = row["SoLuongTonToiThieuSauKhiBan"].ToString();
            }
            foreach (DataRow row in dt3.Rows)
            {
                checkBoxApDung.Checked = Convert.ToBoolean(row["DuocThuVuotSoTienKhachHangDangNo"].ToString());
            }
        }
        private void btnSLNhapToiThieu_Click(object sender, EventArgs e)
        {
            string soluongnhap = "";
            string soluongtoithieudenhap = "";
            DataTable dt = QuyDinh_BUS.Instance.selectThamSoQD_1();
            foreach (DataRow r in dt.Rows)
            {
                soluongnhap = r["SoLuongNhapToiThieu"].ToString();
                soluongtoithieudenhap = r["SoLuongTonToiThieuDeNhap"].ToString();
            }
            string mess = string.Format("QĐ1: Số lượng nhập ít nhất là {0}. Chỉ nhập các đầu sách có lượng tồn ít hơn {1}.", soluongnhap, soluongtoithieudenhap);
            MessageBox.Show(mess, "Thông báo");
        }

        private void btnQuyDinhSLNhapToiThieuDeNhap_Click(object sender, EventArgs e)
        {
            string soluongnhap = "";
            string soluongtoithieudenhap = "";
            DataTable dt = QuyDinh_BUS.Instance.selectThamSoQD_1();
            foreach (DataRow r in dt.Rows)
            {
                soluongnhap = r["SoLuongNhapToiThieu"].ToString();
                soluongtoithieudenhap = r["SoLuongTonToiThieuDeNhap"].ToString();
            }
            string mess = string.Format("QĐ1: Số lượng nhập ít nhất là {0}. Chỉ nhập các đầu sách có lượng tồn ít hơn {1}.", soluongnhap, soluongtoithieudenhap);
            MessageBox.Show(mess, "Thông báo");
        }

        private void btnTienNoToiDa_Click(object sender, EventArgs e)
        {
            string tiennotoida = "";
            string soluongtontoithieusaukhiban = "";
            DataTable dt = QuyDinh_BUS.Instance.selectThamSoQD_2();
            foreach (DataRow r in dt.Rows)
            {
                tiennotoida = r["TienNoToiDa"].ToString();
                soluongtontoithieusaukhiban = r["SoLuongTonToiThieuSauKhiBan"].ToString();
            }
            string mess = string.Format("QĐ2: Chỉ bán cho các khách hàng nợ không quá {0} và đầu sách có lượng tồn sau khi bán ít nhất là {1}.", tiennotoida, soluongtontoithieusaukhiban);
            MessageBox.Show(mess, "Thông báo");
        }

        private void btnSLTonToiThieuSauKhiBan_Click(object sender, EventArgs e)
        {
            string tiennotoida = "";
            string soluongtontoithieusaukhiban = "";
            DataTable dt = QuyDinh_BUS.Instance.selectThamSoQD_2();
            foreach (DataRow r in dt.Rows)
            {
                tiennotoida = r["TienNoToiDa"].ToString();
                soluongtontoithieusaukhiban = r["SoLuongTonToiThieuSauKhiBan"].ToString();
            }
            string mess = string.Format("QĐ2: Chỉ bán cho các khách hàng nợ không quá {0} và đầu sách có lượng tồn sau khi bán ít nhất là {1}.", tiennotoida, soluongtontoithieusaukhiban);
            MessageBox.Show(mess, "Thông báo");
        }

        private void btnSuDungQuyDinh_Click(object sender, EventArgs e)
        {
            string mess = string.Format("QĐ4: Số tiền thu không vượt quá số tiền khách hàng đang nợ. Sử dụng hay không sử dụng quy định này.");
            MessageBox.Show(mess, "Thông báo");
        }

        private void btnCapNhatQuyDinh_Click(object sender, EventArgs e)
        {
            QuyDinh_DTO qd = new QuyDinh_DTO();
            qd.SoLuongNhapToiThieu = int.Parse(txtSLNhapToiThieuMoi.Text);
            qd.SoLuongTonToiThieuDeNhap = int.Parse(txtSLToiThieuDeNhapMoi.Text);
            qd.TienNoToiDa = int.Parse(txtTienNoToiDaMoi.Text);
            qd.SoLuongTonToiThieuSauKhiBan = int.Parse(txtSLTonToiThieuSauKhiBanMoi.Text);
            qd.DuocThuVuotSoTienKhachDangNo = checkBoxApDung.Checked;

            if(QuyDinh_BUS.Instance.updateQuyDinh(qd))
            {
                MessageBox.Show("Cập nhật quy định thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật quy định thất bại");
            }
            loadAllQuyDinhCu();
            txtSLNhapToiThieuMoi.Text = "";
            txtSLToiThieuDeNhapMoi.Text = "";
            txtSLTonToiThieuSauKhiBanMoi.Text = "";
            txtTienNoToiDaMoi.Text = "";
        }
    }
}
