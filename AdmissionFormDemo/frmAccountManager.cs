using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

/**
 * PhucVT
 * 
 * */
namespace AdmissionTrackingApp
{
    public partial class frmAccountManager : Form
    {
        public frmAccountManager()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        string userSelected;
        string picname = null;
        byte[] data = null;
        FileStream fs = null;
        int idButton;
        private string imagePath = "";
        public void setLockFirst()
        {
            txtUsername_AccountManager.ReadOnly = true;
            txtPassword_AccountManager.ReadOnly = true;
            cbxAccountLevel_AccountManager.Enabled = false;
            txtProfileLink_AccountManager.ReadOnly = true;
            btnAdd_AccoutManager.Enabled = true;
            btnEdit_AccoutManager.Enabled = false;
            btnDelete_AccoutManager.Enabled = false;
            btnBrowse_AccountManager.Enabled = false;
            btnSave_AccountManager.Enabled = false;
            picProfile_AccountManager.Enabled = false;
        }
        private void frmAccountManager_Load(object sender, EventArgs e)
        {
            setLockFirst();
            gridList_AccountManager.ReadOnly = true;
            gridList_AccountManager.MultiSelect = false;
            sqlConn = new SqlConnection(App.ConnectionString);
            sqlConn.Open();
            string sqlCount = "select Username,Password,Level from Account";
            SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
            sda = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            sda.Fill(ds, "Account");
            gridList_AccountManager.DataSource = ds.Tables["Account"];
            picname = "profileManager.jpg";
            picProfile_AccountManager.Image = AdmissionTrackingApp.Properties.Resources.DefaultProfile;
            picProfile_AccountManager.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile_AccountManager.Refresh();
            sqlConn.Close();
        }

