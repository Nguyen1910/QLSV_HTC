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
        String maSV = "";
        int vitriLop = 0, vitriSV = 0; 
        int vitriKhoa = 0;
        String flag = "";
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
                this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
                // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.DANGKYTableAdapter.Fill(this.DS.DANGKY);
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
            // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.DANGKYTableAdapter.Fill(this.DS.DANGKY);

            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";

            cmbKhoa.SelectedIndex = Program.m_subscribes;

            if (Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
                btnGhi.Enabled  = btnPhucHoi.Enabled = btnHuy.Enabled =false;
            }
            else if (Program.m_group == "KHOA")
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
            }
            else if (Program.m_group == "SV")
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
            gbTTLop.Enabled = false;
            btnGhiSV.Enabled = btnHuySV.Enabled = btnPhucHoiSV.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count == 0) return;
            flag = "btnThem";
            vitriLop = bdsLop.Position;
            vitriKhoa = cmbKhoa.SelectedIndex;
            bdsLop.AddNew();
            txtMaKhoa.Text = ((DataRowView)Program.bds_dskhoa[vitriKhoa])["MAKHOA"].ToString();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = true;
            gbTTLop.Enabled = true;
            gcLop.Enabled = false;
            cmbKhoa.Enabled = false;
            contextMenuStrip1.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count == 0) return;
            String maLop = "";
            if (bdsSV.Count > 0)
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
            vitriLop = bdsLop.Position;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = true;
            gbTTLop.Enabled = true;
            gcLop.Enabled = false;
            cmbKhoa.Enabled = false;
            contextMenuStrip1.Enabled = false;
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
                                this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.LOPTableAdapter.Fill(this.DS.LOP);
                                bdsLop.Position = vitriLop;
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
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = true;
            contextMenuStrip1.Enabled = true;
            if (Program.m_group == "PGV")
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
            frmSinhVien_Load(sender, e);
            bdsLop.Position = vitriLop;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = true;
            txtMaLop.Enabled = true;
            contextMenuStrip1.Enabled = true;
            if (Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSinhVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload:" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

/*-----------------------======= event SubForm ===========------------------*/
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            flag = "btnThemSV";
            vitriLop = bdsLop.Position;
            vitriSV = bdsSV.Position;
            bdsSV.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = false;
            cmbKhoa.Enabled = false;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = btnLamMoiSV.Enabled = false;
            btnPhucHoiSV.Enabled = btnGhiSV.Enabled = btnHuySV.Enabled = true;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (bdsSV.Count == 0) return;
            vitriSV = bdsSV.Position;
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã đăng ký lớp!", "", MessageBoxButtons.OK);
                return;
            }
            maSV = ((DataRowView)bdsSV[this.bdsSV.Position])["MASV"].ToString();
            String cmd = "EXEC SP_CHECKHPBYMASV @maSV= '" + maSV + "'";
            if (Program.ExecSqlNonQuery(cmd) != 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã đóng học phí!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn xóa sinh viên này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsSV.RemoveCurrent();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.LOPTableAdapter.Update(this.DS.LOP);
                    bdsLop.Position = vitriLop;
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    bdsSV.Position = vitriSV;
                    bdsLop.Position = vitriLop;
                    return;
                }
            }
            if (bdsSV.Count == 0) btnXoaSV.Enabled = false;
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (bdsSV.Count == 0) return;
            flag = "btnSuaSV";
            vitriLop = bdsLop.Position;
            vitriSV = bdsSV.Position;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = false;
            cmbKhoa.Enabled = false;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = btnLamMoiSV.Enabled = false;
            btnPhucHoiSV.Enabled = btnGhiSV.Enabled = btnHuySV.Enabled = true;
            colMALOP1.OptionsColumn.ReadOnly = true;
        }

        private void btnPhucHoiSV_Click(object sender, EventArgs e)
        {

        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        { 
            maSV = ((DataRowView)bdsSV[this.bdsSV.Position])["MASV"].ToString();
            try
            { 
                String cmd = "EXEC SP_CHECKID  @Code ='" + maSV + "' , @Type = 'MASV'";
                switch (flag)
                {
                    case "btnThemSV":
                        {
                            if (Program.ExecSqlNonQuery(cmd) == 0)
                            {
                                bdsSV.EndEdit();
                                bdsSV.ResetCurrentItem();
                                this.LOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.LOPTableAdapter.Update(this.DS.LOP);
                                bdsLop.Position = vitriLop;
                                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                                MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                            }
                            else
                            {
                                bdsSV.EndEdit();
                                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                                bdsLop.Position = vitriLop;
                                bdsSV.Position = vitriSV;
                                MessageBox.Show("Sinh viên đã tồi tại", "", MessageBoxButtons.OK);
                            }
                            break;
                        }
                    case "btnSuaSV":
                        {
                            bdsLop.EndEdit();
                            bdsLop.ResetCurrentItem();
                            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                            this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
            gbTTLop.Enabled = false;
            gcLop.Enabled = true;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = btnLamMoiSV.Enabled = true;
            btnPhucHoiSV.Enabled = btnGhiSV.Enabled = btnHuySV.Enabled = false;
            colMALOP1.OptionsColumn.ReadOnly = false;
            if (Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void btnHuySV_Click(object sender, EventArgs e)
        {
            frmSinhVien_Load(sender, e);
            bdsLop.Position = vitriLop;
            bdsSV.Position = vitriSV;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled  = btnHuy.Enabled = false;
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
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = btnLamMoiSV.Enabled = true;
            btnPhucHoi.Enabled = btnGhiSV.Enabled = btnHuySV.Enabled =  false;
            colMALOP1.OptionsColumn.ReadOnly = false;
        }

        private void btnLamMoiSV_Click(object sender, EventArgs e)
        {
            try
            {
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload:" + ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }
}
