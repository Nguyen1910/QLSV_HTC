﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV_HTC
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private static SqlConnection conn_publisher = new SqlConnection();
        private static BindingSource bds_dssv = new BindingSource();
        public frmLogin()
        {
            InitializeComponent();
        }

        private int connectToPublisher()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connectStr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tên database và tên server");
                return 0;
            }
        }
        private void getListSubscribes(String cmd)
        {
            DataTable dataTable = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn_publisher);
            dataAdapter.Fill(dataTable);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dataTable;
            cbSubscribes.DataSource = Program.bds_dspm;
            cbSubscribes.DisplayMember = "TENKHOA";
            cbSubscribes.ValueMember = "TENSERVER";
        }

        private void getListKhoa()
        {
            String cmd = "Select * from Get_Khoa";
            DataTable dataTable = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn_publisher);
            dataAdapter.Fill(dataTable);
            conn_publisher.Close();
            Program.bds_dskhoa.DataSource = dataTable;
        }

        private void getListSV()
        {
            String cmd = "select * from Get_SinhVien_Info";
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            dataAdapter.Fill(dataTable);
            Program.conn.Close();
            bds_dssv.DataSource = dataTable;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username hay Password trống !");
                return;
            }
            Program.m_login = txtUsername.Text;
            Program.password = txtPassword.Text; 
            Program.m_subscribes = cbSubscribes.SelectedIndex;
            if (Program.m_login.Equals(Program.remoteloginSV) & Program.password.Equals(Program.remotepasswordSV))
            {
                MessageBox.Show("Sai Username hay Password !");
                return;
            }
            if (Program.GetConnection() == 0)
            {
                if(Program.m_subscribes == 2)
                {
                    MessageBox.Show("Sai Username hay Password !");
                    return;
                }
                Program.m_login = Program.remoteloginSV;
                Program.password = Program.remotepasswordSV;
                Program.GetConnection();
                getListSV();
                String sql = "exec SP_CHECKMASV '" + txtUsername.Text + "','"+ txtPassword.Text +"'";
                int isError = Program.ExecSqlNonQuery(sql);
                if (isError == 1)
                {
                    bds_dssv.Position = bds_dssv.Find("MASV", txtUsername.Text);
                    Program.username = ((DataRowView)bds_dssv[bds_dssv.Position])["MASV"].ToString();
                    Program.m_hoTen = ((DataRowView)bds_dssv[bds_dssv.Position])["TENSV"].ToString();
                    Program.m_lop = ((DataRowView)bds_dssv[bds_dssv.Position])["MALOP"].ToString();
                    Program.m_group = "SV";

                    Program.conn.Close();

                    Program.f_main.infoUser_Load(Program.username, Program.m_hoTen, Program.m_group);
                    Program.f_login.Hide();
                    Program.f_main.Show();

                    return;
                }
                Program.m_login = "";
                Program.password = "";
                MessageBox.Show("Sai Username hay Password !");
                return;
            }
            Program.m_loginDN = Program.m_login;
            Program.passwordDN = Program.password;
            String cmd = "exec SP_DANGNHAP '"+Program.m_loginDN+"'";

            Program.reader = Program.ExecSqlDataReader(cmd);
            if (Program.reader == null) return;
            Program.reader.Read();

            Program.username = Program.reader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Bạn không quyền truy cập dữ liệu.\nXem lại username và password");
                return;
            }
            if (Program.reader.GetString(1) == null) Program.m_hoTen = "Sinh Viên";
            else Program.m_hoTen = Program.reader.GetString(1);
            Program.m_group = Program.reader.GetString(2);
            Program.reader.Close();

            Program.conn.Close();

            Program.f_main.infoUser_Load(Program.username,Program.m_hoTen,Program.m_group);
            Program.f_login.Hide();
            Program.f_main.Show();
        }

        private void cbSubscribes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbSubscribes.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (connectToPublisher() == 0) return;
            getListSubscribes("select * from Get_Subscribes");
            getListKhoa();
            cbSubscribes.SelectedIndex = 2;
            cbSubscribes.SelectedIndex = 1;
            cbSubscribes.SelectedIndex = 0;
        }
    }
}
