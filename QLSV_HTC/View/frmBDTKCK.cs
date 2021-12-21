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
    public partial class frmBDTKCK : DevExpress.XtraEditors.XtraForm
    {
        private static BindingSource bds_dslop = new BindingSource();
        private static String khoaHoc = "";
        public frmBDTKCK()
        {
            InitializeComponent();
        }

        private void frmBDTKCK_Load(object sender, EventArgs e)
        {

            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";

            getListLop();
            cmbLop.DataSource = bds_dslop;
            cmbLop.DisplayMember = "TENLOP";
            cmbLop.ValueMember = "MALOP";
            cmbLop.SelectedIndex = 0;

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
                getListLop();
                cmbLop.DataSource = bds_dslop;
                cmbLop.DisplayMember = "TENLOP";
                cmbLop.ValueMember = "MALOP";
                cmbLop.SelectedIndex = 0;

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (frmPrint frm = new frmPrint())
            {
                frm.PrintBDTKCK(cmbKhoa.Text.Trim(),cmbLop.SelectedValue.ToString(),cmbLop.Text.Trim(), khoaHoc);
                frm.ShowDialog();
            }
        }

        private void getListLop()
        {
            String cmd = "SELECT MALOP,TENLOP,KHOAHOC FROM dbo.LOP";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dslop.DataSource = dataTable;
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLop.SelectedIndex >= 0)
            {
                khoaHoc = ((DataRowView)bds_dslop[cmbLop.SelectedIndex])["KHOAHOC"].ToString();
            }
        }
    }
}