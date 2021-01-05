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
    public partial class EditSalary : Form
    {
        private string maNV;
        public EditSalary(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
        private void EditSalary_Load(object sender, EventArgs e)
        {
            LUONG luong = db.LUONGs.Single(l => l.MaNV == maNV);
            Txt_Bonus.Text = luong.PhuCap.ToString();
            Txt_DayOff.Text = luong.SoNgayNghi.ToString();
            Txt_DayWorking.Text = luong.SoNgayCong.ToString();
            Txt_Insurrance.Text = luong.BaoHiem.ToString();
            Txt_Month.Text = luong.Thang;
            Txt_Note.Text = luong.GhiChu;
            Txt_OverTime.Text = luong.SoGioLamThem.ToString();
            Txt_Salary.Text = luong.Luong1.ToString();
            Txt_Year.Text = luong.Nam;
            Txt_MaNV.Text = luong.MaNV;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                LUONG luong = db.LUONGs.Single(l => l.MaNV == maNV);
                luong.MaNV = Txt_MaNV.Text;
                luong.PhuCap = Convert.ToInt32(Txt_Bonus.Text);
                luong.Luong1 = Convert.ToInt32(Txt_Salary.Text);
                luong.Nam = Txt_Year.Text;
                luong.SoGioLamThem = Convert.ToInt32(Txt_OverTime.Text);
                luong.SoNgayCong = Convert.ToInt32(Txt_DayWorking.Text);
                luong.SoNgayNghi = Convert.ToInt32(Txt_DayOff.Text);
                luong.Thang = Txt_Month.Text;
                luong.GhiChu = Txt_Note.Text;
                luong.BaoHiem = Convert.ToInt32(Txt_Insurrance.Text);
                db.SaveChanges();
                MessageBox.Show("EDIT OK");
                this.Close();
            }
            catch
            {
                MessageBox.Show("nhập sai,Vui lòng nhập lại!");
            }
        }
    }
}
