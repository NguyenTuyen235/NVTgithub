using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
//using System.Data.SqlClient;
//using Microsoft.Office.Interop.Excel;
namespace QLDiem.GiaoDien
{
    public partial class frmLopSinhVien : Form
    {
        public frmLopSinhVien()
        {
            InitializeComponent();
        }
        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
        private void frmLopSinhVien_Load(object sender, EventArgs e)
        {
            DGV.DataSource = dt.Lops_SelectAll();
            txtMaLop.Enabled = false;
            txtTenLop. Enabled = false;
            btnThemMoi.Enabled = true;
            btnLuuLai.Enabled = false;
            
            // an hien btn sinh vien
            txtMaSinhVien.Enabled = false;
            txtHoVaTen.Enabled = false;
            txtDanToc.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            btnThemSV.Enabled = true;
            btnLuuSV.Enabled = false;

            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "maLop";
            cboLop.DataSource = dt.Lops_SelectAll();
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", cboLop.DataSource, "maLop");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", cboLop.DataSource, "tenLop");
        }
        Boolean adLop = false;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnLuuLai.Enabled = true;
            btnXoa.Enabled = false;
            btnSuaMaLop.Enabled = false;
            btnThemMoi.Enabled = false;
            //an chuc nang cua sinh vien 
            btnThemSV.Enabled = false;
            btnLuuSV.Enabled = false;
            btnXoaSV.Enabled = false;
            btnSuaSV.Enabled = false;
            btnQuayLaiSV.Enabled = false;

            txtMaLop.Text = "";
            txtTenLop.Text = "";
            
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;

