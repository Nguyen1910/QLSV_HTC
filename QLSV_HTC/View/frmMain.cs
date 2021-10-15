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
            Group.Text = group;
            ID.Text = id;
            Name.Text = HovaTen;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
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
    }
}