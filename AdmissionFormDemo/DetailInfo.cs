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
    public partial class DetailInfo : Form
    {

        public string Time { get; set; }
        public string Do { get; set; }
        public string ID { get; set; }
        public string acc { get; set; }
        public string acl { get; set; }
        Login log = new Login();
        public DetailInfo()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = null;
       
        public DetailInfo(String id,Login log)
        {
            InitializeComponent();
            labId.Text = id;
            loadDataFromDatabase();
            getName(labId.Text);
            this.log = log;
            ID = id;

            //get account
            acc = log.Account;
            if (log.AccountLevel == 1)
            {
                acl = "Admin";
            }
            else
            {
                acl = "Agent";
            }
        }

        public void getName(String id)
        {
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = " select * from GeneralInfo where ID = '" + labId.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    labName.Text = reader["Name"].ToString();
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadDataFromDatabase()
        {
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = " select * from DetailInfo where ID = '" + labId.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    txtSchoolName.Text = reader["SchoolName"].ToString();
                    txtSchoolType.Text = reader["TypeOfSchool"].ToString();
                    txtSchoolLocation.Text = reader["SchoolLocation"].ToString();
                    String date = reader["Passouts"].ToString();
                    if (!String.IsNullOrEmpty(date))
                    {
                        datePickerPassout.Value = Convert.ToDateTime(date, System.Globalization.CultureInfo.CurrentCulture);
                    }
                    txtGPA.Text = reader["GPA"].ToString();
                    txtCompany.Text = reader["Company"].ToString();
                    txtWorkField.Text = reader["FieldOfWork"].ToString();
                    txtCompanyLocation.Text = reader["CompanyLocation"].ToString();
                    txtPosition.Text = reader["Position"].ToString();
                    txtExperienceYear.Text = reader["YearOfExperience"].ToString();
                    txtNote.Text = reader["Note"].ToString();
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // get Data
                String schoolName = txtSchoolName.Text;
                String schoolType = txtSchoolType.Text;
                String schoolLocation = txtSchoolLocation.Text;
                String passout = datePickerPassout.Value.ToShortDateString();
                String gpaString = "null";
                if (!String.IsNullOrEmpty(txtGPA.Text))
                {
                    double gpa = double.Parse(txtGPA.Text.Replace(",", "."));
                    gpaString = gpa + "";
                }
                String company = txtCompany.Text;
                String workfield = txtWorkField.Text;
                String companyLocation = txtCompanyLocation.Text;
                String position = txtPosition.Text;
                String yearString = "null";
                if (!String.IsNullOrEmpty(txtExperienceYear.Text))
                {
                    double experienceYear = double.Parse(txtExperienceYear.Text.Replace(",", "."));
                    yearString = experienceYear + "";
                }
                String note = txtNote.Text;
                String idSelected = labId.Text;
                // set data to database
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sql = string.Format(" update DetailInfo "
                    + " set SchoolName = '{0}', TypeOfSchool = '{1}', SchoolLocation = '{2}', Passouts = '{3}', GPA = {4}, Company ='{5}', "
                    + " FieldOfWork = '{6}', CompanyLocation = '{7}', Position = '{8}', YearOfExperience = {9}, Note = '{10}' "
                    + " where ID = '{11}';", schoolName, schoolType, schoolLocation, passout, gpaString, company, workfield, companyLocation, position, yearString, note, labId.Text);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Detail information has been updated !");

                //get this variable to tranfer
                Time = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                Do = " had open Detail View of student";
                frmCounselingHistory dt = new frmCounselingHistory(this);


                sqlConn.Close();
                this.Close();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
