using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC.View
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHocPhi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSHP);

        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            DSHP.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DSHP.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.SINHVIENTableAdapter.Fill(this.DSHP.SINHVIEN);
            // TODO: This line of code loads data into the 'DSHP.HOCPHI' table. You can move, or remove it, as needed.
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
            this.HOCPHITableAdapter.Fill(this.DSHP.HOCPHI);
            // TODO: This line of code loads data into the 'DSHP.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            this.CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
            this.CT_DONGHOCPHITableAdapter.Fill(this.DSHP.CT_DONGHOCPHI);

            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gbTTHP.Enabled = false;
            gbTTSV.Enabled = true;
            contextMenuStrip1.Enabled = false;
            gcHocPhi.Enabled = gcCTHP.Enabled = false;        
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSHP);
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            String cmd = "EXEC SP_CHECKID  @Code ='" + txtMaSV.Text + "' , @Type = 'MASV'";
            if (Program.ExecSqlNonQuery(cmd) != 0)
            {
                bdsSV.Position = bdsSV.Find("MASV", txtMaSV.Text);
                txtHo.Text = ((DataRowView)bdsSV[bdsSV.Position])["HO"].ToString();
                txtTen.Text = ((DataRowView)bdsSV[bdsSV.Position])["TEN"].ToString();
                txtMaLop.Text = ((DataRowView)bdsSV[bdsSV.Position])["MALOP"].ToString();

                btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
                gbTTHP.Enabled = false;
                gbTTSV.Enabled = true;
                contextMenuStrip1.Enabled = true;
                gcHocPhi.Enabled = gcCTHP.Enabled = true;
                if (bdsHocPhi.Count == 0)
                {
                    contextMenuStrip1.Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Enabled = true;
                }
                gvCTHP.OptionsBehavior.ReadOnly = true;
            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = false;
                gbTTHP.Enabled = false;
                gbTTSV.Enabled = true;
                contextMenuStrip1.Enabled = false;
                gcHocPhi.Enabled = gcCTHP.Enabled = false;
            }
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gbTTHP.Enabled = true;
            gbTTSV.Enabled = false;
            contextMenuStrip1.Enabled = false;

            bdsHocPhi.AddNew();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            gvCTHP.OptionsBehavior.ReadOnly = false;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            gvCTHP.OptionsBehavior.ReadOnly = false;
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {


            gvCTHP.OptionsBehavior.ReadOnly = true;
        }

        private void btnHuySV_Click(object sender, EventArgs e)
        {
            gvCTHP.OptionsBehavior.ReadOnly = true;
        }

        private void btnPhucHoiSV_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoiSV_Click(object sender, EventArgs e)
        {

        }
    }
}
