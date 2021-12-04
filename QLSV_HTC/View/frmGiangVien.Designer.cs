
namespace QLSV_HTC.View
{
    partial class frmGiangVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label cHUYENMONLabel1;
            System.Windows.Forms.Label hOCVILabel1;
            System.Windows.Forms.Label tENLabel1;
            System.Windows.Forms.Label hOLabel1;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label mAGVLabel1;
            System.Windows.Forms.Label hOCHAMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
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
            this.DS = new QLSV_HTC.DS();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.GVTableAdapter = new QLSV_HTC.DSTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new QLSV_HTC.DSTableAdapters.TableAdapterManager();
            this.LTCTableAdapter = new QLSV_HTC.DSTableAdapters.LOPTINCHITableAdapter();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCHAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUYENMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GVGridControl = new DevExpress.XtraGrid.GridControl();
            this.pnlGV = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtHocHam = new DevExpress.XtraEditors.TextEdit();
            this.txtChuyenMon = new DevExpress.XtraEditors.TextEdit();
            this.txtHocVi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            cHUYENMONLabel1 = new System.Windows.Forms.Label();
            hOCVILabel1 = new System.Windows.Forms.Label();
            tENLabel1 = new System.Windows.Forms.Label();
            hOLabel1 = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            mAGVLabel1 = new System.Windows.Forms.Label();
            hOCHAMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGV)).BeginInit();
            this.pnlGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocHam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuyenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.Location = new System.Drawing.Point(0, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(100, 23);
            mAGVLabel.TabIndex = 0;
            // 
            // hOLabel
            // 
            hOLabel.Location = new System.Drawing.Point(0, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(100, 23);
            hOLabel.TabIndex = 0;
            // 
            // tENLabel
            // 
            tENLabel.Location = new System.Drawing.Point(0, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(100, 23);
            tENLabel.TabIndex = 0;
            // 
            // hOCVILabel
            // 
            hOCVILabel.Location = new System.Drawing.Point(0, 0);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(100, 23);
            hOCVILabel.TabIndex = 0;
            // 
            // cHUYENMONLabel1
            // 
            cHUYENMONLabel1.AutoSize = true;
            cHUYENMONLabel1.Location = new System.Drawing.Point(283, 114);
            cHUYENMONLabel1.Name = "cHUYENMONLabel1";
            cHUYENMONLabel1.Size = new System.Drawing.Size(67, 13);
            cHUYENMONLabel1.TabIndex = 29;
            cHUYENMONLabel1.Text = "Chuyên Môn";
            // 
            // hOCVILabel1
            // 
            hOCVILabel1.AutoSize = true;
            hOCVILabel1.Location = new System.Drawing.Point(93, 114);
            hOCVILabel1.Name = "hOCVILabel1";
            hOCVILabel1.Size = new System.Drawing.Size(36, 13);
            hOCVILabel1.TabIndex = 27;
            hOCVILabel1.Text = "Học Vị";
            // 
            // tENLabel1
            // 
            tENLabel1.AutoSize = true;
            tENLabel1.Location = new System.Drawing.Point(283, 74);
            tENLabel1.Name = "tENLabel1";
            tENLabel1.Size = new System.Drawing.Size(25, 13);
            tENLabel1.TabIndex = 25;
            tENLabel1.Text = "Tên";
            // 
            // hOLabel1
            // 
            hOLabel1.AutoSize = true;
            hOLabel1.Location = new System.Drawing.Point(93, 74);
            hOLabel1.Name = "hOLabel1";
            hOLabel1.Size = new System.Drawing.Size(20, 13);
            hOLabel1.TabIndex = 22;
            hOLabel1.Text = "Họ";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(566, 34);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(48, 13);
            mAKHOALabel.TabIndex = 20;
            mAKHOALabel.Text = "Mã Khoa";
            // 
            // mAGVLabel1
            // 
            mAGVLabel1.AutoSize = true;
            mAGVLabel1.Location = new System.Drawing.Point(93, 34);
            mAGVLabel1.Name = "mAGVLabel1";
            mAGVLabel1.Size = new System.Drawing.Size(37, 13);
            mAGVLabel1.TabIndex = 19;
            mAGVLabel1.Text = "Mã GV";
            // 
            // hOCHAMLabel
            // 
            hOCHAMLabel.AutoSize = true;
            hOCHAMLabel.Location = new System.Drawing.Point(566, 114);
            hOCHAMLabel.Name = "hOCHAMLabel";
            hOCHAMLabel.Size = new System.Drawing.Size(49, 13);
            hOCHAMLabel.TabIndex = 30;
            hOCHAMLabel.Text = "Học Hàm";
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
            this.barDockControlTop.Size = new System.Drawing.Size(823, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Manager = this.barManagerTool;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(823, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerTool;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 439);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(823, 24);
            this.barDockControlRight.Manager = this.barManagerTool;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 439);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIANGVIEN";
            this.bdsGV.DataSource = this.DS;
            // 
            // GVTableAdapter
            // 
            this.GVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.GVTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.LTCTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LTCTableAdapter
            // 
            this.LTCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "FK_LOPTINCHI_GIANGVIEN";
            this.bdsLTC.DataSource = this.bdsGV;
            // 
            // gridViewGiangVien
            // 
            this.gridViewGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAKHOA,
            this.colHO,
            this.colTEN,
            this.colHOCVI,
            this.colHOCHAM,
            this.colCHUYENMON});
            this.gridViewGiangVien.GridControl = this.GVGridControl;
            this.gridViewGiangVien.Name = "gridViewGiangVien";
            this.gridViewGiangVien.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewGiangVien.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewGiangVien.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewGiangVien.OptionsBehavior.Editable = false;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 1;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 4;
            // 
            // colHOCHAM
            // 
            this.colHOCHAM.FieldName = "HOCHAM";
            this.colHOCHAM.Name = "colHOCHAM";
            this.colHOCHAM.Visible = true;
            this.colHOCHAM.VisibleIndex = 5;
            // 
            // colCHUYENMON
            // 
            this.colCHUYENMON.FieldName = "CHUYENMON";
            this.colCHUYENMON.Name = "colCHUYENMON";
            this.colCHUYENMON.Visible = true;
            this.colCHUYENMON.VisibleIndex = 6;
            // 
            // GVGridControl
            // 
            this.GVGridControl.DataSource = this.bdsGV;
            this.GVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.GVGridControl.Location = new System.Drawing.Point(0, 24);
            this.GVGridControl.MainView = this.gridViewGiangVien;
            this.GVGridControl.MenuManager = this.barManagerTool;
            this.GVGridControl.Name = "GVGridControl";
            this.GVGridControl.Size = new System.Drawing.Size(823, 220);
            this.GVGridControl.TabIndex = 9;
            this.GVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiangVien});
            // 
            // pnlGV
            // 
            this.pnlGV.Controls.Add(this.cmbKhoa);
            this.pnlGV.Controls.Add(hOCHAMLabel);
            this.pnlGV.Controls.Add(this.txtHocHam);
            this.pnlGV.Controls.Add(cHUYENMONLabel1);
            this.pnlGV.Controls.Add(this.txtChuyenMon);
            this.pnlGV.Controls.Add(hOCVILabel1);
            this.pnlGV.Controls.Add(this.txtHocVi);
            this.pnlGV.Controls.Add(tENLabel1);
            this.pnlGV.Controls.Add(this.txtTen);
            this.pnlGV.Controls.Add(hOLabel1);
            this.pnlGV.Controls.Add(this.txtHo);
            this.pnlGV.Controls.Add(mAKHOALabel);
            this.pnlGV.Controls.Add(mAGVLabel1);
            this.pnlGV.Controls.Add(this.txtMaGV);
            this.pnlGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGV.Enabled = false;
            this.pnlGV.Location = new System.Drawing.Point(0, 244);
            this.pnlGV.Name = "pnlGV";
            this.pnlGV.Size = new System.Drawing.Size(823, 219);
            this.pnlGV.TabIndex = 23;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAKHOA", true));
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(627, 31);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 32;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // txtHocHam
            // 
            this.txtHocHam.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HOCHAM", true));
            this.txtHocHam.Location = new System.Drawing.Point(627, 111);
            this.txtHocHam.MenuManager = this.barManagerTool;
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.Size = new System.Drawing.Size(100, 20);
            this.txtHocHam.TabIndex = 31;
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "CHUYENMON", true));
            this.txtChuyenMon.Location = new System.Drawing.Point(363, 111);
            this.txtChuyenMon.MenuManager = this.barManagerTool;
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Size = new System.Drawing.Size(176, 20);
            this.txtChuyenMon.TabIndex = 30;
            // 
            // txtHocVi
            // 
            this.txtHocVi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HOCVI", true));
            this.txtHocVi.Location = new System.Drawing.Point(142, 111);
            this.txtHocVi.MenuManager = this.barManagerTool;
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(110, 20);
            this.txtHocVi.TabIndex = 28;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(319, 71);
            this.txtTen.MenuManager = this.barManagerTool;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(220, 20);
            this.txtTen.TabIndex = 26;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(142, 71);
            this.txtHo.MenuManager = this.barManagerTool;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(110, 20);
            this.txtHo.TabIndex = 24;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(142, 31);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(110, 21);
            this.txtMaGV.TabIndex = 21;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 483);
            this.Controls.Add(this.pnlGV);
            this.Controls.Add(this.GVGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGV)).EndInit();
            this.pnlGV.ResumeLayout(false);
            this.pnlGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocHam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuyenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsGV;
        private DS DS;
        private DSTableAdapters.GIANGVIENTableAdapter GVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTINCHITableAdapter LTCTableAdapter;
        private System.Windows.Forms.BindingSource bdsLTC;
        private DevExpress.XtraEditors.PanelControl pnlGV;
        private DevExpress.XtraEditors.TextEdit txtHocHam;
        private DevExpress.XtraEditors.TextEdit txtChuyenMon;
        private DevExpress.XtraEditors.TextEdit txtHocVi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private System.Windows.Forms.TextBox txtMaGV;
        private DevExpress.XtraGrid.GridControl GVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCHAM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUYENMON;
        private System.Windows.Forms.ComboBox cmbKhoa;
    }
}