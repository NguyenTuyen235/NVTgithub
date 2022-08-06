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

namespace QLDiem.GiaoDien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            QLdiemDataContext cc = new QLdiemDataContext();

            
                var query = from p in cc.DangNhaps
                            where p.userName == txtTenDangNhap.Text && p.passWord == txtMatKhau.Text
                            select p;
                if (query.Count() == 0)
                {
                    //  lblstatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                    this.lblstatus.ForeColor = Color.Red;
                    lblstatus.Text = "Bạn đăng nhập không thành công";
                }
                  
               
                else
                {
                    frmChinh tinh = new  frmChinh(txtTenDangNhap.Text);
                    this.Hide();
                    tinh.ShowDialog();
                    //this.Show();
                    
            }
               // frmDoiMatKhauSV a = new frmDoiMatKhauSV(txtTenDangNhap.Text, txtMatKhau.Text);
            //a.Show();
             //frmDoiMatKhauSV_Load(sender, e);

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboSeVer.Items.Add(SystemInformation.UserDomainName.ToString() + "\\SQLServer");
            cboSeVer.Text = cboSeVer.Items[0].ToString();

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
       
            if (ShowPass.Checked)
            {
                
               txtMatKhau.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }        
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnDangNhap.Enabled = true;
                btnDangNhap_Click(sender, e);
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
   
    }
}
