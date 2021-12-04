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
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        private static BindingSource bds_dsmh = new BindingSource();
        private static BindingSource bds_dsnk = new BindingSource();
        private static BindingSource bds_dshk = new BindingSource();
        private static BindingSource bds_dsnhom = new BindingSource();
        private static BindingSource bds_dsdk = new BindingSource();
        public frmNhapDiem()
        {
            InitializeComponent();
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            getListND(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim(), cmbMaMH.Text.Trim(), cmbNhom.Text.Trim());

            pnlInput.Enabled = true;

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            int countRows = ((DataTable)bds_dsdk.DataSource).Rows.Count; ;
            int isError = 0;
            for (int i = 0; i < countRows; i++)
            {
                String sql = "UPDATE dbo.DANGKY SET DIEM_CC = " + NDGridView.GetRowCellValue(i, "DIEM_CC") +
                    ", DIEM_GK = " + NDGridView.GetRowCellValue(i, "DIEM_GK") + ", DIEM_CK = " + NDGridView.GetRowCellValue(i, "DIEM_CK") +
                    " WHERE MALTC = '" + NDGridView.GetRowCellValue(i, "MALTC") + "' AND MASV = '" + NDGridView.GetRowCellValue(i, "MASV") + "';";
                isError = Program.ExecSqlNonQuery(sql);
                if (isError != 0)
                {
                    MessageBox.Show("Lỗi ! Không thể cập nhật điểm ", "", MessageBoxButtons.OK);
                    break;
                }
            }


            if (isError == 0)
            {
                getListND(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim(), cmbMaMH.Text.Trim(), cmbNhom.Text.Trim());
                MessageBox.Show("Nhập điểm thành công ! ", "", MessageBoxButtons.OK);
            }

            pnlInput.Enabled = true;

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            loadForm();
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
                loadForm();
            }
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListHocKy(cmbNienKhoa.Text.Trim());

            cmbHocKy.DataSource = bds_dshk;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";


            getListMH(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());

            cmbMaMH.DataSource = bds_dsmh;
            cmbMaMH.DisplayMember = "MAMH";
            cmbMaMH.ValueMember = "MAMH";

            getListNhom(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim(), cmbMaMH.Text.Trim());

            cmbNhom.DataSource = bds_dsnhom;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";

        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListMH(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());

            cmbMaMH.DataSource = bds_dsmh;
            cmbMaMH.DisplayMember = "TENMH";
            cmbMaMH.ValueMember = "MAMH";

            getListNhom(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim(), cmbMaMH.Text.Trim());

            cmbNhom.DataSource = bds_dsnhom;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";

        }

        private void cmbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListNhom(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim(), cmbMaMH.Text.Trim());

            cmbNhom.DataSource = bds_dsnhom;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            getListND(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim(), cmbMaMH.Text.Trim(), cmbNhom.Text.Trim());
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            pnlInput.Enabled = false;
        }

        private void getListND(String nienKhoa, String hocKy, String maMH, String nhom)
        {
            String cmd = "exec SP_LOADNHAPDIEM '" + nienKhoa + "','" + hocKy + "','" + maMH + "','" + nhom + "'";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dsdk.DataSource = dataTable;
            NDGridControl.DataSource = bds_dsdk;
            NDGridView.Columns["MALTC"].Visible = false;
            NDGridView.Columns["MASV"].OptionsColumn.ReadOnly = true;
            NDGridView.Columns["TENSV"].OptionsColumn.ReadOnly = true;
            NDGridView.Columns["DIEM_HM"].OptionsColumn.ReadOnly = true;
        }

        private void getListMH(String nienKhoa, String hocKy) //, TENMH = (SELECT TENMH FROM dbo.MONHOC WHERE ltc.MAMH = MAMH)
        {
            String cmd = "select distinct ltc.MAMH from dbo.LOPTINCHI ltc WHERE ltc.NIENKHOA = '" + nienKhoa + "' AND ltc.HOCKY = '" + hocKy + "'";
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
        }

        private void loadForm()
        {

            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";

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

            cmbHocKy.SelectedIndex = 0;
            cmbHocKy.Text = cmbHocKy.Items[0].ToString();

            getListMH(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());

            cmbMaMH.DataSource = bds_dsmh;
            cmbMaMH.DisplayMember = "TENMH";
            cmbMaMH.ValueMember = "MAMH";

            cmbMaMH.SelectedIndex = 0;
            cmbMaMH.Text = cmbMaMH.Items[0].ToString();

            getListNhom(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim(), cmbMaMH.Text.Trim());

            cmbNhom.DataSource = bds_dsnhom;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";

            cmbNhom.SelectedIndex = 0;
            cmbNhom.Text = cmbNhom.Items[0].ToString();

        }


    }
}