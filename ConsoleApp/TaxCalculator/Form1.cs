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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Amount
            string samount = txt_amount.Text.Trim();
            double damount = Convert.ToDouble(samount);
            //Caculate
            double due = damount * 1.075;
            //Console
            txt_due.Text = due.ToString();

        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            string samount = txt_amount.Text.Trim();
            double damount = Convert.ToDouble(samount);
            //Caculate
            double due = damount * 1.075;
            //Console
            txt_due.Text = due.ToString();
        }

        
    }
}
