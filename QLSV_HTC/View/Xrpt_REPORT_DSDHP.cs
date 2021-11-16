using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLSV_HTC.View
{
    public partial class Xrpt_REPORT_DSDHP : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_REPORT_DSDHP(String nienKhoa, int hocKy, String maLop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maLop;
            this.sqlDataSource1.Fill();
        }
    }
}
