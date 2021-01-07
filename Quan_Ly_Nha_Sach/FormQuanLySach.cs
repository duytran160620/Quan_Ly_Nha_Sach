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
    public partial class FormQuanLySach : Form
    {
        public FormQuanLySach()
        {
            InitializeComponent();
            loadDanhSachDauSach();
        }

        void loadDanhSachDauSach()
        {
            DataTable dt = Sach_BUS.Instance.selectDanhSachDauSach();
            dt.Columns.Add(new DataColumn("Chon", typeof(bool)));
            dataGVDanhSachDauSach.DataSource = dt;
            dataGVDanhSachDauSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            List<Sach_DTO> listSach = new List<Sach_DTO>();
            foreach(DataGridViewRow row in dataGVDanhSachDauSach.Rows)
            {
                if(isNotEmpty(row))
                {
                    if(row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if(Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listSach.Add(new Sach_DTO()
                            {
                                MaSach = row.Cells[0].Value.ToString(),
                                TenSach = row.Cells[1].Value.ToString(),
                                TheLoai = row.Cells[2].Value.ToString(),
                                TacGia = row.Cells[3].Value.ToString(),
                                SoLuongTon = int.Parse(row.Cells[4].Value.ToString()),
                                DonGiaBan = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }

            foreach (var item in listSach)
            {
                if(Sach_BUS.Instance.insertSach(item))
                {
                    string mess = string.Format("Thêm thông tin sách {0} thành công", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Thêm thông tin sách {0} thất bại", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            loadDanhSachDauSach();
        }

        private void btnCapNhatSach_Click(object sender, EventArgs e)
        {
            List<Sach_DTO> listSach = new List<Sach_DTO>();
            foreach (DataGridViewRow row in dataGVDanhSachDauSach.Rows)
            {
                if (isNotEmpty(row))
                {
                    if (row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listSach.Add(new Sach_DTO()
                            {
                                MaSach = row.Cells[0].Value.ToString(),
                                TenSach = row.Cells[1].Value.ToString(),
                                TheLoai = row.Cells[2].Value.ToString(),
                                TacGia = row.Cells[3].Value.ToString(),
                                SoLuongTon = int.Parse(row.Cells[4].Value.ToString()),
                                DonGiaBan = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }

            foreach (var item in listSach)
            {
                if (Sach_BUS.Instance.updateSach(item))
                {
                    string mess = string.Format("Cập nhật thông tin sách {0} thành công", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Thêm thông tin sách {0} thất bại", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            loadDanhSachDauSach();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            List<Sach_DTO> listSach = new List<Sach_DTO>();
            foreach (DataGridViewRow row in dataGVDanhSachDauSach.Rows)
            {
                if (isNotEmpty(row))
                {
                    if (row.Cells[6].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value.ToString()) == true)
                        {
                            listSach.Add(new Sach_DTO()
                            {
                                MaSach = row.Cells[0].Value.ToString(),
                                TenSach = row.Cells[1].Value.ToString(),
                                TheLoai = row.Cells[2].Value.ToString(),
                                TacGia = row.Cells[3].Value.ToString(),
                                SoLuongTon = int.Parse(row.Cells[4].Value.ToString()),
                                DonGiaBan = int.Parse(row.Cells[5].Value.ToString())
                            });
                        }
                    }
                }
            }

            foreach (var item in listSach)
            {
                if (Sach_BUS.Instance.deleteSach(item))
                {
                    string mess = string.Format("Xóa thông tin sách {0} thành công", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
                else
                {
                    string mess = string.Format("Xóa thông tin sách {0} thất bại", item.MaSach);
                    MessageBox.Show(mess, "Thông báo");
                }
            }
            loadDanhSachDauSach();
        }
    }
}
