using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdmissionTrackingApp
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }
        Login log = new Login();

        public frmChangePass(Login log)
        {
            InitializeComponent();
            this.log = log;
        }
        SqlConnection sqlConn = null;
        private void frmChangePass_Load(object sender, EventArgs e)
        {
            lbAccount_ChangePass.Text = log.Account;
            txtOldPass_ChangePass.Focus();
        }

        private void btnSave_ChangePass_Click(object sender, EventArgs e)
        {
            string oldpass = txtOldPass_ChangePass.Text;
            string newpass = txtNewPass_ChangePass.Text;
            string confirm = txtConfirm_ChangePass.Text;
            if(oldpass!=log.Password)
            {
                lbNotify_ChangePass.Text = "Old password is not correct!";
                txtOldPass_ChangePass.Clear();
                txtNewPass_ChangePass.Clear();
                txtConfirm_ChangePass.Clear();
                txtOldPass_ChangePass.Focus();
            }
            else if (newpass != confirm)
            {
                lbNotify_ChangePass.Text = "Confirm password does not match";
                txtNewPass_ChangePass.Clear();
                txtConfirm_ChangePass.Clear();
                txtNewPass_ChangePass.Focus();
            }
            else
            {
                // set data to database
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sql = string.Format(" update Account set Password = '{0}' where Username = '{1}';", newpass, lbAccount_ChangePass.Text);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Password has been updated !");
                sqlConn.Close();
            }
        }

    }
}