        public void LoadDataFromGrid()
        {
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount1 = " select * from Account where Username = '" + userSelected + "'";
                SqlCommand sqlCmd1 = new SqlCommand(sqlCount1, sqlConn);
                SqlDataReader reader = sqlCmd1.ExecuteReader();
                while (reader.Read())
                {
                    txtUsername_AccountManager.Text = reader["Username"].ToString();
                    txtPassword_AccountManager.Text = reader["Password"].ToString();
                    if (reader["Level"].ToString() == "1")
                    {
                        cbxAccountLevel_AccountManager.SelectedItem = "Admin";
                    }
                    else
                        cbxAccountLevel_AccountManager.SelectedItem = "Agent";
                    
                    ShowProfile(picname,sqlCmd1,reader);
                    
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        public void ShowProfile(string picname, SqlCommand sqlCmd1, SqlDataReader r)
        {
            if (! DBNull.Value.Equals(r["Profile"]))
            {
                data = (byte[])r["Profile"];

                try
                {
                    fs = new FileStream(picname, FileMode.Create);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                    picProfile_AccountManager.Image = Image.FromFile(picname);
                    picProfile_AccountManager.SizeMode = PictureBoxSizeMode.StretchImage;
                    picProfile_AccountManager.Refresh();
                }
                catch (Exception ex)
                {
                    //in case the file is opening, you need to close currently file first
                    MessageBox.Show("Loi: " + ex.Message);
                    fs = null;
                }
            }
            else
            {
                picProfile_AccountManager.Image = AdmissionTrackingApp.Properties.Resources.DefaultProfile;
                picProfile_AccountManager.SizeMode = PictureBoxSizeMode.StretchImage;
                picProfile_AccountManager.Refresh();
            }

            //}
        }
        private void gridList_AccountManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idButton = 1;
            userSelected = gridList_AccountManager.CurrentRow.Cells[0].Value.ToString();
            if (picname == "profileManager.jpg")
                picname = "profileManager1.jpg";
            else if (picname == "profileManager1.jpg")
                picname = "profileManager2.jpg";
            else if (picname == "profileManager2.jpg")
                picname = "profileManager.jpg";
            LoadDataFromGrid();

            //lock Gui
            txtUsername_AccountManager.ReadOnly = false;
            txtPassword_AccountManager.ReadOnly = false;
            cbxAccountLevel_AccountManager.Enabled = true;
            txtProfileLink_AccountManager.ReadOnly = true;
            btnAdd_AccoutManager.Enabled = true;
            btnEdit_AccoutManager.Enabled = true;
            btnDelete_AccoutManager.Enabled = true;
            btnBrowse_AccountManager.Enabled = true;
            btnSave_AccountManager.Enabled = false;
            picProfile_AccountManager.Enabled = false;
        }

        private void btnAdd_AccoutManager_Click(object sender, EventArgs e)
        {
            idButton = 2;
            txtUsername_AccountManager.Clear();
            txtPassword_AccountManager.Clear();
            txtProfileLink_AccountManager.Clear();

            txtUsername_AccountManager.Focus();

            txtUsername_AccountManager.ReadOnly = false;
            txtPassword_AccountManager.ReadOnly = false;
            cbxAccountLevel_AccountManager.Enabled = true;
            txtProfileLink_AccountManager.ReadOnly = true;
            btnAdd_AccoutManager.Enabled = true;
            btnEdit_AccoutManager.Enabled = false;
            btnDelete_AccoutManager.Enabled = false;
            btnBrowse_AccountManager.Enabled = true;
            btnSave_AccountManager.Enabled = true;
            picProfile_AccountManager.Enabled = true;
        }

        private void btnEdit_AccoutManager_Click(object sender, EventArgs e)
        {
            idButton = 3;
            txtUsername_AccountManager.ReadOnly = false;
            txtPassword_AccountManager.ReadOnly = false;
            cbxAccountLevel_AccountManager.Enabled = true;
            txtProfileLink_AccountManager.ReadOnly = true;
            btnAdd_AccoutManager.Enabled = false;
            btnEdit_AccoutManager.Enabled = true;
            btnDelete_AccoutManager.Enabled = false;
            btnBrowse_AccountManager.Enabled = true;
            btnSave_AccountManager.Enabled = true;
            picProfile_AccountManager.Enabled = true;
        }

        private void btnDelete_AccoutManager_Click(object sender, EventArgs e)
        {
            idButton = 4;
            txtUsername_AccountManager.ReadOnly = false;
            txtPassword_AccountManager.ReadOnly = false;
            cbxAccountLevel_AccountManager.Enabled = true;
            txtProfileLink_AccountManager.ReadOnly = true;
            btnAdd_AccoutManager.Enabled = false;
            btnEdit_AccoutManager.Enabled = false;
            btnDelete_AccoutManager.Enabled = true;
            btnBrowse_AccountManager.Enabled = true;
            btnSave_AccountManager.Enabled = true;
            picProfile_AccountManager.Enabled = true;

            /*
            * 1. select a row from datagridview
            * 2. remove selected row
            */
            if (gridList_AccountManager.SelectedCells[0] != null)
            {
                if (MessageBox.Show("Delete?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int i = gridList_AccountManager.SelectedCells[0].RowIndex;
                    //remove ith row
                    ds.Tables[0].Rows[i].Delete();
                    //configure sda
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    sda.Update(ds, "Account");
                    MessageBox.Show("An account has been deleted");
                }

            }
            else
                MessageBox.Show("Please select a row to delete");
        }

        private void btnSave_AccountManager_Click(object sender, EventArgs e)
        {
            if(idButton==2)
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = "select * from Account";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                sda = new SqlDataAdapter(sqlCmd);
                ds = new DataSet();
                sda.Fill(ds, "Account");
                string account = txtUsername_AccountManager.Text;
                string password = txtPassword_AccountManager.Text;
                int level;
                if (cbxAccountLevel_AccountManager.SelectedIndex == 0)
                {
                    level = 1;
                }
                else
                {
                    level = 2;
                }
                byte[] profilepic = null;
                if (txtProfileLink_AccountManager.Text != "")
                {
                    profilepic = File.ReadAllBytes(imagePath);
                }
                //save data to newrow = ds.table[0].newRow
                DataRow newrow = ds.Tables["Account"].NewRow();

                newrow[0] = txtUsername_AccountManager.Text;
                newrow[1] = txtPassword_AccountManager.Text;
                newrow[2] = level;
                newrow[3] = profilepic;
                ds.Tables[0].Rows.Add(newrow);

                //configure sda to parse data form ds to datasource
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                sda.Update(ds, "Account");
                MessageBox.Show("New Account has been added!");
                imagePath = "";
                sqlConn.Close();

                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlstring = "select Username,Password,Level from Account";
                SqlCommand sqlCmd1 = new SqlCommand(sqlstring, sqlConn);
                sda = new SqlDataAdapter(sqlCmd1);
                ds = new DataSet();
                sda.Fill(ds, "Account");
                gridList_AccountManager.DataSource = ds.Tables["Account"];
                sqlConn.Close();
            }
            else if(idButton==3)
            {
                // set data to database
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                int level;
                if (cbxAccountLevel_AccountManager.SelectedIndex == 0)
                {
                    level = 1;
                }
                else
                {
                    level = 2;
                }
                string sql = string.Format(" update Account set Password = '{0}',Level = {1},Profile = @profile where Username = '{2}';", txtPassword_AccountManager.Text, level, txtUsername_AccountManager.Text);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                byte[] profile = null;
                if (txtProfileLink_AccountManager.Text != "")
                {
                    profile = File.ReadAllBytes(txtProfileLink_AccountManager.Text);
                }
                sqlCmd.Parameters.AddWithValue("@profile", profile);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Account has been updated !");
                sqlConn.Close();

                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlstring = "select Username,Password,Level from Account";
                SqlCommand sqlCmd1 = new SqlCommand(sqlstring, sqlConn);
                sda = new SqlDataAdapter(sqlCmd1);
                ds = new DataSet();
                sda.Fill(ds, "Account");
                gridList_AccountManager.DataSource = ds.Tables["Account"];
                sqlConn.Close();
            }
        }

        private void btnBrowse_AccountManager_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "JPEG(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtProfileLink_AccountManager.Text = ofd.FileName;
                imagePath = ofd.FileName;
            }
            else
            {
                return;
            }
            picProfile_AccountManager.Image = Image.FromFile(imagePath);
            picProfile_AccountManager.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile_AccountManager.Refresh();
        }

    }
}
