using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Quan_Ly_Nha_Sach
{
    public partial class FormBaoCaoTon : Form
    {
        public FormBaoCaoTon()
        {
            InitializeComponent();
            loadAllDanhSachBaoCaoTon();
            dataGVCTBaoCaoTon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void loadAllDanhSachBaoCaoTon()
        {
            DataTable dt = BaoCaoTon_BUS.Instance.selectAllBaoCaoTon();
            dataGVBaoCaoTon.DataSource = dt;
            dataGVBaoCaoTon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void loadChiTietBaoCaoTonByMaBaoCao(string mabaocaoton)
        {
            DataTable dt = ChiTietBaoCaoTon_BUS.Instance.selectCTBaoCaoTonByMaBaoCaoTon(mabaocaoton);
            dataGVCTBaoCaoTon.DataSource = dt;
            
        }
        private void btnLapBaoCaoTon_Click(object sender, EventArgs e)
        {
            BaoCaoTon_DTO baocao = new BaoCaoTon_DTO();
            baocao.MaBaoCaoTon = txtMaBaoCaoTon.Text;
            baocao.Thang = int.Parse(txtThang.Text);
            baocao.Nam = int.Parse(txtNam.Text);

            if (BaoCaoTon_BUS.Instance.insertBaoCaoTon(baocao))
            {
                string mess = string.Format("Thêm báo cáo tồn {0} thành công", baocao.MaBaoCaoTon);
                MessageBox.Show(mess, "Thông báo");
                loadBaoCaoChotatCaMaSach();
            }
            else
            {
                string mess = string.Format("Thêm báo cáo tồn {0} thất bại", baocao.MaBaoCaoTon);
                MessageBox.Show(mess, "Thông báo");
            }
            loadAllDanhSachBaoCaoTon();
        }

        private void btnCapNhatBaoCaoTon_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVBaoCaoTon.Rows[dataGVBaoCaoTon.CurrentCell.RowIndex];

            BaoCaoTon_DTO baocao = new BaoCaoTon_DTO();
            baocao.MaBaoCaoTon = selectedRow.Cells["MaBaoCaoTon"].Value.ToString();
            baocao.Thang = int.Parse(selectedRow.Cells["Thang"].Value.ToString());
            baocao.Nam = int.Parse(selectedRow.Cells["Nam"].Value.ToString());

            if (BaoCaoTon_BUS.Instance.updateBaoCaoTon(baocao))
            {
                string mess = string.Format("Cập nhật báo cáo tồn {0} thành công", baocao.MaBaoCaoTon);
                MessageBox.Show(mess, "Thông báo");
            }
            else
            {
                string mess = string.Format("Cập nhật báo cáo tồn {0} thất bại", baocao.MaBaoCaoTon);
                MessageBox.Show(mess, "Thông báo");
            }
            loadAllDanhSachBaoCaoTon();
        }

        private void btnXoaBaoCaoTon_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVBaoCaoTon.Rows[dataGVBaoCaoTon.CurrentCell.RowIndex];

            BaoCaoTon_DTO baocao = new BaoCaoTon_DTO();
            baocao.MaBaoCaoTon = selectedRow.Cells["MaBaoCaoTon"].Value.ToString();
            baocao.Thang = int.Parse(selectedRow.Cells["Thang"].Value.ToString());
            baocao.Nam = int.Parse(selectedRow.Cells["Nam"].Value.ToString());

            if (BaoCaoTon_BUS.Instance.deleteBaoCaoTon(baocao))
            {
                string mess = string.Format("Xóa báo cáo tồn {0} thành công", baocao.MaBaoCaoTon);
                MessageBox.Show(mess, "Thông báo");
            }
            else
            {
                string mess = string.Format("Xóa báo cáo tồn {0} thất bại", baocao.MaBaoCaoTon);
                MessageBox.Show(mess, "Thông báo");
            }
            loadAllDanhSachBaoCaoTon();
        }

        private void btnXemCTBaoCaoTon_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVBaoCaoTon.Rows[dataGVBaoCaoTon.CurrentCell.RowIndex];
            string mabaocaoton = selectedRow.Cells["MaBaoCaoTon"].Value.ToString();
            loadChiTietBaoCaoTonByMaBaoCao(mabaocaoton);
        }


        bool isNotEmpty(DataGridViewRow testrow)
        {
            for (int i = 0; i < testrow.Cells.Count; i++)
            {
                if (testrow.Cells[i].Value != null)
                {
                    if (testrow.Cells[i].Value.ToString() != string.Empty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void btnLapCTBaoCaoTon_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVBaoCaoTon.Rows[dataGVBaoCaoTon.CurrentCell.RowIndex];
            List<ChiTietBaoCaoTon_DTO> ListCTBaoCao = new List<ChiTietBaoCaoTon_DTO>();
            foreach (DataGridViewRow row in dataGVCTBaoCaoTon.Rows)
            {
                if (isNotEmpty(row))
                {
                    ListCTBaoCao.Add(new ChiTietBaoCaoTon_DTO()
                    {
                        MaBaoCaoTon = selectedRow.Cells["MaBaoCaoTon"].Value.ToString(),
                        MaSach = row.Cells["MaSach"].Value.ToString(),
                        SoLuongTonDau = int.Parse(row.Cells["SoLuongTonDau"].Value.ToString()),
                        PhatSinh = int.Parse(row.Cells["PhatSinh"].Value.ToString()),
                        SoLuongTonCuoi = int.Parse(row.Cells["SoLuongTonCuoi"].Value.ToString())
                    });
                }
            }
            foreach (var item in ListCTBaoCao)
            {
                if (ChiTietBaoCaoTon_BUS.Instance.insertChiTietBaoCaoTon(item))
                {
                    string mess = string.Format("Lập báo cáo cho mã sách {0} thành công", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Lập báo cáo cho mã sách {0} thất bại", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            //loadChiTietBaoCaoTonByMaBaoCao(selectedRow.Cells["MaBaoCaoTon"].Value.ToString());
        }

        private void btnCapNhatCTBaoCaoTon_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVBaoCaoTon.Rows[dataGVBaoCaoTon.CurrentCell.RowIndex];
            List<ChiTietBaoCaoTon_DTO> ListCTBaoCao = new List<ChiTietBaoCaoTon_DTO>();
            foreach (DataGridViewRow row in dataGVCTBaoCaoTon.Rows)
            {
                if (isNotEmpty(row))
                {
                    ListCTBaoCao.Add(new ChiTietBaoCaoTon_DTO()
                    {
                        MaBaoCaoTon = selectedRow.Cells["MaBaoCaoTon"].Value.ToString(),
                        MaSach = row.Cells["MaSach"].Value.ToString(),
                        SoLuongTonDau = int.Parse(row.Cells["SoLuongTonDau"].Value.ToString()),
                        PhatSinh = int.Parse(row.Cells["PhatSinh"].Value.ToString()),
                        SoLuongTonCuoi = (int.Parse(row.Cells["SoLuongTonDau"].Value.ToString()) - int.Parse(row.Cells["PhatSinh"].Value.ToString()))
                    });
                }
            }
            foreach (var item in ListCTBaoCao)
            {
                if (ChiTietBaoCaoTon_BUS.Instance.updateChiTietBaoCaoTon(item))
                {
                    string mess = string.Format("Cập nhật báo cáo cho mã sách {0} thành công", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Cập nhật báo cáo cho mã sách {0} thất bại", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            loadChiTietBaoCaoTonByMaBaoCao(selectedRow.Cells["MaBaoCaoTon"].Value.ToString());
        }

        private void btnXoaCTBaoCaoTon_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVCTBaoCaoTon.Rows[dataGVCTBaoCaoTon.CurrentCell.RowIndex];
            DataGridViewRow selectedRow2 = dataGVBaoCaoTon.Rows[dataGVBaoCaoTon.CurrentCell.RowIndex];
            ChiTietBaoCaoTon_DTO ct = new ChiTietBaoCaoTon_DTO();
            ct.MaBaoCaoTon = selectedRow2.Cells["MaBaoCaoTon"].Value.ToString();
            ct.MaSach = selectedRow.Cells["MaSach"].Value.ToString();
            if (ChiTietBaoCaoTon_BUS.Instance.deleteChiTietBaoCaoTon(ct))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            loadChiTietBaoCaoTonByMaBaoCao(selectedRow2.Cells["MaBaoCaoTon"].Value.ToString());
        }
        

        void loadBaoCaoChotatCaMaSach()
        {
            DataGridViewRow selectedRow = dataGVBaoCaoTon.Rows[dataGVBaoCaoTon.CurrentCell.RowIndex];

            BaoCaoTon_DTO bc = new BaoCaoTon_DTO();
            bc.MaBaoCaoTon = txtMaBaoCaoTon.Text;
            bc.Thang = int.Parse(txtThang.Text);
            bc.Nam = int.Parse(txtNam.Text);
            DataTable dt = ChiTietBaoCaoTon_BUS.Instance.baoCaoTon(bc.Thang, bc.Nam);
            dataGVCTBaoCaoTon.DataSource = dt;
        }
        

        
    }
}
