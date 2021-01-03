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
    public partial class FormHoaDonBanSach : Form
    {
        public FormHoaDonBanSach()
        {
            InitializeComponent();
            loadDanhSachMaKhachHang();
            loadTenKhachHangByMaKH(comboBoxMaKH.Text);
            loadDanhSachHoaDonDaLap();
            settingDataGridView(dataGVHoaDon);
            settingDataGridView(dataGVCTHoaDon);
        }

        void loadDanhSachMaKhachHang()
        {
            comboBoxMaKH.DataSource = KhachHang_BUS.Instance.selectAllMaKhachHang();
            comboBoxMaKH.DisplayMember = "MaKhachHang";
            comboBoxMaKH.ValueMember = "MaKhachHang";
        }
        void loadTenKhachHangByMaKH(string makh)
        {
            DataTable dt = KhachHang_BUS.Instance.selectTenKhachHangByMaKH(makh);
            foreach (DataRow row in dt.Rows)
            {
                txtTenKH.Text = row["TenKhachHang"].ToString();
            }
        }
        void loadDanhSachHoaDonDaLap()
        {
            DataTable dt = HoaDonBanSach_BUS.Instance.selectAllHoaDon();
            dataGVHoaDon.DataSource = dt;
        }
        DataTable initDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSach", typeof(string))); // index = 0
            dt.Columns.Add(new DataColumn("TenSach", typeof(string))); // index = 1
            dt.Columns.Add(new DataColumn("TheLoai", typeof(string))); // index = 2
            dt.Columns.Add(new DataColumn("TacGia", typeof(string))); // index = 3
            dt.Columns.Add(new DataColumn("SoLuongBan", typeof(string))); // index = 4
            dt.Columns.Add(new DataColumn("DonGia", typeof(string))); // index = 5
            dt.Columns.Add(new DataColumn("Chon", typeof(bool))); // index = 6
            dt.Columns["Chon"].DefaultValue = true;
            dt.Columns["TenSach"].ReadOnly = true;
            dt.Columns["TheLoai"].ReadOnly = true;
            dt.Columns["TacGia"].ReadOnly = true;
            return dt;
        }
        void settingDataGridView(DataGridView dataGV)
        {
            dataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        // Start hoa don
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonBanSach_DTO hd = new HoaDonBanSach_DTO();
            hd.MaHoaDon = txtMaHD.Text;
            hd.MaKhachHang = comboBoxMaKH.Text;
            hd.NgayLapHoaDon = txtNgayLap.Value.ToShortDateString();

            DataTable dt  = KhachHang_BUS.Instance.selectTienNoCuaKhachhangByMaKH(hd.MaKhachHang);
            DataRow row = dt.Rows[0];
            int tienNoCuaKH = int.Parse(row["TienNo"].ToString());
            bool quydinh = QuyDinh_BUS.Instance.checkTienNoCuaKhachHang(tienNoCuaKH);
            if(quydinh)
            {
                if(HoaDonBanSach_BUS.Instance.insertHoaDon(hd))
                {
                    string mess = string.Format("Lập hóa đơn cho mã khách hàng {0} thành công", hd.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                    loadDanhSachHoaDonDaLap();
                    dataGVCTHoaDon.DataSource = initDataTable();
                }
            }
            else
            {
                DataTable temp = QuyDinh_BUS.Instance.selectThamSoQD_2();
                DataRow r = temp.Rows[0];
                string mess = string.Format("Không thể lập hóa đơn {0} cho mã khách hàng {1} vì số nợ của khách hàng này vượt quá {2}", hd.MaHoaDon, hd.MaKhachHang, r["TienNoToiDa"].ToString());
                MessageBox.Show(mess, "Thông báo");
            }
        }

        private void btnCapNhatHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVHoaDon.Rows[dataGVHoaDon.CurrentCell.RowIndex];
            HoaDonBanSach_DTO hd = new HoaDonBanSach_DTO();
            hd.MaHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();
            hd.MaKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
            hd.NgayLapHoaDon = selectedRow.Cells["NgayLapHoaDon"].Value.ToString();

            DataTable dt = KhachHang_BUS.Instance.selectTienNoCuaKhachhangByMaKH(hd.MaKhachHang);
            DataRow row = dt.Rows[0];
            int tienNoCuaKH = int.Parse(row["TienNo"].ToString());
            
            bool quydinh = QuyDinh_BUS.Instance.checkTienNoCuaKhachHang(tienNoCuaKH);
            if (quydinh)
            {
                if (HoaDonBanSach_BUS.Instance.updateHoaDon(hd))
                {
                    string mess = string.Format("Cập nhật hóa đơn {0} cho mã khách hàng {1} thành công", hd.MaHoaDon, hd.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                    loadDanhSachHoaDonDaLap();
                }
            }
            else
            {
                DataTable temp = QuyDinh_BUS.Instance.selectThamSoQD_2();
                DataRow r = temp.Rows[0];
                string mess = string.Format("Không thể cập nhật hóa đơn {0} cho mã khách hàng {1} vì số nợ của khách hàng này vượt quá {2}", hd.MaHoaDon, hd.MaKhachHang, r["TienNoToiDa"].ToString());
                MessageBox.Show(mess, "Thông báo");
                loadDanhSachHoaDonDaLap();
            }
        }

        private void btnDeleteHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVHoaDon.Rows[dataGVHoaDon.CurrentCell.RowIndex];
            HoaDonBanSach_DTO hd = new HoaDonBanSach_DTO();
            hd.MaHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();
            hd.MaKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
            hd.NgayLapHoaDon = selectedRow.Cells["NgayLapHoaDon"].Value.ToString();

            if(HoaDonBanSach_BUS.Instance.deleteHoaDon(hd))
            {
                string mess = string.Format("Xóa hóa đơn {0} thành công", hd.MaHoaDon);
                MessageBox.Show(mess, "Thông báo");
                loadDanhSachHoaDonDaLap();
            }
            else
            {
                string mess = string.Format("Xóa hóa đơn {0} không thành công", hd.MaHoaDon);
                MessageBox.Show(mess, "Thông báo");
            }
        }

        private void btnXemChiTietHD_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVHoaDon.Rows[dataGVHoaDon.CurrentCell.RowIndex];
            HoaDonBanSach_DTO hd = new HoaDonBanSach_DTO();
            hd.MaHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();
            hd.MaKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
            hd.NgayLapHoaDon = selectedRow.Cells["NgayLapHoaDon"].Value.ToString();

            lblMaHD.Text = hd.MaHoaDon;
            lblNgayLapHD.Text = hd.NgayLapHoaDon;

            DataTable dt = ChiTietHoaDonBanSach_BUS.Instance.selectInfoChiTietHoaDonBanSachByMaHD(hd.MaHoaDon);
            dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
            dt.Columns["Chon"].DefaultValue = true;
            dt.Columns["TenSach"].ReadOnly = true;
            dt.Columns["TheLoai"].ReadOnly = true;
            dt.Columns["TacGia"].ReadOnly = true;
            dataGVCTHoaDon.DataSource = dt;
        }


        // Start chi tiết hóa đơn
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
        private void btnLapCTHoaDon_Click(object sender, EventArgs e)
        {
            List<ChiTietHoaDonBanSach_DTO> listCTHD = new List<ChiTietHoaDonBanSach_DTO>();

            foreach (DataGridViewRow row in dataGVCTHoaDon.Rows)
            {
                if(isNotEmpty(row))
                {
                    if (row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listCTHD.Add(new ChiTietHoaDonBanSach_DTO()
                            {
                                MaHoaDon = lblMaHD.Text,
                                MaSach = row.Cells[0].Value.ToString(),
                                SoLuongBan = int.Parse(row.Cells[4].Value.ToString()),
                                DonGiaBan = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }

            for (int i = 0; i < listCTHD.Count; i++)
            {
                bool updateSauBan = Sach_BUS.Instance.updateSoLuongTonSauKhiBan(listCTHD[i].MaSach, listCTHD[i].SoLuongBan);
                if(updateSauBan)
                {
                    DataTable dt = Sach_BUS.Instance.selectSoLuongTonBy(listCTHD[i].MaSach);
                    DataRow row = dt.Rows[0];
                    int soluongtonsaukhiban = int.Parse(row["SoLuongTon"].ToString());
                    bool quydinh = QuyDinh_BUS.Instance.checkSoLuongTonSauKhiBan(soluongtonsaukhiban);
                    if(quydinh == true)
                    {
                        if(ChiTietHoaDonBanSach_BUS.Instance.insertChiTietHoaDonBanSach(listCTHD[i]))
                        {
                            string mess = string.Format("Thêm chi tiết hóa đơn bán sách {0} thành công", listCTHD[i].MaHoaDon);
                            MessageBox.Show(mess, "Thông báo");
                        }
                        else
                        {
                            string mess = string.Format("Thêm chi tiết hóa đơn bán sách {0} không thành công", listCTHD[i].MaHoaDon);
                            MessageBox.Show(mess, "Thông báo");
                        }
                    }
                    else
                    {
                        Sach_BUS.Instance.updateSoLuongTonSauKhiBanKhongThanhCong(listCTHD[i].MaSach, listCTHD[i].SoLuongBan);
                        string mess = string.Format("Không thêm được chi tiết hóa đơn bán sách {0} , vì mã sách {1} có số lượng tồn sau khi bán nhỏ hơn 20", listCTHD[i].MaHoaDon, listCTHD[i].MaSach);
                        MessageBox.Show(mess, "Thông báo");
                    }
                }
            }
        }

        private void btnCapNhatCTHoaDon_Click(object sender, EventArgs e)
        {
            List<ChiTietHoaDonBanSach_DTO> listCTHD = new List<ChiTietHoaDonBanSach_DTO>();

            foreach (DataGridViewRow row in dataGVCTHoaDon.Rows)
            {
                if (isNotEmpty(row))
                {
                    if (row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listCTHD.Add(new ChiTietHoaDonBanSach_DTO()
                            {
                                MaHoaDon = lblMaHD.Text,
                                MaSach = row.Cells[0].Value.ToString(),
                                SoLuongBan = int.Parse(row.Cells[4].Value.ToString()),
                                DonGiaBan = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }

            for (int i = 0; i < listCTHD.Count; i++)
            {
                bool updateSauBan = Sach_BUS.Instance.updateSoLuongTonSauKhiBan(listCTHD[i].MaSach, listCTHD[i].SoLuongBan);
                if (updateSauBan)
                {
                    DataTable dt = Sach_BUS.Instance.selectSoLuongTonBy(listCTHD[i].MaSach);
                    DataRow row = dt.Rows[0];
                    int soluongtonsaukhiban = int.Parse(row["SoLuongTon"].ToString());
                    bool quydinh = QuyDinh_BUS.Instance.checkSoLuongTonSauKhiBan(soluongtonsaukhiban);
                    if (quydinh == true)
                    {
                        if (ChiTietHoaDonBanSach_BUS.Instance.updateChiTietHoaDonBanSach(listCTHD[i]))
                        {
                            string mess = string.Format("Cập nhật chi tiết hóa đơn bán sách {0} thành công", listCTHD[i].MaHoaDon);
                            MessageBox.Show(mess, "Thông báo");
                        }
                        else
                        {
                            string mess = string.Format("Cập nhật chi tiết hóa đơn bán sách {0} không thành công", listCTHD[i].MaHoaDon);
                            MessageBox.Show(mess, "Thông báo");
                        }
                    }
                    else
                    {
                        Sach_BUS.Instance.updateSoLuongTonSauKhiBanKhongThanhCong(listCTHD[i].MaSach, listCTHD[i].SoLuongBan);
                        string mess = string.Format("Không cập nhật được chi tiết hóa đơn bán sách {0} , vì mã sách {1} có số lượng tồn sau khi bán nhỏ hơn 20", listCTHD[i].MaHoaDon, listCTHD[i].MaSach);
                        MessageBox.Show(mess, "Thông báo");
                    }
                }
            }
        }

        private void btnXoaCTHoaDon_Click(object sender, EventArgs e)
        {
            List<ChiTietHoaDonBanSach_DTO> listCTHD = new List<ChiTietHoaDonBanSach_DTO>();

            foreach (DataGridViewRow row in dataGVCTHoaDon.Rows)
            {
                if (isNotEmpty(row))
                {
                    if (row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listCTHD.Add(new ChiTietHoaDonBanSach_DTO()
                            {
                                MaHoaDon = lblMaHD.Text,
                                MaSach = row.Cells[0].Value.ToString(),
                                SoLuongBan = int.Parse(row.Cells[4].Value.ToString()),
                                DonGiaBan = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }

            for (int i = 0; i < listCTHD.Count; i++)
            {
                if(ChiTietHoaDonBanSach_BUS.Instance.deleteChiTietHoaDonBanSach(listCTHD[i]))
                {
                    string mess = string.Format("Xóa mã sách {0} của hóa đơn {1} thành công", listCTHD[i].MaSach, listCTHD[i].MaHoaDon);
                    MessageBox.Show(mess, "Thông báo");
                    DataTable dt = ChiTietHoaDonBanSach_BUS.Instance.selectInfoChiTietHoaDonBanSachByMaHD(listCTHD[i].MaHoaDon);
                    dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
                    dt.Columns["Chon"].DefaultValue = true;
                    dt.Columns["TenSach"].ReadOnly = true;
                    dt.Columns["TheLoai"].ReadOnly = true;
                    dt.Columns["TacGia"].ReadOnly = true;
                    dataGVCTHoaDon.DataSource = dt;
                }
                else
                {
                    string mess = string.Format("Xóa mã sách {0} của hóa đơn {1} không thành công", listCTHD[i].MaSach, listCTHD[i].MaHoaDon);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
        }

        private void comboBoxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTenKhachHangByMaKH(comboBoxMaKH.Text);
        }

        private void dataGVCTHoaDon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGVCTHoaDon.Rows[dataGVCTHoaDon.CurrentCell.RowIndex];
            string masach = selectedRow.Cells["MaSach"].Value.ToString();
            DataTable dt = Sach_BUS.Instance.selectAllDataBy(masach);
            dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
            dt.Columns["Chon"].DefaultValue = true;
            dt.Columns["TenSach"].ReadOnly = true;
            dt.Columns["TheLoai"].ReadOnly = true;
            dt.Columns["TacGia"].ReadOnly = true;
            int temp = 0;
            foreach (DataRow row in dt.Rows)
            {
                selectedRow.Cells["MaSach"].Value = masach;
                selectedRow.Cells["TenSach"].Value = row["TenSach"].ToString();
                selectedRow.Cells["TheLoai"].Value = row["TheLoai"].ToString();
                selectedRow.Cells["TacGia"].Value = row["TacGia"].ToString();
                selectedRow.Cells["SoLuongBan"].Value = temp.ToString();
                selectedRow.Cells["DonGiaBan"].Value = row["DonGiaBan"].ToString();
            }
        }
    }
}
