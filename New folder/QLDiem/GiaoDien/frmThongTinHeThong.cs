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
    public partial class frmThongTinHeThong : Form
    {
        public frmThongTinHeThong()
        {
            InitializeComponent();
        }
        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
        private void frmThongTinHeThong_Load(object sender, EventArgs e)
        {
            txtTinh.DataBindings.Clear();
            txtTinh.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "tinh");
            txtDonViChuQuan.DataBindings.Clear();
            txtDonViChuQuan.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "donViChuQuan");
            txtTenTruong.DataBindings.Clear();
            txtTenTruong.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "tenTruong");
            txtKhoaHoc.DataBindings.Clear();
            txtKhoaHoc.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "khoaHoc");
            txtNganhHoc.DataBindings.Clear();
            txtNganhHoc.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "nganhHoc");
            txtChuyenNganh.DataBindings.Clear();
            txtChuyenNganh.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "chuyenNganh");
        }

        private void btnCapNhạt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTinh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tỉnh");
                    txtTinh.Focus();
                    return;
                }
                if (txtDonViChuQuan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đơn vị chủ quản");
                    txtDonViChuQuan.Focus();
                    return;
                }
                if (txtTenTruong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên trường");
                    txtTenTruong.Focus();
                    return;
                }
                if (txtNganhHoc.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên trường");
                    txtNganhHoc.Focus();
                    return;
                }
                if (txtChuyenNganh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên trường");
                    txtChuyenNganh.Focus();
                    return;
                }
                if (txtKhoaHoc. Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập khóa học");
                    txtKhoaHoc.Focus();
                    return;
                }

                dt.ThongTin_Update(txtTinh.Text, txtDonViChuQuan.Text, txtTenTruong.Text,
                    txtKhoaHoc.Text, txtNganhHoc.Text, txtChuyenNganh.Text);

                MessageBox.Show("Cập nhật thành công thông tin hệ thống !", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại, kiểm tra lại dữ liệu của bạn", "Thông Báo",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmThongTinHeThong_Load(sender, e);
        }
    }
}
