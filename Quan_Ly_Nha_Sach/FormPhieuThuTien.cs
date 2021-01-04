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
    public partial class FormPhieuThuTien : Form
    {
        public FormPhieuThuTien()
        {
            InitializeComponent();
            loadDanhSachMaHoaDon();
            loadDanhSachCacPhieuThuTienDaLap();
            loadInfoKhachHangByMaHD(comboBoxMaHD.Text);
        }

        void loadDanhSachMaHoaDon()
        {
            DataTable dt = HoaDonBanSach_BUS.Instance.selectMaHoaDon();
            comboBoxMaHD.DataSource = dt;
            comboBoxMaHD.DisplayMember = "MaHoaDon";
            comboBoxMaHD.ValueMember = "MaHoaDon";
        }
        void loadInfoKhachHangByMaHD(string mahd)
        {
            DataTable dt = HoaDonBanSach_BUS.Instance.selectInfoKhachHangByMaHD(mahd);
            foreach (DataRow r in dt.Rows)
            {
                txtMaKH.Text = r["MaKhachHang"].ToString();
                txtTenKH.Text = r["TenKhachHang"].ToString();
                txtDiaChi.Text = r["DiaChi"].ToString();
                txtEmail.Text = r["Email"].ToString();
                txtSDT.Text = r["SDT"].ToString();
            }

        }
        DataTable initDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaPhieuThuTien", typeof(string))); // index = 0
            dt.Columns.Add(new DataColumn("MaKhachHang", typeof(string))); // index = 1
            dt.Columns.Add(new DataColumn("NgayThuTien", typeof(string))); // index = 2
            dt.Columns.Add(new DataColumn("SoTienThu", typeof(string))); // index = 3
            dt.Columns.Add(new DataColumn("Chon", typeof(bool))); // index = 4
            dt.Columns["Chon"].DefaultValue = true;
            return dt;
        }
        void loadDanhSachCacPhieuThuTienDaLap()
        {
            DataTable dt = PhieuThuTien_BUS.Instance.selectAllData();
            dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
            dt.Columns["Chon"].DefaultValue = true;
            dataGVDanhSachPhieuThuTien.DataSource = dt;
            dataGVDanhSachPhieuThuTien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void btnLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            PhieuThuTien_DTO pt = new PhieuThuTien_DTO();
            pt.MaPhieuTien = txtMaPhieuThu.Text;
            pt.MaKhachHang = txtMaKH.Text;
            pt.NgayThuTien = txtNgayThuTien.Value.ToShortDateString();
            pt.SoTienThu = int.Parse(txtSoTienThu.Text);

            DataTable dt = KhachHang_BUS.Instance.selectTienNoCuaKhachhangByMaKH(pt.MaKhachHang);
            DataRow row = dt.Rows[0];
            int tienocuakh = int.Parse(row["TienNo"].ToString());
            bool quydinh = QuyDinh_BUS.Instance.checkQD_4(pt.SoTienThu, tienocuakh);

            if (tienocuakh == 0)
            {
                if (PhieuThuTien_BUS.Instance.insertPhieuThuTien(pt))
                {
                    string mess = string.Format("Thêm phiếu thu tiền thành công");
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Thêm phiếu thu tiền thất bại");
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            else if (quydinh == true)
            {

                if (PhieuThuTien_BUS.Instance.insertPhieuThuTien(pt))
                {
                    string mess = string.Format("Thêm phiếu thu tiền thành công");
                    MessageBox.Show(mess, "Thông báo");
                    if (checkBoxYes.Checked == true) // khách hàng đồng ý thanh toán nợ
                    {
                        // cập nhật tiền nợ của khách hàng đó về 0
                        KhachHang_BUS.Instance.updateTienNoCuaKhSauKhiThanhToanNo(pt.MaKhachHang);
                    }
                }
                else
                {
                    string mess = string.Format("Thêm phiếu thu tiền thất bại");
                    MessageBox.Show(mess, "Thông báo");
                }

            }
            else if (quydinh == false)
            {
                string mess = string.Format("Thêm phiếu thu tiền thất bại, vì số tiền thu của khách hàng {0} vượt quá số tiền đang nợ", pt.MaKhachHang);
                MessageBox.Show(mess, "Thông báo");
            }
            loadDanhSachCacPhieuThuTienDaLap();
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
        private void btnCapNhatPhieuThuTien_Click(object sender, EventArgs e)
        {
            List<PhieuThuTien_DTO> listPhieuThu = new List<PhieuThuTien_DTO>();
            foreach (DataGridViewRow row in dataGVDanhSachPhieuThuTien.Rows)
            {
                if (isNotEmpty(row))
                {
                    if (row.Cells[4].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[4].Value.ToString()) == true)
                        {
                            listPhieuThu.Add(new PhieuThuTien_DTO()
                            {
                                MaPhieuTien = row.Cells[0].Value.ToString(),
                                MaKhachHang = row.Cells[1].Value.ToString(),
                                NgayThuTien = row.Cells[2].Value.ToString(),
                                SoTienThu = int.Parse(row.Cells[3].Value.ToString())
                            });
                        }
                    }
                }
            }


            foreach (var item in listPhieuThu)
            {
                DataTable dt = KhachHang_BUS.Instance.selectTienNoCuaKhachhangByMaKH(item.MaKhachHang);
                DataRow row = dt.Rows[0];
                int tienocuakh = int.Parse(row["TienNo"].ToString());
                bool quydinh = QuyDinh_BUS.Instance.checkQD_4(item.SoTienThu, tienocuakh);

                if (tienocuakh == 0)
                {
                    if (PhieuThuTien_BUS.Instance.updatePhieuThuTien(item))
                    {
                        string mess = string.Format("Cập nhật phiếu thu tiền thành công");
                        MessageBox.Show(mess, "Thông báo");
                        
                    }
                    else
                    {
                        string mess = string.Format("Cập nhật phiếu thu tiền thất bại");
                        MessageBox.Show(mess, "Thông báo");
                        
                    }
                }
                else if (quydinh == true)
                {

                    if (PhieuThuTien_BUS.Instance.updatePhieuThuTien(item))
                    {
                        string mess = string.Format("Cập nhật phiếu thu tiền thành công");
                        MessageBox.Show(mess, "Thông báo");
                        
                    }
                    else
                    {
                        string mess = string.Format("Cập nhật phiếu thu tiền thất bại");
                        MessageBox.Show(mess, "Thông báo");
                        
                    }

                }
                else if (quydinh == false)
                {
                    string mess = string.Format("Cập nhật phiếu thu tiền thất bại, vì số tiền thu của khách hàng {0} vượt quá số tiền đang nợ", item.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                    
                }
            }
            loadDanhSachCacPhieuThuTienDaLap();
        }

        private void btnXoaPhieuThuTien_Click(object sender, EventArgs e)
        {
            List<PhieuThuTien_DTO> listPhieuThu = new List<PhieuThuTien_DTO>();
            foreach (DataGridViewRow row in dataGVDanhSachPhieuThuTien.Rows)
            {
                if (isNotEmpty(row))
                {
                    if (row.Cells[4].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[4].Value.ToString()) == true)
                        {
                            listPhieuThu.Add(new PhieuThuTien_DTO()
                            {
                                MaPhieuTien = row.Cells[0].Value.ToString(),
                                MaKhachHang = row.Cells[1].Value.ToString(),
                                NgayThuTien = row.Cells[2].Value.ToString(),
                                SoTienThu = int.Parse(row.Cells[3].Value.ToString())
                            });
                        }
                    }
                }
            }

            foreach (var item in listPhieuThu)
            {
                if(PhieuThuTien_BUS.Instance.deletePhieuThuTien(item))
                {
                    string mess = string.Format("Xóa phiếu thu tiền {0} thành công", item.MaPhieuTien);
                    MessageBox.Show(mess, "THông báo");
                    
                }
                else
                {
                    string mess = string.Format("Xóa phiếu thu tiền {0} không thành công", item.MaPhieuTien);
                    MessageBox.Show(mess, "THông báo");
                }
            }
            loadDanhSachCacPhieuThuTienDaLap();
        }

        private void comboBoxMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInfoKhachHangByMaHD(comboBoxMaHD.Text);
            if (checkBoxNo.Checked == true)
            {
                int sotienthu = PhieuThuTien_BUS.Instance.tinhSoTienThu(comboBoxMaHD.Text, txtMaKH.Text);
                txtSoTienThu.Text = sotienthu.ToString();
                checkBoxYes.Checked = false;
            }
            else if (checkBoxYes.Checked == true)
            {
                int sotienthu = PhieuThuTien_BUS.Instance.thanhToanTienNoCuaKhachHang(comboBoxMaHD.Text, txtMaKH.Text);
                txtSoTienThu.Text = sotienthu.ToString();
                checkBoxNo.Checked = false;
            }
        }

        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYes.Checked == true)
            {
                int sotienthu = PhieuThuTien_BUS.Instance.thanhToanTienNoCuaKhachHang(comboBoxMaHD.Text, txtMaKH.Text);
                txtSoTienThu.Text = sotienthu.ToString();
                checkBoxNo.Checked = false;
            }
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo.Checked == true)
            {
                int sotienthu = PhieuThuTien_BUS.Instance.tinhSoTienThu(comboBoxMaHD.Text, txtMaKH.Text);
                txtSoTienThu.Text = sotienthu.ToString();
                checkBoxYes.Checked = false;
            }
        }
    }
}
