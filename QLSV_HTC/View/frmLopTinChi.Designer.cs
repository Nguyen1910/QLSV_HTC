
namespace QLSV_HTC
{
    partial class frmLopTinChi
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
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label hUYLOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopTinChi));
            this.barManagerTool = new DevExpress.XtraBars.BarManager(this.components);
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
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLSV_HTC.DS();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.LTCTableAdapter = new QLSV_HTC.DSTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLSV_HTC.DSTableAdapters.TableAdapterManager();
            this.DKTableAdapter = new QLSV_HTC.DSTableAdapters.DANGKYTableAdapter();
            this.LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlLTC = new DevExpress.XtraEditors.PanelControl();
            this.huyLop_checkBox = new System.Windows.Forms.CheckBox();
            this.soSVMin_spinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.hocKy_spinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.nhom_spinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bdsDK = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            nHOMLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLTC)).BeginInit();
            this.pnlLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soSVMin_spinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocKy_spinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom_spinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).BeginInit();
            this.SuspendLayout();
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(446, 35);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(34, 13);
            nHOMLabel.TabIndex = 4;
            nHOMLabel.Text = "Nhóm";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(245, 31);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(39, 13);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "Mã MH";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(245, 70);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(55, 13);
            nIENKHOALabel.TabIndex = 6;
            nIENKHOALabel.Text = "Niên Khoá";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(446, 70);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(40, 13);
            hOCKYLabel.TabIndex = 8;
            hOCKYLabel.Text = "Học Kỳ";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(32, 31);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(37, 13);
            mAGVLabel.TabIndex = 10;
            mAGVLabel.Text = "Mã GV";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(446, 112);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(48, 13);
            mAKHOALabel.TabIndex = 12;
            mAKHOALabel.Text = "Mã Khoa";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(30, 74);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(80, 13);
            sOSVTOITHIEULabel.TabIndex = 14;
            sOSVTOITHIEULabel.Text = "Số SV Tối Thiểu";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(32, 112);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(46, 13);
            hUYLOPLabel.TabIndex = 16;
            hUYLOPLabel.Text = "Huỷ Lớp";
            // 
            // barManagerTool
            // 
            this.barManagerTool.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManagerTool.DockControls.Add(this.barDockControlTop);
            this.barManagerTool.DockControls.Add(this.barDockControlBottom);
            this.barManagerTool.DockControls.Add(this.barDockControlLeft);
            this.barManagerTool.DockControls.Add(this.barDockControlRight);
            this.barManagerTool.Form = this;
            this.barManagerTool.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnPhucHoi,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi});
            this.barManagerTool.MaxItemId = 7;
            this.barManagerTool.StatusBar = this.bar3;
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
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
            this.btnPhucHoi.Enabled = false;
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
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
            this.barDockControlTop.Manager = this.barManagerTool;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(667, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 456);
            this.barDockControlBottom.Manager = this.barManagerTool;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(667, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerTool;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(667, 24);
            this.barDockControlRight.Manager = this.barManagerTool;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(667, 64);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(105, 20);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(251, 21);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "LOPTINCHI";
            this.bdsLTC.DataSource = this.DS;
            // 
            // LTCTableAdapter
            // 
            this.LTCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = this.DKTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.LTCTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DKTableAdapter
            // 
            this.DKTableAdapter.ClearBeforeFill = true;
            // 
            // LTCGridControl
            // 
            this.LTCGridControl.DataSource = this.bdsLTC;
            this.LTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTCGridControl.Location = new System.Drawing.Point(0, 88);
            this.LTCGridControl.MainView = this.gridView1;
            this.LTCGridControl.MenuManager = this.barManagerTool;
            this.LTCGridControl.Name = "LTCGridControl";
            this.LTCGridControl.Size = new System.Drawing.Size(667, 176);
            this.LTCGridControl.TabIndex = 6;
            this.LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.GridControl = this.LTCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 4;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 5;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 6;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 7;
            // 
            // pnlLTC
            // 
            this.pnlLTC.Controls.Add(this.cmbMaMH);
            this.pnlLTC.Controls.Add(this.cmbMaGV);
            this.pnlLTC.Controls.Add(this.huyLop_checkBox);
            this.pnlLTC.Controls.Add(hUYLOPLabel);
            this.pnlLTC.Controls.Add(sOSVTOITHIEULabel);
            this.pnlLTC.Controls.Add(this.soSVMin_spinEdit);
            this.pnlLTC.Controls.Add(mAKHOALabel);
            this.pnlLTC.Controls.Add(this.txtMaKhoa);
            this.pnlLTC.Controls.Add(mAGVLabel);
            this.pnlLTC.Controls.Add(hOCKYLabel);
            this.pnlLTC.Controls.Add(this.hocKy_spinEdit);
            this.pnlLTC.Controls.Add(nIENKHOALabel);
            this.pnlLTC.Controls.Add(this.txtNienKhoa);
            this.pnlLTC.Controls.Add(mAMHLabel);
            this.pnlLTC.Controls.Add(nHOMLabel);
            this.pnlLTC.Controls.Add(this.nhom_spinEdit);
            this.pnlLTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLTC.Enabled = false;
            this.pnlLTC.Location = new System.Drawing.Point(0, 264);
            this.pnlLTC.Name = "pnlLTC";
            this.pnlLTC.Size = new System.Drawing.Size(667, 192);
            this.pnlLTC.TabIndex = 7;
            // 
            // huyLop_checkBox
            // 
            this.huyLop_checkBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsLTC, "HUYLOP", true));
            this.huyLop_checkBox.Location = new System.Drawing.Point(84, 109);
            this.huyLop_checkBox.Name = "huyLop_checkBox";
            this.huyLop_checkBox.Size = new System.Drawing.Size(104, 24);
            this.huyLop_checkBox.TabIndex = 20;
            this.huyLop_checkBox.Text = "Đồng ý";
            this.huyLop_checkBox.UseVisualStyleBackColor = true;
            // 
            // soSVMin_spinEdit
            // 
            this.soSVMin_spinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "SOSVTOITHIEU", true));
            this.soSVMin_spinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soSVMin_spinEdit.Location = new System.Drawing.Point(116, 69);
            this.soSVMin_spinEdit.MenuManager = this.barManagerTool;
            this.soSVMin_spinEdit.Name = "soSVMin_spinEdit";
            this.soSVMin_spinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soSVMin_spinEdit.Size = new System.Drawing.Size(60, 20);
            this.soSVMin_spinEdit.TabIndex = 15;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "MAKHOA", true));
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(500, 109);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(100, 21);
            this.txtMaKhoa.TabIndex = 13;
            // 
            // hocKy_spinEdit
            // 
            this.hocKy_spinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "HOCKY", true));
            this.hocKy_spinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hocKy_spinEdit.Location = new System.Drawing.Point(500, 67);
            this.hocKy_spinEdit.MenuManager = this.barManagerTool;
            this.hocKy_spinEdit.Name = "hocKy_spinEdit";
            this.hocKy_spinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hocKy_spinEdit.Size = new System.Drawing.Size(60, 20);
            this.hocKy_spinEdit.TabIndex = 9;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(314, 67);
            this.txtNienKhoa.MenuManager = this.barManagerTool;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtNienKhoa.TabIndex = 7;
            // 
            // nhom_spinEdit
            // 
            this.nhom_spinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NHOM", true));
            this.nhom_spinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nhom_spinEdit.Location = new System.Drawing.Point(500, 32);
            this.nhom_spinEdit.MenuManager = this.barManagerTool;
            this.nhom_spinEdit.Name = "nhom_spinEdit";
            this.nhom_spinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nhom_spinEdit.Size = new System.Drawing.Size(60, 20);
            this.nhom_spinEdit.TabIndex = 5;
            // 
            // bdsDK
            // 
            this.bdsDK.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDK.DataSource = this.bdsLTC;
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "MAGV", true));
            this.cmbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(84, 28);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(121, 21);
            this.cmbMaGV.TabIndex = 21;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "MAMH", true));
            this.cmbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(293, 28);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(121, 21);
            this.cmbMaMH.TabIndex = 22;
            // 
            // frmLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 476);
            this.Controls.Add(this.pnlLTC);
            this.Controls.Add(this.LTCGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLopTinChi";
            this.Text = "Lớp tín chỉ";
            this.Load += new System.EventHandler(this.frmLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLTC)).EndInit();
            this.pnlLTC.ResumeLayout(false);
            this.pnlLTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soSVMin_spinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocKy_spinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhom_spinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManagerTool;
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
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsLTC;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.LOPTINCHITableAdapter LTCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pnlLTC;
        private DevExpress.XtraGrid.GridControl LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.DANGKYTableAdapter DKTableAdapter;
        private System.Windows.Forms.BindingSource bdsDK;
        private DevExpress.XtraEditors.SpinEdit soSVMin_spinEdit;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private DevExpress.XtraEditors.SpinEdit hocKy_spinEdit;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraEditors.SpinEdit nhom_spinEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private System.Windows.Forms.CheckBox huyLop_checkBox;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.ComboBox cmbMaGV;
    }
}