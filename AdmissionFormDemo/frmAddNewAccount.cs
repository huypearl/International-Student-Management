using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace AdmissionTrackingApp
{
    public partial class frmAddNewAccount : Form
    {
        public frmAddNewAccount()
        {
            InitializeComponent();
        }
        Login log = new Login();
        public frmAddNewAccount(Login log)
        {
            InitializeComponent();
            this.log = log;
        }
        SqlConnection sqlConn = null;
        private void frmAddNewAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnSave__AddNewAccout_Click(object sender, EventArgs e)
        {
            string account = txtAccount_AddNewAccout.Text;
            string password = txtPassword_AddNewAccout.Text;
            int level;
            if(cbxLevel__AddNewAccout.SelectedIndex==0)
            {
                level = 1;
            } 
            else
            {
                level = 2;
            }
            
            sqlConn = new SqlConnection(App.ConnectionString);
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("insert into Account (Username,Password,Level,Profile) values('" + account + "','" + password + "'," + level + ",@profile)", sqlConn);
            FileStream fs1 = new FileStream(txtLinkProfile_AddNewAccout.Text, FileMode.Open);
            byte[] profile = new byte[fs1.Length];
            fs1.Read(profile, 0, profile.Length);
            sqlCmd.Parameters.AddWithValue("@profile", profile);
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Profile picture has been updated !");
            sqlConn.Close();
        }

        private void btnBrowse_AddNewAccout_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "JPEG(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtLinkProfile_AddNewAccout.Text = ofd.FileName;
            }
        }

        private void btnCancel__AddNewAccout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
