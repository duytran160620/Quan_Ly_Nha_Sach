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
    public partial class FormBaoCaoCongNo : Form
    {
        public FormBaoCaoCongNo()
        {
            InitializeComponent();
            loadAllDanhSachBaoCongNo();
        }
        void loadAllDanhSachBaoCongNo()
        {
            DataTable dt = BaoCaoCongNo_BUS.Instance.selectAllBaoCaoCongNo();
            dataGVBaoCaoCongNo.DataSource = dt;
            dataGVBaoCaoCongNo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnLapBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            BaoCaoCongNo_DTO baocao = new BaoCaoCongNo_DTO();
            baocao.MaBaoCaoCongNo = txtMaBaoCaoCongNo.Text;
            baocao.Thang = int.Parse(txtThang.Text);
            baocao.Nam = int.Parse(txtNam.Text);

            if (BaoCaoCongNo_BUS.Instance.insertBaoCaoCongNo(baocao))
            {
                string mess = string.Format("Thêm báo cáo công nợ {0} thành công", baocao.MaBaoCaoCongNo);
                MessageBox.Show(mess, "Thông báo");
            }
            else
            {
                string mess = string.Format("Thêm báo cáo công nợ {0} thất bại", baocao.MaBaoCaoCongNo);
                MessageBox.Show(mess, "Thông báo");
            }
            loadAllDanhSachBaoCongNo();
        }

        private void btnCapNhatBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVBaoCaoCongNo.Rows[dataGVBaoCaoCongNo.CurrentCell.RowIndex];
            BaoCaoCongNo_DTO baocao = new BaoCaoCongNo_DTO();
            baocao.MaBaoCaoCongNo = selectedRow.Cells["MaBaoCaoCongNo"].Value.ToString();
            baocao.Thang = int.Parse(selectedRow.Cells["Thang"].Value.ToString());
            baocao.Nam = int.Parse(selectedRow.Cells["Nam"].Value.ToString());
            if (BaoCaoCongNo_BUS.Instance.updateBaoCaoCongNo(baocao))
            {
                string mess = string.Format("Cập nhật báo cáo công nợ {0} thành công", baocao.MaBaoCaoCongNo);
                MessageBox.Show(mess, "Thông báo");
            }
            else
            {
                string mess = string.Format("Cập nhật báo cáo công nợ {0} thất bại", baocao.MaBaoCaoCongNo);
                MessageBox.Show(mess, "Thông báo");
            }
            loadAllDanhSachBaoCongNo();
        }

        private void btnXoaBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVBaoCaoCongNo.Rows[dataGVBaoCaoCongNo.CurrentCell.RowIndex];
            BaoCaoCongNo_DTO baocao = new BaoCaoCongNo_DTO();
            baocao.MaBaoCaoCongNo = selectedRow.Cells["MaBaoCaoCongNo"].Value.ToString();
            baocao.Thang = int.Parse(selectedRow.Cells["Thang"].Value.ToString());
            baocao.Nam = int.Parse(selectedRow.Cells["Nam"].Value.ToString());
            if (BaoCaoCongNo_BUS.Instance.deleteBaoCaoCongNo(baocao))
            {
                string mess = string.Format("Xóa báo cáo công nợ {0} thành công", baocao.MaBaoCaoCongNo);
                MessageBox.Show(mess, "Thông báo");
            }
            else
            {
                string mess = string.Format("Xóa báo cáo công nợ {0} thất bại", baocao.MaBaoCaoCongNo);
                MessageBox.Show(mess, "Thông báo");
            }
            loadAllDanhSachBaoCongNo();
        }

        private void btnXemCTBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVBaoCaoCongNo.Rows[dataGVBaoCaoCongNo.CurrentCell.RowIndex];
            string mabaocaocongno = selectedRow.Cells["MaBaoCaoCongNo"].Value.ToString();
            DataTable dt = ChiTietBaoCaoCongNo_BUS.Instance.selectChiTietBaoCaoCongNoByMaBaoCao(mabaocaocongno);
            dataGVCTBaoCaoCongNo.DataSource = dt;
            dataGVCTBaoCaoCongNo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
