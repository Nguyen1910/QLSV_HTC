
namespace QLSV_HTC.View
{
    partial class frmHocPhi
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.Windows.Forms.Label nIENKHOALabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            this.DSHP = new QLSV_HTC.DSHP();
            this.tableAdapterManager = new QLSV_HTC.DSHPTableAdapters.TableAdapterManager();
            this.gbTTSV = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.SINHVIENTableAdapter = new QLSV_HTC.DSHPTableAdapters.SINHVIENTableAdapter();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.HOCPHITableAdapter = new QLSV_HTC.DSHPTableAdapters.HOCPHITableAdapter();
            this.gcHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gvHocPhi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbTTHP = new System.Windows.Forms.GroupBox();
            this.cbbNienKhoa = new System.Windows.Forms.ComboBox();
            this.txtHocPhi = new DevExpress.XtraEditors.TextEdit();
            this.cbbHocKy = new System.Windows.Forms.ComboBox();
            this.bdsCTHP = new System.Windows.Forms.BindingSource(this.components);
            this.CT_DONGHOCPHITableAdapter = new QLSV_HTC.DSHPTableAdapters.CT_DONGHOCPHITableAdapter();
            this.gcCTHP = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemCHTP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuyCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLamMoiCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.gvCTHP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienDaDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienCanDong = new DevExpress.XtraGrid.Columns.GridColumn();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            nIENKHOALabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSHP)).BeginInit();
            this.gbTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).BeginInit();
            this.gbTTHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHP)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(32, 30);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(66, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Mã sinh viên";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(277, 30);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(575, 30);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(28, 13);
            mALOPLabel.TabIndex = 5;
            mALOPLabel.Text = "Lớp:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(26, 93);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(45, 13);
            hOCKYLabel.TabIndex = 2;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Location = new System.Drawing.Point(26, 136);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(50, 13);
            hOCPHILabel.TabIndex = 4;
            hOCPHILabel.Text = "HOCPHI:";
            // 
            // nIENKHOALabel1
            // 
            nIENKHOALabel1.AutoSize = true;
            nIENKHOALabel1.Location = new System.Drawing.Point(26, 54);
            nIENKHOALabel1.Name = "nIENKHOALabel1";
            nIENKHOALabel1.Size = new System.Drawing.Size(63, 13);
            nIENKHOALabel1.TabIndex = 6;
            nIENKHOALabel1.Text = "NIENKHOA:";
            // 
            // DSHP
            // 
            this.DSHP.DataSetName = "DSHP";
            this.DSHP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLSV_HTC.DSHPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gbTTSV
            // 
            this.gbTTSV.Controls.Add(this.txtMaSV);
            this.gbTTSV.Controls.Add(this.txtMaLop);
            this.gbTTSV.Controls.Add(mALOPLabel);
            this.gbTTSV.Controls.Add(this.txtTen);
            this.gbTTSV.Controls.Add(hOLabel);
            this.gbTTSV.Controls.Add(this.txtHo);
            this.gbTTSV.Controls.Add(mASVLabel);
            this.gbTTSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTTSV.Location = new System.Drawing.Point(0, 24);
            this.gbTTSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTTSV.Name = "gbTTSV";
            this.gbTTSV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTTSV.Size = new System.Drawing.Size(819, 72);
            this.gbTTSV.TabIndex = 14;
            this.gbTTSV.TabStop = false;
            this.gbTTSV.Text = "Thông tin sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(121, 28);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(119, 21);
            this.txtMaSV.TabIndex = 8;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(621, 28);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(104, 21);
            this.txtMaLop.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(428, 28);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(86, 21);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(309, 28);
            this.txtHo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(104, 21);
            this.txtHo.TabIndex = 3;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.DSHP;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.DataMember = "FK_HOCPHI_SINHVIEN";
            this.bdsHocPhi.DataSource = this.bdsSV;
            // 
            // HOCPHITableAdapter
            // 
            this.HOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // gcHocPhi
            // 
            this.gcHocPhi.DataSource = this.bdsHocPhi;
            this.gcHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHocPhi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcHocPhi.Location = new System.Drawing.Point(0, 96);
            this.gcHocPhi.MainView = this.gvHocPhi;
            this.gcHocPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(819, 179);
            this.gcHocPhi.TabIndex = 29;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocPhi});
            // 
            // gvHocPhi
            // 
            this.gvHocPhi.CustomizationFormBounds = new System.Drawing.Rectangle(677, 502, 252, 266);
            this.gvHocPhi.DetailHeight = 284;
            this.gvHocPhi.GridControl = this.gcHocPhi;
            this.gvHocPhi.Name = "gvHocPhi";
            this.gvHocPhi.OptionsBehavior.ReadOnly = true;
            // 
            // gbTTHP
            // 
            this.gbTTHP.Controls.Add(nIENKHOALabel1);
            this.gbTTHP.Controls.Add(this.cbbNienKhoa);
            this.gbTTHP.Controls.Add(hOCPHILabel);
            this.gbTTHP.Controls.Add(this.txtHocPhi);
            this.gbTTHP.Controls.Add(hOCKYLabel);
            this.gbTTHP.Controls.Add(this.cbbHocKy);
            this.gbTTHP.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTTHP.Location = new System.Drawing.Point(0, 275);
            this.gbTTHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTTHP.Name = "gbTTHP";
            this.gbTTHP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTTHP.Size = new System.Drawing.Size(328, 313);
            this.gbTTHP.TabIndex = 30;
            this.gbTTHP.TabStop = false;
            this.gbTTHP.Text = "Thông tin đóng học phí";
            // 
            // cbbNienKhoa
            // 
            this.cbbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHocPhi, "NIENKHOA", true));
            this.cbbNienKhoa.FormattingEnabled = true;
            this.cbbNienKhoa.Items.AddRange(new object[] {
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.cbbNienKhoa.Location = new System.Drawing.Point(98, 51);
            this.cbbNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNienKhoa.Name = "cbbNienKhoa";
            this.cbbNienKhoa.Size = new System.Drawing.Size(185, 21);
            this.cbbNienKhoa.TabIndex = 7;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "HOCPHI", true));
            this.txtHocPhi.Location = new System.Drawing.Point(98, 133);
            this.txtHocPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Properties.DisplayFormat.FormatString = "n0";
            this.txtHocPhi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHocPhi.Properties.EditFormat.FormatString = "n0";
            this.txtHocPhi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHocPhi.Size = new System.Drawing.Size(184, 20);
            this.txtHocPhi.TabIndex = 5;
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHocPhi, "HOCKY", true));
            this.cbbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbHocKy.Location = new System.Drawing.Point(97, 90);
            this.cbbHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(63, 21);
            this.cbbHocKy.TabIndex = 3;
            // 
            // bdsCTHP
            // 
            this.bdsCTHP.DataMember = "FK_CT_DONGHOCPHI_HOCPHI";
            this.bdsCTHP.DataSource = this.bdsHocPhi;
            // 
            // CT_DONGHOCPHITableAdapter
            // 
            this.CT_DONGHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // gcCTHP
            // 
            this.gcCTHP.ContextMenuStrip = this.contextMenuStrip1;
            this.gcCTHP.DataSource = this.bdsCTHP;
            this.gcCTHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTHP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCTHP.Location = new System.Drawing.Point(328, 275);
            this.gcCTHP.MainView = this.gvCTHP;
            this.gcCTHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCTHP.Name = "gcCTHP";
            this.gcCTHP.Size = new System.Drawing.Size(491, 313);
            this.gcCTHP.TabIndex = 30;
            this.gcCTHP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTHP});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCHTP,
            this.btnXoaCTHP,
            this.btnSuaCTHP,
            this.btnGhiCTHP,
            this.btnHuyCTHP,
            this.btnPhucHoiCTHP,
            this.btnLamMoiCTHP});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 186);
            // 
            // btnThemCHTP
            // 
            this.btnThemCHTP.Image = global::QLSV_HTC.Properties.Resources.plus;
            this.btnThemCHTP.Name = "btnThemCHTP";
            this.btnThemCHTP.Size = new System.Drawing.Size(125, 26);
            this.btnThemCHTP.Text = "Thêm";
            this.btnThemCHTP.Click += new System.EventHandler(this.btnThemCHTP_Click);
            // 
            // btnXoaCTHP
            // 
            this.btnXoaCTHP.Image = global::QLSV_HTC.Properties.Resources.erase;
            this.btnXoaCTHP.Name = "btnXoaCTHP";
            this.btnXoaCTHP.Size = new System.Drawing.Size(125, 26);
            this.btnXoaCTHP.Text = "Xóa";
            this.btnXoaCTHP.Click += new System.EventHandler(this.btnXoaCTHP_Click);
            // 
            // btnSuaCTHP
            // 
            this.btnSuaCTHP.Image = global::QLSV_HTC.Properties.Resources.repair;
            this.btnSuaCTHP.Name = "btnSuaCTHP";
            this.btnSuaCTHP.Size = new System.Drawing.Size(125, 26);
            this.btnSuaCTHP.Text = "Sửa";
            this.btnSuaCTHP.Click += new System.EventHandler(this.btnSuaCTHP_Click);
            // 
            // btnGhiCTHP
            // 
            this.btnGhiCTHP.Image = global::QLSV_HTC.Properties.Resources.save_all;
            this.btnGhiCTHP.Name = "btnGhiCTHP";
            this.btnGhiCTHP.Size = new System.Drawing.Size(125, 26);
            this.btnGhiCTHP.Text = "Ghi";
            this.btnGhiCTHP.Click += new System.EventHandler(this.btnGhiCTHP_Click);
            // 
            // btnHuyCTHP
            // 
            this.btnHuyCTHP.Image = global::QLSV_HTC.Properties.Resources.stock_not;
            this.btnHuyCTHP.Name = "btnHuyCTHP";
            this.btnHuyCTHP.Size = new System.Drawing.Size(125, 26);
            this.btnHuyCTHP.Text = "Hủy";
            this.btnHuyCTHP.Click += new System.EventHandler(this.btnHuyCTHP_Click);
            // 
            // btnPhucHoiCTHP
            // 
            this.btnPhucHoiCTHP.Image = global::QLSV_HTC.Properties.Resources.undo;
            this.btnPhucHoiCTHP.Name = "btnPhucHoiCTHP";
            this.btnPhucHoiCTHP.Size = new System.Drawing.Size(125, 26);
            this.btnPhucHoiCTHP.Text = "Phục hồi";
            this.btnPhucHoiCTHP.Click += new System.EventHandler(this.btnPhucHoiCTHP_Click);
            // 
            // btnLamMoiCTHP
            // 
            this.btnLamMoiCTHP.Image = global::QLSV_HTC.Properties.Resources.gnome_view_refresh;
            this.btnLamMoiCTHP.Name = "btnLamMoiCTHP";
            this.btnLamMoiCTHP.Size = new System.Drawing.Size(125, 26);
            this.btnLamMoiCTHP.Text = "Làm mới";
            this.btnLamMoiCTHP.Click += new System.EventHandler(this.btnLamMoiCTHP_Click);
            // 
            // gvCTHP
            // 
            this.gvCTHP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gvCTHP.DetailHeight = 284;
            this.gvCTHP.GridControl = this.gcCTHP;
            this.gvCTHP.Name = "gvCTHP";
            this.gvCTHP.OptionsView.ShowFooter = true;
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.DisplayFormat.FormatString = "d";
            this.colNGAYDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 21;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 81;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.DisplayFormat.FormatString = "n0";
            this.colSOTIENDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 21;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SOTIENDONG", "Tổng : {0:n0}")});
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 81;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnPhucHoi,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick_1);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(819, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(819, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 564);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(819, 24);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(0, 564);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(819, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 564);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 21;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Width = 81;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 21;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Width = 81;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.DisplayFormat.FormatString = "n0";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 21;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Width = 81;
            // 
            // colSoTienDaDong
            // 
            this.colSoTienDaDong.Caption = "SOTIENDADONG";
            this.colSoTienDaDong.DisplayFormat.FormatString = "n0";
            this.colSoTienDaDong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTienDaDong.MinWidth = 21;
            this.colSoTienDaDong.Name = "colSoTienDaDong";
            this.colSoTienDaDong.OptionsColumn.ReadOnly = true;
            this.colSoTienDaDong.Width = 81;
            // 
            // colSoTienCanDong
            // 
            this.colSoTienCanDong.Caption = "SOTIENCANDONG";
            this.colSoTienCanDong.DisplayFormat.FormatString = "n0";
            this.colSoTienCanDong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTienCanDong.MinWidth = 21;
            this.colSoTienCanDong.Name = "colSoTienCanDong";
            this.colSoTienCanDong.OptionsColumn.ReadOnly = true;
            this.colSoTienCanDong.Width = 81;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 608);
            this.Controls.Add(this.gcCTHP);
            this.Controls.Add(this.gbTTHP);
            this.Controls.Add(this.gcHocPhi);
            this.Controls.Add(this.gbTTSV);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHocPhi";
            this.Text = "frmHocPhi";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSHP)).EndInit();
            this.gbTTSV.ResumeLayout(false);
            this.gbTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).EndInit();
            this.gbTTHP.ResumeLayout(false);
            this.gbTTHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHP)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DSHP DSHP;
        private DSHPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbTTSV;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSHPTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsHocPhi;
        private DSHPTableAdapters.HOCPHITableAdapter HOCPHITableAdapter;
        private DevExpress.XtraGrid.GridControl gcHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocPhi;
        private System.Windows.Forms.GroupBox gbTTHP;
        private System.Windows.Forms.BindingSource bdsCTHP;
        private DSHPTableAdapters.CT_DONGHOCPHITableAdapter CT_DONGHOCPHITableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTHP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTHP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private DevExpress.XtraEditors.TextEdit txtHocPhi;
        private System.Windows.Forms.ComboBox cbbHocKy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemCHTP;
        private System.Windows.Forms.ToolStripMenuItem btnXoaCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnSuaCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnGhiCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnHuyCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnLamMoiCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiCTHP;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ComboBox cbbNienKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienDaDong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienCanDong;
    }
}