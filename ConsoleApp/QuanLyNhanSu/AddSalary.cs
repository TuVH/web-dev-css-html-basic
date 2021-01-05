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
    public partial class AddSalary : Form
    {
        public AddSalary()
        {
            InitializeComponent();
        }
        

        private void AddSalary_Load(object sender, EventArgs e)
        {
            QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
            Cbb_Name.DataSource = db.NHANVIENs.ToList();
            Cbb_Name.DisplayMember = "Hoten";
            Cbb_Name.ValueMember = "MaNV";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
                LUONG luong = new LUONG();
                luong.MaNV = (string)Cbb_Name.SelectedValue;
                luong.Luong1 = Convert.ToInt32(Txt_Salary.Text);
                luong.Nam = Txt_Year.Text;
                luong.PhuCap = Convert.ToInt32(Txt_Bonus.Text);
                luong.SoNgayCong = Convert.ToInt32(Txt_DayWorking.Text);
                luong.Thang = Txt_Month.Text;
                luong.SoGioLamThem = Convert.ToInt32(Txt_OverTime.Text);
                luong.GhiChu = Txt_Note.Text;
                luong.SoNgayNghi = Convert.ToInt32(Txt_DayOff.Text);
                luong.BaoHiem = Convert.ToInt32(Txt_Insurrance.Text);
                db.LUONGs.Add(luong);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Nhập Sai, vui lòng nhập lại!");
            }
        }
    }
}
