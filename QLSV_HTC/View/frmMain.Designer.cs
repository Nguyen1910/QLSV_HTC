
namespace QLSV_HTC
{
    public partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSignIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnSignOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDKLopTC = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDSDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnReportDSLTC = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDSSVDKLTC = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnBDHM = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPD = new DevExpress.XtraBars.BarButtonItem();
            this.Icon = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ID_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Name_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Group_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(0)))), ((int)(((byte)(41)))));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.ForeColor = System.Drawing.Color.White;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSignIn,
            this.btnSignOut,
            this.btnThongTin,
            this.btnDoiMatKhau,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem4,
            this.btnGiangVien,
            this.btnSinhVien,
            this.bbtnDKLopTC,
            this.bbtnNhapDiem,
            this.bbtnDongHocPhi,
            this.bbtnDSDongHocPhi,
            this.btnTaoTaiKhoan,
            this.bbtnReportDSLTC,
            this.bbtnDSSVDKLTC,
            this.bbtnBDHM,
            this.bbtnPD});
            this.ribbon.LargeImages = this.Icon;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 44;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rbDanhMuc,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.ribbon.Size = new System.Drawing.Size(798, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Caption = "Đăng Nhập";
            this.btnSignIn.Id = 4;
            this.btnSignIn.ImageOptions.Image = global::QLSV_HTC.Properties.Resources.outline_login_black_24dp;
            this.btnSignIn.Name = "btnSignIn";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Caption = "Đăng Xuất";
            this.btnSignOut.Id = 5;
            this.btnSignOut.ImageOptions.Image = global::QLSV_HTC.Properties.Resources.outline_logout_black_24dp;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSignOut_ItemClick);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thông Tin";
            this.btnThongTin.Id = 26;
            this.btnThongTin.ImageOptions.LargeImageIndex = 4;
            this.btnThongTin.Name = "btnThongTin";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Id = 27;
            this.btnDoiMatKhau.ImageOptions.LargeImageIndex = 3;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Lớp";
            this.barButtonItem6.Id = 28;
            this.barButtonItem6.ImageOptions.LargeImageIndex = 2;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Môn Học";
            this.barButtonItem7.Id = 29;
            this.barButtonItem7.ImageOptions.LargeImageIndex = 0;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tín Chỉ";
            this.barButtonItem4.Id = 30;
            this.barButtonItem4.ImageOptions.LargeImageIndex = 11;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Caption = "Giảng Viên";
            this.btnGiangVien.Id = 31;
            this.btnGiangVien.ImageOptions.LargeImageIndex = 6;
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiangVien_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Id = 32;
            this.btnSinhVien.ImageOptions.LargeImageIndex = 5;
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // bbtnDKLopTC
            // 
            this.bbtnDKLopTC.Caption = "Đăng Ký Tín Chỉ";
            this.bbtnDKLopTC.Id = 33;
            this.bbtnDKLopTC.ImageOptions.LargeImageIndex = 21;
            this.bbtnDKLopTC.Name = "bbtnDKLopTC";
            this.bbtnDKLopTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDKLopTC_ItemClick);
            // 
            // bbtnNhapDiem
            // 
            this.bbtnNhapDiem.Caption = "Nhập Điểm";
            this.bbtnNhapDiem.Id = 34;
            this.bbtnNhapDiem.ImageOptions.LargeImageIndex = 22;
            this.bbtnNhapDiem.Name = "bbtnNhapDiem";
            this.bbtnNhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnNhapDiem_ItemClick);
            // 
            // bbtnDongHocPhi
            // 
            this.bbtnDongHocPhi.Caption = "Đóng Học Phí";
            this.bbtnDongHocPhi.Id = 35;
            this.bbtnDongHocPhi.ImageOptions.LargeImageIndex = 20;
            this.bbtnDongHocPhi.Name = "bbtnDongHocPhi";
            this.bbtnDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // bbtnDSDongHocPhi
            // 
            this.bbtnDSDongHocPhi.Caption = "Danh sách học phí theo lớp";
            this.bbtnDSDongHocPhi.Id = 36;
            this.bbtnDSDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnDSDongHocPhi.ImageOptions.Image")));
            this.bbtnDSDongHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnDSDongHocPhi.ImageOptions.LargeImage")));
            this.bbtnDSDongHocPhi.Name = "bbtnDSDongHocPhi";
            this.bbtnDSDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDSDongHocPhi_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Id = 38;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // bbtnReportDSLTC
            // 
            this.bbtnReportDSLTC.Caption = "Danh sách lớp tín chỉ";
            this.bbtnReportDSLTC.Id = 39;
            this.bbtnReportDSLTC.ImageOptions.LargeImageIndex = 21;
            this.bbtnReportDSLTC.Name = "bbtnReportDSLTC";
            this.bbtnReportDSLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnReportDSLTC_ItemClick);
            // 
            // bbtnDSSVDKLTC
            // 
            this.bbtnDSSVDKLTC.Caption = "Danh sách sinh viên đã đăng ký lớp tín chỉ";
            this.bbtnDSSVDKLTC.Id = 40;
            this.bbtnDSSVDKLTC.ImageOptions.LargeImageIndex = 21;
            this.bbtnDSSVDKLTC.Name = "bbtnDSSVDKLTC";
            this.bbtnDSSVDKLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDSSVDKLTC_ItemClick);
            // 
            // bbtnBDHM
            // 
            this.bbtnBDHM.Caption = "Bảng điểm hết môn";
            this.bbtnBDHM.Id = 42;
            this.bbtnBDHM.ImageOptions.LargeImageIndex = 21;
            this.bbtnBDHM.Name = "bbtnBDHM";
            this.bbtnBDHM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnBDHM_ItemClick);
            // 
            // bbtnPD
            // 
            this.bbtnPD.Caption = "Phiếu điểm sinh viên";
            this.bbtnPD.Id = 43;
            this.bbtnPD.ImageOptions.LargeImageIndex = 21;
            this.bbtnPD.Name = "bbtnPD";
            this.bbtnPD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPD_ItemClick);
            // 
            // Icon
            // 
            this.Icon.ImageSize = new System.Drawing.Size(48, 48);
            this.Icon.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("Icon.ImageStream")));
            this.Icon.Images.SetKeyName(0, "book.png");
            this.Icon.Images.SetKeyName(1, "Classroom.png");
            this.Icon.Images.SetKeyName(2, "classroomalt.png");
            this.Icon.Images.SetKeyName(3, "password.png");
            this.Icon.Images.SetKeyName(4, "person.png");
            this.Icon.Images.SetKeyName(5, "student.png");
            this.Icon.Images.SetKeyName(6, "lecturer.png");
            this.Icon.Images.SetKeyName(7, "Credits.png");
            this.Icon.Images.SetKeyName(8, "outline_account_circle_black_24dp.png");
            this.Icon.Images.SetKeyName(9, "outline_add_black_24dp.png");
            this.Icon.Images.SetKeyName(10, "outline_check_circle_black_24dp.png");
            this.Icon.Images.SetKeyName(11, "outline_class_black_24dp.png");
            this.Icon.Images.SetKeyName(12, "outline_delete_black_24dp.png");
            this.Icon.Images.SetKeyName(13, "outline_done_black_24dp.png");
            this.Icon.Images.SetKeyName(14, "outline_groups_black_24dp.png");
            this.Icon.Images.SetKeyName(15, "outline_login_black_24dp.png");
            this.Icon.Images.SetKeyName(16, "outline_logout_black_24dp.png");
            this.Icon.Images.SetKeyName(17, "outline_manage_accounts_black_24dp.png");
            this.Icon.Images.SetKeyName(18, "outline_people_black_24dp.png");
            this.Icon.Images.SetKeyName(19, "outline_vpn_key_black_24dp.png");
            this.Icon.Images.SetKeyName(20, "fee.png");
            this.Icon.Images.SetKeyName(21, "register.png");
            this.Icon.Images.SetKeyName(22, "mark.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Cấu Hình";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSignIn);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSignOut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnThongTin, true);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDoiMatKhau, true);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tài khoản";
            // 
            // rbDanhMuc
            // 
            this.rbDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup7});
            this.rbDanhMuc.Name = "rbDanhMuc";
            this.rbDanhMuc.Text = "Danh Mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem7, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tổ Chức";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnGiangVien, true);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSinhVien, true);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Nhân Sự";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Tác Vụ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnDKLopTC, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnNhapDiem, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnDongHocPhi, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo Cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnDSDongHocPhi);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnReportDSLTC);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnDSSVDKLTC);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnBDHM);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnPD);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo cáo";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(798, 24);
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_StatusLabel,
            this.Name_StatusLabel,
            this.Group_StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(798, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ID_StatusLabel
            // 
            this.ID_StatusLabel.Name = "ID_StatusLabel";
            this.ID_StatusLabel.Size = new System.Drawing.Size(18, 17);
            this.ID_StatusLabel.Text = "ID";
            // 
            // Name_StatusLabel
            // 
            this.Name_StatusLabel.Name = "Name_StatusLabel";
            this.Name_StatusLabel.Size = new System.Drawing.Size(39, 17);
            this.Name_StatusLabel.Text = "Name";
            // 
            // Group_StatusLabel
            // 
            this.Group_StatusLabel.Name = "Group_StatusLabel";
            this.Group_StatusLabel.Size = new System.Drawing.Size(40, 17);
            this.Group_StatusLabel.Text = "Group";
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSignIn;
        private DevExpress.XtraBars.BarButtonItem btnSignOut;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnGiangVien;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem bbtnDKLopTC;
        private DevExpress.XtraBars.BarButtonItem bbtnNhapDiem;
        private DevExpress.XtraBars.BarButtonItem bbtnDongHocPhi;
        private DevExpress.Utils.ImageCollection Icon;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ID_StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Name_StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Group_StatusLabel;
        private DevExpress.XtraBars.BarButtonItem bbtnDSDongHocPhi;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem bbtnReportDSLTC;
        private DevExpress.XtraBars.BarButtonItem bbtnDSSVDKLTC;
        private DevExpress.XtraBars.BarButtonItem bbtnBDHM;
        private DevExpress.XtraBars.BarButtonItem bbtnPD;
    }
}