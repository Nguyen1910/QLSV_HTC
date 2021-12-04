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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        const int tongSoTiet = 45;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.MHTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.MHTableAdapter.Fill(this.DS.MONHOC);
            this.LTCTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.LTCTableAdapter.Fill(this.DS.LOPTINCHI);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            pnlNhapMonHoc.Enabled = true;
            bdsMH.AddNew();

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = false;

            btnPhucHoi.Enabled = true;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            MHGridControl.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMH = "";
            if (bdsLopTC.Count > 0)
            {
                MessageBox.Show("Không thể xoá môn học đã đăng ký trong lớp tín chỉ !", "", MessageBoxButtons.OK);
            }
            else if (MessageBox.Show("Bạn có muốn xoá môn học này không ? ", "Xác nhận ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maMH = ((DataRowView)bdsMH[bdsMH.Position])["MAMH"].ToString();
                    bdsMH.RemoveCurrent();
                    this.MHTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.MHTableAdapter.Update(this.DS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá môn học !" + ex.Message, "", MessageBoxButtons.OK);
                    this.MHTableAdapter.Fill(this.DS.MONHOC);
                    bdsMH.Position = bdsMH.Find("MAMH", maMH);
                }
            }
            if (bdsMH.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsMH.Position = vitri;
                MHGridControl.Enabled = true;
                pnlNhapMonHoc.Enabled = false;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLamMoi.Enabled = true;

                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsMH.Position = vitri;
                MHGridControl.Enabled = true;
                pnlNhapMonHoc.Enabled = false;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLamMoi.Enabled = true;

                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            MHGridControl.Enabled = false;
            pnlNhapMonHoc.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = false;

            btnPhucHoi.Enabled = true;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.MHTableAdapter.Fill(this.DS.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload! " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập mã môn học", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
            }
            else if (txtTenMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập tên môn học", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
            }
            else if (soTiet_LT_spinEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập số tiết lý thuyết", "", MessageBoxButtons.OK);
                soTiet_LT_spinEdit.Focus();
            }
            else if (soTiet_TH_spinEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cần nhập số tiêt thực hành", "", MessageBoxButtons.OK);
                soTiet_TH_spinEdit.Focus();
            }
            else
            {
                try
                {
                    bdsMH.EndEdit();
                    bdsMH.ResetCurrentItem();
                    this.MHTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.MHTableAdapter.Update(this.DS.MONHOC);
                    MHGridControl.Enabled = true;
                    pnlNhapMonHoc.Enabled = false;

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    btnLamMoi.Enabled = true;

                    btnPhucHoi.Enabled = false;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi : " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void soTiet_LT_spinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (pnlNhapMonHoc.Enabled == true && soTiet_LT_spinEdit.Text.Trim().Length > 0)
            {
                int soTiet_LT = ((int)soTiet_LT_spinEdit.Value);
                if (soTiet_LT > tongSoTiet || soTiet_LT < 0)
                {
                    MessageBox.Show("Tổng số tiết của một môn học là " + tongSoTiet + ".\n Hãy nhập lại! ", "", MessageBoxButtons.OK);
                    soTiet_LT_spinEdit.Focus();
                }
                else
                {
                    soTiet_TH_spinEdit.EditValue = tongSoTiet - ((int)soTiet_LT_spinEdit.Value);
                }
            }
        }

        private void soTiet_TH_spinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (pnlNhapMonHoc.Enabled == true && soTiet_TH_spinEdit.Text.Trim().Length > 0)
            {
                int soTiet_TH = ((int)soTiet_TH_spinEdit.Value);
                if (soTiet_TH > tongSoTiet || soTiet_TH < 0)
                {
                    MessageBox.Show("Tổng số tiết của một môn học là " + tongSoTiet + ".\n Hãy nhập lại! ", "", MessageBoxButtons.OK);
                    soTiet_TH_spinEdit.Focus();
                }
                else
                {
                    soTiet_LT_spinEdit.EditValue = tongSoTiet - ((int)soTiet_TH_spinEdit.Value);
                }
            }
        }
    }
}