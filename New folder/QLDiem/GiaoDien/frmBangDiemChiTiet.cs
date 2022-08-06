using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;

namespace QLDiem.GiaoDien
{
    public partial class frmBangDiemChiTiet : Form
    {
        public frmBangDiemChiTiet()
        {
            InitializeComponent();
        }

        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
        XuLyDiem.XuLy  xl=new XuLyDiem.XuLy();
        private void frmBangDiemChiTiet_Load(object sender, EventArgs e)
        {
            cboChonLop.ValueMember = "maLop";
            cboChonLop.DisplayMember = "tenLop";
            cboChonLop.DataSource = dt.Lops_SelectAll();
         
        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            treeViewSV.Nodes.Clear();
            foreach(var r in dt.SinhVien_SelectMaLop(cboChonLop.SelectedValue.ToString()))
            {
                TreeNode node = new TreeNode();
                node.Name = r.maSV;
                node.Text = r.hoTen;
                treeViewSV.Nodes.Add(node);
            }
            treeViewSV.ExpandAll();
        }

        private void treeViewSV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach(var r in dt.SinhVien_SelectID(e.Node.Name))
            {
                txtMaSV.Text = e.Node.Name;
                txtHoTen.Text = r.hoTen;
                txtNgaySinh.Text = r.ngaySinh.ToString();
                if(r.gioiTinh.ToString()=="1")
                {
                    txtGioiTinh.Text = "Nữ";
                }
                else
                {
                    txtGioiTinh.Text = "Nam";
                }
                txtDanToc.Text = r.danToc;
                txtNoiSinh.Text = r.noiSinh;
            }
            var table = new DataTable();
            DataColumnCollection col = table.Columns;
            if (!col.Contains("maMon"))
                table.Columns.Add("maMon", typeof(String));
            if (!col.Contains("tenMon"))
                table.Columns.Add("tenMon", typeof(String));
            if (!col.Contains("soTinChi"))
                table.Columns.Add("soTinChi", typeof(String));
            if (!col.Contains("diemHP"))
                table.Columns.Add("diemHP", typeof(String));
            if (!col.Contains("diemChu"))
                table.Columns.Add("diemChu", typeof(String));
            if (!col.Contains("diemSo"))
                table.Columns.Add("diemSo", typeof(String));
            Double tong = 0;
            int soTinChi = 0;
            foreach(var m in dt.MonHP_SelectAll())
            {
                DataRow r = table.NewRow();
                r["maMon"] = m.maMon;
                r["tenMon"] = m.tenMon;
                r["soTinChi"] = m.soTinChi;
                soTinChi += Convert.ToInt32(m.soTinChi);
                foreach(var d in dt.DiemHP_Search(m.maMon,e.Node.Name))
                {
                    if(d.diemLan2==null)
                    {
                        r["diemHP"]=d.diemLan1;
                        r["diemChu"]=xl.diemChu(Convert.ToDouble(d.diemLan1));
                        r["diemSo"]=xl.diemSo(Convert.ToDouble(d.diemLan1));
                        tong += xl.diemSo(Convert.ToDouble(d.diemLan1))
                            * Convert.ToDouble(m.soTinChi);
                    }
                    else
                    {
                        r["diemHP"]=d.diemLan2;
                        r["diemSo"] = xl.diemChu(Convert.ToDouble(d.diemLan2));
                        r["diemSo"]=xl.diemSo(Convert.ToDouble(d.diemLan2));
                        tong += xl.diemSo(Convert.ToDouble(d.diemLan2))
                            * Convert.ToDouble(m.soTinChi);
                    }
                }
                table.Rows.Add(r);

            }//Kết thúc mon HP
            Double t = Math.Round(tong / soTinChi, 2);
            txtTBtoankhoa.Text = t.ToString();
            txtXLtoankhoa.Text = xl.XLtoankhoa(t);
            DGVBangDiemSV.DataSource = table;
            DGVBangDiemSV.Columns["maMon"].HeaderText = "Mã Môn";
            DGVBangDiemSV.Columns["maMon"].Width = 100;
            DGVBangDiemSV.Columns["tenMon"].HeaderText = "Tên môn";
            DGVBangDiemSV.Columns["tenMon"].Width = 150;
            DGVBangDiemSV.Columns["soTinChi"].HeaderText = "Số tín chỉ";
            DGVBangDiemSV.Columns["soTinChi"].Width = 50;
            DGVBangDiemSV.Columns["diemHP"].HeaderText = "Điểm HP";
            DGVBangDiemSV.Columns["diemHP"].Width = 50;
            DGVBangDiemSV.Columns["diemChu"].HeaderText = "Điểm chữ";
            DGVBangDiemSV.Columns["diemChu"].Width = 50;
            DGVBangDiemSV.Columns["diemSo"].HeaderText = "Điểm số";
            DGVBangDiemSV.Columns["diemSo"].Width = 50;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // Khởi tạo Excel
            Microsoft.Office.Interop.Excel._Application app= new Microsoft.Office.Interop.Excel.Application();
            // Khởi tạo WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // Khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];           
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Đổ dữ liệu vào Sheet
            worksheet.Cells[1, 1] = "BẢNG TỔNG HỢP ĐIỂM CHI TIẾT SINH VIÊN";
            worksheet.Cells[3, 2] = "Mã SV:" + txtMaSV.Text;
            worksheet.Cells[4, 2] = "Họ tên:" + txtHoTen.Text;
            worksheet.Cells[5, 2] = "Ngày sinh:" + txtNgaySinh.Text;
            worksheet.Cells[6, 2] = "Giới tính:" + txtGioiTinh.Text;
            worksheet.Cells[7, 2] = "Nơi sinh:" + txtNoiSinh.Text;
            worksheet.Cells[8, 2] = "Dân tộc:" + txtDanToc.Text;
            worksheet.Cells[9, 1] = "STT";
            worksheet.Cells[9, 2] = "Mã môn";
            worksheet.Cells[9, 3] = "Tên môn";
            worksheet.Cells[9, 4] = "Số tín chỉ";
            worksheet.Cells[9, 5] = "Điểm HP";
            worksheet.Cells[9, 6] = "Điểm chữ";
            worksheet.Cells[9, 7] = "Điểm số";

