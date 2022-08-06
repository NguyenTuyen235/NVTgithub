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
    public partial class frmMonDiemHocPhanQuyen : Form
    {
        public frmMonDiemHocPhanQuyen()
        {
            InitializeComponent();
        }
        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
        private void frmMonDiemHP_Load(object sender, EventArgs e)
        {
            txtMaHocKy.Enabled = false;
            txtTenHocKy.Enabled = false;
            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;
            txtSoTC.Enabled = false;
            if (dt.Lops_SelectAll().Count() > 0)
            {
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
                cboLop.DataSource = dt.Lops_SelectAll();
            }

            if (dt.HocKy_SelectAll().Count() > 0)
            {
                cboHocKy.DataSource = dt.HocKy_SelectAll();
                cboHocKy.ValueMember = "maHK";
                cboHocKy.DisplayMember = "tenHK";
            }
            txtMaHocKy.DataBindings.Clear();
            txtMaHocKy.DataBindings.Add("Text", cboHocKy.DataSource, "maHK");
            txtTenHocKy.DataBindings.Clear();
            txtTenHocKy.DataBindings.Add("Text", cboHocKy.DataSource, "tenHK");
            txtMaHocKy.Enabled = false;
            cboMonHocPhan_SelectedIndexChanged(sender, e);
        }
        //Boolean adHK = false;
        //private void btnThemMoiHK_Click(object sender, EventArgs e)
        //{
        //    txtMaHocKy.Text = "";
        //    txtTenHocKy.Text = "";
        //    txtMaHocKy.Enabled = true;
        //    txtMaHocKy.Focus();
        //    adHK = true;
        //}

        //private void btnLuuLaiHK_Click(object sender, EventArgs e)
        //{
        //    if (adHK)
        //    {
        //        try
        //        {
        //            dt.HocKy_Insert(txtMaHocKy.Text, txtMaHocKy.Text);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Nhập dữ liệu thất bại,kiểm tra dữ liệu nhập vào", "Thông Báo",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        txtMaHocKy.Enabled = false;
        //        adHK = false;
        //        frmMonDiemHP_Load(sender, e);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            dt.HocKy_Update(txtMaHocKy.Text, txtTenHocKy.Text);
        //            frmMonDiemHP_Load(sender, e);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Update thất bại,kiểm tra dữ liệu nhập vào", "Thông Báo",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        frmMonDiemHP_Load(sender, e);
        //    }
        //}

        //private void btnXoaHK_Click(object sender, EventArgs e)
        //{
        //    DialogResult lenh = MessageBox.Show("Bạn có chắc chắn muốn xóa học kỳ này không",
        //        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (lenh == DialogResult.Yes)
        //    {
        //        dt.HocKy_Delete(txtMaHocKy.Text);
        //    }

        //    frmMonDiemHP_Load(sender, e);
        //}

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonHocPhan.ValueMember = "maMon";
            cboMonHocPhan.DisplayMember = "tenMon";
            cboMonHocPhan.DataSource = dt.MonHP_SelectMaHK(cboHocKy.SelectedValue.ToString());

            txtMaMon.DataBindings.Clear();
            txtMaMon.DataBindings.Add("Text", cboMonHocPhan.DataSource, "maMon");
            txtMaMon.DataBindings.Clear();
            txtMaMon.DataBindings.Add("Text", cboMonHocPhan.DataSource, "maMon");

            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("Text", cboMonHocPhan.DataSource, "tenMon");

            txtSoTC.DataBindings.Clear();
            txtSoTC.DataBindings.Add("Text", cboMonHocPhan.DataSource, "soTinChi");

            // txtSoTC.ResetText();
            txtMaMon.Enabled = false;
            cboLop_SelectedIndexChanged(sender, e);
            
        }
        //Boolean adMonHocPhan = false;
        //private void btnThemMoiHP_Click(object sender, EventArgs e)
        //{
        //    txtMaMon.Text = "";
        //    txtTenMon.Text = "";
        //    txtSoTC.Text = "";
        //    txtMaMon.Enabled = true;
        //    adMonHocPhan = true;
        //}

        //private void btnLuuLaiHP_Click(object sender, EventArgs e)
        //{
        //    if (adMonHocPhan)
        //    {
        //        try
        //        {
        //            dt.MonHP_Insert(txtMaMon.Text, txtTenMon.Text, Convert.ToInt16(txtSoTC.Text), txtMaHocKy.Text);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Nhập dữ liệu thất bại,kiểm tra dữ liệu nhập vào", "Thông Báo",
        //               MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        adMonHocPhan = false;
        //        cboHocKy_SelectedIndexChanged(sender, e);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            dt.MonHP_Update(txtMaMon.Text, txtTenMon.Text, Convert.ToInt16(txtSoTC.Text));
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Update thất bại,kiểm tra dữ liệu nhập vào", "Thông Báo",
        //               MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        cboHocKy_SelectedIndexChanged(sender, e);
        //    }
        //}

        //private void btnXoaHP_Click(object sender, EventArgs e)
        //{
        //    DialogResult lenh = MessageBox.Show("Bạn có chắc chắn muốn xóa môn" + txtTenMon.Text + "?",
        //        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (lenh == DialogResult.Yes)
        //    {
        //        dt.MonHP_Delete(txtMaMon.Text);
        //    }

        //    cboHocKy_SelectedIndexChanged(sender, e);
        //}

        //private void btnCapNhatDuLieu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        foreach (var m in dt.MonHP_SelectAll())
        //        {
        //            foreach (var s in dt.SinhVien_SelectAll())
        //            {
        //                if (dt.DiemHP_Search(m.maMon, s.maSV).Count() == 0)
        //                {
        //                    dt.DiemHP_Insert(m.maMon, s.maSV);
        //                }
        //            }
        //        }
        //        MessageBox.Show("Cập nhật thành công cơ sở dữ liệu cho điểm học phần !", "Thông Báo",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Cập nhật dữ liệu thất bại, kiểm tra lại dữ liệu của bạn", "Thông Báo",
        //           MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void cboMonHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVDiem.Columns["maSV"].HeaderText = "Mã SV";
            DGVDiem.Columns["maSV"].ReadOnly = true;
            DGVDiem.Columns["hoTen"].ReadOnly = true;
            DGVDiem.Columns["ngaySinh"].ReadOnly = true;
            DGVDiem.Columns["maSV"].Width = 100;

            DGVDiem.Columns["hoTen"].HeaderText = "Họ và Tên";
            DGVDiem.Columns["hoTen"].Width = 180;
            DGVDiem.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            DGVDiem.Columns["ngaySinh"].Width = 100;
            DGVDiem.Columns["diemLan1"].HeaderText = "Điểm Lần 1";
            DGVDiem.Columns["diemLan1"].Width = 60;
            DGVDiem.Columns["diemLan2"].HeaderText = "Điểm Lần 2";
            DGVDiem.Columns["diemLan2"].Width = 60;
            DGVDiem.DataSource = dt.BangDiemHP(cboLop.SelectedValue.ToString(), txtMaMon.Text);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVDiem.DataSource = dt.BangDiemHP(cboLop.SelectedValue.ToString(), txtMaMon.Text);
        }

        //private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cboMonHocPhan_SelectedIndexChanged(sender, e);
        //}

        //private void DGVDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    int i = DGVDiem.CurrentCell.RowIndex;
        //    if (!String.IsNullOrEmpty(DGVDiem.Rows[i].Cells["diemLan1"].Value.ToString()))
        //    {
        //        Double d1 = Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan1"].Value);
        //        if (d1 >= 0 && d1 <= 100)
        //        {
        //            if (d1 > 10)
        //            {
        //                d1 = d1 / 10;
        //                DGVDiem.Rows[i].Cells["diemLan1"].Value = d1;
        //            }


        //            dt.DiemHP_UpdateLan1(Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan1"].Value),
        //            txtMaMon.Text, DGVDiem.Rows[i].Cells["maSV"].Value.ToString());
        //        }
        //        else
        //        {
        //            MessageBox.Show("Bạn chỉ nhập các điểm từ 0 đến 10. Vui lòng nhập lại",
        //                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //            // Nếu người dùng nhập sai Xóa bỏ dữ liệu vừa nhập vào cho bằng rỗng 
        //            DGVDiem.Rows[i].Cells["diemLan1"].Value = "";
        //        }

        //    }
        //    if (!String.IsNullOrEmpty(DGVDiem.Rows[i].Cells["diemLan2"].Value.ToString()))
        //    {
        //        Double d2 = Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan2"].Value);
        //        if (d2 >= 0 && d2 <= 100)
        //        {
        //            if (d2 > 10)
        //            {
        //                d2 = d2 / 10;
        //                DGVDiem.Rows[i].Cells["diemLan2"].Value = d2;
        //            }


        //            dt.DiemHP_UpdateLan2(Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan2"].Value),
        //            txtMaMon.Text, DGVDiem.Rows[i].Cells["maSV"].Value.ToString());
        //        }
        //        else
        //        {
        //            MessageBox.Show("Bạn chỉ nhập các điểm từ 0 đến 10. Vui lòng nhập lại",
        //                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //            // Nếu người dùng nhập sai Xóa bỏ dữ liệu vừa nhập vào cho bằng rỗng 
        //            DGVDiem.Rows[i].Cells["diemLan2"].Value = "";
        //        }

        //    }
        //}
    }
}
