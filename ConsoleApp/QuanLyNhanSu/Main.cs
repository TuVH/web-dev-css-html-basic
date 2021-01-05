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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
        private void Main_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }
        private void LoadEmployee()
        {
            Dtg_NhanVien.DataSource = db.NHANVIENs.Select(items => new
            {
                items.MaNV,
                items.MaBoPhan,
                items.Hoten,
                items.NgaySinh,
                items.SDT,
                items.TonGiao,
                items.DiaChi,
                items.QuocTich,
                items.HocVan,
                items.NgayVaoLam,
                items.GhiChu
                
            }).ToList();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dtg_NhanVien.SelectedRows.Count == 1)
            {
                var row = Dtg_NhanVien.SelectedRows[0];
                var cell = row.Cells["MaNV"];
                string id = (string)cell.Value;

                db = new QUANLYNHANSUEntities();
                NHANVIEN nhanvien = db.NHANVIENs.Single(nv => nv.MaNV == id);
                db.NHANVIENs.Remove(nhanvien);
                db.SaveChanges();
                MessageBox.Show("Xóa Nhân viên Thành công");

            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadEmployee();
        }

        private void sHOWSALARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.ShowDialog();
            LoadEmployee();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee employee = new AddEmployee();
            employee.ShowDialog();
            LoadEmployee();
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dtg_NhanVien.SelectedRows.Count == 1)
            {
                var row = Dtg_NhanVien.SelectedRows[0];
                var cell = row.Cells["MaNV"];
                string id = (string)cell.Value;
                EditEmployee employee = new EditEmployee(id);
                employee.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mời bạn chọn 1 dòng");
            }
            LoadEmployee();
        }
    }
}
