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
 * HuyTLN
 * 
 * **/
namespace AdmissionTrackingApp
{
    public partial class EditGeneralInfo : Form
    {
        string selectedID;
        FileStream fs;
        byte[] data = null;

        public string Time { get; set; }
        public string Do { get; set; }
        public string ID { get; set; }
        public string acc { get; set; }
        public string acl { get; set; }

        Login log = null;

        public EditGeneralInfo()
        {
            InitializeComponent();
        }
        public EditGeneralInfo(string si,Login log)
        {
            InitializeComponent();
            selectedID = si;
            this.log = log;

            //get account
            if (log.AccountLevel == 1)
            {
                acl = "Admin";
            }
            else
            {
                acl = "Agent";
            }
            acc = log.Account;

        }

        private void EditGeneralInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string connection = App.ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();
                string sqlSelect = "select * from GeneralInfo where ID = '" + selectedID + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    lbId_EditGeneralInfo.Text = reader["id"].ToString();
                    lbName_EditGeneralInfo.Text = reader["Name"].ToString();
                    dtpDob_EditGeneralInfo.Text = reader["Dob"].ToString();

                    if (reader["Gender"].ToString().Equals("True"))
                        radMale_EditGeneralInfo.Checked = true;
                    else
                        radFemale_EditGeneralInfo.Checked = true;

                    txtAddress_EditGeneralInfo.Text = reader["Address"].ToString();
                    txtEmail_EditGeneralInfo.Text = reader["Email"].ToString();
                    txtMobile_EditGeneralInfo.Text = reader["Mobile"].ToString();
                    txtSkype_EditGeneralInfo.Text = reader["Skype"].ToString();
                    txtTypeOfDegree_EditGeneralInfo.Text = reader["TypeOfDegree"].ToString();
                    txtInterestedProgram_EditGeneralInfo.Text = reader["InterestedProgram"].ToString();
                    cbbStudentStatus_EditGeneralInfo.Text = reader["StudentStatus"].ToString();
                    txtStatusNote_EditGeneralInfo.Text = reader["StatusNote"].ToString();
                    ricNote_EditGeneralInfo.Text = reader["Note"].ToString();
                    try
                    {
                        data = (byte[])reader["Profile"];
                    }
                    catch (Exception ex)
                    {

                    }
                    if (data != null)
                    {
                        textBox4.Enabled = false;
                        textBox4.Visible = false;
                        try
                        {
                            fs = new FileStream("image.jpg", FileMode.Create);
                            fs.Write(data, 0, data.Length);
                            picProfile_GeneralInfo.Image = Image.FromStream(fs);
                            picProfile_GeneralInfo.Height = 138;
                            picProfile_GeneralInfo.Width = 120;
                            picProfile_GeneralInfo.Update();
                            fs.Close();
                        }
                        catch (Exception ex)
                        {
                            //in case the file is opening, you need to close currently file first
                            MessageBox.Show(ex.Message);
                            fs = null;
                        }
                    }

                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_EditGeneralInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = App.ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();

                string id = lbId_EditGeneralInfo.Text;
                string name = lbName_EditGeneralInfo.Text;
                string dob = dtpDob_EditGeneralInfo.Value.ToString("M-d-yyyy");
                bool male = true;
                if (radFemale_EditGeneralInfo.Checked == true)
                    male = false;

                string address = txtAddress_EditGeneralInfo.Text;
                string email = txtEmail_EditGeneralInfo.Text;
                int mobile;
                errorProvider1.Clear();
                foreach (char c in txtMobile_EditGeneralInfo.Text.ToCharArray())
                {
                    if (!char.IsDigit(c))
                    {
                        errorProvider1.SetError(txtMobile_EditGeneralInfo, "Mobile cannot must be integer number");
                        txtMobile_EditGeneralInfo.Focus();
                        return;
                    }
                }
                errorProvider1.Clear();


                if (string.IsNullOrEmpty(txtMobile_EditGeneralInfo.Text))
                {
                    mobile = 0;
                }
                else
                {
                    mobile = int.Parse(txtMobile_EditGeneralInfo.Text);
                }
                string skype = txtSkype_EditGeneralInfo.Text;
                string degree = txtTypeOfDegree_EditGeneralInfo.Text;
                string program = txtInterestedProgram_EditGeneralInfo.Text;
                string stuStatus = cbbStudentStatus_EditGeneralInfo.Text;
                string statusNote = txtStatusNote_EditGeneralInfo.Text;
                string note = ricNote_EditGeneralInfo.Text;

                string sql = string.Format("UPDATE GeneralInfo "
                    + "SET name = '{0}', DoB = '{1}', gender = '{2}', "
                    + "Address = '{3}', Email = '{4}', "
                    + "Mobile = {5}, Skype = '{6}', TypeOfDegree = '{7}', "
                    + "InterestedProgram = '{8}', StudentStatus = '{9}', StatusNote = '{10}', "
                    + "Note = '{11}' "
                    + "WHERE ID = '{12}' ", name, dob, male, address, email, mobile, skype,
                       degree, program, stuStatus, statusNote, note, id);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Student information has been added");

                //get this variable to transfer
                Time = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                Do = " had Update General Info of student";
                ID = selectedID;
                frmCounselingHistory ch = new frmCounselingHistory(this);

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error with your app!" + ex.Message + ex.ToString());
            }
        }
    }
}
