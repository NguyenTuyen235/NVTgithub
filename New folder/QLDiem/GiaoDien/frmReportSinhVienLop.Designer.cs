namespace QLDiem.GiaoDien
{
    partial class frmReportSinhVienLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportSinhVienLop));
            this.SinhVien_SelectMaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetSinhVienLop = new QLDiem.GiaoDien.DataSetSinhVienLop();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cboLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SinhVien_SelectMaLopTableAdapter = new QLDiem.GiaoDien.DataSetSinhVienLopTableAdapters.SinhVien_SelectMaLopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVien_SelectMaLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSinhVienLop)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SinhVien_SelectMaLopBindingSource
            // 
            this.SinhVien_SelectMaLopBindingSource.DataMember = "SinhVien_SelectMaLop";
            this.SinhVien_SelectMaLopBindingSource.DataSource = this.DataSetSinhVienLop;
            // 
            // DataSetSinhVienLop
            // 
            this.DataSetSinhVienLop.DataSetName = "DataSetSinhVienLop";
            this.DataSetSinhVienLop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cboLop);
            this.panelEx1.Controls.Add(this.reportViewer1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(857, 514);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // cboLop
            // 
            this.cboLop.DisplayMember = "Text";
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.ItemHeight = 15;
            this.cboLop.Location = new System.Drawing.Point(3, 22);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(216, 21);
            this.cboLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SinhVien_SelectMaLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLDiem.GiaoDien.ReportSinhVienLop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(851, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // SinhVien_SelectMaLopTableAdapter
            // 
            this.SinhVien_SelectMaLopTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportSinhVienLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 514);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(873, 553);
            this.MinimumSize = new System.Drawing.Size(873, 553);
            this.Name = "frmReportSinhVienLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo danh sách sinh viên theo lớp";
            this.Load += new System.EventHandler(this.frmReportSinhVienLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVien_SelectMaLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSinhVienLop)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLop;
        private System.Windows.Forms.BindingSource SinhVien_SelectMaLopBindingSource;
        private DataSetSinhVienLop DataSetSinhVienLop;
        private DataSetSinhVienLopTableAdapters.SinhVien_SelectMaLopTableAdapter SinhVien_SelectMaLopTableAdapter;
    }
}