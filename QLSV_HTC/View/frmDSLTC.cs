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
    public partial class frmDSLTC : DevExpress.XtraEditors.XtraForm
    {
        private static BindingSource bds_dsnk = new BindingSource();
        private static BindingSource bds_dshk = new BindingSource();
        public frmDSLTC()
        {
            InitializeComponent();
        }

        private void frmDSLTC_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.m_subscribes;

            getListNienKhoa();

            cmbNienKhoa.DataSource = bds_dsnk;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";

            cmbNienKhoa.SelectedIndex = 0;
            cmbNienKhoa.Text = cmbNienKhoa.Items[0].ToString();

            getListHocKy(cmbNienKhoa.Text.Trim());

            cmbHocKy.DataSource = bds_dshk;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (frmPrint frm = new frmPrint())
            {
                frm.PrintDSLTC(cmbKhoa.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                frm.ShowDialog();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {

        }

        private void getListHocKy(String nienKhoa)
        {
            String cmd = "select distinct HOCKY from dbo.LOPTINCHI WHERE NIENKHOA = '" + nienKhoa + "'";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dshk.DataSource = dataTable;
        }

        private void getListNienKhoa()
        {
            String cmd = "select distinct NIENKHOA from dbo.LOPTINCHI";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dsnk.DataSource = dataTable;

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cmbKhoa.SelectedValue.ToString();
            if (cmbKhoa.SelectedIndex != Program.m_subscribes)
            {
                Program.m_login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.m_login = Program.m_loginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.GetConnection() == 0)
            {
                MessageBox.Show("Lỗi kết nối chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {

                getListNienKhoa();

                cmbNienKhoa.DataSource = bds_dsnk;
                cmbNienKhoa.DisplayMember = "NIENKHOA";
                cmbNienKhoa.ValueMember = "NIENKHOA";

                cmbNienKhoa.SelectedIndex = 0;
                cmbNienKhoa.Text = cmbNienKhoa.Items[0].ToString();

                getListHocKy(cmbNienKhoa.Text.Trim());

                cmbHocKy.DataSource = bds_dshk;
                cmbHocKy.DisplayMember = "HOCKY";
                cmbHocKy.ValueMember = "HOCKY";
            }
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListHocKy(cmbNienKhoa.Text.Trim());

            cmbHocKy.DataSource = bds_dshk;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}