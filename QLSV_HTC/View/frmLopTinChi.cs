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

namespace QLSV_HTC
{
    public partial class frmLopTinChi : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        int vitriKhoa = 0;
        private static BindingSource bds_dsgv = new BindingSource();
        private static BindingSource bds_dsmh = new BindingSource();
        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void getListGV()
        {
            String cmd = "select MAGV from dbo.GIANGVIEN";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dsgv.DataSource = dataTable;
            cmbMaGV.DataSource = bds_dsgv;
            cmbMaGV.DisplayMember = "MAGV";
        }

        private void getListMH()
        {
            String cmd = "select MAMH from dbo.MONHOC";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dsmh.DataSource = dataTable;
            cmbMaMH.DataSource = bds_dsmh;
            cmbMaMH.DisplayMember = "MAMH";
        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.LTCTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.LTCTableAdapter.Fill(this.DS.LOPTINCHI);
            this.DKTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.DKTableAdapter.Fill(this.DS.DANGKY);

            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.m_subscribes;

            getListGV();
            getListMH();

            if (Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            vitriKhoa = cmbKhoa.SelectedIndex;
            pnlLTC.Enabled = true;
            bdsLTC.AddNew();

            cmbMaGV.SelectedIndex = 0;
            cmbMaGV.Text = cmbMaGV.Items[0].ToString();
            cmbMaMH.SelectedIndex = 0;
            cmbMaMH.Text = cmbMaMH.Items[0].ToString();
            huyLop_checkBox.Checked = false;
            huyLop_checkBox.Enabled = false;

            txtMaKhoa.Text = ((DataRowView)Program.bds_dskhoa[vitriKhoa])["MAKHOA"].ToString();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = false;

            btnPhucHoi.Enabled = true;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            cmbKhoa.Enabled = false;
            LTCGridControl.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLTC = "";
            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Không thể xoá tín chỉ đã đăng ký trong lớp tín chỉ !", "", MessageBoxButtons.OK);
            }
            else if (MessageBox.Show("Bạn có muốn xoá lớp tín chỉ này không ? ", "Xác nhận ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLTC = ((DataRowView)bdsLTC[bdsLTC.Position])["MALTC"].ToString();
                    bdsLTC.RemoveCurrent();
                    this.LTCTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.LTCTableAdapter.Update(this.DS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá lớp tín chỉ này !" + ex.Message, "", MessageBoxButtons.OK);
                    this.LTCTableAdapter.Fill(this.DS.LOPTINCHI);
                    bdsLTC.Position = bdsLTC.Find("MALTC", maLTC);
                }
            }
            if (bdsLTC.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            LTCGridControl.Enabled = false;
            pnlLTC.Enabled = true;

            cmbMaGV.DataSource = bds_dsgv;
            cmbMaGV.DisplayMember = "MAGV";
            cmbMaGV.ValueMember = "MAGV";

            cmbMaMH.DataSource = bds_dsmh;
            cmbMaMH.DisplayMember = "MAMH";
            cmbMaMH.ValueMember = "MAMH";

            huyLop_checkBox.Enabled = true;
            txtNienKhoa.Enabled = false;
            hocKy_spinEdit.Enabled = false;
            nhom_spinEdit.Enabled = false;
            cmbMaMH.Enabled = false;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = false;

            btnPhucHoi.Enabled = true;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            cmbKhoa.Enabled = false;

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsLTC.Position = vitri;
                LTCGridControl.Enabled = true;
                pnlLTC.Enabled = false;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLamMoi.Enabled = true;

                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;

                cmbKhoa.Enabled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // check trùng, 
            if (txtNienKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập niên khoá ", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
            }
            else if (nhom_spinEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập nhóm", "", MessageBoxButtons.OK);
                nhom_spinEdit.Focus();
            }
            else if (soSVMin_spinEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập chuyên môn của giảng viên", "", MessageBoxButtons.OK);
                soSVMin_spinEdit.Focus();
            }
            else if (hocKy_spinEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập học vị của giảng viên", "", MessageBoxButtons.OK);
                hocKy_spinEdit.Focus();
            }
            else
            {
                try
                {
                    bdsLTC.EndEdit();
                    bdsLTC.ResetCurrentItem();
                    this.LTCTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.LTCTableAdapter.Update(this.DS.LOPTINCHI);
                    LTCGridControl.Enabled = true;
                    pnlLTC.Enabled = false;

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    btnLamMoi.Enabled = true;

                    btnPhucHoi.Enabled = false;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    cmbKhoa.Enabled = true;
                }
                catch (Exception ex)
                {
                    this.LTCTableAdapter.Fill(this.DS.LOPTINCHI);
                    MessageBox.Show("Lỗi ghi : " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsLTC.Position = vitri;
                LTCGridControl.Enabled = true;
                pnlLTC.Enabled = false;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLamMoi.Enabled = true;

                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                cmbKhoa.Enabled = true;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LTCTableAdapter.Fill(this.DS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload! " + ex.Message, "", MessageBoxButtons.OK);
                return;
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
                this.LTCTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.LTCTableAdapter.Fill(this.DS.LOPTINCHI);
                this.DKTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.DKTableAdapter.Fill(this.DS.DANGKY);
            }
        }
    }
}