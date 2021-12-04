using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC.View
{
    public partial class frmPDSV : DevExpress.XtraEditors.XtraForm
    {
        private static BindingSource bds_dssv = new BindingSource();
        public frmPDSV()
        {
            InitializeComponent();
        }

        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (frmPrint frm = new frmPrint())
            {
                frm.PrintPDSV(cmbMaSV.Text.Trim());
                frm.ShowDialog();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {

        }

        private void getListSV()
        {
            String cmd = "select MASV, HO + ' ' + TEN AS TENSV, MALOP FROM dbo.SINHVIEN";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dssv.DataSource = dataTable;
        }

        private void frmPDSV_Load(object sender, EventArgs e)
        {
            getListSV();
            cmbMaSV.DataSource = bds_dssv;
            cmbMaSV.DisplayMember = "MASV";
            cmbMaSV.ValueMember = "TENSV";
        }
    }
}