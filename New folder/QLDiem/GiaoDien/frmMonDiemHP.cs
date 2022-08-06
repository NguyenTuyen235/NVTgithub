using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QLDiem.GiaoDien.ProcessBar;
namespace QLDiem.GiaoDien
{
    public partial class frmMonDiemHP : Form
    {
        public frmMonDiemHP()
        {
            InitializeComponent();
        }
        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
        private void frmMonDiemHP_Load(object sender, EventArgs e)
        {
            //DGVDiem.DataSource = dt.HocKy_SelectAll();
            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;
            txtSoTC.Enabled = false;
            btnThemMoiHP.Enabled = true;
            btnLuuLaiHP.Enabled = false;

            //AN BTN MA HOC KY
            txtMaHocKy.Enabled = false;
            txtTenHocKy.Enabled = false;
            btnThemMoiHK.Enabled = true;
            btnLuuLaiHK.Enabled = false;
            cboHocKy.Enabled = true;
            if (dt.Lops_SelectAll().Count() >0)
            {
                cboLop.DisplayMember = "tenLop";
                cboLop.ValueMember = "maLop";
                cboLop.DataSource = dt.Lops_SelectAll();
            }

            if (dt.HocKy_SelectAll().Count() >0)
            {
                //cboHocKy.DataSource = dt.HocKy_SelectAll();
                cboHocKy.ValueMember = "maHK";
                cboHocKy.DisplayMember = "tenHK";
                cboHocKy.DataSource = dt.HocKy_SelectAll();
            }          
            txtMaHocKy.DataBindings.Clear();
            txtMaHocKy.DataBindings.Add("Text", cboHocKy.DataSource, "maHK");
            txtTenHocKy.DataBindings.Clear();
            txtTenHocKy.DataBindings.Add("Text", cboHocKy.DataSource, "tenHK");
            txtMaHocKy.Enabled = false;
            
            cboMonHocPhan_SelectedIndexChanged(sender, e);
        }
        Boolean adHK = false;
        private void btnThemMoiHK_Click(object sender, EventArgs e)
        {
            btnThemMoiHP.Enabled = false;
            btnLuuLaiHP.Enabled = false;
            btnSuaTenMon.Enabled = false;
            btnXoaHP.Enabled = false;
            btnQuayLaiMonHP.Enabled = false;

            btnLuuLaiHK.Enabled = true;
            btnXoaHK.Enabled = false;
            btnSuaHocKy.Enabled = false;
            btnThemMoiHK.Enabled = false;
            txtMaHocKy.Text = "";
            txtTenHocKy.Text = "";
           cboHocKy.Enabled = false;

            txtMaHocKy.Enabled = true;
            txtTenHocKy.Enabled = true;
            txtMaHocKy.Focus();
            adHK = true;
        }

        private void btnLuuLaiHK_Click(object sender, EventArgs e)
        {
            if(adHK)
            {
                try
                {
                    if (txtMaHocKy.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã Học Kỳ");
                        txtMaHocKy.Focus();
                        return;
                    }
                    if (txtTenHocKy.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Tên Học Kỳ");
                        txtTenHocKy.Focus();
                        return;
                    }
                    dt.HocKy_Insert(txtMaHocKy.Text, txtTenHocKy. Text);
                    btnThemMoiHK.Enabled = true;
                    btnSuaHocKy.Enabled = true;
                    btnXoaHK.Enabled = true;
                    btnLuuLaiHK.Enabled = false;
                    txtMaHocKy.Enabled = false;
                    MessageBox.Show("Lưu lại thành công", "Thông Báo");
                   
                    cboHocKy.Enabled = true;
                    txtTenHocKy.Enabled = true;

                    btnThemMoiHP.Enabled = true;
                    btnLuuLaiHP.Enabled = false;
                    btnSuaTenMon.Enabled = true;
                    btnXoaHP.Enabled = true;
                    btnQuayLaiMonHP.Enabled = true;
                    
                    adHK = false;
                    frmMonDiemHP_Load(sender, e);               
                }
                catch
                {
                    MessageBox.Show("Thêm dữ liệu thất bại kiểm tra dữ liệu nhập vào","Thông báo");

             
                }            
            }
            else
            {
                try
                {
                    txtTenHocKy.Enabled = true;
                    txtTenHocKy.Focus();
                    dt.HocKy_Update(txtMaHocKy.Text, txtTenHocKy.Text);
                    adHK = false;
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThemMoiHK.Enabled = true;
                    btnSuaHocKy.Enabled = true;
                    btnXoaHK.Enabled = true;
                    btnLuuLaiHK.Enabled = true;
                    btnSuaTenMon.Enabled = true;
                    btnXoaHP.Enabled = true;
                    btnQuayLaiMonHP.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Update thất bại,kiểm tra dữ liệu nhập vào", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }
                frmMonDiemHP_Load(sender, e);                                  
            }
           
           
        }

        private void btnXoaHK_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Bạn có chắc chắn muốn xóa học kỳ này không",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(lenh==DialogResult.Yes)
            {
                dt.HocKy_Delete(txtMaHocKy.Text);
            }
            
            frmMonDiemHP_Load(sender, e);
        }

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

