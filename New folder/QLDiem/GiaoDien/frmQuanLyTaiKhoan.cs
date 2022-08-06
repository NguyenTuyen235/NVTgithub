using QLDiem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiem.GiaoDien
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
       
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dtgDangnhap.DataSource = dt.DangNhap_SelectAll();
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            cboQuyen.Enabled = false;
            btThem.Enabled = true;
            btSua.Enabled = false;
            // chinh chu tren DGV 
            dtgDangnhap.Columns["userName"].HeaderText = "Tên đăng nhập";
            dtgDangnhap.Columns["passWord"].HeaderText = "Mật khẩu";
            dtgDangnhap.Columns["Quyen"].HeaderText = "Quyền";
            //chinh khoang cach bang
            dtgDangnhap.Columns["userName"].Width = 200;
            dtgDangnhap.Columns["passWord"].Width = 200;
            dtgDangnhap.Columns["Quyen"].Width = 200;
        }
        Boolean adDangNhap = false;
        private void btThem_Click(object sender, EventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = false;
            btnS.Enabled = false;
            btThem.Enabled = false;
           
            txtUser.Text = "";
            txtPass.Text = "";
            cboQuyen.Text = "";     
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            cboQuyen.Enabled = true;
            txtUser.Focus();
            adDangNhap = true;
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (adDangNhap)
            {


                try
                {
                    if (txtUser.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tài khoản");
                        txtUser.Focus();
                        return;
                    }
                    if (txtPass.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu");
                        txtPass.Focus();
                        return;
                    }
                    if (cboQuyen.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập quyền");
                        cboQuyen.Focus();
                        return;
                    }

                    // string a = "select userName from DangNhap";
                    if (txtUser.Text == txtUser.Text)
                    {


                        dt.DangNhap_Insert(txtUser.Text, txtPass.Text, cboQuyen.Text);
                        btThem.Enabled = true;
                        btnS.Enabled = true;
                        btXoa.Enabled = true;
                        btSua.Enabled = false;
                        MessageBox.Show("Cập nhật tài khoản thành công");
                    }

                }
                catch
                {
                    {
                        if (txtUser.Enabled == true)
                        {
                            MessageBox.Show("Tài khoản đã được sữ dụng.Cập nhật thất bại","Thông báo");
                        }
                        
                            if (txtUser.Enabled == false)
                            {
                                DialogResult xoa = MessageBox.Show("Bạn chắc chắn mún đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (xoa == DialogResult.Yes)
                                {
                                    //      dt.Lops_Delete(cboLop.SelectedValue.ToString());


                                    txtPass.Enabled = true;
                                    txtPass.Focus();
                                    dt.DangNhap_Update(txtUser.Text, txtPass.Text, cboQuyen.Text);
                                    adDangNhap = false;
                                    MessageBox.Show("Đổi mật khẩu thành công","Thông báo");
                                    btXoa.Enabled = true;
                                    btnS.Enabled = true;

                                }
                               
                            }                       
                    }
                }
                frmQuanLyTaiKhoan_Load(sender, e);
            }
        }                         
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult lenh = MessageBox.Show("Bạn có chắc chắn muốn xóa ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (lenh == DialogResult.Yes)
                {
                    txtUser.Enabled = true;
                    txtPass.Enabled = true;
                    cboQuyen.Enabled = true;
                    //Bindings du lieu len text
                    txtUser.DataBindings.Clear();
                    txtUser.DataBindings.Add("Text", dtgDangnhap.DataSource, "userName");
                    txtPass.DataBindings.Clear();
                    txtPass.DataBindings.Add("Text", dtgDangnhap.DataSource, "passWord");
                    cboQuyen.DataBindings.Clear();
                    cboQuyen.DataBindings.Add("Text", dtgDangnhap.DataSource, "Quyen");

                    dt.DangNhap_Delete(txtUser.Text);
                    MessageBox.Show("Xóa thành công","Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xóa thất bại hoặc hết dữ liệu");
            }
            frmQuanLyTaiKhoan_Load(sender, e);
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                frmChinh frm = new frmChinh();                
                this.Hide();
                frm.ShowDialog();                
            }                     
        }

        private void dtgDangnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dtgDangnhap.DataSource = dt.DangNhap_SelectQuyen(cboQuyen.Text);

            //Bindings du lieu len text
            txtUser.DataBindings.Clear();
            txtUser.DataBindings.Add("Text", dtgDangnhap.DataSource, "userName");
            txtPass.DataBindings.Clear();
            txtPass.DataBindings.Add("Text", dtgDangnhap.DataSource, "passWord");
            cboQuyen.DataBindings.Clear();
            cboQuyen.DataBindings.Add("Text", dtgDangnhap.DataSource, "Quyen");
            
            // chinh chu tren DGV 
            dtgDangnhap.Columns["userName"].HeaderText = "Tên đăng nhập";
            dtgDangnhap.Columns["passWord"].HeaderText = "Mật khẩu";
            dtgDangnhap.Columns["Quyen"].HeaderText = "Quyền";

            
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = false;
            btnS.Enabled = false;
            btThem.Enabled = false;

           
            txtUser.Enabled = false;
            txtPass.Enabled = true;
            cboQuyen.Enabled = true;
            txtPass.Focus();
            adDangNhap = true;                     
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
           btThem. Enabled = true;
            btXoa.Enabled = true;
           btnS. Enabled = true;
            
           btSua.Enabled = false;
            
           txtUser.Enabled = false;
           txtPass.Enabled = false;
        }
        private void dtgDangnhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }  
      
    }
}
