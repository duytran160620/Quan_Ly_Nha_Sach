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
    public partial class FormTimKiemSach : Form
    {
        public FormTimKiemSach()
        {
            InitializeComponent();
            dataGVKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(radioBtnMaSach.Checked == true)
            {
                dataGVKetQua.DataSource = Sach_BUS.Instance.searchByMaSach(txtInput.Text);
            }
            else if(radioBtnTenSach.Checked == true)
            {
                dataGVKetQua.DataSource = Sach_BUS.Instance.searchByTenSach(txtInput.Text);
            }
            else if(radioBtnTheLoai.Checked == true)
            {
                dataGVKetQua.DataSource = Sach_BUS.Instance.searchByTheLoai(txtInput.Text);
            }
            else if(radioBtnTacGia.Checked == true)
            {
                dataGVKetQua.DataSource = Sach_BUS.Instance.searchByTacGia(txtInput.Text);
            }
        }
    }
}
