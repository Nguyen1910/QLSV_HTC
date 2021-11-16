using DevExpress.XtraReports.UI;
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
    
    public partial class frmDSDongHocPhi : DevExpress.XtraEditors.XtraForm
    {
        int  hocKy = 0;
        String nienKhoa = "", tenKhoa = "", maLop = "";
        public frmDSDongHocPhi()
        {
            InitializeComponent();
        }

        private void frmDSDongHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSHP.TENLOP' table. You can move, or remove it, as needed.
            DSHP.EnforceConstraints = false;
            this.TENLOPTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.TENLOPTableAdapter.Fill(this.DSHP.TENLOP);
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTENLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSHP);

        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maLop = cbbTenLop.SelectedValue.ToString();
                tenKhoa = ((DataRowView)bdsTENLOP[bdsTENLOP.Position])["TENKHOA"].ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                hocKy = int.Parse(cbbHocKy.Text);
                nienKhoa = cbbNienKhoa.Text;
                //MessageBox.Show(nienKhoa + ", " + hocKy + ", " + maLop + ", " + tenKhoa, cbbTenLop.Text, MessageBoxButtons.OK);
                Xrpt_REPORT_DSDHP rpt = new Xrpt_REPORT_DSDHP(nienKhoa, hocKy, maLop);
                rpt.lblMaLop.Text = maLop;
                rpt.lblKhoa.Text = tenKhoa;
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(nienKhoa+", " + hocKy + ", "+ maLop + ", "+tenKhoa, "", MessageBoxButtons.OK);
            }
        }
    }
}
