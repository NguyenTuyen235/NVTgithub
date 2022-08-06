namespace QLDiem.GiaoDien
{
    partial class frmMonDiemHP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonDiemHP));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.DGVDiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTenHocKy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThemMoiHK = new DevComponents.DotNetBar.ButtonX();
            this.txtMaHocKy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnQuayLai = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuLaiHK = new DevComponents.DotNetBar.ButtonX();
            this.cboHocKy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnSuaHocKy = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaHK = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtSoTC = new System.Windows.Forms.NumericUpDown();
            this.btnCapNhatDuLieu = new DevComponents.DotNetBar.ButtonX();
            this.btnThemMoiHP = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaHP = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuLaiHP = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaTenMon = new DevComponents.DotNetBar.ButtonX();
            this.btnQuayLaiMonHP = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtTenMon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtMaMon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboMonHocPhan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiem)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.ribbonClientPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.DGVDiem);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(982, 543);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // DGVDiem
            // 
            this.DGVDiem.AllowUserToAddRows = false;
            this.DGVDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGVDiem.Location = new System.Drawing.Point(188, 293);
            this.DGVDiem.Name = "DGVDiem";
            this.DGVDiem.Size = new System.Drawing.Size(541, 247);
            this.DGVDiem.TabIndex = 1;
            this.DGVDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDiem_CellEndEdit);
            this.DGVDiem.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGVDiem_DataError);
            // 
            // groupPanel1
            // 
            this.groupPanel1.AutoSize = true;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.ribbonClientPanel1);
            this.groupPanel1.Controls.Add(this.panelEx2);
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(979, 284);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "CẬP NHẬT HỌC KỲ,MÔN THI HỌC PHẦN,ĐIỂM HỌC PHẦN";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.labelX5);
            this.ribbonClientPanel1.Controls.Add(this.txtTenHocKy);
            this.ribbonClientPanel1.Controls.Add(this.btnThemMoiHK);
            this.ribbonClientPanel1.Controls.Add(this.txtMaHocKy);
            this.ribbonClientPanel1.Controls.Add(this.labelX4);
            this.ribbonClientPanel1.Controls.Add(this.labelX3);
            this.ribbonClientPanel1.Controls.Add(this.cboLop);
            this.ribbonClientPanel1.Controls.Add(this.btnQuayLai);
            this.ribbonClientPanel1.Controls.Add(this.btnLuuLaiHK);
            this.ribbonClientPanel1.Controls.Add(this.cboHocKy);
            this.ribbonClientPanel1.Controls.Add(this.labelX1);
            this.ribbonClientPanel1.Controls.Add(this.btnSuaHocKy);
            this.ribbonClientPanel1.Controls.Add(this.btnXoaHK);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(3, 11);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(483, 252);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.TabIndex = 28;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(68, 203);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Tên học kỳ:";
            // 
            // txtTenHocKy
            // 
            // 
            // 
            // 
            this.txtTenHocKy.Border.Class = "TextBoxBorder";
            this.txtTenHocKy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenHocKy.Location = new System.Drawing.Point(161, 203);
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(160, 22);
            this.txtTenHocKy.TabIndex = 6;
            // 
            // btnThemMoiHK
            // 
            this.btnThemMoiHK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMoiHK.AutoSize = true;
            this.btnThemMoiHK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMoiHK.Image = global::QLDiem.Properties.Resources.Add2;
            this.btnThemMoiHK.Location = new System.Drawing.Point(0, 4);
            this.btnThemMoiHK.Name = "btnThemMoiHK";
            this.btnThemMoiHK.Size = new System.Drawing.Size(84, 38);
            this.btnThemMoiHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemMoiHK.TabIndex = 2;
            this.btnThemMoiHK.Text = "Thêm";
            this.btnThemMoiHK.Click += new System.EventHandler(this.btnThemMoiHK_Click);
            // 
            // txtMaHocKy
            // 
            // 
            // 
            // 
            this.txtMaHocKy.Border.Class = "TextBoxBorder";
            this.txtMaHocKy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHocKy.Location = new System.Drawing.Point(161, 162);
            this.txtMaHocKy.Name = "txtMaHocKy";
            this.txtMaHocKy.Size = new System.Drawing.Size(160, 22);
            this.txtMaHocKy.TabIndex = 5;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(68, 160);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Mã học kỳ:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(65, 117);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(63, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Học kỳ:";
            // 
            // cboLop
            // 
            this.cboLop.DisplayMember = "Text";
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.ItemHeight = 16;
            this.cboLop.Location = new System.Drawing.Point(161, 75);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(160, 22);
            this.cboLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLop.TabIndex = 0;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuayLai.AutoSize = true;
            this.btnQuayLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuayLai.Image = global::QLDiem.Properties.Resources.back;
            this.btnQuayLai.Location = new System.Drawing.Point(326, 4);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(89, 38);
            this.btnQuayLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuayLai.TabIndex = 21;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnLuuLaiHK
            // 
            this.btnLuuLaiHK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuLaiHK.AutoSize = true;
            this.btnLuuLaiHK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuLaiHK.Image = global::QLDiem.Properties.Resources.Luusavepng;
            this.btnLuuLaiHK.Location = new System.Drawing.Point(90, 4);
            this.btnLuuLaiHK.Name = "btnLuuLaiHK";
            this.btnLuuLaiHK.Size = new System.Drawing.Size(84, 38);
            this.btnLuuLaiHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuLaiHK.TabIndex = 18;
            this.btnLuuLaiHK.Text = "LưuLại";
            this.btnLuuLaiHK.Click += new System.EventHandler(this.btnLuuLaiHK_Click);
            // 
            // cboHocKy
            // 
            this.cboHocKy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboHocKy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboHocKy.DisplayMember = "Text";
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.ItemHeight = 16;
            this.cboHocKy.Location = new System.Drawing.Point(161, 118);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(160, 22);
            this.cboHocKy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboHocKy.TabIndex = 4;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(71, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Lớp:";
            // 
            // btnSuaHocKy
            // 
            this.btnSuaHocKy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaHocKy.AutoSize = true;
            this.btnSuaHocKy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaHocKy.Image = global::QLDiem.Properties.Resources.Icon_WriteArticles;
            this.btnSuaHocKy.Location = new System.Drawing.Point(179, 4);
            this.btnSuaHocKy.Name = "btnSuaHocKy";
            this.btnSuaHocKy.Size = new System.Drawing.Size(66, 38);
            this.btnSuaHocKy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaHocKy.TabIndex = 20;
            this.btnSuaHocKy.Text = "Sửa";
            this.btnSuaHocKy.Click += new System.EventHandler(this.btnSuaHocKy_Click);
            // 
            // btnXoaHK
            // 
            this.btnXoaHK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaHK.AutoSize = true;
            this.btnXoaHK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaHK.Image = global::QLDiem.Properties.Resources.thung_rac;
            this.btnXoaHK.Location = new System.Drawing.Point(251, 4);
            this.btnXoaHK.Name = "btnXoaHK";
            this.btnXoaHK.Size = new System.Drawing.Size(69, 38);
            this.btnXoaHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaHK.TabIndex = 19;
            this.btnXoaHK.Text = "Xóa";
            this.btnXoaHK.Click += new System.EventHandler(this.btnXoaHK_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txtSoTC);
            this.panelEx2.Controls.Add(this.btnCapNhatDuLieu);
            this.panelEx2.Controls.Add(this.btnThemMoiHP);
            this.panelEx2.Controls.Add(this.btnXoaHP);
            this.panelEx2.Controls.Add(this.btnLuuLaiHP);
            this.panelEx2.Controls.Add(this.btnSuaTenMon);
            this.panelEx2.Controls.Add(this.btnQuayLaiMonHP);
            this.panelEx2.Controls.Add(this.labelX7);
            this.panelEx2.Controls.Add(this.labelX8);
            this.panelEx2.Controls.Add(this.txtTenMon);
            this.panelEx2.Controls.Add(this.labelX6);
            this.panelEx2.Controls.Add(this.txtMaMon);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.cboMonHocPhan);
            this.panelEx2.Location = new System.Drawing.Point(484, 11);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(491, 252);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 27;
            this.panelEx2.Click += new System.EventHandler(this.panelEx2_Click);
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(186, 177);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(161, 22);
            this.txtSoTC.TabIndex = 3;
            // 
            // btnCapNhatDuLieu
            // 
            this.btnCapNhatDuLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhatDuLieu.AutoSize = true;
            this.btnCapNhatDuLieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhatDuLieu.Image = global::QLDiem.Properties.Resources.tichphong_svg_med;
            this.btnCapNhatDuLieu.Location = new System.Drawing.Point(6, 206);
            this.btnCapNhatDuLieu.Name = "btnCapNhatDuLieu";
            this.btnCapNhatDuLieu.Size = new System.Drawing.Size(135, 37);
            this.btnCapNhatDuLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCapNhatDuLieu.TabIndex = 14;
            this.btnCapNhatDuLieu.Text = "Cập nhật dữ liệu";
            this.btnCapNhatDuLieu.Click += new System.EventHandler(this.btnCapNhatDuLieu_Click);
            // 
            // btnThemMoiHP
            // 
            this.btnThemMoiHP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMoiHP.AutoSize = true;
            this.btnThemMoiHP.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMoiHP.Image = global::QLDiem.Properties.Resources.Add2;
            this.btnThemMoiHP.Location = new System.Drawing.Point(6, 3);
            this.btnThemMoiHP.Name = "btnThemMoiHP";
            this.btnThemMoiHP.Size = new System.Drawing.Size(84, 39);
            this.btnThemMoiHP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemMoiHP.TabIndex = 20;
            this.btnThemMoiHP.Text = "Thêm";
            this.btnThemMoiHP.Click += new System.EventHandler(this.btnThemMoiHP_Click);
            // 
            // btnXoaHP
            // 
            this.btnXoaHP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaHP.AutoSize = true;
            this.btnXoaHP.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaHP.Image = global::QLDiem.Properties.Resources.thung_rac;
            this.btnXoaHP.Location = new System.Drawing.Point(261, 4);
            this.btnXoaHP.Name = "btnXoaHP";
            this.btnXoaHP.Size = new System.Drawing.Size(64, 38);
            this.btnXoaHP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaHP.TabIndex = 22;
            this.btnXoaHP.Text = "Xóa";
            this.btnXoaHP.Click += new System.EventHandler(this.btnXoaHP_Click);
            // 
            // btnLuuLaiHP
            // 
            this.btnLuuLaiHP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuLaiHP.AutoSize = true;
            this.btnLuuLaiHP.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuLaiHP.Image = global::QLDiem.Properties.Resources.Luusavepng;
            this.btnLuuLaiHP.Location = new System.Drawing.Point(96, 3);
            this.btnLuuLaiHP.Name = "btnLuuLaiHP";
            this.btnLuuLaiHP.Size = new System.Drawing.Size(84, 38);
            this.btnLuuLaiHP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuLaiHP.TabIndex = 21;
            this.btnLuuLaiHP.Text = "LưuLại";
            this.btnLuuLaiHP.Click += new System.EventHandler(this.btnLuuLaiHP_Click);
            // 
            // btnSuaTenMon
            // 
            this.btnSuaTenMon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaTenMon.AutoSize = true;
            this.btnSuaTenMon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaTenMon.Image = global::QLDiem.Properties.Resources.Icon_WriteArticles;
            this.btnSuaTenMon.Location = new System.Drawing.Point(186, 4);
            this.btnSuaTenMon.Name = "btnSuaTenMon";
            this.btnSuaTenMon.Size = new System.Drawing.Size(69, 38);
            this.btnSuaTenMon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaTenMon.TabIndex = 23;
            this.btnSuaTenMon.Text = "Sửa";
            this.btnSuaTenMon.Click += new System.EventHandler(this.btnSuaTenMon_Click);
            // 
            // btnQuayLaiMonHP
            // 
            this.btnQuayLaiMonHP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuayLaiMonHP.AutoSize = true;
            this.btnQuayLaiMonHP.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuayLaiMonHP.Image = global::QLDiem.Properties.Resources.back;
            this.btnQuayLaiMonHP.Location = new System.Drawing.Point(331, 4);
            this.btnQuayLaiMonHP.Name = "btnQuayLaiMonHP";
            this.btnQuayLaiMonHP.Size = new System.Drawing.Size(94, 38);
            this.btnQuayLaiMonHP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuayLaiMonHP.TabIndex = 24;
            this.btnQuayLaiMonHP.Text = "Quay Lại";
            this.btnQuayLaiMonHP.Click += new System.EventHandler(this.btnQuayLaiMonHP_Click);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(65, 175);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(48, 23);
            this.labelX7.TabIndex = 16;
            this.labelX7.Text = "Số TC:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(65, 133);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(59, 23);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "Tên môn:";
            // 
            // txtTenMon
            // 
            // 
            // 
            // 
            this.txtTenMon.Border.Class = "TextBoxBorder";
            this.txtTenMon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenMon.Location = new System.Drawing.Point(188, 135);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(159, 22);
            this.txtTenMon.TabIndex = 1;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(65, 88);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(64, 23);
            this.labelX6.TabIndex = 15;
            this.labelX6.Text = "Mã môn:";
            // 
            // txtMaMon
            // 
            // 
            // 
            // 
            this.txtMaMon.Border.Class = "TextBoxBorder";
            this.txtMaMon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaMon.Location = new System.Drawing.Point(188, 90);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(159, 22);
            this.txtMaMon.TabIndex = 0;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(62, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(97, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Môn học phần:";
            // 
            // cboMonHocPhan
            // 
            this.cboMonHocPhan.DisplayMember = "Text";
            this.cboMonHocPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonHocPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHocPhan.FormattingEnabled = true;
            this.cboMonHocPhan.ItemHeight = 16;
            this.cboMonHocPhan.Location = new System.Drawing.Point(188, 48);
            this.cboMonHocPhan.Name = "cboMonHocPhan";
            this.cboMonHocPhan.Size = new System.Drawing.Size(159, 22);
            this.cboMonHocPhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMonHocPhan.TabIndex = 13;
            this.cboMonHocPhan.SelectedIndexChanged += new System.EventHandler(this.cboMonHocPhan_SelectedIndexChanged);
            // 
            // frmMonDiemHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 543);
            this.Controls.Add(this.panelEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMonDiemHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách điểm thi của sinh viên";
            this.Load += new System.EventHandler(this.frmMonDiemHP_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiem)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboHocKy;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHocKy;
        private DevComponents.DotNetBar.ButtonX btnThemMoiHK;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLop;
        private DevComponents.DotNetBar.ButtonX btnXoaHP;
        private DevComponents.DotNetBar.ButtonX btnLuuLaiHP;
        private DevComponents.DotNetBar.ButtonX btnThemMoiHP;
        private DevComponents.DotNetBar.ButtonX btnXoaHK;
        private DevComponents.DotNetBar.ButtonX btnLuuLaiHK;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnCapNhatDuLieu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMonHocPhan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaMon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenMon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHocKy;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGVDiem;
        private DevComponents.DotNetBar.ButtonX btnSuaHocKy;
        private DevComponents.DotNetBar.ButtonX btnSuaTenMon;
        private DevComponents.DotNetBar.ButtonX btnQuayLai;
        private DevComponents.DotNetBar.ButtonX btnQuayLaiMonHP;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private System.Windows.Forms.NumericUpDown txtSoTC;
    }
}