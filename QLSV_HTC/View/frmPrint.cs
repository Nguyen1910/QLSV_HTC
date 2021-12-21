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

namespace QLSV_HTC.View
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void PrintBDTKCK(String maKhoa,String maLop,String tenLop,String khoaHoc)
        {
            rpBDTKCK report = new rpBDTKCK(maLop);
            report.txtKhoa.Text = maKhoa;
            report.txtLop.Text = tenLop;
            report.txtKhoaHoc.Text = khoaHoc;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintDSLTC(String maKhoa, String nienKhoa, String hocKy)
        {
            rpDSLTC report = new rpDSLTC(nienKhoa, hocKy);
            report.lblMaKhoa.Text = maKhoa;
            report.lblNienKhoa.Text = nienKhoa;
            report.lblHocKy.Text = hocKy;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintDSSVDKLTC(String maKhoa, String nienKhoa, String hocKy, String maMH,String tenMH, String nhom)
        {
            rpDSSVDKLTC report = new rpDSSVDKLTC(nienKhoa, hocKy, maMH, nhom);
            report.lblMaKhoa.Text = maKhoa;
            report.lblNienKhoa.Text = nienKhoa;
            report.lblHocKy.Text = hocKy;
            report.lblMonHoc.Text = tenMH;
            report.lblNhom.Text = nhom;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintBDHM(String maKhoa, String nienKhoa, String hocKy, String maMH, String tenMH, String nhom)
        {
            rpBDHM report = new rpBDHM(nienKhoa, hocKy, maMH, nhom);
            report.lblMaKhoa.Text = maKhoa;
            report.lblNienKhoa.Text = nienKhoa;
            report.lblHocKy.Text = hocKy;
            report.lblMonHoc.Text = tenMH;
            report.lblNhom.Text = nhom;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void PrintPDSV(String maSV)
        {
            rpPDSV report = new rpPDSV(maSV);
            report.lblMaSV.Text = maSV;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}