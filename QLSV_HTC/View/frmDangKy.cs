using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        private static BindingSource bds_dsnk = new BindingSource();
        private static BindingSource bds_dsltc = new BindingSource();
        private static BindingSource bds_dshk = new BindingSource();
        private static BindingSource bds_dsltcdk = new BindingSource();
        
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtMaSV.Text = Program.username;
            txtTenSV.Text = Program.m_hoTen;
            txtMaLop.Text = Program.m_lop;

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

            getListLTC(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());

            getListLTCDK(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
        }
        /*private void getListSV()
        {
            String cmd = "select * from Get_SinhVien_Info";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dssv.DataSource = dataTable;
        }*/

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

        private void getListLTC(String maSV, String nienKhoa, String hocKy)
        {
            String cmd = "exec SP_LOADLTC '" + maSV + "','" + nienKhoa + "','" + hocKy + "'";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dsltc.DataSource = dataTable;
            LTCGridControl.DataSource = bds_dsltc;
            LTCGridView.Columns["MALTC"].Visible = false;
        }


        private void getListLTCDK(String maSV, String nienKhoa, String hocKy)
        {
            String cmd = "exec SP_LOADDK '" + maSV + "','" + nienKhoa + "','" + hocKy + "'";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dsltcdk.DataSource = dataTable;
            DKGridControl.DataSource = bds_dsltcdk;
            DKGridView.Columns["MALTC"].Visible = false;
        }


        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListHocKy(cmbNienKhoa.Text.Trim());

            cmbHocKy.DataSource = bds_dshk;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";

            getListLTC(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
            getListLTCDK(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListLTC(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
            getListLTCDK(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
        }

        private void btnLuuDK_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int[] selectedRows = LTCGridView.GetSelectedRows();
            if(selectedRows.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn tín chỉ đăng ký ! ", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MALTC", (typeof(int)));
                dt.Columns.Add("MASV", (typeof(string)));
                dt.Columns.Add("HUYDANGKY", (typeof(bool)));
                foreach (int i in selectedRows)
                {
                    dt.Rows.Add(((DataRowView)bds_dsltc[i])["MALTC"], txtMaSV.Text.Trim(), 0);
                }
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKYTC";
                para.ParameterName = "@DKTC";
                para.Value = dt;
                Program.GetConnection();
                SqlCommand sqlCommand = new SqlCommand("SP_UPDATEDKLTC", Program.conn);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(para);
                sqlCommand.ExecuteNonQuery(); 
                getListLTC(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                getListLTCDK(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                MessageBox.Show("Đăng ký thành công ! ", "", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại ! Lỗi : "+ ex.Message, "", MessageBoxButtons.OK);
            }            
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int[] selectedRows = DKGridView.GetSelectedRows();
            if (selectedRows.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn tín chỉ để huỷ đăng ký ! ", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MALTC", (typeof(int)));
                dt.Columns.Add("MASV", (typeof(string)));
                dt.Columns.Add("HUYDANGKY", (typeof(bool)));
                foreach (int i in selectedRows)
                {
                    dt.Rows.Add(((DataRowView)bds_dsltcdk[i])["MALTC"], txtMaSV.Text.Trim(), 1);
                }
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKYTC";
                para.ParameterName = "@DKTC";
                para.Value = dt;
                Program.GetConnection();
                SqlCommand sqlCommand = new SqlCommand("SP_UPDATEDKLTC", Program.conn);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(para);
                sqlCommand.ExecuteNonQuery();
                getListLTC(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                getListLTCDK(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                MessageBox.Show("Huỷ đăng ký thành công ! ", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Huỷ đăng ký thất bại ! Lỗi : " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void txtMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            /*string sql = "exec SP_CHECKMASV '" + txtMaSV.Text.Trim() + "',''";
            int isError = Program.ExecSqlNonQuery(sql);
            if (isError == 1)
            {
                bds_dssv.Position = bds_dssv.Find("MASV", txtMaSV.Text);
                txtTenSV.Text = ((DataRowView)bds_dssv[bds_dssv.Position])["TENSV"].ToString();
                txtMaLop.Text = ((DataRowView)bds_dssv[bds_dssv.Position])["MALOP"].ToString();

                getListLTC(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                getListLTCDK(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
            }else
            {
                txtTenSV.Text = "";
                txtMaLop.Text = "";

                getListLTC(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                getListLTCDK(txtMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
            }*/
        }
    }
}