using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable dt = QuyDinh_BUS.Instance.selectThamSoQD_1();
            foreach (DataRow item in dt.Rows)
            {
                int soluongnhaptoithieu = int.Parse(item["SoLuongNhapToiThieu"].ToString());
                if (150 >= soluongnhaptoithieu)
                {
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("not ok");
                }
                
            }
        }
    }
}
