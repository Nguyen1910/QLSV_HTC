using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        String makhoa;
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            makhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.m_subscribes;
            if(Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = true;
            } 
            else if (Program.m_group == "KHOA") {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = true;
            }
            else if (Program.m_group == "SV") {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            if(cmbKhoa.SelectedIndex != Program.m_subscribes)
            {
                Program.m_login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.m_login = Program.m_loginDN;
                Program.password = Program.passwordDN;
            }
            if(Program.GetConnection() == 0)
            {
                MessageBox.Show("Lỗi kết nối chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
                // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

                makhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            }
        }
    }
}