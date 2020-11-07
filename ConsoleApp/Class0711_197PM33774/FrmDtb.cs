using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0711_197PM33774
{
    public partial class FrmDtb : Form
    {
        public FrmDtb()
        {
            InitializeComponent();
        }

        private void btnMang_Click(object sender, EventArgs e)
        {
            FrmMang frmMang = new FrmMang();
            frmMang.Show();
        }

        private void btnDtb_Click(object sender, EventArgs e)
        {
            double dtb = Convert.ToInt32(txtChuyenCan.Text) * 0.1
                + Convert.ToInt32(txtGiuaKi.Text) * 0.4
                + Convert.ToInt32(txtCuoiKi.Text) * 0.5;
            lbDtb.Text = "Điểm trung bình học kì: " + dtb;


        }
    }
}
