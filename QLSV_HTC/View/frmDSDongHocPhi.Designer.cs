
namespace QLSV_HTC.View
{
    partial class frmDSDongHocPhi
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
            System.Windows.Forms.Label tENLOPLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cbbHocKy = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsTENLOP = new System.Windows.Forms.BindingSource(this.components);
            this.DSHP = new QLSV_HTC.DSHP();
            this.TENLOPTableAdapter = new QLSV_HTC.DSHPTableAdapters.TENLOPTableAdapter();
            this.tableAdapterManager = new QLSV_HTC.DSHPTableAdapters.TableAdapterManager();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTENLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSHP)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(26, 59);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(58, 17);
            tENLOPLabel.TabIndex = 6;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niên khóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học kỳ:";
            // 
            // cbbNienKhoa
            // 
            this.cbbNienKhoa.FormattingEnabled = true;
            this.cbbNienKhoa.Items.AddRange(new object[] {
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022"});
            this.cbbNienKhoa.Location = new System.Drawing.Point(446, 55);
            this.cbbNienKhoa.Name = "cbbNienKhoa";
            this.cbbNienKhoa.Size = new System.Drawing.Size(121, 24);
            this.cbbNienKhoa.TabIndex = 4;
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbHocKy.Location = new System.Drawing.Point(679, 55);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(121, 24);
            this.cbbHocKy.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(341, 136);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(98, 32);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbTenLop);
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.cbbHocKy);
            this.panelControl1.Controls.Add(this.cbbNienKhoa);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(826, 188);
            this.panelControl1.TabIndex = 0;
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.DataSource = this.bdsTENLOP;
            this.cbbTenLop.DisplayMember = "TENLOP";
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(107, 56);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(223, 24);
            this.cbbTenLop.TabIndex = 7;
            this.cbbTenLop.ValueMember = "MALOP";
            this.cbbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbbTenLop_SelectedIndexChanged);
            // 
            // bdsTENLOP
            // 
            this.bdsTENLOP.DataMember = "TENLOP";
            this.bdsTENLOP.DataSource = this.DSHP;
            // 
            // DSHP
            // 
            this.DSHP.DataSetName = "DSHP";
            this.DSHP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TENLOPTableAdapter
            // 
            this.TENLOPTableAdapter.ClearBeforeFill = true;
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
            // frmDSDongHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 511);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDSDongHocPhi";
            this.Text = "Danh sách học phí theo lớp";
            this.Load += new System.EventHandler(this.frmDSDongHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTENLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNienKhoa;
        private System.Windows.Forms.ComboBox cbbHocKy;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSHP DSHP;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private System.Windows.Forms.BindingSource bdsTENLOP;
        private DSHPTableAdapters.TENLOPTableAdapter TENLOPTableAdapter;
        private DSHPTableAdapters.TableAdapterManager tableAdapterManager;
    }
}