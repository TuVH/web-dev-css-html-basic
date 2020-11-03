using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class frm_form : Form
    {
        
        public frm_form()
        {
            InitializeComponent();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            double numberA, numberB, numberC;
            double.TryParse(txt_A.Text, out numberA);
            double.TryParse(txt_B.Text, out numberB);
            double.TryParse(txt_C.Text, out numberC);

            txt_result.Text = Caculate.Solve(numberA, numberB, numberC);


        }
    }
}
