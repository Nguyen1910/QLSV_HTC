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
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        String username;
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.m_group == "PKT")
            {
                this.HOTENGVHPTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.HOTENGVHPTableAdapter.Fill(this.DSHP.HOTENGVHP);
                cbbGiangVien.DataSource = bdsHOTENGVHP;
                cbbGiangVien.DisplayMember = "HOTEN";
                cbbGiangVien.ValueMember = "MAGV";
            }
            else
            {
                this.HOTENGVTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.HOTENGVTableAdapter.Fill(this.DS.HOTENGV);
                cbbGiangVien.DataSource = bdsHOTENGV;
                cbbGiangVien.DisplayMember = "HOTEN";
                cbbGiangVien.ValueMember = "MAGV";
            }

            if(Program.m_group == "PKT")
            {
                rbtnPKT.Checked = true;
                rbtnPGV.Enabled = false;
                rbtnKhoa.Enabled = false;
            }
            else if (Program.m_group == "KHOA")
            {
                rbtnPKT.Enabled = false;
                rbtnPGV.Enabled = false;
                rbtnKhoa.Checked = true;
            }
            else if (Program.m_group == "PGV")
            {
                rbtnPKT.Enabled = false;
                rbtnPGV.Checked = true;
                rbtnKhoa.Enabled = true;
            }

        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassConfirm.PasswordChar = '*';
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            String pass = "";
            String login = txtLogin.Text;
            String password = txtPassword.Text;
            String passConfirm = txtPassConfirm.Text;
            String role = rbtnKhoa.Checked ? "KHOA" : (rbtnPGV.Checked ? "PGV" : "PKT");
            if (password.Equals(passConfirm))
            {
                pass = passConfirm;
                if( Program.m_group == "PKT")
                {
                    if(Program.ExecSqlNonQuery("EXEC LINK1.QLSV_HTC.[DBO].[SP_CHECKID]  @Code ='" + username + "' , @Type = 'USER'") == 2 || Program.ExecSqlNonQuery("EXEC LINK2.QLSV_HTC.[DBO].[SP_CHECKID]  @Code ='" + username + "' , @Type = 'USER'") == 2)
                    {
                        MessageBox.Show("User đã tạo tài khoản rồi!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int check = Program.ExecSqlNonQuery("EXEC SP_TAOLOGIN @LGNAME = N'" + login + "', " +
                                                            "@PASS = N'" + pass + "', " +
                                                            "@USERNAME = N'" + username + "', " +
                                                            "@ROLE = N'" + role + "'");
                        if (check == 1)
                        {
                            MessageBox.Show("Login đã tồn tại!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 2)
                        {
                            MessageBox.Show("User đã tạo tài khoản rồi!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 3)
                        {
                            MessageBox.Show("Tạo tài khoản thất bại!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                        }
                    }
                } else if (Program.m_subscribes == 0 )
                {
                    if (Program.ExecSqlNonQuery("EXEC LINK.QLSV_HTC.[DBO].[SP_CHECKID]  @Code ='" + username + "' , @Type = 'USER'") == 2 || Program.ExecSqlNonQuery("EXEC LINK2.QLSV_HTC.[DBO].[SP_CHECKID]  @Code ='" + username + "' , @Type = 'USER'") == 2)
                    {
                        MessageBox.Show("User đã tạo tài khoản rồi!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int check = Program.ExecSqlNonQuery("EXEC SP_TAOLOGIN @LGNAME = N'" + login + "', " +
                                                            "@PASS = N'" + pass + "', " +
                                                            "@USERNAME = N'" + username + "', " +
                                                            "@ROLE = N'" + role + "'");
                        if (check == 1)
                        {
                            MessageBox.Show("Login đã tồn tại!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 2)
                        {
                            MessageBox.Show("User đã tạo tài khoản rồi!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 3)
                        {
                            MessageBox.Show("Tạo tài khoản thất bại!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                        }
                    }
                }
                else if (Program.m_subscribes == 1)
                {
                    if (Program.ExecSqlNonQuery("EXEC LINK.QLSV_HTC.[DBO].[SP_CHECKID]  @Code ='" + username + "' , @Type = 'USER'") == 2 || Program.ExecSqlNonQuery("EXEC LINK3.QLSV_HTC.[DBO].[SP_CHECKID]  @Code ='" + username + "' , @Type = 'USER'") == 2)
                    {
                        MessageBox.Show("User đã tạo tài khoản rồi!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int check = Program.ExecSqlNonQuery("EXEC SP_TAOLOGIN @LGNAME = N'" + login + "', " +
                                                            "@PASS = N'" + pass + "', " +
                                                            "@USERNAME = N'" + username + "', " +
                                                            "@ROLE = N'" + role + "'");
                        if (check == 1)
                        {
                            MessageBox.Show("Login đã tồn tại!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 2)
                        {
                            MessageBox.Show("User đã tạo tài khoản rồi!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 3)
                        {
                            MessageBox.Show("Tạo tài khoản thất bại!", "", MessageBoxButtons.OK);
                        }
                        else if (check == 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cbbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                username = cbbGiangVien.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
