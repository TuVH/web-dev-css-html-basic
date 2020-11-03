using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frm_Bai38 : Form
    {
        public frm_Bai38()
        {
            InitializeComponent();
        }

        private void btnBai40_Click(object sender, EventArgs e)
        {
            frm_Bai40 bai40 = new frm_Bai40();
            MessageBox.Show("Open new Tab");
            bai40.ShowDialog();
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            int money = 0;
            int.TryParse(txtAmount.Text, out money);            
            Exercise38 exercise38 = new Exercise38();
            txtResult.Text = exercise38.Tranfer(money);
            
        }
    }
}
