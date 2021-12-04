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
    public partial class frmGiangVien : DevExpress.XtraEditors.XtraForm
    {
        private String temp_servername = Program.servername;
        int vitri = 0;
        int change_server = 0;
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.GVTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.GVTableAdapter.Fill(this.DS.GIANGVIEN);
            this.LTCTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.LTCTableAdapter.Fill(this.DS.LOPTINCHI);

            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "MAKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
            pnlGV.Enabled = true;
            bdsGV.AddNew();

            if (Program.m_group == "PGV")
            {
                cmbKhoa.Enabled = true;
            }

            cmbKhoa.DataSource = Program.bds_dskhoa;
            cmbKhoa.DisplayMember = "MAKHOA";
            cmbKhoa.SelectedIndex = 0;
            cmbKhoa.Text = cmbKhoa.Items[0].ToString();


            cmbKhoa.SelectedIndex = Program.m_subscribes;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = false;
            txtMaGV.Enabled = true;

            btnPhucHoi.Enabled = true;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            GVGridControl.Enabled = false;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = "";
            if (bdsLTC.Count > 0)
            {
                MessageBox.Show("Không thể xoá giảng viên đã đăng ký trong lớp tín chỉ !", "", MessageBoxButtons.OK);
            }
            else if (MessageBox.Show("Bạn có muốn xoá giảng viên này không ? ", "Xác nhận ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maGV = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();
                    bdsGV.RemoveCurrent();
                    this.GVTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.GVTableAdapter.Update(this.DS.GIANGVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá giảng viên !" + ex.Message, "", MessageBoxButtons.OK);
                    this.GVTableAdapter.Fill(this.DS.GIANGVIEN);
                    bdsGV.Position = bdsGV.Find("MAGV", maGV);
                }
            }
            if (bdsGV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
            GVGridControl.Enabled = false;
            pnlGV.Enabled = true;

            txtMaGV.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = false;

            btnPhucHoi.Enabled = true;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsGV.Position = vitri;
                GVGridControl.Enabled = true;
                pnlGV.Enabled = false;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLamMoi.Enabled = true;

                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                cmbKhoa.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập mã giảng viên", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
            }
            else if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập họ giảng viên", "", MessageBoxButtons.OK);
                txtHo.Focus();
            }
            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập tên giảng viên", "", MessageBoxButtons.OK);
                txtTen.Focus();
            }
            else
            {
                try
                {
                    bdsGV.EndEdit();
                    bdsGV.ResetCurrentItem();

                    if (change_server == 0)
                    {
                        this.GVTableAdapter.Connection.ConnectionString = Program.connectStr;
                        this.GVTableAdapter.Update(this.DS.GIANGVIEN);
                    }
                    else
                    {
                        Program.conn.Close();
                        String connectChangedStr = Program.changeConnectStr(cmbKhoa.SelectedValue.ToString(), Program.remotelogin, Program.remotepassword);
                        if (Program.GetConnection(connectChangedStr) == 0)
                        {
                            MessageBox.Show("Lỗi không thể thêm giảng viên !", "", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            this.GVTableAdapter.Connection.ConnectionString = connectChangedStr;
                            this.GVTableAdapter.Update(DS.GIANGVIEN);
                        }
                        Program.GetConnection();
                        change_server = 0;
                    }

                    GVGridControl.Enabled = true;
                    pnlGV.Enabled = false;

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    btnLamMoi.Enabled = true;

                    btnPhucHoi.Enabled = false;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    cmbKhoa.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi : " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsGV.Position = vitri;
                GVGridControl.Enabled = true;
                pnlGV.Enabled = false;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLamMoi.Enabled = true;

                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                cmbKhoa.Enabled = false;
            }

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.GVTableAdapter.Fill(this.DS.GIANGVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload! " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedIndex == Program.m_subscribes)
            {
                change_server = 0;
            }
            else
            {
                change_server = 1;
            }
        }
    }
}
