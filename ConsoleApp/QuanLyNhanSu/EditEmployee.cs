using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class EditEmployee : Form
    {
        private string maNV;
        public EditEmployee(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
        private void EditEmployee_Load(object sender, EventArgs e)
        {
            NHANVIEN nhanvien = db.NHANVIENs.Single(nv => nv.MaNV == maNV);
            Txt_MaNV.Text = nhanvien.MaNV;
            Txt_Name.Text = nhanvien.Hoten;
            Txt_DateOfBirth.Text = nhanvien.NgaySinh.ToString("dd/MM/yyyy");
            Txt_DateStarted.Text = nhanvien.NgayVaoLam.ToString("dd/MM/yyyy");
            Txt_PhoneNumber.Text = nhanvien.SDT;
            Txt_Study.Text = nhanvien.HocVan;
            Txt_Country.Text = nhanvien.QuocTich;
            Txt_Religions.Text = nhanvien.TonGiao;
            Txt_Address.Text = nhanvien.DiaChi;
            Txt_Note.Text = nhanvien.GhiChu;
            Cbb_BoPhan.DataSource = db.BOPHANs.ToList();
            Cbb_BoPhan.DisplayMember = "TenBoPhan";
            Cbb_BoPhan.ValueMember = "MaBoPhan";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nhanvien = db.NHANVIENs.Single(nv => nv.MaNV == maNV);
                nhanvien.MaNV = Txt_MaNV.Text;
                nhanvien.Hoten = Txt_Name.Text;
                nhanvien.NgaySinh = DateTime.ParseExact(Txt_DateOfBirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nhanvien.NgayVaoLam = DateTime.ParseExact(Txt_DateStarted.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nhanvien.SDT = Txt_PhoneNumber.Text;
                nhanvien.HocVan = Txt_Study.Text;
                nhanvien.QuocTich = Txt_Country.Text;
                nhanvien.TonGiao = Txt_Religions.Text;
                nhanvien.DiaChi = Txt_Address.Text;
                nhanvien.GhiChu = Txt_Note.Text;
                nhanvien.MaBoPhan = (string)Cbb_BoPhan.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("EDIT OK");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập theo định dạng :dd/MM/yyyy!");
            }
            
        }
    }
}
