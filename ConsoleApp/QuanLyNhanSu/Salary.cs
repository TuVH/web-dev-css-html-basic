using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        private void Salary_Load(object sender, EventArgs e)
        {
            LoadSalary();
        }
        public void LoadSalary()
        {
            Dtg_Salary.DataSource = db.LUONGs.Select(items => new
            {
                items.id,
                items.MaNV,
                items.Luong1,
                items.SoNgayCong,
                items.SoNgayNghi,
                items.Thang,
                items.Nam,
                items.BaoHiem,
                items.SoGioLamThem,
                items.PhuCap,
                items.GhiChu
            }).ToList();
        }
        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dtg_Salary.SelectedRows.Count == 1)
            {
                var row = Dtg_Salary.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;

                db = new QUANLYNHANSUEntities();
                LUONG salary = db.LUONGs.Single(nv => nv.id == id);
                db.LUONGs.Remove(salary);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành công");
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadSalary();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSalary add = new AddSalary();
            add.ShowDialog();
            LoadSalary();
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Dtg_Salary.SelectedRows.Count == 1)
            {
                var row = Dtg_Salary.SelectedRows[0];
                var cell = row.Cells["MaNV"];
                string id = (string)cell.Value;
                EditSalary edit = new EditSalary(id);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadSalary();
        }
    }
}
