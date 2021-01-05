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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            this.Load += AddEmployee_Load;
        }


        private void AddEmployee_Load(object sender, EventArgs e)
        {
            QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
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
                QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
                NHANVIEN nhanvien = new NHANVIEN();
                nhanvien.MaNV = Txt_MaNV.Text;
                nhanvien.MaBoPhan = (string)Cbb_BoPhan.SelectedValue;
                nhanvien.Hoten = Txt_Name.Text;
                nhanvien.NgaySinh = DateTime.ParseExact(Txt_DateOfBirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nhanvien.SDT = Txt_PhoneNumber.Text;
                nhanvien.TonGiao = Txt_Religions.Text;
                nhanvien.DiaChi = Txt_Address.Text;
                nhanvien.HocVan = Txt_Study.Text;
                nhanvien.QuocTich = Txt_Country.Text;
                nhanvien.NgayVaoLam = DateTime.ParseExact(Txt_DateStarted.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nhanvien.GhiChu = Txt_Note.Text;
                db.NHANVIENs.Add(nhanvien);
                db.SaveChanges();
                MessageBox.Show("Thêm Nhân Viên Thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập theo định dạng :dd/MM/yyyy!");
            }
        }
    }
}
