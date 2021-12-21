
namespace QLSV_HTC.View
{
    partial class frmNhapDiem
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_loadLTC = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLSV_HTC.DS();
            this.LTCGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NDGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_loadDiem = new System.Windows.Forms.BindingSource(this.components);
            this.NDGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_HM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlInput = new DevExpress.XtraEditors.PanelControl();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadDiemTableAdapter = new QLSV_HTC.DSTableAdapters.SP_LOADNHAPDIEMTableAdapter();
            this.tableAdapterManager = new QLSV_HTC.DSTableAdapters.TableAdapterManager();
            this.loadLTCTableAdapter = new QLSV_HTC.DSTableAdapters.SP_LOADNDLTCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_loadLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NDGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_loadDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NDGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInput)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.LTCGridControl);
            this.panelControl1.Controls.Add(this.NDGridControl);
            this.panelControl1.Controls.Add(this.pnlInput);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1139, 486);
            this.panelControl1.TabIndex = 0;
            // 
            // LTCGridControl
            // 
            this.LTCGridControl.DataSource = this.bds_loadLTC;
            this.LTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTCGridControl.Location = new System.Drawing.Point(2, 47);
            this.LTCGridControl.MainView = this.LTCGridView;
            this.LTCGridControl.Name = "LTCGridControl";
            this.LTCGridControl.Size = new System.Drawing.Size(1135, 172);
            this.LTCGridControl.TabIndex = 9;
            this.LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LTCGridView});
            // 
            // bds_loadLTC
            // 
            this.bds_loadLTC.DataMember = "SP_LOADNDLTC";
            this.bds_loadLTC.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LTCGridView
            // 
            this.LTCGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colTENGV});
            this.LTCGridView.GridControl = this.LTCGridControl;
            this.LTCGridView.Name = "LTCGridView";
            this.LTCGridView.OptionsBehavior.Editable = false;
            this.LTCGridView.OptionsBehavior.ReadOnly = true;
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
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            // 
            // colTENGV
            // 
            this.colTENGV.FieldName = "TENGV";
            this.colTENGV.Name = "colTENGV";
            this.colTENGV.Visible = true;
            this.colTENGV.VisibleIndex = 3;
            // 
            // NDGridControl
            // 
            this.NDGridControl.DataSource = this.bds_loadDiem;
            this.NDGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NDGridControl.Location = new System.Drawing.Point(2, 277);
            this.NDGridControl.MainView = this.NDGridView;
            this.NDGridControl.Name = "NDGridControl";
            this.NDGridControl.Size = new System.Drawing.Size(1135, 207);
            this.NDGridControl.TabIndex = 8;
            this.NDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.NDGridView});
            // 
            // bds_loadDiem
            // 
            this.bds_loadDiem.DataMember = "SP_LOADNHAPDIEM";
            this.bds_loadDiem.DataSource = this.DS;
            // 
            // NDGridView
            // 
            this.NDGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colTENSV,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.colDIEM_HM});
            this.NDGridView.GridControl = this.NDGridControl;
            this.NDGridView.Name = "NDGridView";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã Sinh Viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.UnboundExpression = "0 <= [DIEM_CC] >= 10";
            this.colMASV.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colTENSV
            // 
            this.colTENSV.Caption = "Tên Sinh Viên";
            this.colTENSV.FieldName = "TENSV";
            this.colTENSV.Name = "colTENSV";
            this.colTENSV.OptionsColumn.ReadOnly = true;
            this.colTENSV.Visible = true;
            this.colTENSV.VisibleIndex = 1;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.Caption = "Điểm chuyên cần";
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.Caption = "Điểm giữa kỳ";
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.Caption = "Điểm cuối kỳ";
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            // 
            // colDIEM_HM
            // 
            this.colDIEM_HM.Caption = "Điểm hết môn";
            this.colDIEM_HM.FieldName = "DIEM_HM";
            this.colDIEM_HM.Name = "colDIEM_HM";
            this.colDIEM_HM.OptionsColumn.ReadOnly = true;
            this.colDIEM_HM.UnboundExpression = "([DIEM_CC] * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6) / 3";
            this.colDIEM_HM.Visible = true;
            this.colDIEM_HM.VisibleIndex = 5;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.btnLoad);
            this.pnlInput.Controls.Add(this.btnBatDau);
            this.pnlInput.Controls.Add(this.btnGhi);
            this.pnlInput.Controls.Add(this.cmbHocKy);
            this.pnlInput.Controls.Add(this.labelControl3);
            this.pnlInput.Controls.Add(this.cmbNienKhoa);
            this.pnlInput.Controls.Add(this.labelControl2);
            this.pnlInput.Controls.Add(this.cmbKhoa);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(2, 2);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(1135, 45);
            this.pnlInput.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(813, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 26);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Tải Tín Chỉ";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Appearance.Options.UseFont = true;
            this.btnBatDau.Location = new System.Drawing.Point(919, 11);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(100, 26);
            this.btnBatDau.TabIndex = 14;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Appearance.Options.UseFont = true;
            this.btnGhi.Location = new System.Drawing.Point(1025, 11);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 26);
            this.btnGhi.TabIndex = 4;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(604, 11);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(75, 26);
            this.cmbHocKy.TabIndex = 9;
            this.cmbHocKy.SelectedIndexChanged += new System.EventHandler(this.cmbHocKy_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(548, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 18);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Học Kỳ";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(405, 11);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 26);
            this.cmbNienKhoa.TabIndex = 7;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(326, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 18);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Niên Khoá";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(58, 11);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(251, 26);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // loadDiemTableAdapter
            // 
            this.loadDiemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loadLTCTableAdapter
            // 
            this.loadLTCTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 486);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_loadLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NDGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_loadDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NDGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInput)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl pnlInput;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl NDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView NDGridView;
        private DevExpress.XtraEditors.SimpleButton btnBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENSV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_HM;
        private DS DS;
        private System.Windows.Forms.BindingSource bds_loadDiem;
        private DSTableAdapters.SP_LOADNHAPDIEMTableAdapter loadDiemTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView LTCGridView;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.BindingSource bds_loadLTC;
        private DSTableAdapters.SP_LOADNDLTCTableAdapter loadLTCTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colTENGV;
    }
}