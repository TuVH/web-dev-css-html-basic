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
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
            this.Load += FrmAdd_Load;
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            Employee197PM33774Entities db = new Employee197PM33774Entities();
            CbbRoom.DataSource = db.DEPARTMENTs.ToList();
            CbbRoom.DisplayMember = "name";//ten cột trong db
            CbbRoom.ValueMember = "id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.NAME = txtName.Text;
            emp.BIRTHDATE = txtBirthday.Text;
            emp.ID_DEPARTMENT = (int)CbbRoom.SelectedValue;
            Employee197PM33774Entities db = new Employee197PM33774Entities();
            db.Employees.Add(emp);
            db.SaveChanges();
            MessageBox.Show("Thêm mới thành công");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
