
namespace QLSV_HTC.View
{
    partial class frmDangKy
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DKGridControl = new DevExpress.XtraGrid.GridControl();
            this.DKGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuuDK = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.LTCGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DKGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.DKGridControl);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.LTCGridControl);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(797, 578);
            this.panelControl1.TabIndex = 0;
            // 
            // DKGridControl
            // 
            this.DKGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DKGridControl.Location = new System.Drawing.Point(2, 373);
            this.DKGridControl.MainView = this.DKGridView;
            this.DKGridControl.Name = "DKGridControl";
            this.DKGridControl.Size = new System.Drawing.Size(793, 203);
            this.DKGridControl.TabIndex = 3;
            this.DKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DKGridView});
            // 
            // DKGridView
            // 
            this.DKGridView.GridControl = this.DKGridControl;
            this.DKGridView.Name = "DKGridView";
            this.DKGridView.OptionsBehavior.Editable = false;
            this.DKGridView.OptionsSelection.MultiSelect = true;
            this.DKGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnLuuDK);
            this.panelControl3.Controls.Add(this.btnHuyDangKy);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 317);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(793, 56);
            this.panelControl3.TabIndex = 2;
            // 
            // btnLuuDK
            // 
            this.btnLuuDK.Location = new System.Drawing.Point(38, 17);
            this.btnLuuDK.Name = "btnLuuDK";
            this.btnLuuDK.Size = new System.Drawing.Size(75, 25);
            this.btnLuuDK.TabIndex = 1;
            this.btnLuuDK.Text = "Lưu Đăng Ký";
            this.btnLuuDK.Click += new System.EventHandler(this.btnLuuDK_Click);
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Location = new System.Drawing.Point(189, 17);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(75, 25);
            this.btnHuyDangKy.TabIndex = 0;
            this.btnHuyDangKy.Text = "Huỷ Đăng Ký";
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // LTCGridControl
            // 
            this.LTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTCGridControl.Location = new System.Drawing.Point(2, 115);
            this.LTCGridControl.MainView = this.LTCGridView;
            this.LTCGridControl.Name = "LTCGridControl";
            this.LTCGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.LTCGridControl.Size = new System.Drawing.Size(793, 202);
            this.LTCGridControl.TabIndex = 1;
            this.LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LTCGridView});
            // 
            // LTCGridView
            // 
            this.LTCGridView.GridControl = this.LTCGridControl;
            this.LTCGridView.Name = "LTCGridView";
            this.LTCGridView.OptionsBehavior.Editable = false;
            this.LTCGridView.OptionsBehavior.ReadOnly = true;
            this.LTCGridView.OptionsSelection.MultiSelect = true;
            this.LTCGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtMaLop);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtTenSV);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.cmbMaSV);
            this.panelControl2.Controls.Add(this.cmbHocKy);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.cmbNienKhoa);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(793, 113);
            this.panelControl2.TabIndex = 0;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(536, 63);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(135, 26);
            this.txtMaLop.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(468, 66);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "MÃ LỚP";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Enabled = false;
            this.txtTenSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Location = new System.Drawing.Point(101, 63);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(334, 26);
            this.txtTenSV.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TÊN SV";
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMaSV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(101, 15);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(163, 26);
            this.cmbMaSV.TabIndex = 6;
            this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.cmbMaSV_SelectedIndexChanged);
            this.cmbMaSV.TextChanged += new System.EventHandler(this.cmbMaSV_TextChanged);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(596, 15);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(75, 26);
            this.cmbHocKy.TabIndex = 5;
            this.cmbHocKy.SelectedIndexChanged += new System.EventHandler(this.cmbHocKy_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(540, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Học Kỳ";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(391, 15);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 26);
            this.cmbNienKhoa.TabIndex = 3;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(312, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Niên Khoá";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "MÃ SV";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 578);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DKGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTCGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView LTCGridView;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLuuDK;
        private DevExpress.XtraEditors.SimpleButton btnHuyDangKy;
        private DevExpress.XtraGrid.GridControl DKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DKGridView;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.TextBox txtMaLop;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtTenSV;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}