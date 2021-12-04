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
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        String flag = "";
        int vitriHP = 0, vitriCTHP = 0;
        int totalHPDaDong = 0;
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHocPhi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSHP);

        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            DSHP.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DSHP.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.SINHVIENTableAdapter.Fill(this.DSHP.SINHVIEN);
            // TODO: This line of code loads data into the 'DSHP.HOCPHI' table. You can move, or remove it, as needed.
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
            this.HOCPHITableAdapter.FillDetail(this.DSHP.HOCPHI);
            this.CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
            this.CT_DONGHOCPHITableAdapter.Fill(this.DSHP.CT_DONGHOCPHI);

            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gbTTHP.Enabled = false;
            gbTTSV.Enabled = true;
            contextMenuStrip1.Enabled = false;
            gcHocPhi.Enabled = gcCTHP.Enabled = false;
            gvHocPhi.OptionsBehavior.ReadOnly = true;
            float total = 0;
            for (int i = 0; i < bdsHocPhi.Count; i++)
            {

                /*for (int j = 0; j < bdsCTHP.Count; j++)
                {
                    total += float.Parse(((DataRowView)bdsCTHP[j])[2].ToString());
                }
                MessageBox.Show(total + "         ", "", MessageBoxButtons.OK);*/
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            String cmd = "EXEC SP_CHECKID  @Code ='" + txtMaSV.Text + "' , @Type = 'MASV'";
            if (Program.ExecSqlNonQuery(cmd) != 0)
            {
                bdsSV.Position = bdsSV.Find("MASV", txtMaSV.Text);

                txtHo.Text = ((DataRowView)bdsSV[bdsSV.Position])["HO"].ToString();
                txtTen.Text = ((DataRowView)bdsSV[bdsSV.Position])["TEN"].ToString();
                txtMaLop.Text = ((DataRowView)bdsSV[bdsSV.Position])["MALOP"].ToString();

                btnThem.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
                gbTTHP.Enabled = false;
                gbTTSV.Enabled = true;
                gcHocPhi.Enabled = gcCTHP.Enabled = true;
                if (bdsCTHP.Count >= 0)
                {
                    contextMenuStrip1.Enabled = true;
                    btnThemCHTP.Enabled = btnXoaCTHP.Enabled = btnSuaCTHP.Enabled = btnPhucHoiCTHP.Enabled = true;
                    btnGhiCTHP.Enabled = btnHuyCTHP.Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Enabled = false;
                    btnThemCHTP.Enabled = btnXoaCTHP.Enabled = btnSuaCTHP.Enabled = btnPhucHoiCTHP.Enabled = false;
                    btnGhiCTHP.Enabled = btnHuyCTHP.Enabled = false;
                }
                if (bdsHocPhi.Count > 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = true;
                }
                else
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }
            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = false;
                gbTTHP.Enabled = false;
                gbTTSV.Enabled = true;
                contextMenuStrip1.Enabled = false;
                gcHocPhi.Enabled = gcCTHP.Enabled = false;
            }

        }


        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = "btnThem";
            vitriHP = bdsHocPhi.Position;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = true;
            gbTTHP.Enabled = true;
            gbTTSV.Enabled = false;
            contextMenuStrip1.Enabled = false;
            gcHocPhi.Enabled = gcCTHP.Enabled = false;
            bdsHocPhi.AddNew();
        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsHocPhi.Count == 0) return;
            vitriHP = bdsHocPhi.Position;
            if (bdsCTHP.Count > 0)
            {
                MessageBox.Show("Không thể xóa học phí này vì đã có chi tiết học phí!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn xóa học phí này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsHocPhi.RemoveCurrent();
                    this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.HOCPHITableAdapter.Update(this.DSHP.HOCPHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa học phí. Bạn hãy xóa lại " + ex.Message, "", MessageBoxButtons.OK);
                    this.HOCPHITableAdapter.FillDetail(this.DSHP.HOCPHI);
                    bdsHocPhi.Position = vitriHP;
                    return;
                }
            }
            if (bdsHocPhi.Count == 0) btnXoa.Enabled = false;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsHocPhi.Count == 0) return;
            flag = "btnSua";
            vitriHP = bdsHocPhi.Position;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = true;
            gbTTHP.Enabled = true;
            gbTTSV.Enabled = false;
            contextMenuStrip1.Enabled = false;
            gcHocPhi.Enabled = gcCTHP.Enabled = false;
            cbbNienKhoa.Enabled = false;
            cbbHocKy.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được bỏ trống!", "", MessageBoxButtons.OK);
                cbbNienKhoa.Focus();
                return;
            }
            if (cbbHocKy.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn học kỳ!", "", MessageBoxButtons.OK);
                cbbHocKy.Focus();
                return;
            }
            if (txtHocPhi.Text.Trim() == "")
            {
                MessageBox.Show("Học phí không được bỏ trống!", "", MessageBoxButtons.OK);
                txtHocPhi.Focus();
                return;
            }
            try
            {
                String cmd = "EXEC SP_CHECKIDHOCPHI  @NienKhoa ='" + cbbNienKhoa.Text + "', @HocKy ='" + cbbHocKy.SelectedItem + "', @maSV = '" + txtMaSV.Text + "'";
                switch (flag)
                {
                    case "btnThem":
                        {
                            if (Program.ExecSqlNonQuery(cmd) == 0)
                            {
                                bdsHocPhi.EndEdit();
                                bdsHocPhi.ResetCurrentItem();
                                this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.HOCPHITableAdapter.Update(this.DSHP.HOCPHI);
                                btnThemCHTP.Enabled = btnXoaCTHP.Enabled = btnSuaCTHP.Enabled = btnLamMoiCTHP.Enabled = true;
                                btnGhiCTHP.Enabled = btnHuyCTHP.Enabled = false;
                            }
                            else
                            {
                                bdsHocPhi.EndEdit();
                                this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.HOCPHITableAdapter.FillDetail(this.DSHP.HOCPHI);
                                bdsHocPhi.Position = vitriHP;
                                MessageBox.Show("Mã học phí đã tồi tại", "", MessageBoxButtons.OK);
                            }
                            break;
                        }
                    case "btnSua":
                        {
                            bdsHocPhi.EndEdit();
                            bdsHocPhi.ResetCurrentItem();
                            this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                            this.HOCPHITableAdapter.Update(this.DSHP.HOCPHI);
                            cbbNienKhoa.Enabled = true;
                            cbbHocKy.Enabled = true;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gbTTSV.Enabled = true;
            gbTTHP.Enabled = false;
            gcHocPhi.Enabled = true;
            gcCTHP.Enabled = true;
            contextMenuStrip1.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.HOCPHITableAdapter.FillDetail(this.DSHP.HOCPHI);
            bdsHocPhi.Position = vitriHP;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gbTTHP.Enabled = false;
            gbTTSV.Enabled = true;
            contextMenuStrip1.Enabled = true;
            gcHocPhi.Enabled = gcCTHP.Enabled = true;
            cbbNienKhoa.Enabled = cbbHocKy.Enabled = true;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                this.HOCPHITableAdapter.FillDetail(this.DSHP.HOCPHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload:" + ex.Message, "", MessageBoxButtons.OK);
            }
        }


        /*-----------------------======= event SubForm ===========------------------*/

        private void btnThemCHTP_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < gvCTHP.RowCount; k++)
            {
                DataRow data = gvCTHP.GetDataRow(k);
                totalHPDaDong = totalHPDaDong + int.Parse(data["SOTIENDONG"].ToString());
            }
            flag = "btnThemCTHP";
            vitriHP = bdsHocPhi.Position;
            vitriCTHP = bdsCTHP.Position;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = false;
            gbTTHP.Enabled = false;
            gbTTSV.Enabled = false;
            contextMenuStrip1.Enabled = true;
            gcHocPhi.Enabled = false;
            gcCTHP.Enabled = true;
            bdsCTHP.AddNew();
            btnThemCHTP.Enabled = btnXoaCTHP.Enabled = btnSuaCTHP.Enabled = btnLamMoiCTHP.Enabled = false;
            btnGhiCTHP.Enabled = btnHuyCTHP.Enabled = btnPhucHoiCTHP.Enabled = true;
        }

        private void btnSuaCTHP_Click(object sender, EventArgs e)
        {
            if (bdsCTHP.Count == 0) return;
            flag = "btnSuaCTHP";
            vitriHP = bdsHocPhi.Position;
            vitriCTHP = bdsCTHP.Position;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = false;
            gbTTHP.Enabled = false;
            gbTTSV.Enabled = false;
            contextMenuStrip1.Enabled = true;
            gcHocPhi.Enabled = false;
            gcCTHP.Enabled = true;
            btnThemCHTP.Enabled = btnXoaCTHP.Enabled = btnSuaCTHP.Enabled = btnLamMoiCTHP.Enabled = false;
            btnGhiCTHP.Enabled = btnHuyCTHP.Enabled = btnPhucHoiCTHP.Enabled = true;
        }


        private void btnXoaCTHP_Click(object sender, EventArgs e)
        {
            if (bdsCTHP.Count == 0) return;
            vitriHP = bdsHocPhi.Position;
            vitriCTHP = bdsCTHP.Position;
            if (MessageBox.Show("Bạn thực sự muốn xóa chi tiết học phí này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTHP.RemoveCurrent();
                    this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.HOCPHITableAdapter.FillDetail(this.DSHP.HOCPHI);
                    bdsHocPhi.Position = vitriHP;
                    this.CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.CT_DONGHOCPHITableAdapter.Update(this.DSHP.CT_DONGHOCPHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết học phí. Bạn hãy xóa lại " + ex.Message, "", MessageBoxButtons.OK);
                    this.CT_DONGHOCPHITableAdapter.Fill(this.DSHP.CT_DONGHOCPHI);
                    bdsCTHP.Position = vitriHP;
                    return;
                }
            }
        }

        private void btnGhiCTHP_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayDong = DateTime.Parse(((DataRowView)bdsCTHP[this.bdsCTHP.Position])["NGAYDONG"].ToString());
                String cmd = "EXEC SP_CHECKIDCTHP @NienKhoa ='" + cbbNienKhoa.Text + "', @HocKy ='" + cbbHocKy.SelectedItem.ToString() + "', @maSV = '" + txtMaSV.Text + "', @NgayDong = '" + ngayDong.ToShortDateString() + "'";
                switch (flag)
                {
                    case "btnThemCTHP":
                        {
                            int hocPhiDuocDong = int.Parse(((DataRowView)bdsHocPhi[this.bdsHocPhi.Position])["HOCPHI"].ToString()) - totalHPDaDong;
                            if (Program.ExecSqlNonQuery(cmd) == 0)
                            {
                                if (hocPhiDuocDong < int.Parse(((DataRowView)bdsCTHP[this.bdsCTHP.Position])["SOTIENDONG"].ToString()))
                                {
                                    bdsCTHP.EndEdit();
                                    bdsCTHP.RemoveCurrent();
                                    MessageBox.Show("Số tiền đươc phép đóng tối đa là " + hocPhiDuocDong + "Đ !", "", MessageBoxButtons.OK);
                                    totalHPDaDong = 0;
                                }
                                else
                                {
                                    bdsCTHP.EndEdit();
                                    bdsCTHP.ResetCurrentItem();
                                    this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                                    this.HOCPHITableAdapter.FillDetail(this.DSHP.HOCPHI);
                                    bdsHocPhi.Position = vitriHP;
                                    this.CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                                    this.CT_DONGHOCPHITableAdapter.Update(this.DSHP.CT_DONGHOCPHI);
                                    totalHPDaDong = 0;
                                }

                            }
                            else
                            {
                                bdsCTHP.EndEdit();
                                this.CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                                this.CT_DONGHOCPHITableAdapter.Fill(this.DSHP.CT_DONGHOCPHI);
                                bdsHocPhi.Position = vitriHP;
                                bdsCTHP.Position = vitriCTHP;
                                MessageBox.Show("Mã học phí đã tồi tại", "", MessageBoxButtons.OK);
                            }
                            break;
                        }
                    case "btnSuaCTHP":
                        {
                            bdsCTHP.EndEdit();
                            bdsCTHP.ResetCurrentItem();
                            this.HOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                            this.HOCPHITableAdapter.FillDetail(this.DSHP.HOCPHI);
                            bdsHocPhi.Position = vitriHP;
                            this.CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                            this.CT_DONGHOCPHITableAdapter.Update(this.DSHP.CT_DONGHOCPHI);
                            bdsCTHP.Position = vitriCTHP;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi chi tiết học phí!" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gbTTSV.Enabled = true;
            gbTTHP.Enabled = false;
            gcHocPhi.Enabled = true;
            btnThemCHTP.Enabled = btnXoaCTHP.Enabled = btnSuaCTHP.Enabled = btnLamMoiCTHP.Enabled = true;
            btnGhiCTHP.Enabled = btnHuyCTHP.Enabled = false;
            btnPhucHoiCTHP.Enabled = true;
            if (bdsHocPhi.Count > 0)
            {
                gcCTHP.Enabled = true;
                if (bdsCTHP.Count == 0)
                {
                    btnXoaCTHP.Enabled = btnSuaCTHP.Enabled = btnHuyCTHP.Enabled = btnGhiCTHP.Enabled = false;
                }
            }
        }

        private void btnPhucHoiCTHP_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoiCTHP_Click(object sender, EventArgs e)
        {
            try
            {
                this.CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
                this.CT_DONGHOCPHITableAdapter.Fill(this.DSHP.CT_DONGHOCPHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload:" + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void btnHuyCTHP_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnPhucHoi.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            gbTTSV.Enabled = true;
            gbTTHP.Enabled = false;
            gcHocPhi.Enabled = gcCTHP.Enabled = true;
            btnThemCHTP.Enabled = btnXoaCTHP.Enabled = btnSuaCTHP.Enabled = btnLamMoiCTHP.Enabled = true;
            btnGhiCTHP.Enabled = btnHuyCTHP.Enabled = false;
            btnPhucHoiCTHP.Enabled = true;
            this.CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectStr;
            this.CT_DONGHOCPHITableAdapter.Fill(this.DSHP.CT_DONGHOCPHI);
            bdsCTHP.Position = vitriCTHP;
        }
    }
}