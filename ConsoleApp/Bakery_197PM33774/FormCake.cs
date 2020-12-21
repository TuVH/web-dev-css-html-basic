using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bakery_197PM33774
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        CAKEMANAGEMENTEntities db;

        void LoadDB()
        {
            db = new CAKEMANAGEMENTEntities();
            dtgBakery.DataSource = db.cakes.Select(cake => new
            {
                cake.id,
                cake.cakename,
                kind = cake.kind.kindname
            }).ToList();     
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_add f = new Frm_add();
            f.ShowDialog();
            LoadDB();
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dtgBakery.SelectedRows.Count == 1)
            {
                var row = dtgBakery.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;
                Frm_edit f = new Frm_edit(id);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadDB();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgBakery.SelectedRows.Count == 1)
            {
                var row = dtgBakery.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;

                db = new CAKEMANAGEMENTEntities();
                cake cake = db.cakes.Where(ca => ca.id == id).ToList()[0];
                db.cakes.Remove(cake);
                db.SaveChanges();
                MessageBox.Show("Xóa bánh Thành công");
                
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadDB();
        }
    }
}
