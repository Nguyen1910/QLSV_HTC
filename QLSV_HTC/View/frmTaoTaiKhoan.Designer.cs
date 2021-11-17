
namespace QLSV_HTC.View
{
    partial class frmTaoTaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRole = new System.Windows.Forms.Panel();
            this.rbtnPKT = new System.Windows.Forms.RadioButton();
            this.rbtnKhoa = new System.Windows.Forms.RadioButton();
            this.rbtnPGV = new System.Windows.Forms.RadioButton();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbbGiangVien = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DSHP = new QLSV_HTC.DSHP();
            this.tableAdapterManager = new QLSV_HTC.DSHPTableAdapters.TableAdapterManager();
            this.DS = new QLSV_HTC.DS();
            this.tableAdapterManager1 = new QLSV_HTC.DSTableAdapters.TableAdapterManager();
            this.bdsHOTENGV = new System.Windows.Forms.BindingSource(this.components);
            this.HOTENGVTableAdapter = new QLSV_HTC.DSTableAdapters.HOTENGVTableAdapter();
            this.bdsHOTENGVHP = new System.Windows.Forms.BindingSource(this.components);
            this.HOTENGVHPTableAdapter = new QLSV_HTC.DSHPTableAdapters.HOTENGVHPTableAdapter();
            this.panel1.SuspendLayout();
            this.pnRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENGVHP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pnRole);
            this.panel1.Controls.Add(this.txtPassConfirm);
            this.panel1.Controls.Add(this.cbShowPass);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.cbbGiangVien);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(189, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 478);
            this.panel1.TabIndex = 0;
            // 
            // pnRole
            // 
            this.pnRole.BackColor = System.Drawing.Color.Gainsboro;
            this.pnRole.Controls.Add(this.rbtnPKT);
            this.pnRole.Controls.Add(this.rbtnKhoa);
            this.pnRole.Controls.Add(this.rbtnPGV);
            this.pnRole.Location = new System.Drawing.Point(157, 343);
            this.pnRole.Name = "pnRole";
            this.pnRole.Size = new System.Drawing.Size(219, 37);
            this.pnRole.TabIndex = 20;
            // 
            // rbtnPKT
            // 
            this.rbtnPKT.AutoSize = true;
            this.rbtnPKT.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnPKT.ForeColor = System.Drawing.Color.Black;
            this.rbtnPKT.Location = new System.Drawing.Point(152, 9);
            this.rbtnPKT.Name = "rbtnPKT";
            this.rbtnPKT.Size = new System.Drawing.Size(53, 21);
            this.rbtnPKT.TabIndex = 21;
            this.rbtnPKT.TabStop = true;
            this.rbtnPKT.Text = "PKT";
            this.rbtnPKT.UseVisualStyleBackColor = false;
            // 
            // rbtnKhoa
            // 
            this.rbtnKhoa.AutoSize = true;
            this.rbtnKhoa.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnKhoa.ForeColor = System.Drawing.Color.Black;
            this.rbtnKhoa.Location = new System.Drawing.Point(72, 9);
            this.rbtnKhoa.Name = "rbtnKhoa";
            this.rbtnKhoa.Size = new System.Drawing.Size(64, 21);
            this.rbtnKhoa.TabIndex = 20;
            this.rbtnKhoa.TabStop = true;
            this.rbtnKhoa.Text = "KHOA";
            this.rbtnKhoa.UseVisualStyleBackColor = false;
            // 
            // rbtnPGV
            // 
            this.rbtnPGV.AutoSize = true;
            this.rbtnPGV.BackColor = System.Drawing.Color.Gainsboro;
            this.rbtnPGV.ForeColor = System.Drawing.Color.Black;
            this.rbtnPGV.Location = new System.Drawing.Point(3, 9);
            this.rbtnPGV.Name = "rbtnPGV";
            this.rbtnPGV.Size = new System.Drawing.Size(54, 21);
            this.rbtnPGV.TabIndex = 19;
            this.rbtnPGV.TabStop = true;
            this.rbtnPGV.Text = "PGV";
            this.rbtnPGV.UseVisualStyleBackColor = false;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(157, 274);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = '*';
            this.txtPassConfirm.Size = new System.Drawing.Size(177, 23);
            this.txtPassConfirm.TabIndex = 18;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.ForeColor = System.Drawing.Color.Black;
            this.cbShowPass.Location = new System.Drawing.Point(340, 276);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(64, 21);
            this.cbShowPass.TabIndex = 17;
            this.cbShowPass.Text = "Show";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 232);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(177, 23);
            this.txtPassword.TabIndex = 16;
            // 
            // cbbGiangVien
            // 
            this.cbbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiangVien.FormattingEnabled = true;
            this.cbbGiangVien.Location = new System.Drawing.Point(157, 313);
            this.cbbGiangVien.Name = "cbbGiangVien";
            this.cbbGiangVien.Size = new System.Drawing.Size(177, 24);
            this.cbbGiangVien.TabIndex = 14;
            this.cbbGiangVien.SelectedIndexChanged += new System.EventHandler(this.cbbGiangVien_SelectedIndexChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(256, 418);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(54, 418);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(120, 40);
            this.btnDangKy.TabIndex = 12;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(157, 192);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(177, 22);
            this.txtLogin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giảng viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV_HTC.Properties.Resources._97819;
            this.pictureBox1.Location = new System.Drawing.Point(139, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.LOPTINCHITableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsHOTENGV
            // 
            this.bdsHOTENGV.DataMember = "HOTENGV";
            this.bdsHOTENGV.DataSource = this.DS;
            // 
            // HOTENGVTableAdapter
            // 
            this.HOTENGVTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHOTENGVHP
            // 
            this.bdsHOTENGVHP.DataMember = "HOTENGVHP";
            this.bdsHOTENGVHP.DataSource = this.DSHP;
            // 
            // HOTENGVHPTableAdapter
            // 
            this.HOTENGVHPTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 566);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnRole.ResumeLayout(false);
            this.pnRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENGVHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbGiangVien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangKy;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassConfirm;
        protected System.Windows.Forms.CheckBox cbShowPass;
        private DSHP DSHP;
        private DSHPTableAdapters.TableAdapterManager tableAdapterManager;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bdsHOTENGV;
        private DSTableAdapters.HOTENGVTableAdapter HOTENGVTableAdapter;
        private System.Windows.Forms.BindingSource bdsHOTENGVHP;
        private DSHPTableAdapters.HOTENGVHPTableAdapter HOTENGVHPTableAdapter;
        private System.Windows.Forms.Panel pnRole;
        private System.Windows.Forms.RadioButton rbtnPGV;
        private System.Windows.Forms.RadioButton rbtnPKT;
        private System.Windows.Forms.RadioButton rbtnKhoa;
    }
}