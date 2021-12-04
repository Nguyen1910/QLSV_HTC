using DevExpress.XtraBars;
using QLSV_HTC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private Form CheckExits(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype) return f;
            return null;
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmLop));
            if (f != null) f.Activate();
            else
            {
                frmLop frm = new frmLop();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmMonHoc));
            if (f != null) f.Activate();
            else
            {
               frmMonHoc frm = new frmMonHoc();
            frm.MdiParent = this;
            frm.Show();
            }
            
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmLopTinChi));
            if (f != null) f.Activate();
            else
            {
            frmLopTinChi frm = new frmLopTinChi();
            frm.MdiParent = this;
            frm.Show();

            }
        }

        public void infoUser_Load(String id,String HovaTen,String group)
        {
            Group_StatusLabel.Text = group;
            ID_StatusLabel.Text = id;
            Name_StatusLabel.Text = HovaTen;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Bạn có muốn đóng ứng dụng ?", "Đóng Ứng Dụng", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    Program.f_login.Close();
                    break;
                default:                  
                    break;
            }
        }

        private void btnGiangVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmGiangVien));
            if (f != null) f.Activate();
            else
            {
                frmGiangVien frm = new frmGiangVien();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmSinhVien));
            if (f != null) f.Activate();
            else
            {
                frmSinhVien frm = new frmSinhVien();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmHocPhi));
            if (f != null) f.Activate();
            else
            {
                frmHocPhi frm = new frmHocPhi();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Program.m_group == "PKT")
            {
                this.bbtnDKLopTC.Enabled = false;
                this.bbtnNhapDiem.Enabled = false;
                this.bbtnDongHocPhi.Enabled = true;
                this.rbDanhMuc.Visible = false;
            }
            else if(Program.m_group == "SV")
            {
                this.bbtnDongHocPhi.Enabled = false;
            }
            else
            {
                this.bbtnDongHocPhi.Enabled = false;
            }
        }

        private void bbtnDSDongHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmDSDongHocPhi));
            if (f != null) f.Activate();
            else
            {
                frmDSDongHocPhi frm = new frmDSDongHocPhi();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmTaoTaiKhoan));
            if (f != null) f.Activate();
            else
            {
                frmTaoTaiKhoan frm = new frmTaoTaiKhoan();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnSignOut_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void bbtnDKLopTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmHocPhi));
            if (f != null) f.Activate();
            else
            {
                frmDangKy frm = new frmDangKy();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void bbtnNhapDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmHocPhi));
            if (f != null) f.Activate();
            else
            {
                frmNhapDiem frm = new frmNhapDiem();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void bbtnReportDSLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmHocPhi));
            if (f != null) f.Activate();
            else
            {
                frmDSLTC frm = new frmDSLTC();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void bbtnDSSVDKLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmHocPhi));
            if (f != null) f.Activate();
            else
            {
                frmDSSVDKLTC frm = new frmDSSVDKLTC();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void bbtnBDHM_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmHocPhi));
            if (f != null) f.Activate();
            else
            {
                frmBDHM frm = new frmBDHM();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void bbtnPD_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExits(typeof(frmHocPhi));
            if (f != null) f.Activate();
            else
            {
                frmPDSV frm = new frmPDSV();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}