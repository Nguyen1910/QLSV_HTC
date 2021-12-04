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
        private static BindingSource bds_dssv = new BindingSource();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            getListSV();
            cmbMaSV.DataSource = bds_dssv;
            cmbMaSV.DisplayMember = "MASV";

            cmbMaSV.Text = "";

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

            getListLTC(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());

            getListLTCDK(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
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

            getListLTC(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
            getListLTCDK(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListLTC(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
            getListLTCDK(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
        }

        private void btnLuuDK_Click(object sender, EventArgs e)
        {
            if (cmbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int[] selectedRows = LTCGridView.GetSelectedRows();
            int isError = 0;
            foreach (int i in selectedRows)
            {
                string sql = "SELECT COUNT(MALTC) FROM dbo.DANGKY WHERE MALTC = '" + LTCGridView.GetRowCellValue(i, "MALTC") + "' AND MASV = '" + cmbMaSV.Text.Trim() + "'";
                Program.reader = Program.ExecSqlDataReader(sql);
                if (Program.reader == null) return;
                Program.reader.Read();

                if (Program.reader.GetInt32(0) == 0)
                {
                    Program.reader.Close();
                    sql = "INSERT INTO dbo.DANGKY(MALTC,MASV,HUYDANGKY) VALUES ('" + LTCGridView.GetRowCellValue(i, "MALTC") + "','" + cmbMaSV.Text.Trim() + "','" + 0 + "');";
                    isError = Program.ExecSqlNonQuery(sql);
                    if (isError != 0)
                    {
                        MessageBox.Show("Lỗi ! Không thể đăng ký bằng cách tạo mới ", "", MessageBoxButtons.OK);
                        break;
                    }
                }
                else
                {
                    Program.reader.Close();
                    sql = "UPDATE dbo.DANGKY SET HUYDANGKY = 0 WHERE MALTC = '" + LTCGridView.GetRowCellValue(i, "MALTC") + "' AND MASV = '" + cmbMaSV.Text.Trim() + "';";
                    isError = Program.ExecSqlNonQuery(sql);
                    if (isError != 0)
                    {
                        MessageBox.Show("Lỗi ! Không thể đăng ký bằng cách cập nhật", "", MessageBoxButtons.OK);
                        break;
                    }
                }

            }

            if (isError == 0)
            {
                getListLTC(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                getListLTCDK(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                MessageBox.Show("Đăng ký thành công ! ", "", MessageBoxButtons.OK);
            }
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            int[] selectedRows = DKGridView.GetSelectedRows();
            int isError = 0;
            foreach (int i in selectedRows)
            {
                string sql = "UPDATE dbo.DANGKY SET HUYDANGKY = 1 WHERE MALTC = '" + DKGridView.GetRowCellValue(i, "MALTC") + "' AND MASV = '" + cmbMaSV.Text.Trim() + "';";
                isError = Program.ExecSqlNonQuery(sql);
                if (isError != 0)
                {
                    MessageBox.Show("Lỗi ! Không thể huỷ đăng ký ", "", MessageBoxButtons.OK);
                    break;
                }
            }

            if (isError == 0)
            {
                getListLTC(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                getListLTCDK(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                MessageBox.Show("Huỷ đăng ký thành công ! ", "", MessageBoxButtons.OK);
            }
        }

        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbMaSV_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(MASV) FROM dbo.SINHVIEN WHERE MASV = '" + cmbMaSV.Text.Trim() + "'";
            Program.reader = Program.ExecSqlDataReader(sql);
            if (Program.reader == null) return;
            Program.reader.Read();

            if (Program.reader.GetInt32(0) == 0)
            {
                Program.reader.Close();
                txtTenSV.Text = "";
                txtMaLop.Text = "";

                getListLTC(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                getListLTCDK(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
            }
            else
            {
                Program.reader.Close();
                bds_dssv.Position = bds_dssv.Find("MASV", cmbMaSV.Text);
                txtTenSV.Text = ((DataRowView)bds_dssv[bds_dssv.Position])["TENSV"].ToString();
                txtMaLop.Text = ((DataRowView)bds_dssv[bds_dssv.Position])["MALOP"].ToString();

                getListLTC(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
                getListLTCDK(cmbMaSV.Text.Trim(), cmbNienKhoa.Text.Trim(), cmbHocKy.Text.Trim());
            }
        }
    }
}