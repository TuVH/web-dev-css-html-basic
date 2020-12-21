using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_197PM33774
{
    public partial class Frm_edit : Form
    {
        CAKEMANAGEMENTEntities db;
        cake cake; 
        public Frm_edit(int id)
        {
            InitializeComponent();
            db = new CAKEMANAGEMENTEntities();
            cake = db.cakes.Single(cake => cake.id == id);
            this.Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt_cakeName.Text = cake.cakename;
            Cbb_kindName.DataSource = db.kinds.ToList();
            Cbb_kindName.DisplayMember = "kindname";
            Cbb_kindName.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cake.cakename = txt_cakeName.Text;
            cake.id_cakekind = (int)Cbb_kindName.SelectedValue;
            db.Entry(cake).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Edit thành công");
            this.Close();
        }
    }
}
