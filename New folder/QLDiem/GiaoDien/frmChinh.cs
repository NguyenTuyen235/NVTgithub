using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDiem.DataAccess;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
namespace QLDiem.GiaoDien
{
     
    public partial class frmChinh : Form
    {
        public  static DangNhap dangnhap { set; get; }
       
        public frmChinh()
        {
            InitializeComponent();
        }
        public frmChinh(string user)
        {
            InitializeComponent();
            QLdiemDataContext data = new QLdiemDataContext();
            dangnhap = new DangNhap();
            
            dangnhap = data.DangNhaps.Single(p => p.userName == user);
          //dangnhap = data.DangNhaps.Single(p => p.passWord == pass );
         //  dangnhap = data.DangNhaps.Single(p => p.Quyen == quyen);
          
            lblstatus.Text = "Chào Mừng " + dangnhap.userName + " Đến Với Hệ Thống Của Chúng Tôi              Chức Vụ:" + dangnhap.Quyen+"";// + dangnhap.userName + "";// Chức Vụ :" + dangnhap.Quyen;
       //  GiaoDien.   frmThongTinHeThong a = new GiaoDien. frmThongTinHeThong();
            if (dangnhap.Quyen == "Giảng Viên")
            {
                this.btnXuLyTT.Enabled = false;
                this.btnThongTinTaiKhoan.Enabled = false;
                this.btnMonDiemHP.Enabled = false;
                this.btnLopSinhVien.Enabled = false;
                this.btnMonDiemHP.Enabled = false;
                this.btnBangDiemChiTiet.Enabled = false;
                this.btnDSSVLop.Enabled = false;
                this.gpTTHT.Enabled = false;
          //      this.gpTTHT.Enabled = true;
                
                
            //     frmDoiMatKhauSV a = new frmDoiMatKhauSV(dangnhap.userName, dangnhap.passWord);
              //  a.Show();
            }
            else

            {
               
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLopSinhVien_Click(object sender, EventArgs e)
        {
            GiaoDien.frmLopSinhVien frm = new GiaoDien.frmLopSinhVien();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnMonDiemHP_Click(object sender, EventArgs e)
        {
            GiaoDien.frmMonDiemHP frm = new GiaoDien.frmMonDiemHP();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnXuLyTT_Click(object sender, EventArgs e)
        {
            GiaoDien.frmThongTinHeThong frm = new GiaoDien.frmThongTinHeThong();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            
        }

        private void btnBangDiemChiTiet_Click(object sender, EventArgs e)
        {
            GiaoDien.frmBangDiemChiTiet frm = new GiaoDien.frmBangDiemChiTiet();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void Times_Tick(object sender, EventArgs e)
        {
            txtGio.Text = "Bây giờ là: " + DateTime.Now.Hour.ToString() + " :" +
                DateTime.Now.Minute.ToString() + " :" + DateTime.Now.Second.ToString();
        }

        //public string Get_Day()
        //{
        //    string str = DateTime.Now.ToString().Trim();
        //    str = str.Substring(0, 2);
        //    return str;
        //}
        //public string Get_Month()
        //{
        //    string str = DateTime.Now.ToString().Trim();
        //    str = str.Substring(3, 2);
        //    return str;
        //}
        //public string Get_Year()
        //{
        //    string str = DateTime.Now.ToString().Trim();
        //    str = str.Substring(6, 4);
        //    return str;
        //}
        private void frmChinh_Load(object sender, EventArgs e)
        {
            //txtNgay.Text = DateTime.Now.ToString().Trim();
            //txtNgay.Text = Get_Month();
            //txtNgay.Text = Get_Year();
            //txtNgay.Text = doiNgay(DateTime.Now.DayOfWeek.ToString()) + "/" +
            //    DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" +
            //    DateTime.Now.Year.ToString();
        }

        private void btnDSSVLop_Click(object sender, EventArgs e)
        {
            frmReportSinhVienLop frm = new frmReportSinhVienLop();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            GiaoDien.frmLogin frm = new GiaoDien.frmLogin();
            this.Hide();
            frm.ShowDialog();
            //this.Show();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            GiaoDien.frmQuanLyTaiKhoan frm = new GiaoDien.frmQuanLyTaiKhoan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void anhLopHoc_Click(object sender, EventArgs e)
        {
            GiaoDien.frmThongTinHeThong frm=new GiaoDien.frmThongTinHeThong();
            this.Hide();
            frm.ShowDialog();

            this.Show();
        }

        private void anhDiemThi_Click(object sender, EventArgs e)
        {
            //GiaoDien.frmMonDiemHocPhanQuyen frm = new GiaoDien.frmMonDiemHocPhanQuyen();
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {
            GiaoDien.frmLopSVQuyen frm = new GiaoDien.frmLopSVQuyen();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {
            GiaoDien.frmMonDiemHocPhanQuyen frm = new GiaoDien.frmMonDiemHocPhanQuyen();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDoiTaiKhoanSV_Click(object sender, EventArgs e)
        {
            //frmChinh_Load(sender, e);
            //frmChinh_Load(sender, e);
            //this.Hide();
            // frmDoiMatKhauSV frm = new  frmDoiMatKhauSV();
            //this.Hide();
            //frm.ShowDialog();
            frmDoiMatKhauSV a = new frmDoiMatKhauSV(dangnhap.userName, dangnhap.passWord, dangnhap.Quyen);
            this.Hide();
            a.ShowDialog();
        }
            //a.Show();
              
          //this. Show();
        public string fileExcel { get; set; }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            frmTroGiup frm = new frmTroGiup();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }




        
    }
}
