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
        String makhoa = "";
        int vitri = 0;
        String flag = "";
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
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
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
            gbTTLop.Enabled = false;
            btnHuy.Enabled = false;
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = "btnThem";
            vitri = bdsLop.Position;
            bdsLop.AddNew();
            txtMaKhoa.Text = makhoa;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = true;
            gbTTLop.Enabled = true;
            gcLop.Enabled = false;
            cmbKhoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLop = "";
            if(bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn xóa lớp này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.LOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại " + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(this.DS.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = "btnSua";
            txtMaLop.Enabled = false;
            vitri = bdsLop.Position;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = true;
            gbTTLop.Enabled = true;
            gcLop.Enabled = false;
            cmbKhoa.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTableAdapter.Fill(this.DS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload:" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaLop.Text.Trim()== "")
            {
                MessageBox.Show("Mã lớp không được bỏ trống!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if(txtTenLop.Text.Trim()== "")
            {
                MessageBox.Show("Tên lớp không được bỏ trống!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }if(txtKhoaHoc.Text.Trim()== "")
            {
                MessageBox.Show("Khóa học không được bỏ trống!", "", MessageBoxButtons.OK);
                txtKhoaHoc.Focus();
                return;
            }
            try
            {
                String cmd = "EXEC SP_CHECKID  @Code ='" + txtMaLop.Text + "' , @Type = 'MALOP'";
                switch (flag)
                {
                    case "btnThem":
                        {
                            if (Program.ExecSqlNonQuery(cmd) == 0)
                            {
                                bdsLop.EndEdit();
                                bdsLop.ResetCurrentItem();
                                this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.LOPTableAdapter.Update(this.DS.LOP);
                            }
                            else
                            {
                                bdsLop.EndEdit();
                                this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.LOPTableAdapter.Fill(this.DS.LOP);
                                bdsLop.Position = vitri;
                                MessageBox.Show("Lớp đã tồi tại", "", MessageBoxButtons.OK);
                            }
                            break;
                        }
                    case "btnSua":
                        {
                            bdsLop.EndEdit();
                            bdsLop.ResetCurrentItem();
                            this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                            this.LOPTableAdapter.Update(this.DS.LOP);
                            bdsLop.Position = vitri;
                            txtMaLop.Enabled = true;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnHuy.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = true;
            if(Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            bdsLop.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = true;
            txtMaLop.Enabled = true;
            if (Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
        }
    }
}