            // Khúc này SAO NHI LOI J
            for (int i = 0; i < DGVBangDiemSV.RowCount-1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 10, 1] = i + 1;
                    worksheet.Cells[i + 10, j + 2] = DGVBangDiemSV.Rows[i].Cells[j].Value;
                }
            }
            int mon = DGVBangDiemSV.RowCount;
            worksheet.Cells[mon + 10, 1] = "Trung bình toàn khóa:" + txtTBtoankhoa.Text;
            worksheet.Cells[mon + 11, 1] = "Xếp loại toàn khóa:" + txtXLtoankhoa.Text;
            // Định dạng trang:
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            //Định dạng cột:
            worksheet.Range["A1"].ColumnWidth = 8.43;
            worksheet.Range["B1"].ColumnWidth = 9.54;
            worksheet.Range["C1"].ColumnWidth = 26.14;
            worksheet.Range["D1"].ColumnWidth = 9.86;
            worksheet.Range["E1"].ColumnWidth = 9.43;
            worksheet.Range["F1"].ColumnWidth = 10.57;
            worksheet.Range["G1"].ColumnWidth = 9.86;
            //Định dạng font chữ:
            worksheet.Range["A1", "G100"].Font.Name = "Time New Roman";
            worksheet.Range["A1", "G100"].Font.Size = 12;
            worksheet.Range["A1", "G1"].MergeCells = true;
            worksheet.Range["A1", "G1"].Font.Bold = true;
            worksheet.Range["A9", "G9"].Font.Bold = true;
            // Kẻ bảng điểm:
            worksheet.Range["A9", "G" + (mon + 8)].Borders.LineStyle = 1;
            // Định dạng các dòng Text:
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A9", "G9"].HorizontalAlignment = 3;
            worksheet.Range["A10", "A" + (mon + 8)].HorizontalAlignment = 3;
            worksheet.Range["D10", "D" + (mon + 8)].HorizontalAlignment = 3;
            worksheet.Range["E10", "E" + (mon + 8)].HorizontalAlignment = 3;
            worksheet.Range["F10", "F" + (mon + 8)].HorizontalAlignment = 3;
            worksheet.Range["G10", "G" + (mon + 8)].HorizontalAlignment = 3;

        }


    }
}
