
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label hOCPHILabel;
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
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienDaDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienCanDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbTTHP = new System.Windows.Forms.GroupBox();
            this.hOCPHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOCKYComboBox = new System.Windows.Forms.ComboBox();
            this.nIENKHOATextBox = new System.Windows.Forms.TextBox();
            this.bdsCTHP = new System.Windows.Forms.BindingSource(this.components);
            this.CT_DONGHOCPHITableAdapter = new QLSV_HTC.DSHPTableAdapters.CT_DONGHOCPHITableAdapter();
            this.gcCTHP = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuySV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLamMoiSV = new System.Windows.Forms.ToolStripMenuItem();
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
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSHP)).BeginInit();
            this.gbTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocPhi)).BeginInit();
            this.gbTTHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHITextEdit.Properties)).BeginInit();
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
            mASVLabel.Location = new System.Drawing.Point(37, 37);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(82, 17);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Mã sinh viên";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(323, 37);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(671, 37);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(36, 17);
            mALOPLabel.TabIndex = 5;
            mALOPLabel.Text = "Lớp:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(30, 55);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(78, 17);
            nIENKHOALabel.TabIndex = 0;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(30, 114);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(57, 17);
            hOCKYLabel.TabIndex = 2;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Location = new System.Drawing.Point(30, 167);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(62, 17);
            hOCPHILabel.TabIndex = 4;
            hOCPHILabel.Text = "HOCPHI:";
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
            this.gbTTSV.Location = new System.Drawing.Point(0, 30);
            this.gbTTSV.Name = "gbTTSV";
            this.gbTTSV.Size = new System.Drawing.Size(963, 88);
            this.gbTTSV.TabIndex = 14;
            this.gbTTSV.TabStop = false;
            this.gbTTSV.Text = "Thông tin sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(141, 34);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(138, 23);
            this.txtMaSV.TabIndex = 8;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(724, 34);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 23);
            this.txtMaLop.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(499, 34);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 23);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(361, 34);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(121, 23);
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
            this.gcHocPhi.Location = new System.Drawing.Point(0, 118);
            this.gcHocPhi.MainView = this.gvHocPhi;
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(963, 220);
            this.gcHocPhi.TabIndex = 29;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocPhi});
            // 
            // gvHocPhi
            // 
            this.gvHocPhi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSoTienDaDong,
            this.colSoTienCanDong});
            this.gvHocPhi.GridControl = this.gcHocPhi;
            this.gvHocPhi.Name = "gvHocPhi";
            this.gvHocPhi.OptionsBehavior.ReadOnly = true;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 94;
            // 
            // colSoTienDaDong
            // 
            this.colSoTienDaDong.Caption = "SOTIENDADONG";
            this.colSoTienDaDong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTienDaDong.MinWidth = 25;
            this.colSoTienDaDong.Name = "colSoTienDaDong";
            this.colSoTienDaDong.Visible = true;
            this.colSoTienDaDong.VisibleIndex = 3;
            this.colSoTienDaDong.Width = 94;
            // 
            // colSoTienCanDong
            // 
            this.colSoTienCanDong.Caption = "SOTIENCANDONG";
            this.colSoTienCanDong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTienCanDong.MinWidth = 25;
            this.colSoTienCanDong.Name = "colSoTienCanDong";
            this.colSoTienCanDong.Visible = true;
            this.colSoTienCanDong.VisibleIndex = 4;
            this.colSoTienCanDong.Width = 94;
            // 
            // gbTTHP
            // 
            this.gbTTHP.Controls.Add(hOCPHILabel);
            this.gbTTHP.Controls.Add(this.hOCPHITextEdit);
            this.gbTTHP.Controls.Add(hOCKYLabel);
            this.gbTTHP.Controls.Add(this.hOCKYComboBox);
            this.gbTTHP.Controls.Add(nIENKHOALabel);
            this.gbTTHP.Controls.Add(this.nIENKHOATextBox);
            this.gbTTHP.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTTHP.Location = new System.Drawing.Point(0, 338);
            this.gbTTHP.Name = "gbTTHP";
            this.gbTTHP.Size = new System.Drawing.Size(396, 390);
            this.gbTTHP.TabIndex = 30;
            this.gbTTHP.TabStop = false;
            this.gbTTHP.Text = "Thông tin đóng học phí";
            // 
            // hOCPHITextEdit
            // 
            this.hOCPHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHocPhi, "HOCPHI", true));
            this.hOCPHITextEdit.Location = new System.Drawing.Point(114, 164);
            this.hOCPHITextEdit.Name = "hOCPHITextEdit";
            this.hOCPHITextEdit.Size = new System.Drawing.Size(215, 22);
            this.hOCPHITextEdit.TabIndex = 5;
            // 
            // hOCKYComboBox
            // 
            this.hOCKYComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHocPhi, "HOCKY", true));
            this.hOCKYComboBox.FormattingEnabled = true;
            this.hOCKYComboBox.Location = new System.Drawing.Point(113, 111);
            this.hOCKYComboBox.Name = "hOCKYComboBox";
            this.hOCKYComboBox.Size = new System.Drawing.Size(73, 24);
            this.hOCKYComboBox.TabIndex = 3;
            // 
            // nIENKHOATextBox
            // 
            this.nIENKHOATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHocPhi, "NIENKHOA", true));
            this.nIENKHOATextBox.Location = new System.Drawing.Point(114, 52);
            this.nIENKHOATextBox.Name = "nIENKHOATextBox";
            this.nIENKHOATextBox.Size = new System.Drawing.Size(215, 23);
            this.nIENKHOATextBox.TabIndex = 1;
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
            this.gcCTHP.Location = new System.Drawing.Point(396, 338);
            this.gcCTHP.MainView = this.gvCTHP;
            this.gcCTHP.Name = "gcCTHP";
            this.gcCTHP.Size = new System.Drawing.Size(567, 390);
            this.gcCTHP.TabIndex = 30;
            this.gcCTHP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTHP});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemSV,
            this.btnXoaSV,
            this.btnSuaSV,
            this.btnGhiSV,
            this.btnHuySV,
            this.btnPhucHoiSV,
            this.btnLamMoiSV});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 214);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Image = global::QLSV_HTC.Properties.Resources.plus;
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(214, 26);
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Image = global::QLSV_HTC.Properties.Resources.erase;
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(214, 26);
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Image = global::QLSV_HTC.Properties.Resources.repair;
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(214, 26);
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnGhiSV
            // 
            this.btnGhiSV.Image = global::QLSV_HTC.Properties.Resources.save_all;
            this.btnGhiSV.Name = "btnGhiSV";
            this.btnGhiSV.Size = new System.Drawing.Size(214, 26);
            this.btnGhiSV.Text = "Ghi";
            this.btnGhiSV.Click += new System.EventHandler(this.btnGhiSV_Click);
            // 
            // btnHuySV
            // 
            this.btnHuySV.Image = global::QLSV_HTC.Properties.Resources.stock_not;
            this.btnHuySV.Name = "btnHuySV";
            this.btnHuySV.Size = new System.Drawing.Size(214, 26);
            this.btnHuySV.Text = "Hủy";
            this.btnHuySV.Click += new System.EventHandler(this.btnHuySV_Click);
            // 
            // btnPhucHoiSV
            // 
            this.btnPhucHoiSV.Image = global::QLSV_HTC.Properties.Resources.undo;
            this.btnPhucHoiSV.Name = "btnPhucHoiSV";
            this.btnPhucHoiSV.Size = new System.Drawing.Size(214, 26);
            this.btnPhucHoiSV.Text = "Phục hồi";
            this.btnPhucHoiSV.Click += new System.EventHandler(this.btnPhucHoiSV_Click);
            // 
            // btnLamMoiSV
            // 
            this.btnLamMoiSV.Image = global::QLSV_HTC.Properties.Resources.gnome_view_refresh;
            this.btnLamMoiSV.Name = "btnLamMoiSV";
            this.btnLamMoiSV.Size = new System.Drawing.Size(214, 26);
            this.btnLamMoiSV.Text = "Làm mới";
            this.btnLamMoiSV.Click += new System.EventHandler(this.btnLamMoiSV_Click);
            // 
            // gvCTHP
            // 
            this.gvCTHP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gvCTHP.GridControl = this.gcCTHP;
            this.gvCTHP.Name = "gvCTHP";
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 25;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 94;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 25;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 94;
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
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
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
            this.barDockControlTop.Size = new System.Drawing.Size(963, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 728);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(963, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 698);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(963, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 698);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(963, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 698);
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 748);
            this.Controls.Add(this.gcCTHP);
            this.Controls.Add(this.gbTTHP);
            this.Controls.Add(this.gcHocPhi);
            this.Controls.Add(this.gbTTSV);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
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
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHITextEdit.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private DevExpress.XtraEditors.TextEdit hOCPHITextEdit;
        private System.Windows.Forms.ComboBox hOCKYComboBox;
        private System.Windows.Forms.TextBox nIENKHOATextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienDaDong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienCanDong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemSV;
        private System.Windows.Forms.ToolStripMenuItem btnXoaSV;
        private System.Windows.Forms.ToolStripMenuItem btnSuaSV;
        private System.Windows.Forms.ToolStripMenuItem btnGhiSV;
        private System.Windows.Forms.ToolStripMenuItem btnHuySV;
        private System.Windows.Forms.ToolStripMenuItem btnLamMoiSV;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiSV;
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
    }
}