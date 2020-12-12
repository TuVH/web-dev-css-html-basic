using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVIen
{
    public partial class Frm_QLTV : Form
    {
        public Frm_QLTV()
        {
            InitializeComponent();
        }
        QUANLYTHUVIENEntities db;
        void LoadQLTV()
        {
            db = new QUANLYTHUVIENEntities();
            dtg_data.DataSource = db.Saches.ToList();
        }

        private void Frm_QLTV_Load(object sender, EventArgs e)
        {
            LoadQLTV();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add add = new Frm_Add();
            add.ShowDialog();
            LoadQLTV();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtg_data.SelectedRows.Count == 1)
            {
                var row = dtg_data.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;

                db = new QUANLYTHUVIENEntities();
                Sach sach = db.Saches.Single(nv => nv.id == id);
                db.Saches.Remove(sach);
                db.SaveChanges();

                MessageBox.Show("Xóa Sách THành công");
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadQLTV();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtg_data.SelectedRows.Count == 1)
            {
                var row = dtg_data.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;
                Frm_Edit edit = new Frm_Edit(id);
                edit.ShowDialog();

            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadQLTV();
        }
    }
}
