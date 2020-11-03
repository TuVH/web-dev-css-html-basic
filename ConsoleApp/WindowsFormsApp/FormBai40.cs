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
    public partial class frm_Bai40 : Form
    {
        public frm_Bai40()
        {
            InitializeComponent();
        }

        private void btnBai38_Click(object sender, EventArgs e)
        {
            frm_Bai38 bai38 = new frm_Bai38();
            MessageBox.Show("Open new Tab");
            bai38.ShowDialog();
            
        }

        private void frm_Bai40_Load(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int numberA = 0, numberB = 0;
            int.TryParse(txtNumberA.Text,out numberA);
            int.TryParse(txtNumberB.Text,out numberB);
            while (numberA ==0)
            {
                MessageBox.Show("Mời bạn nhập số A");
                txtNumberA.Text = "1";
                int.TryParse(txtNumberA.Text, out numberA);
            }
            while (numberB == 0)
            {
                MessageBox.Show("Mời bạn nhập số B");
                txtNumberB.Text = "1";
                int.TryParse(txtNumberB.Text, out numberB);
            }
            Exercise40 exercise40 = new Exercise40();
            txtResult.Text = exercise40.ShowResult(numberA, numberB);                    
        }
    }
}
