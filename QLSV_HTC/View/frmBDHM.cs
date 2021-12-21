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
    public partial class frmBDHM : DevExpress.XtraEditors.XtraForm
    {
        private static BindingSource bds_dsmh = new BindingSource();
        private static BindingSource bds_dsnk = new BindingSource();
        private static BindingSource bds_dshk = new BindingSource();
        private static BindingSource bds_dsnhom = new BindingSource();
        public frmBDHM()
        {
            InitializeComponent();
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
                if (cmbMaMH.SelectedIndex >= 0)
                {
                    getListNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMaMH.SelectedValue.ToString());
                }
            }
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListHocKy(cmbNienKhoa.Text);
            if (cmbMaMH.SelectedIndex >= 0)
            {
                getListNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMaMH.SelectedValue.ToString());
            }
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListMH(cmbNienKhoa.Text, cmbHocKy.Text);
            if (cmbMaMH.SelectedIndex >= 0)
            {
                getListNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMaMH.SelectedValue.ToString());
            }
        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMaMH.SelectedValue.ToString());
        }

        private void cmbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBDHM_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";

            getListNienKhoa();

            cmbMaMH.DataSource = bds_dsmh;
            cmbMaMH.DisplayMember = "TENMH";
            cmbMaMH.ValueMember = "MAMH";
            cmbMaMH.SelectedIndex = 0;

            getListNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMaMH.SelectedValue.ToString());

            if (Program.m_subscribes < 2)
            {
                cmbKhoa.SelectedIndex = Program.m_subscribes;
            }
            else
            {
                cmbKhoa.SelectedIndex = 0;
            }
            if (Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (frmPrint frm = new frmPrint())
            {
                frm.PrintBDHM(cmbKhoa.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim(), cmbMaMH.SelectedValue.ToString(), cmbMaMH.Text.Trim(), cmbNhom.Text.Trim());
                frm.ShowDialog();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {

        }
        private void getListMH(String nienKhoa, String hocKy)
        {
            String cmd = "select distinct ltc.MAMH, TENMH = (SELECT TENMH FROM dbo.MONHOC WHERE ltc.MAMH = MAMH) from dbo.LOPTINCHI ltc WHERE ltc.NIENKHOA = '" + nienKhoa + "' AND ltc.HOCKY = '" + hocKy + "'";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dsmh.DataSource = dataTable;
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
            cmbHocKy.DataSource = bds_dshk;
            cmbHocKy.DisplayMember = "HOCKY";
            getListMH(cmbNienKhoa.Text, cmbHocKy.Text);
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
            cmbNienKhoa.DataSource = bds_dsnk;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            getListHocKy(cmbNienKhoa.Text);
        }

        private void getListNhom(String nienKhoa, String hocKy, String maMH)
        {
            String cmd = "select distinct NHOM from dbo.LOPTINCHI WHERE (NIENKHOA = '" + nienKhoa + "' AND  HOCKY = '" + hocKy + "') AND MAMH = '" + maMH + "'";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dsnhom.DataSource = dataTable;
            cmbNhom.DataSource = bds_dsnhom;
            cmbNhom.DisplayMember = "NHOM";
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}