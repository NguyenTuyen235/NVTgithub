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
    public partial class frmReportSinhVienLop : Form
    {
        public frmReportSinhVienLop()
        {
            InitializeComponent();
        }

        DataAccess.QLdiemDataContext dt = new DataAccess.QLdiemDataContext();
        private void frmReportSinhVienLop_Load(object sender, EventArgs e)
        {
            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "maLop";
            cboLop.DataSource = dt.Lops_SelectAll();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetSinhVienLop.SinhVien_SelectMaLop' table. You can move, or remove it, as needed.
            this.SinhVien_SelectMaLopTableAdapter.Fill(this.DataSetSinhVienLop.SinhVien_SelectMaLop,cboLop.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
