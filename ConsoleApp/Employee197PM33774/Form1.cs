using System;
using System.Linq;
using System.Windows.Forms;

namespace Employee197PM33774
{
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();          
        }
        Employee197PM33774Entities employee;
               
        void LoadEmployee()
        {
            employee  = new Employee197PM33774Entities();
            dtgEmployee.DataSource = employee.Employees.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgEmployee.SelectedRows.Count ==1)
            {
                var row = dtgEmployee.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;

                employee = new Employee197PM33774Entities();
                Employee emp = employee.Employees.Single(nv => nv.id == id);
                employee.Employees.Remove(emp);
                employee.SaveChanges();
                
                MessageBox.Show("Xóa NV THành công");
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadEmployee();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd add = new FrmAdd();
            add.ShowDialog();
            LoadEmployee();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgEmployee.SelectedRows.Count == 1)
            {
                var row = dtgEmployee.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;
                FrmEdit edit = new FrmEdit(id);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadEmployee();
        }
    }
}
