using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee197PM33774
{
    public partial class FrmEdit : Form
    {
        Employee emp;
        Employee197PM33774Entities db;
        public FrmEdit(int id)
        {
            InitializeComponent();
            
            db = new Employee197PM33774Entities();
            emp = db.Employees.Single(nv => nv.id == id);
            this.Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CbbRoom.DataSource = db.DEPARTMENTs.ToList();
            CbbRoom.DisplayMember = "name";//ten cột trong db
            CbbRoom.ValueMember = "id";
            //Load lại dữ liệu NV cũ
            txtName.Text = emp.NAME;
            txtBirthday.Text = emp.BIRTHDATE;
            CbbRoom.SelectedValue = emp.ID_DEPARTMENT;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emp.NAME = txtName.Text;
            emp.BIRTHDATE = txtBirthday.Text;
            emp.ID_DEPARTMENT = (int) CbbRoom.SelectedValue;

            db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Edit ok");
            this.Close();

        }
    }
}
