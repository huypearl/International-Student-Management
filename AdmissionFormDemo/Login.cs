using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

/**
 * PhucVT
 * 
 * */
namespace AdmissionTrackingApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lbLoginStatus_Login.Visible = false;
        }
       
        //int accountLevel;
        //string account;
        public int AccountLevel { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }

        SqlDataAdapter sda = null;
        DataSet ds = null;
        SqlConnection sqlConn = null;
        SqlDataReader dr = null;
        private void button1_Click(object sender, EventArgs e)
        {
            txtAccount_Login.Text = "phucvt";
            txtPassword_Login.Text = "12345678";
            if (String.IsNullOrEmpty(txtAccount_Login.Text))
            {
                lbLoginStatus_Login.Text = "Account can't be empty!";
                lbLoginStatus_Login.Visible = true;
            }
            else if (String.IsNullOrEmpty(txtPassword_Login.Text))
            {
                lbLoginStatus_Login.Text = "Password can't be empty!";
                lbLoginStatus_Login.Visible = true;
            }
            else
            {
                try
                {
                    sqlConn = new SqlConnection(App.ConnectionString);
                    sqlConn.Open();
                    string sqlCount = "Select Password,Level from Account where Username='" + txtAccount_Login.Text + "'";
                    SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                    dr = sqlCmd.ExecuteReader();
                    dr.Read();
                    if ( txtPassword_Login.Text==dr.GetValue(0).ToString())
                    { 
                        AccountLevel = dr.GetInt32(1);
                        Account = txtAccount_Login.Text;
                        Password = txtPassword_Login.Text;
                        lbLoginStatus_Login.Text = "Login successfully!";
                        lbLoginStatus_Login.Visible = true;
                        MainForm mf = new MainForm(this);
                        this.Hide();
                        mf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        lbLoginStatus_Login.Text = "Password is not correct!";
                        lbLoginStatus_Login.Visible = true;
                        txtPassword_Login.Clear();
                        txtPassword_Login.Focus();
                    }
                }
                catch (Exception)
                {
                    lbLoginStatus_Login.Text = "Account is not exist!";
                    lbLoginStatus_Login.Visible = true;
                    txtAccount_Login.Clear();
                    txtPassword_Login.Clear();
                    txtPassword_Login.Focus();
                }
                sqlConn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
