using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC.View
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        String makhoa = "";
        String flag = "";
        int vitri = 0;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
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
                // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
                this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
                // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.DANGKYTableAdapter.Fill(this.DS.DANGKY);

                makhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            }
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.DANGKYTableAdapter.Fill(this.DS.DANGKY);

            makhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.m_subscribes;
            if (Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = true;
            }
            else if (Program.m_group == "KHOA")
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = true;
            }
            else if (Program.m_group == "SV")
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = false;
            }
            gbTTLop.Enabled = false;
            btnHuy.Enabled = false;
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
            Int32 maLop = 0;
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn xóa lớp này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = int.Parse(((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString());
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
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được bỏ trống!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được bỏ trống!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtKhoaHoc.Text.Trim() == "")
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
                                frmSinhVien_Load(sender, e);
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
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSinhVien_Load(sender, e);
            bdsLop.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = true;
            txtMaLop.Enabled = true;
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

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            flag = "btnThemSV";
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = btnLamMoiSV.Enabled = false;
            btnHuySV.Enabled = btnGhiSV.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled= btnGhi.Enabled = btnLamMoi.Enabled = btnHuy.Enabled = false;
            cmbKhoa.Enabled = false;
            gcLop.Enabled = false;
            gbTTLop.Enabled = false;
            vitri = bdsSinhVien.Position;
            bdsSinhVien.AddNew();
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            flag = "btnSuaSV";
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = btnLamMoiSV.Enabled = false;
            btnHuySV.Enabled = btnGhiSV.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnHuy.Enabled = false;
            cmbKhoa.Enabled = false;
            gcLop.Enabled = false;
            gbTTLop.Enabled = false;
            vitri = bdsSinhVien.Position;
            gvSinhVien.Columns[0].Visible = false;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            Int32 maSV = 0;
            if(bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã đăng ký lớp tín chỉ!", "", MessageBoxButtons.OK);
            }
            String cmd = "EXEC SP_CHECKHPBYMASV @maSV = N'" + maSV + "'";
            if(Program.ExecSqlNonQuery(cmd) != 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã đóng học phí!", "", MessageBoxButtons.OK);
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này!", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maSV = int.Parse(((DataRowView)bdsSinhVien[this.bdsSinhVien.Position])["MASV"].ToString());
                    bdsSinhVien.RemoveCurrent();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên"+ ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", maSV);
                    return;
                }
            }
            if (bdsSinhVien.Count == 0) btnXoaSV.Enabled = false;
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            try
            {
                String cmd = "EXEC SP_CHECKID  @Code ='" + txtMaLop.Text + "' , @Type = 'SINHVIEN'";
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
                                frmSinhVien_Load(sender, e);
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
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = true;
        }
    }
}
