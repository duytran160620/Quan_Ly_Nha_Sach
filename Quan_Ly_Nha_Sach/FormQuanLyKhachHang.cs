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
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
            loadDanhSachKhachHang();
        }
        void loadDanhSachKhachHang()
        {
            DataTable dt = KhachHang_BUS.Instance.selectDanhSachKhachHang();
            dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
            dataGVDanhSachKH.DataSource = dt;
            dataGVDanhSachKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            List<KhachHang_DTO> listKH = new List<KhachHang_DTO>();
            foreach (DataGridViewRow row in dataGVDanhSachKH.Rows)
            {
                if(isNotEmpty(row))
                {
                    if(row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if(Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listKH.Add(new KhachHang_DTO()
                            {
                                MaKhachHang = row.Cells[0].Value.ToString(),
                                TenKhachHang = row.Cells[1].Value.ToString(),
                                Email = row.Cells[2].Value.ToString(),
                                SDT = row.Cells[3].Value.ToString(),
                                DiaChi = row.Cells[4].Value.ToString(),
                                TienNo = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }


            foreach (var item in listKH)
            {
                if(KhachHang_BUS.Instance.insertKhachHang(item))
                {
                    string mess = string.Format("Thêm thông tin khách hàng {0} thành công", item.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Thêm thông tin khách hàng {0} thất bại", item.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            loadDanhSachKhachHang();
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            List<KhachHang_DTO> listKH = new List<KhachHang_DTO>();
            foreach (DataGridViewRow row in dataGVDanhSachKH.Rows)
            {
                if (isNotEmpty(row))
                {
                    if (row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listKH.Add(new KhachHang_DTO()
                            {
                                MaKhachHang = row.Cells[0].Value.ToString(),
                                TenKhachHang = row.Cells[1].Value.ToString(),
                                Email = row.Cells[2].Value.ToString(),
                                SDT = row.Cells[3].Value.ToString(),
                                DiaChi = row.Cells[4].Value.ToString(),
                                TienNo = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }


            foreach (var item in listKH)
            {
                if (KhachHang_BUS.Instance.updateKhachHang(item))
                {
                    string mess = string.Format("Cập nhật thông tin khách hàng {0} thành công", item.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Cập nhật thông tin khách hàng {0} thất bại", item.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            loadDanhSachKhachHang();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            List<KhachHang_DTO> listKH = new List<KhachHang_DTO>();
            foreach (DataGridViewRow row in dataGVDanhSachKH.Rows)
            {
                if (isNotEmpty(row))
                {
                    if (row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listKH.Add(new KhachHang_DTO()
                            {
                                MaKhachHang = row.Cells[0].Value.ToString(),
                                TenKhachHang = row.Cells[1].Value.ToString(),
                                Email = row.Cells[2].Value.ToString(),
                                SDT = row.Cells[3].Value.ToString(),
                                DiaChi = row.Cells[4].Value.ToString(),
                                TienNo = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }


            foreach (var item in listKH)
            {
                if (KhachHang_BUS.Instance.deleteKhachHang(item))
                {
                    string mess = string.Format("Xóa thông tin khách hàng {0} thành công", item.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Xóa thông tin khách hàng {0} thất bại", item.MaKhachHang);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            loadDanhSachKhachHang();
        }
    }
}
