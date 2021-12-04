
namespace QLSV_HTC
{
    partial class frmMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLSV_HTC.DS();
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
            this.MHTableAdapter = new QLSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLSV_HTC.DSTableAdapters.TableAdapterManager();
            this.MHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlNhapMonHoc = new DevExpress.XtraEditors.PanelControl();
            this.soTiet_TH_spinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.soTiet_LT_spinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.bdsLopTC = new System.Windows.Forms.BindingSource(this.components);
            this.LTCTableAdapter = new QLSV_HTC.DSTableAdapters.LOPTINCHITableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNhapMonHoc)).BeginInit();
            this.pnlNhapMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soTiet_TH_spinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTiet_LT_spinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTC)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(80, 40);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(65, 13);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã Môn Học";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(80, 90);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(69, 13);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Tên Môn Học";
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Location = new System.Drawing.Point(506, 40);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(91, 13);
            sOTIET_LTLabel.TabIndex = 4;
            sOTIET_LTLabel.Text = "Số Tiết Lý Thuyết";
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Location = new System.Drawing.Point(506, 90);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(95, 13);
            sOTIET_THLabel.TabIndex = 6;
            sOTIET_THLabel.Text = "Số Tiết Thực Hành";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.barDockControlTop.Size = new System.Drawing.Size(843, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 442);
            this.barDockControlBottom.Manager = this.barManagerTool;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(843, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerTool;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 418);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(843, 24);
            this.barDockControlRight.Manager = this.barManagerTool;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 418);
            // 
            // MHTableAdapter
            // 
            this.MHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MHTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MHGridControl
            // 
            this.MHGridControl.DataSource = this.bdsMH;
            this.MHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MHGridControl.Location = new System.Drawing.Point(0, 24);
            this.MHGridControl.MainView = this.gridView1;
            this.MHGridControl.MenuManager = this.barManagerTool;
            this.MHGridControl.Name = "MHGridControl";
            this.MHGridControl.Size = new System.Drawing.Size(843, 220);
            this.MHGridControl.TabIndex = 4;
            this.MHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gridView1.GridControl = this.MHGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            // 
            // pnlNhapMonHoc
            // 
            this.pnlNhapMonHoc.Controls.Add(sOTIET_THLabel);
            this.pnlNhapMonHoc.Controls.Add(this.soTiet_TH_spinEdit);
            this.pnlNhapMonHoc.Controls.Add(sOTIET_LTLabel);
            this.pnlNhapMonHoc.Controls.Add(this.soTiet_LT_spinEdit);
            this.pnlNhapMonHoc.Controls.Add(tENMHLabel);
            this.pnlNhapMonHoc.Controls.Add(this.txtTenMH);
            this.pnlNhapMonHoc.Controls.Add(mAMHLabel);
            this.pnlNhapMonHoc.Controls.Add(this.txtMaMH);
            this.pnlNhapMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNhapMonHoc.Enabled = false;
            this.pnlNhapMonHoc.Location = new System.Drawing.Point(0, 244);
            this.pnlNhapMonHoc.Name = "pnlNhapMonHoc";
            this.pnlNhapMonHoc.Size = new System.Drawing.Size(843, 198);
            this.pnlNhapMonHoc.TabIndex = 5;
            // 
            // soTiet_TH_spinEdit
            // 
            this.soTiet_TH_spinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMH, "SOTIET_TH", true));
            this.soTiet_TH_spinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soTiet_TH_spinEdit.Location = new System.Drawing.Point(607, 87);
            this.soTiet_TH_spinEdit.MenuManager = this.barManagerTool;
            this.soTiet_TH_spinEdit.Name = "soTiet_TH_spinEdit";
            this.soTiet_TH_spinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soTiet_TH_spinEdit.Size = new System.Drawing.Size(107, 20);
            this.soTiet_TH_spinEdit.TabIndex = 7;
            this.soTiet_TH_spinEdit.EditValueChanged += new System.EventHandler(this.soTiet_TH_spinEdit_EditValueChanged);
            // 
            // soTiet_LT_spinEdit
            // 
            this.soTiet_LT_spinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMH, "SOTIET_LT", true));
            this.soTiet_LT_spinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soTiet_LT_spinEdit.Location = new System.Drawing.Point(607, 37);
            this.soTiet_LT_spinEdit.MenuManager = this.barManagerTool;
            this.soTiet_LT_spinEdit.Name = "soTiet_LT_spinEdit";
            this.soTiet_LT_spinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soTiet_LT_spinEdit.Size = new System.Drawing.Size(107, 20);
            this.soTiet_LT_spinEdit.TabIndex = 5;
            this.soTiet_LT_spinEdit.EditValueChanged += new System.EventHandler(this.soTiet_LT_spinEdit_EditValueChanged);
            // 
            // txtTenMH
            // 
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMH, "TENMH", true));
            this.txtTenMH.Location = new System.Drawing.Point(155, 87);
            this.txtTenMH.MenuManager = this.barManagerTool;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(300, 20);
            this.txtTenMH.TabIndex = 3;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMH, "MAMH", true));
            this.txtMaMH.Location = new System.Drawing.Point(155, 37);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(100, 21);
            this.txtMaMH.TabIndex = 1;
            // 
            // bdsLopTC
            // 
            this.bdsLopTC.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLopTC.DataSource = this.bdsMH;
            // 
            // LTCTableAdapter
            // 
            this.LTCTableAdapter.ClearBeforeFill = true;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 462);
            this.Controls.Add(this.pnlNhapMonHoc);
            this.Controls.Add(this.MHGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonHoc";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNhapMonHoc)).EndInit();
            this.pnlNhapMonHoc.ResumeLayout(false);
            this.pnlNhapMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soTiet_TH_spinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTiet_LT_spinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTC)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsMH;
        private DS DS;
        private DSTableAdapters.MONHOCTableAdapter MHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pnlNhapMonHoc;
        private DevExpress.XtraGrid.GridControl MHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsLopTC;
        private DSTableAdapters.LOPTINCHITableAdapter LTCTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private DevExpress.XtraEditors.SpinEdit soTiet_TH_spinEdit;
        private DevExpress.XtraEditors.SpinEdit soTiet_LT_spinEdit;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
    }
}