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
    public partial class frmLopSVQuyen : Form
    {
        public frmLopSVQuyen()
        {
            InitializeComponent();
        }
        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
        private void frmLopSinhVien_Load(object sender, EventArgs e)
        {
            txtMaSinhVien.Enabled = false;
            txtHoVaTen.Enabled = false;
            txtDanToc.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;

            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "maLop";
            cboLop.DataSource = dt.Lops_SelectAll();
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", cboLop.DataSource, "maLop");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", cboLop.DataSource, "tenLop");
        }
        //Boolean adLop = false;
        //private void btnThemMoi_Click(object sender, EventArgs e)
        //{
        //    txtMaLop.Text = "";
        //    txtTenLop.Text = "";
        //    txtMaLop.Enabled = true;
        //    txtMaLop.Focus();
        //    adLop = true;
        //}

        //private void btnLuuLai_Click(object sender, EventArgs e)
        //{
        //    if (adLop)
        //    {
        //        dt.Lops_Insert(txtMaLop.Text, txtTenLop.Text);
        //        txtMaLop.Enabled = false;
        //        adLop = false;
        //    }
        //    else
        //    {
        //        dt.Lops_Update(txtMaLop.Text, txtTenLop.Text);
        //    }
        //    frmLopSinhVien_Load(sender, e);
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    dt.Lops_Delete(cboLop.SelectedValue.ToString());
        //    frmLopSinhVien_Load(sender, e);
        //}

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGV.DataSource = dt.SinhVien_SelectMaLop(cboLop.SelectedValue.ToString());

            DGV.Columns["maSV"].HeaderText = "Mã SV";
            txtMaSinhVien.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("Text", DGV.DataSource, "maSV");

            DGV.Columns["hoTen"].HeaderText = "Họ và Tên";
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", DGV.DataSource, "hoTen");

            DGV.Columns["ngaySinh"].HeaderText = "Ngày Sinh";

            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", DGV.DataSource, "ngaySinh");

            DGV.Columns["gioiTinh"].HeaderText = "Giới Tính";
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", DGV.DataSource, "gioiTinh");

            DGV.Columns["noiSinh"].HeaderText = "Nơi Sinh";
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", DGV.DataSource, "noiSinh");

            DGV.Columns["danToc"].HeaderText = "Dân Tộc";
            txtDanToc.DataBindings.Clear();
            txtDanToc.DataBindings.Add("Text", DGV.DataSource, "danToc");

            DGV.Columns["maLop"].HeaderText = "Mã lớp";


            //dieu chinh kich thuoc cac dong
            // DGV.Columns["maSV"].Width = 120;
            DGV.Columns["hoTen"].Width = 220;
            DGV.Columns["gioiTinh"].Width = 100;
            DGV.Columns["ngaySinh"].Width = 100;
            DGV.Columns["danToc"].Width = 80;
            DGV.Columns["noiSinh"].Width = 100;
            DGV.Columns["maLop"].Width = 100;
            
        }
        //Boolean adSV = false;
        //private void btnThemSV_Click(object sender, EventArgs e)
        //{
        //    txtMaSinhVien.Text = "";
        //    txtHoVaTen.Text = "";
        //    txtDanToc.Text = "";
        //    txtGioiTinh.Text = "";
        //    txtNgaySinh.Text = "";
        //    txtNoiSinh.Text = "";
        //    txtMaSinhVien.Enabled = true;
        //    txtMaSinhVien.Focus();
        //    adSV = true;
        //}

        //private void btnLuuSV_Click(object sender, EventArgs e)
        //{
        //    if (adSV)
        //    {
        //        dt.SinhVien_Insert(txtMaSinhVien.Text, txtHoVaTen.Text, txtNgaySinh.Value,
        //            Convert.ToInt16(txtGioiTinh.Text), txtNoiSinh.Text, txtDanToc.Text, txtMaLop.Text);
        //        adSV = false;
        //        txtMaSinhVien.Enabled = false;
        //        cboLop_SelectedIndexChanged(sender, e);
        //    }
        //    else
        //    {
        //        dt.SinhVien_Update(txtMaSinhVien.Text, txtHoVaTen.Text, txtNgaySinh.Value,
        //            Convert.ToInt16(txtGioiTinh.Text), txtNoiSinh.Text, txtDanToc.Text);
        //        cboLop_SelectedIndexChanged(sender, e);
        //    }
        //}

        //private void btnXoaSV_Click(object sender, EventArgs e)
        //{
        //    dt.SinhVien_Delete(txtMaSinhVien.Text);
        //    cboLop_SelectedIndexChanged(sender, e);
        //}
        private void txtTimKiemSinhVien_TextChanged(object sender, EventArgs e)
        {
            
            DGV.DataSource = dt.SinhViens.Where(x => x.hoTen.Contains(txtTimKiemSinhVien.Text)).ToList();
            DGV.Columns["maSV"].HeaderText = "Mã SV";
            txtMaSinhVien.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("Text", DGV.DataSource, "maSV");

            DGV.Columns["hoTen"].HeaderText = "Họ và Tên";
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", DGV.DataSource, "hoTen");

            DGV.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", DGV.DataSource, "ngaySinh");

            DGV.Columns["gioiTinh"].HeaderText = "Giới Tính";
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", DGV.DataSource, "gioiTinh");

            DGV.Columns["noiSinh"].HeaderText = "Nơi Sinh";
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", DGV.DataSource, "noiSinh");

            DGV.Columns["danToc"].HeaderText = "Dân Tộc";
            txtDanToc.DataBindings.Clear();
            txtDanToc.DataBindings.Add("Text", DGV.DataSource, "danToc");


        }     
    }
}
