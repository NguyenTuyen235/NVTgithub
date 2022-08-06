using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiem.GiaoDien
{
    public partial class frmDoiMatKhauSV : Form
    {
        private string taikhoan, matkhau, quyen;
        public frmDoiMatKhauSV()
        {
            InitializeComponent();
            

        }

        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
        public frmDoiMatKhauSV(string TaiKhoan, string MatKhau,string Quyen) : this()
        {
            taikhoan = TaiKhoan;
            matkhau = MatKhau;
            quyen = Quyen;
            lbTaiKhoan.Text = taikhoan;
            lbMatKhauCu.Text = matkhau;
            lbQuyen.Text = quyen;
            
           
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!", "Chú ý");
                txtMatKhauMoi.Focus();

            }
            else if (txtNhapLai.Text == "")
            {
                MessageBox.Show("Bạn chưa đánh lại mật khẩu!", "Chú ý");
               txtNhapLai.Focus();

            }
            
            else if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Bạn đánh lại mật khẩu không trùng khớp!", "Chú ý");
                txtMatKhauMoi.Focus();
            }
            
            else
            {
                DialogResult doi = MessageBox.Show("Bạn chắc chắn mún đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (doi == DialogResult.Yes)
                {
                    
                    dt.DangNhap_Update(lbTaiKhoan.Text, txtMatKhauMoi.Text,lbQuyen.Text);
                    MessageBox.Show("Cập nhật thành công!","Thông báo");

                  

                }
            }


            //this.Hide();
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                frmChinh a = new frmChinh(lbTaiKhoan.Text);
                this.Hide();
                a.ShowDialog();

            }
           // MessageBox.Show("Bạn có muốn thoát không","Thông báo");
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapLai_TextChanged(object sender, EventArgs e)
        {
        //    if (e.KeyChar == (char)13)
        //    {
        //        btnCapNhat. Enabled = true;
        //        btnCapNhat_Click(sender, e);
        //    }
        }

        private void txtNhapLai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnCapNhat.Enabled = true;
                btnCapNhat_Click(sender, e);
            }
        }
    }
}