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
    public partial class Frm_add : Form
    {
        public Frm_add()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CAKEMANAGEMENTEntities db = new CAKEMANAGEMENTEntities(); 
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
            cake cake = new cake();
            cake.cakename = txt_cakeName.Text;
            cake.id_cakekind = (int)Cbb_kindName.SelectedValue;
            CAKEMANAGEMENTEntities db = new CAKEMANAGEMENTEntities();
            db.cakes.Add(cake);
            db.SaveChanges();
            MessageBox.Show("Thêm bánh mới thành công");
            this.Close();
        }
    }
}
