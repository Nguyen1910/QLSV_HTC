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
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MALTC", (typeof(int)));
                dt.Columns.Add("MASV", (typeof(string)));
                dt.Columns.Add("DIEM_CC", (typeof(int)));
                dt.Columns.Add("DIEM_GK", (typeof(float)));
                dt.Columns.Add("DIEM_CK", (typeof(float)));
                for (int i = 0; i < bds_loadDiem.Count; i++)
                {
                    dt.Rows.Add(((DataRowView)bds_loadDiem[i])["MALTC"], ((DataRowView)bds_loadDiem[i])["MASV"], ((DataRowView)bds_loadDiem[i])["DIEM_CC"], ((DataRowView)bds_loadDiem[i])["DIEM_GK"], ((DataRowView)bds_loadDiem[i])["DIEM_CK"]);
                }
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.GetConnection();

                SqlCommand sqlCommand = new SqlCommand("SP_UPDATEDIEM", Program.conn);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(para);
                sqlCommand.ExecuteNonQuery();
                this.loadDiemTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.loadDiemTableAdapter.Fill(this.DS.SP_LOADNHAPDIEM, (int)((DataRowView)bds_loadDiem[bds_loadDiem.Position])["MALTC"]);
                MessageBox.Show("Nhập điểm thành công ! ", "", MessageBoxButtons.OK);
                pnlInput.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập điểm ! " + ex.Message, "", MessageBoxButtons.OK);
                this.loadDiemTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.loadDiemTableAdapter.Fill(this.DS.SP_LOADNHAPDIEM, (int)((DataRowView)bds_loadDiem[bds_loadDiem.Position])["MALTC"]);
            }
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            btnGhi.Enabled = false;
            btnBatDau.Enabled = false;
            btnLoad.Enabled = true;
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

        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (bds_loadLTC.Position >= 0)
            {
                this.loadDiemTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.loadDiemTableAdapter.Fill(this.DS.SP_LOADNHAPDIEM, (int)((DataRowView)bds_loadLTC[bds_loadLTC.Position])["MALTC"]);
                btnGhi.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tín chỉ để nhập điểm", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void getListMH(String nienKhoa, String hocKy)
        {
            String cmd = "exec SP_GETMONHOC '" + nienKhoa + "','" + hocKy + "'";
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
            String cmd = "exec SP_GETHOCKY '" + nienKhoa + "'";
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
            String cmd = "select * from Get_NienKhoa";
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
            String cmd = "exec SP_GETNHOM '" + nienKhoa + "','" + hocKy + "','" + maMH + "'";
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


            getListHocKy(cmbNienKhoa.Text.Trim());

            cmbHocKy.DataSource = bds_dshk;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";

            getListMH(cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                this.loadLTCTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.loadLTCTableAdapter.Fill(this.DS.SP_LOADNDLTC, cmbNienKhoa.Text.Trim(), Int32.Parse(cmbHocKy.Text.Trim()));
                btnBatDau.Enabled = true;
                btnGhi.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi !"+ ex.Message,"Thông báo",MessageBoxButtons.OK);
                btnBatDau.Enabled = false;
                btnGhi.Enabled = false;
            }
            
        }
    }
}