            txtMaLop.Focus();
            cboLop.Enabled = false;
            adLop = true;
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
         

            
            if(adLop)
            {
                try
                {


                    if (txtMaLop.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập MÃ LỚP");
                        txtMaLop.Focus();
                        
                        return;
                    }
                    if (txtTenLop.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập TÊN LỚP");
                        txtTenLop.Focus();
                        return;
                    }
                    //MessageBox.Show("Thêm thành công");
                    dt.Lops_Insert(txtMaLop.Text, txtTenLop.Text);
                    btnThemMoi.Enabled = true;
                    btnSuaMaLop.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuuLai.Enabled = false;
                    txtMaLop.Enabled = false;

                    MessageBox.Show("Thêm thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //an chuc nang cua sinh vien 
                    btnThemSV.Enabled = true;
                    btnLuuSV.Enabled = false;
                    btnXoaSV.Enabled = true;
                    btnSuaSV.Enabled = true;
                    btnQuayLaiSV.Enabled = true;

                    cboLop.Enabled = true;
                    adLop = false;

                }
                catch
                {
                    MessageBox.Show("Thêm dữ liệu thất bại kiểm tra dữ liệu nhập vào","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   
                }                        
            
            }
            else
            {
                try
                {
                    txtTenLop.Enabled = true;
                    txtTenLop.Focus();
                    dt.Lops_Update(txtMaLop.Text, txtTenLop.Text);
                    adLop = false;
                    MessageBox.Show("Sửa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnThemSV.Enabled = true;
                    btnLuuSV.Enabled = false;
                    btnXoaSV.Enabled = true;
                    btnSuaSV.Enabled = true;
                    btnQuayLaiSV.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSuaMaLop.Enabled = true;
                    txtTenLop.Enabled = true;
                    txtTenLop.Focus();
                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu thất bại kiểm tra dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmLopSinhVien_Load(sender, e);        
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult xoa=
            MessageBox.Show("Bạn có muốn xóa lớp không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                dt.Lops_Delete(cboLop.SelectedValue.ToString());
            }
            
            frmLopSinhVien_Load(sender, e);
        }

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

        Boolean adSV = false;
        private void btnThemSV_Click(object sender, EventArgs e)
        {

            btnLuuSV.Enabled = true;
            btnXoaSV.Enabled = false;
            btnSuaSV.Enabled = false;
            btnThemSV.Enabled = false;
            //an lop
            btnThemMoi.Enabled = false;
            btnSuaMaLop.Enabled = false;
            btnXoa.Enabled = false;
            btnQuayLaiDSL.Enabled = false;

            //txtMaLop.Text = "";
            //txtTenLop.Text = "";
            //txtMaLop.Enabled = true;
            //txtTenLop.Enabled = true;
            //txtMaLop.Focus();
            
            txtMaSinhVien.Text = "";
            txtHoVaTen.Text = "";
            txtDanToc.Text = "";
            txtGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtNoiSinh.Text = "";
            
            txtMaSinhVien.Enabled = true;
            txtHoVaTen.Enabled = true;
            txtDanToc.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtMaSinhVien.Focus();

            adSV = true;
        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            if(adSV)
            {
                try
                {

                    if (txtMaSinhVien.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập MÃ SINH VIÊN");
                        txtMaSinhVien.Focus();
                        return;
                    }
                    if (txtHoVaTen.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập HỌ VÀ TÊN");
                        txtHoVaTen.Focus();
                        return;
                    }
                    if (txtDanToc.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập DÂN TỘC");
                        txtDanToc.Focus();
                        return;
                    }

                    if (txtGioiTinh.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập GIỚI TÍNH");
                        txtGioiTinh.Focus();
                        return;
                    }
                    if (txtNgaySinh.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập NGÀY SINH");
                        txtNgaySinh.Focus();
                        return;
                    }
                    if (txtNoiSinh.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập NƠI SINH");
                        txtNoiSinh.Focus();
                        return;
                    }
                    dt.SinhVien_Insert(txtMaSinhVien.Text, txtHoVaTen.Text, txtNgaySinh.Value,
                        (txtGioiTinh.Text), txtNoiSinh.Text, txtDanToc.Text, txtMaLop.Text);
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //mo buton lop
                    btnThemMoi.Enabled = true;
                    btnSuaMaLop.Enabled = true;
                    btnXoa.Enabled = true;
                    btnQuayLaiDSL.Enabled = true;
                    //tat chuc nang các nút khi lưu thành cong
                    txtDanToc.Enabled = false;
                    txtGioiTinh.Enabled = false;
                    txtHoVaTen.Enabled = false;
                    txtNoiSinh.Enabled = false;
                    txtNgaySinh.Enabled = false;

                    adSV = false;
                    txtMaSinhVien.Enabled = false;
                    btnThemSV.Enabled = true;
                    btnSuaSV.Enabled = true;
                    btnXoaSV.Enabled = true;
                    btnLuuSV.Enabled = false;
                    cboLop_SelectedIndexChanged(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã sinh viên bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }
            }
            else
            {
                try
                {
                    dt.SinhVien_Update(txtMaSinhVien.Text, txtHoVaTen.Text, txtNgaySinh.Value,
                       (txtGioiTinh.Text), txtNoiSinh.Text, txtDanToc.Text);

                    //cboLop_SelectedIndexChanged(sender, e);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //mo buton lop
                    btnThemMoi.Enabled = true;
                    btnSuaMaLop.Enabled = true;
                    btnXoa.Enabled = true;
                    btnQuayLaiDSL.Enabled = true;
                    //tat chuc nang các nút khi sửa thành cong
                    txtDanToc.Enabled = false;
                    txtGioiTinh.Enabled = false;
                    txtHoVaTen.Enabled = false;
                    txtNoiSinh.Enabled = false;
                    txtNgaySinh.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cboLop_SelectedIndexChanged(sender, e);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
             DialogResult xoa=
            MessageBox.Show("Bạn có muốn xóa sinh viên không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
             if (xoa == DialogResult.Yes)
             {
                 //MessageBox.Show("Bạn có muốn xóa không","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                 dt.SinhVien_Delete(txtMaSinhVien.Text);
                 cboLop_SelectedIndexChanged(sender, e);
             }
        }

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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Khởi tạo Excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // Khởi tạo WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // Khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Lấy tên cột dữ liệu:
            for (int j = 0; j < DGV.ColumnCount - 1; j++)
            {
                worksheet.Cells[1, j+1] = DGV.Columns[j].HeaderText;
            }
            // Đổ dữ liệu vào Sheet:
            worksheet.Cells[3, 2] = "Mã SV:" + txtMaSinhVien.Text;
            worksheet.Cells[4, 2] = "Họ tên:" + txtHoVaTen.Text;
            worksheet.Cells[5, 2] = "Ngày sinh:" + txtNgaySinh.Text;
            worksheet.Cells[6, 2] = "Giới tính:" + txtGioiTinh.Text;
            worksheet.Cells[7, 2] = "Nơi sinh:" + txtNoiSinh.Text;
            worksheet.Cells[8, 2] = "Dân tộc:" + txtDanToc.Text;
            
            // Khúc này  
            for (int i = 0; i < DGV.RowCount-1 ; i++)
            {
                for (int j = 0; j < DGV.ColumnCount -1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DGV.Rows[i].Cells[j].Value;
                    
                }
                
            }
            // Định dạng trang:
           
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            //Định dạng cột:
            worksheet.Range["A1"].ColumnWidth = 16;
            worksheet.Range["B1"].ColumnWidth = 20;
            worksheet.Range["C1"].ColumnWidth = 13;
            worksheet.Range["D1"].ColumnWidth = 9.86;
            worksheet.Range["E1"].ColumnWidth = 9.43;
            worksheet.Range["F1"].ColumnWidth = 10.57;
            worksheet.Range["G1"].ColumnWidth = 9.86;
            
            //DINH DANG DONG TEX
            
           
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //Kết nối với dữ liệu Excel:
                OleDbConnection con = new OleDbConnection();
               // con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\Visual Studio 2013\C#\XayDungPhanMemQLDiem\QLDiem\bin\Debug\data\Test.xlsx;Extended Properties=Excel 12.0;";
                //con.ConnectionString = (@"Data Source =C:\Users\admin\Desktop\Test.xlsx;HDR=no;Format=xlsx;");
                //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\Users\admin\Desktop\Test.xlsx;HDR=yes;Format=xlsx;Extended Properties='Excel 12.0 Macro;HDR=YES';";
                //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Desktop\Test.xlsx;Extended Properties='Excel 12.0;HDR=YES';";
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Desktop\Test.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES';";
                OleDbCommand command = new OleDbCommand ("SELECT * FROM [Sheet1$]", con);
                OleDbDataAdapter dap = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                DGV.DataSource = dt;
                MessageBox.Show("Kết nối thành công");
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaMaLop_Click(object sender, EventArgs e)
        {
            btnLuuLai.Enabled = true;
            btnXoa.Enabled = false;
            btnSuaMaLop.Enabled = false;
            btnThemMoi.Enabled = false;
            //an chuc nang cua sinh vien 
            btnThemSV.Enabled = false;
            btnLuuSV.Enabled = false;
            btnXoaSV.Enabled = false;
            btnSuaSV.Enabled = false;
            btnQuayLaiSV.Enabled = false;

            txtMaLop.Enabled = false;
            txtTenLop.Enabled = true;
            
            txtTenLop.Focus();
            adLop = true;
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            btnLuuSV.Enabled = true;
            btnXoaSV.Enabled = false;
            btnSuaSV.Enabled = false;
            btnThemSV.Enabled = false;
            //an lop
            btnThemMoi.Enabled = false;
            btnSuaMaLop.Enabled = false;
            btnXoa.Enabled = false;
            btnQuayLaiDSL.Enabled = false;

            txtMaSinhVien.Enabled = false;
            txtHoVaTen.Enabled = true;
            txtDanToc.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
        }

        private void btnQuayLaiSV_Click(object sender, EventArgs e)
        {
            frmLopSinhVien_Load(sender, e);
            txtMaSinhVien.Enabled = false;
            txtHoVaTen.Enabled = false;
            txtDanToc.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            btnThemSV.Enabled = true;
            btnLuuSV.Enabled = false;
            btnXoaSV.Enabled = true;
            btnSuaSV.Enabled = true;
            //mo buton lop
            btnThemMoi.Enabled = true;
            btnSuaMaLop.Enabled = true;
            btnXoa.Enabled = true;
            btnQuayLaiDSL.Enabled = true;
        }

        private void btnQuayLaiDSL_Click(object sender, EventArgs e)
        {
            frmLopSinhVien_Load(sender, e);
            //btnQuayLaiSV_Click(sender,e);
            btnThemSV.Enabled = false;
           btnThemMoi.Enabled = true;
           btnXoa. Enabled = true;
           btnSuaMaLop.Enabled = true;
           btnLuuLai.Enabled = false;
           cboLop.Enabled = true;
           txtMaLop.Enabled = false;
           txtTenLop.Enabled = false;
            //mo sinh vien
           btnThemSV.Enabled = true;
           btnXoaSV.Enabled = true;
           btnSuaSV.Enabled = true;
           btnQuayLaiSV.Enabled = true;
        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }       

    }
}