        Boolean adMonHocPhan = false;
        private void btnThemMoiHP_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Bạn có muốn thêm mới môn học phần không");
           
            btnLuuLaiHP.Enabled = true;
            btnXoaHP.Enabled = false;
            btnThemMoiHP.Enabled = false;
            btnSuaTenMon.Enabled = false;
            //an hoc ky
            btnThemMoiHK.Enabled = false;
            btnXoaHK.Enabled = false;
            btnLuuLaiHK.Enabled = false;
            btnSuaHocKy.Enabled = false;
            btnQuayLai.Enabled = false;
            //btnSuaHocKy
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtSoTC.Text = "";
            txtMaMon.Enabled = true;
            txtTenMon.Enabled = true;
            txtSoTC.Enabled = true;
            txtMaMon.Focus();
            adMonHocPhan = true;
        }

        private void btnLuuLaiHP_Click(object sender, EventArgs e)
        {
            if(adMonHocPhan)
                
            {
              //  cboHocKy_SelectedIndexChanged(sender, e);
                try
                {
                    
                    if(txtMaMon.Text =="")
                    {
                        MessageBox.Show("Bạn chưa nhập mã môn");
                        txtMaMon.Focus();
                        return;
                    }
                    if(txtTenMon.Text =="")
                    {
                        MessageBox.Show("Bạn chưa nhập tên môn");
                        txtTenMon.Focus();
                        return;
                    }
                    if(txtSoTC.Text =="")
                    {
                        MessageBox.Show("Bạn chưa nhập số tín chỉ");
                        txtSoTC.Focus();
                        return;
                    }                  
                    dt.MonHP_Insert(txtMaMon.Text, txtTenMon.Text, txtSoTC.Text, txtMaHocKy.Text); 
                    
                    adMonHocPhan = false;
                    
                    btnThemMoiHP. Enabled = true;
                    btnSuaTenMon. Enabled = true;
                    btnXoaHP. Enabled =true;
                    btnLuuLaiHP. Enabled = false;
                    txtMaMon. Enabled = false;
                    MessageBox.Show("Thêm thành công");
                   // adHK = false;
                   cboHocKy_SelectedIndexChanged(sender, e);
                  //  frmMonDiemHP_Load( sender,e);
                }

                catch(Exception ex)
                {

                   
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Thêm du lieu that bai", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //why
                //adMonHocPhan = false;
                //cboHocKy_SelectedIndexChanged(sender, e);
            }
            else
            {
                try
                {
                    //MessageBox.Show("Bạn có muốn sửa lại không");
                    txtTenMon.Enabled = true;
                    txtTenMon.Focus();
                    dt.MonHP_Update(txtMaMon.Text, txtTenMon.Text, txtSoTC.Text);
                    cboHocKy_SelectedIndexChanged(sender, e);
                   // cboMonHocPhan_SelectedIndexChanged(sender, e);
                }
                catch
                {
                    MessageBox.Show("Update thất bại,kiểm tra dữ liệu nhập vào", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //cboHocKy_SelectedIndexChanged(sender, e);
            }
        }

        private void btnXoaHP_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Bạn có chắc chắn muốn xóa môn" + txtTenMon.Text + "?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(lenh==DialogResult.Yes)
            {
                dt.MonHP_Delete(txtMaMon.Text);
            }
           
            cboHocKy_SelectedIndexChanged(sender, e);
        }

        private void btnCapNhatDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
               
                foreach (var m in dt.MonHP_SelectAll())
                {
                    foreach (var s in dt.SinhVien_SelectAll())
                    {
                        if (dt.DiemHP_Search(m.maMon, s.maSV).Count() == 0)
                        {
                            dt.DiemHP_Insert(m.maMon, s.maSV);
                        }
                    }
                }
               
                MessageBox.Show("Cập nhật thành công cơ sở dữ liệu cho điểm học phần !", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLop_SelectedIndexChanged(sender, e);
            }
            catch
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại, kiểm tra lại dữ liệu của bạn", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

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

        private void DGVDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int i = DGVDiem.CurrentCell.RowIndex;
               
                    if (!String.IsNullOrEmpty(DGVDiem.Rows[i].Cells["diemLan1"].Value.ToString()))
                    {
                        Double d1 = Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan1"].Value);
                        if (d1 >= 0 && d1 <= 100)
                        {
                            if (d1 > 10)
                            {
                                d1 = d1 / 10;
                                DGVDiem.Rows[i].Cells["diemLan1"].Value = d1;
                            }


                            dt.DiemHP_UpdateLan1(Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan1"].Value),
                            txtMaMon.Text, DGVDiem.Rows[i].Cells["maSV"].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Bạn chỉ nhập các điểm từ 0 đến 10. Vui lòng nhập lại",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Nếu người dùng nhập sai Xóa bỏ dữ liệu vừa nhập vào cho bằng rỗng 
                            DGVDiem.Rows[i].Cells["diemLan1"].Value = "";
                        }
   
                    }

                  
                    if (!String.IsNullOrEmpty(DGVDiem.Rows[i].Cells["diemLan2"].Value.ToString()))
                    {



                        Double d2 = Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan2"].Value);
                        if (d2 >= 0 && d2 <= 100)
                        {
                            if (d2 > 10)
                            {
                                d2 = d2 / 10;
                                DGVDiem.Rows[i].Cells["diemLan2"].Value = d2;
                            }


                            dt.DiemHP_UpdateLan2(Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan2"].Value),
                            txtMaMon.Text, DGVDiem.Rows[i].Cells["maSV"].Value.ToString());
                        }
                        else
                        {
                            
                            {
                                MessageBox.Show("Bạn chỉ nhập các điểm từ 0 đến 10. Vui lòng nhập lại",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                // Nếu người dùng nhập sai Xóa bỏ dữ liệu vừa nhập vào cho bằng rỗng 
                                DGVDiem.Rows[i].Cells["diemLan2"].Value = "";
                            }
                            
                        }

                    }
                    
                
            }
            catch
            {

                DGVDiem.Columns["maSV"].HeaderText = "Mã SV";
                DialogResult lenh = MessageBox.Show("Bạn có muốn nhập điểm không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (lenh == DialogResult.Yes)
                {
                    int i = DGVDiem.CurrentCell.RowIndex;
                    dt.DiemHP_UpdateLan1(Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan1"].Value),
                        txtMaMon.Text, DGVDiem.Rows[i].Cells["maSV"].Value.ToString());
                    dt.DiemHP_UpdateLan2(Convert.ToDouble(DGVDiem.Rows[i].Cells["diemLan2"].Value),
                       txtMaMon.Text, DGVDiem.Rows[i].Cells["maSV"].Value.ToString());
                }
            }
        }

        private void btnSuaTenMon_Click(object sender, EventArgs e)
        {
            btnLuuLaiHP.Enabled = true;
            btnXoaHP.Enabled = false;
            btnSuaTenMon.Enabled = false;
            btnThemMoiHP.Enabled = false;
            btnThemMoiHK.Enabled = false;
            btnSuaHocKy.Enabled = false;
            btnXoaHK.Enabled = false;
            btnQuayLai.Enabled = false;


            txtMaMon.Enabled = false;

            txtTenMon.Enabled = true;
            txtSoTC.Enabled = true;
            txtMaMon.Enabled =false;
            txtTenMon.Focus();
            adMonHocPhan = true;
           
        }
        private void btnSuaHocKy_Click(object sender, EventArgs e)
        {
            //AN NUT THEM MOI KHI CLICK VAO SUA HOC KY
            btnThemMoiHP.Enabled = false;
            btnLuuLaiHP.Enabled = true;
            btnSuaTenMon.Enabled = false;
            btnXoaHP.Enabled = false;
            btnQuayLaiMonHP.Enabled = false;
            btnLuuLaiHP.Enabled = false;
            cboHocKy.Enabled = false;

            btnLuuLaiHK.Enabled = true;
            btnXoaHK.Enabled = false;
            btnSuaHocKy.Enabled = false;
            btnThemMoiHK.Enabled = false;

            txtMaHocKy.Enabled = false;
            txtTenHocKy.Enabled = true;
            txtTenHocKy.Focus();
            adHK = true;
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMonDiemHP_Load( sender,e);
            btnThemMoiHK.Enabled = true;
            btnSuaHocKy.Enabled = true;
            btnXoaHK.Enabled = true;
            btnLuuLaiHK.Enabled = false;
            txtMaHocKy.Enabled = false;
            txtTenHocKy.Enabled = false;
            btnSuaTenMon.Enabled = true;
            btnXoaHP.Enabled = true;
            btnQuayLaiMonHP.Enabled = true;
            cboHocKy.Enabled = true;
            //txtMaMon.Enabled = false;
            //txtTenMon.Enabled = false;
            //txtSoTC.Enabled = false;
            //btnThemMoiHP.Enabled = true;
            //btnLuuLaiHP.Enabled = false;

            //AN BTN MA HOC KY
            //txtMaHocKy.Enabled = false;
            //txtTenHocKy.Enabled = false;
            //btnThemMoiHK.Enabled = true;
            //btnLuuLaiHK.Enabled = false;
            //cboHocKy.Enabled = true;
        }
        private void btnQuayLaiMonHP_Click(object sender, EventArgs e)
        {
            btnThemMoiHP.Enabled = true;
            btnSuaTenMon.Enabled = true;
            btnXoaHP.Enabled = true;
            btnLuuLaiHP.Enabled = false;
            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;
            txtSoTC.Enabled = false;
            btnThemMoiHK.Enabled = true;
            btnSuaHocKy.Enabled = true;
            btnXoaHK.Enabled = true;
            btnQuayLai.Enabled = true;
        }

        private void txtSoTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelEx2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.PerformStep();
        }

        private void DGVDiem_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Bạn chỉ được nhập số vào ô điểm!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);

         }

       
    }
}
