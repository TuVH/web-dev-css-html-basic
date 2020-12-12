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
    public partial class Frm_Edit : Form
    {
        Sach sach;
        QUANLYTHUVIENEntities db;
        public Frm_Edit(int id)
        {
            InitializeComponent();
            db = new QUANLYTHUVIENEntities();
            sach = db.Saches.Single(nv => nv.id == id);
            this.Load += Form3_Load;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            CbbType.DataSource = db.Saches.ToList();
            CbbType.DisplayMember = "name";//ten cột trong db
            CbbType.ValueMember = "id";
            //Load lại dữ liệu sách cũ
            txtName.Text = sach.NAME;
            txtAuthor.Text = emp.BIRTHDATE;
            txt .Text = sach.NAME;
            txtAuthor.Text = emp.BIRTHDATE;
            CbbRoom.SelectedValue = emp.ID_DEPARTMENT;
        }
    }
}
