using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLSV_HTC.View
{
    public partial class rpBDTKCK : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBDTKCK(String maLop)
        {
            InitializeComponent();
            CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(Program.connectStr);
            this.sqlDataSource1.ConnectionParameters = connectionParameters;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Fill();
        }

    }
}
