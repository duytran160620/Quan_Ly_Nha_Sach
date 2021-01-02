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
    public partial class FormPhieuNhapSach : Form
    {
        public FormPhieuNhapSach()
        {
            InitializeComponent();
            // Hiện ngày hiện tại lên textbox
            txtNgayNhap.Text = DateTime.Now.ToShortDateString();
            // load toàn bộ phiếu nhập hiện tại lên datagridview
            loadAllPhieuNhapSach();
            // setting selection mode = full row select
            settingDataGridView(dataGVPhieuNhapSach);
            settingDataGridView(dataGVCTPhieuNhapSach);


        }
        void settingDataGridView(DataGridView dataGV)
        {
            dataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void loadAllPhieuNhapSach()
        {
            PhieuNhapSach_BUS.Instance.loadAllPhieuNhapSach(dataGVPhieuNhapSach);
        }

        DataTable initDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("MaSach", typeof(string)));
            dt.Columns.Add(new DataColumn("SoLuongNhap", typeof(string)));
            dt.Columns.Add(new DataColumn("TenSach", typeof(string)));
            dt.Columns.Add(new DataColumn("TheLoai", typeof(string)));
            dt.Columns.Add(new DataColumn("TacGia", typeof(string)));
            dt.Columns.Add(new DataColumn("SoLuongTon", typeof(string)));
            dt.Columns.Add(new DataColumn("DonGiaBan", typeof(string)));
            dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
            return dt;
        }
        // Start Phieu Nhap Sach
        private void btnLapPhieuNhapSach_Click(object sender, EventArgs e)
        {
            PhieuNhapSach_DTO pn;
            string maPN = txtMaPN.Text;
            string ngayNhap = txtNgayNhap.Text;
            pn = new PhieuNhapSach_DTO();
            pn.MaPhieuNhap = maPN;
            pn.NgayNhap = ngayNhap;
            if (PhieuNhapSach_BUS.Instance.insertPhieuNhapSach(pn))
            {
                // Thông báo
                string mess = string.Format("Thêm phiếu nhập {0} thành công", pn.MaPhieuNhap);
                MessageBox.Show(mess, "Thông báo");
                // Load lại toàn bộ phiếu nhập
                loadAllPhieuNhapSach();
                // Hiển thị mã phiếu nhập và ngày nhập mới
                lblMaPN.Text = pn.MaPhieuNhap;
                lblNgayNhap.Text = pn.NgayNhap;
                dataGVCTPhieuNhapSach.DataSource = initDataTable();

            }
            else
            {
                string mess = string.Format("Thêm phiếu nhập {0} không thành công", pn.MaPhieuNhap);
                MessageBox.Show(mess, "Thông báo");
            }


        }

        private void btnCapNhatPhieuNhapSach_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dataGVPhieuNhapSach.Rows[dataGVPhieuNhapSach.CurrentCell.RowIndex];
            string maPN = selectedRow.Cells["MaPhieuNhap"].Value.ToString();
            string ngayNhap = selectedRow.Cells["NgayNhap"].Value.ToString();
            PhieuNhapSach_DTO pn = new PhieuNhapSach_DTO();
            pn.MaPhieuNhap = maPN;
            pn.NgayNhap = ngayNhap;


            if (PhieuNhapSach_BUS.Instance.updatePhieuNhapSach(pn))
            {
                string mess = string.Format("Cập nhật phiếu nhập {0} thành công", pn.MaPhieuNhap);
                MessageBox.Show(mess, "Thông báo");
                loadAllPhieuNhapSach();
            }
            else
            {
                string mess = string.Format("Cập nhật phiếu nhập {0} không thành công", pn.MaPhieuNhap);
                MessageBox.Show(mess, "Thông báo");
            }
        }

        private void btnXoaPhieuNhapSach_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGVPhieuNhapSach.Rows[dataGVPhieuNhapSach.CurrentCell.RowIndex];
            string maPN = selectedRow.Cells["MaPhieuNhap"].Value.ToString();
            PhieuNhapSach_DTO pn = new PhieuNhapSach_DTO();
            pn.MaPhieuNhap = maPN;
            if (PhieuNhapSach_BUS.Instance.deletePhieuNhapSach(pn))
            {
                string mess = string.Format("Xóa phiếu nhập {0} thành công", pn.MaPhieuNhap);
                MessageBox.Show(mess, "Thông báo");
                
                loadAllPhieuNhapSach();
            }
            else
            {
                string mess = string.Format("Xóa phiếu nhập {0} không thành công", pn.MaPhieuNhap);
                MessageBox.Show(mess, "Thông báo");
                
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            // lấy data từ datagridview
            DataGridViewRow selectedRow = dataGVPhieuNhapSach.Rows[dataGVPhieuNhapSach.CurrentCell.RowIndex];
            string mapn = selectedRow.Cells["MaPhieuNhap"].Value.ToString();
            string ngaynhap = selectedRow.Cells["NgayNhap"].Value.ToString();

            // tạo object
            PhieuNhapSach_DTO pn = new PhieuNhapSach_DTO();
            pn.MaPhieuNhap = mapn;
            pn.NgayNhap = ngaynhap;
            // hiển thị thồng tin mã phiếu, ngày nhập lên label
            lblMaPN.Text = pn.MaPhieuNhap;
            lblNgayNhap.Text = pn.NgayNhap;
            // hiển thị chi tiết phiếu tương ứng lên datagridviewct

            DataTable dt = ChiTietPhieuNhapSach_BUS.Instance.selectInfoCTPhieuNhap(new ChiTietPhieuNhapSach_DTO()
            {
                MaPhieuNhap = pn.MaPhieuNhap
            });
            dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
            dataGVCTPhieuNhapSach.DataSource = dt;

        }

        // Start CT Phieu Nhap Sach
        bool checkrow(DataGridViewRow testrow)
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
        private void btnLapCTPhieuNhapSach_Click(object sender, EventArgs e)
        {
            List<ChiTietPhieuNhapSach_DTO> listCT = new List<ChiTietPhieuNhapSach_DTO>();
            List<Sach_DTO> listSach = new List<Sach_DTO>();
            foreach (DataGridViewRow row in dataGVCTPhieuNhapSach.Rows)
            {
                if (checkrow(row))
                {
                    if (row.Cells[7].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[7].Value.ToString()) == true)
                        {
                            listCT.Add(new ChiTietPhieuNhapSach_DTO()
                            {
                                MaPhieuNhap = lblMaPN.Text,
                                MaSach = row.Cells[0].Value.ToString(),
                                SoLuongNhap = int.Parse(row.Cells[1].Value.ToString())
                            });
                            listSach.Add(new Sach_DTO()
                            {
                                MaSach = row.Cells[0].Value.ToString(),
                                TenSach = row.Cells[2].Value.ToString(),
                                TheLoai = row.Cells[3].Value.ToString(),
                                TacGia = row.Cells[4].Value.ToString(),
                                SoLuongTon = int.Parse(row.Cells[5].Value.ToString()),
                                DonGiaBan = int.Parse(row.Cells[6].Value.ToString())
                            });
                        }
                    }
                }
            }
            for (int i = 0; i < listCT.Count; i++)
            {
                bool quydinh_1a = ChiTietPhieuNhapSach_BUS.Instance.checkQD_1(listCT[i].SoLuongNhap);
                bool quydinh_1b = Sach_BUS.Instance.checkQD_1(listSach[i].SoLuongTon);
                if (quydinh_1a == false && quydinh_1b == true)
                {
                    string mess = string.Format("Không thêm được mã sách {0} vì số lượng nhập phải ít nhất là 150", listCT[i].MaSach);
                    MessageBox.Show(mess, "Thông báo");
                    dataGVCTPhieuNhapSach.Rows.RemoveAt(i);
                }
                else if (quydinh_1a == true && quydinh_1b == false)
                {
                    string mess = string.Format("Không thêm được mã sách {0} vì số lượng tồn tối thiểu phải ít hơn là 300", listCT[i].MaSach);
                    MessageBox.Show(mess, "Thông báo");
                    dataGVCTPhieuNhapSach.Rows.RemoveAt(i);
                }
                else if (quydinh_1a == true && quydinh_1b == true)
                {
                    // kiểm tra true false // hiện thông báo
                    if (ChiTietPhieuNhapSach_BUS.Instance.insertChiTietPhieuNhapSach(listCT[i]))
                    {
                        string mess = string.Format("Thêm mã sách {0} thành công", listCT[i].MaSach);
                        MessageBox.Show(mess, "Thông báo");
                    }
                    else
                    {
                        string mess = string.Format("Thêm mã sách {0} không thành công", listCT[i].MaSach);
                        MessageBox.Show(mess, "Thông báo");
                    }
                }
            }
        }

        private void btnCapNhatCTPhieuNhapSach_Click(object sender, EventArgs e)
        {
            List<ChiTietPhieuNhapSach_DTO> listCT = new List<ChiTietPhieuNhapSach_DTO>();
            List<Sach_DTO> listSach = new List<Sach_DTO>();
            foreach (DataGridViewRow row in dataGVCTPhieuNhapSach.Rows)
            {
                if (checkrow(row))
                {
                    if (row.Cells[7].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[7].Value.ToString()) == true)
                        {
                            listCT.Add(new ChiTietPhieuNhapSach_DTO()
                            {
                                MaPhieuNhap = lblMaPN.Text,
                                MaSach = row.Cells[0].Value.ToString(),
                                SoLuongNhap = int.Parse(row.Cells[1].Value.ToString())
                            });
                            listSach.Add(new Sach_DTO()
                            {
                                MaSach = row.Cells[0].Value.ToString(),
                                TenSach = row.Cells[2].Value.ToString(),
                                TheLoai = row.Cells[3].Value.ToString(),
                                TacGia = row.Cells[4].Value.ToString(),
                                SoLuongTon = int.Parse(row.Cells[5].Value.ToString()),
                                DonGiaBan = int.Parse(row.Cells[6].Value.ToString())
                            });
                        }
                    }
                }
            }
            for (int i = 0; i < listCT.Count; i++)
            {
                bool quydinh_1a = ChiTietPhieuNhapSach_BUS.Instance.checkQD_1(listCT[i].SoLuongNhap);
                bool quydinh_1b = Sach_BUS.Instance.checkQD_1(listSach[i].SoLuongTon);
                if (quydinh_1a == false && quydinh_1b == true)
                {
                    string mess = string.Format("Không cập nhật được mã sách {0} vì số lượng nhập phải ít nhất là 150", listCT[i].MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
                else if (quydinh_1a == true && quydinh_1b == false)
                {
                    string mess = string.Format("Không cập nhật được mã sách {0} vì số lượng tồn tối thiểu phải ít hơn là 300", listCT[i].MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
                else if (quydinh_1a == true && quydinh_1b == true)
                {
                    // kiểm tra true false // hiện thông báo
                    if (ChiTietPhieuNhapSach_BUS.Instance.updateChiTietPhieuNhapSach(listCT[i]))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công", "Thông báo");
                    }
                }
            }
        }

        private void btnXoaCTPhieuNhapSach_Click(object sender, EventArgs e)
        {
            List<ChiTietPhieuNhapSach_DTO> listCT = new List<ChiTietPhieuNhapSach_DTO>();
            foreach (DataGridViewRow row in dataGVCTPhieuNhapSach.Rows)
            {
                if (checkrow(row))
                {
                    if (row.Cells[7].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[7].Value.ToString()) == true)
                        {
                            listCT.Add(new ChiTietPhieuNhapSach_DTO()
                            {
                                MaPhieuNhap = lblMaPN.Text,
                                MaSach = row.Cells[0].Value.ToString(),
                                SoLuongNhap = int.Parse(row.Cells[1].Value.ToString())
                            });
                        }
                    }
                }
            }
            for (int i = 0; i < listCT.Count; i++)
            {
                // kiểm tra true false // hiện thông báo
                if (ChiTietPhieuNhapSach_BUS.Instance.deleteChiTietPhieuNhapSach(listCT[i]))
                {
                    string mess = string.Format("Xóa mã sách {0} thành công", listCT[i].MaSach);
                    MessageBox.Show(mess, "Thông báo");
                    DataTable dt = ChiTietPhieuNhapSach_BUS.Instance.selectInfoCTPhieuNhap(new ChiTietPhieuNhapSach_DTO()
                    {
                        MaPhieuNhap = listCT[i].MaPhieuNhap
                    });
                    dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
                    dataGVCTPhieuNhapSach.DataSource = dt;
                }
                else
                {
                    string mess = string.Format("Xóa mã sách {0} không thành công", listCT[i].MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
        }


        
        private void dataGVCTPhieuNhapSach_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGVCTPhieuNhapSach.Rows[dataGVCTPhieuNhapSach.CurrentCell.RowIndex];
            string masach = selectedRow.Cells["MaSach"].Value.ToString();
            DataTable dt = Sach_BUS.Instance.selectAllDataBy(masach);
            dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
            int temp = 0;
            foreach (DataRow row in dt.Rows)
            {
                selectedRow.Cells["MaSach"].Value = masach;
                selectedRow.Cells["SoLuongNhap"].Value = temp.ToString();
                selectedRow.Cells["TenSach"].Value = row["TenSach"].ToString();
                selectedRow.Cells["TheLoai"].Value = row["TheLoai"].ToString();
                selectedRow.Cells["TacGia"].Value = row["TacGia"].ToString();
                selectedRow.Cells["SoLuongTon"].Value = row["SoLuongTon"].ToString();
                selectedRow.Cells["DonGiaBan"].Value = row["DonGiaBan"].ToString();
            }
        }






    }
}
