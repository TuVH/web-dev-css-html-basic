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
    public partial class FrmMang : Form
    {
        public FrmMang()
        {
            InitializeComponent();
        }

        private void btnDtb_Click(object sender, EventArgs e)
        {
            FrmDtb frmDtb = new FrmDtb();
            frmDtb.Show();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            //Add phần tử vào mảng.
            string[] mang = txtMang.Text.Trim().Split(' ');
            List<int> list = new List<int>();
            for (int i = 0; i < mang.Length; i++)
            {
                int temp = 0;
                int.TryParse(mang[i],out temp);
                list.Add(temp);
            }
            //Hiển thị.
            Mang mang1 = new Mang(list);
            lbHienThiKetQua.Text = "Mảng :" + mang1.Ketqua() +
                "\r\n Tổng: " + mang1.Tong() + "\r\n Trung bình cộng: "
                + mang1.Trungbinh();
        }
    }
}
