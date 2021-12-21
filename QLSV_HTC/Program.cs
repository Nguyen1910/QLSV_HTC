using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLSV_HTC
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connectStr_publisher = @"Data Source=DESKTOP-H44NOK6\SERVER;Initial Catalog=QLSV_HTC;Integrated Security=True";
        public static String connectStr;

        public static SqlDataReader reader;
        public static String servername = "";
        public static String username = "";
        public static String m_login = "";
        public static String password = "";

        public static String database = "QLSV_HTC";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String remoteloginSV = "SV";
        public static String remotepasswordSV = "123456";

        public static String m_loginDN = "";
        public static String passwordDN = "";

        public static String m_group = "";
        public static String m_hoTen = "";
        public static String m_lop = "";

        public static int m_subscribes = 0;

        public static frmMain f_main;
        public static frmLogin f_login;

        public static BindingSource bds_dspm = new BindingSource();
        public static BindingSource bds_dskhoa = new BindingSource();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f_main = new frmMain();
            f_login = new frmLogin();
            Application.Run(f_login);
        }

        public static int GetConnection()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connectStr = @"Data Source="+ Program.servername +";Initial Catalog="+ Program.database +";User ID="+ Program.m_login +";password="+ Program.password;
                Program.conn.ConnectionString = Program.connectStr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                
                return 0;
            }
        }

        public static int GetConnection(String conStr)
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.conn.ConnectionString = conStr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static String changeConnectStr(String serverName, String userName, String passWord)
        {
            return @"Data Source=" + serverName + ";Initial Catalog=" + Program.database + ";User ID=" + userName + ";password=" + passWord;
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader reader;
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                reader = sqlcmd.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }         
        }

        public static DataTable ExecSqlDataTble(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String cmd)
        {
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch(SqlException ex)
            {
                return ex.State;
            }
        }
    }
}
