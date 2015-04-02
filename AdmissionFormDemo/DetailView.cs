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
 * TuanHA
 * 
 * **/
namespace AdmissionTrackingApp
{
    public partial class DetailView : Form
    {
        string Id = null;

        public string Time { get; set; }
        public string Do { get; set; }
        public string ID { get; set; }
        public string acc { get; set; }
        public string acl { get; set; }
        Login log = new Login();

        String connection = @"data source = (local); database = Admission_Tracking; integrated security = true";
        public DetailView()
        {
            InitializeComponent();
        }

        public DetailView(string id,Login log)
        {
            InitializeComponent();
            this.log = log;
            Id = id;

            //get this variable to transfer
            if (id != null)
            {
                Time = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                Do = " had open Detail View of student";
                ID = id;
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
        }

        private void DetailView_Load(object sender, EventArgs e)
        {
            //General Infomation
            GeneralInfoView();

            //Detail Infomation
            DetailInfoView();

            //Document Collection
            lockCheckboxDocument();
            loadDocumentFromDatabase();
            setCheckedDocument();

            //Visa
            VisaView();

            // On Arrival
            OnArrivalView();
            

        }

        /**
         * TuanHA
         * General Information View
         * 
         * **/
        public void GeneralInfoView()
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = " select * from GeneralInfo where ID = '" + Id + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                txtID_DetailView.Text = Id;
                while (reader.Read())
                {
                    txtName_DetailView.Text = reader["Name"].ToString();
                    if (!String.IsNullOrEmpty(reader["DoB"].ToString()))
                    {
                        dptDoB_GeneralInfo_DetailView.Value = Convert.ToDateTime(reader["DoB"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    }
                    if (reader["Gender"].ToString() == "1")
                    {
                        radMale_GeneralInfo_DetailView.Select();
                    }
                    else
                        radFemale_GeneralInfo_DetailView.Select();
                    txtAddress_GeneralInfo_DetailView.Text = reader["Address"].ToString();
                    txtEmail_GeneralInfo_DetailView.Text = reader["Email"].ToString();
                    txtSkype_GeneralInfo_DetailView.Text = reader["Skype"].ToString();
                    txtMobile_GeneralInfo_DetailView.Text = "0" + reader["Mobile"].ToString();
                    txtTypeOfDegree_GeneralInfo_DetailView.Text = reader["TypeOfDegree"].ToString();
                    txtInterestedProgram_GeneralInfo_DetailView.Text = reader["InterestedProgram"].ToString();
                    txtStudentStatus_GeneralInfo_DetailView.Text = reader["StudentStatus"].ToString();
                    txtStatusNote_GeneralInfo_DetailView.Text = reader["StatusNote"].ToString();
                    rtxt_Note_GeneralInfo_DetailView.Text = reader["Note"].ToString();
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * PhucVT
         * Detail Infomation View
         * 
         * **/
        public void DetailInfoView()
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = " select * from DetailInfo where ID = '" + Id + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    txtSchoolName_DetailInfo_DetailView.Text = reader["SchoolName"].ToString();
                    txtTypeOfSchool_DetailInfo_DetailView.Text = reader["TypeOfSchool"].ToString();
                    txtSchoolLocation_DetailInfo_DetailView.Text = reader["SchoolLocation"].ToString();
                    String date = reader["Passouts"].ToString();
                    if (!String.IsNullOrEmpty(date))
                    {
                        dptPassouts_DetailInfo_DetailView.Value = Convert.ToDateTime(date, System.Globalization.CultureInfo.CurrentCulture);
                    }
                    txtGPA_DetailInfo_DetailView.Text = reader["GPA"].ToString();
                    txtCompany_DetailInfo_DetailView.Text = reader["Company"].ToString();
                    txtFieldOfWork_DetailInfo_DetailView.Text = reader["FieldOfWork"].ToString();
                    txtCompanyLocation_DetailInfo_DetailView.Text = reader["CompanyLocation"].ToString();
                    txtPosition_DetailInfo_DetailView.Text = reader["Position"].ToString();
                    txtYearOfExperience_DetailInfo_DetailView.Text = reader["YearOfExperience"].ToString();
                    txtNote_DetailInfo_DetailView.Text = reader["Note"].ToString();
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * DauNQ
         * Add On arrival
         * 
         * **/
        public void OnArrivalView()
        {
            try
            {
                string connection = App.ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();
                string sqlSelect = "select * from OnArrival where ID = '" + Id + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    lbId_OnArrival.Text = reader["ID"].ToString();
                    string date = reader["DateFlight"].ToString();
                    dtpDateFlight_OnArrival.Text = reader["DateFlight"].ToString();
                    txtFlightNo_OnArrival.Text = reader["FlightNo"].ToString();
                    txtService_OnArrival.Text = reader["Service"].ToString();
                    txtCampusTour_OnArrival.Text = reader["CampusTour"].ToString();

                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load database!" + ex.Message);
            }
        }

        /**
         * PhungVM
         * Add Visa
         * 
         * **/
        public void VisaView()
        {
            //VISA
            try
            {
                SqlConnection sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = " select * from VISA where ID = '" + Id + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    txtNumber_VISA_DetailView.Text = reader["Number"].ToString();
                    txtType_VISA_DetailView.Text = reader["Type"].ToString();
                    if (!String.IsNullOrEmpty(reader["DateOfIssue"].ToString()))
                    {
                        dptPassouts_DetailInfo_DetailView.Value = Convert.ToDateTime(reader["DateOfIssue"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    }
                    if (!String.IsNullOrEmpty(reader["DateOfExpiry"].ToString()))
                    {
                        dptPassouts_DetailInfo_DetailView.Value = Convert.ToDateTime(reader["DateOfIssue"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    }
                    rtxtNote_VISA_DetailView.Text = reader["Note"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClose_DetailView_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteDetailView_DetailViewInfo_DetailView_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Student DetailInfo?", "Confirmation", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
            {
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();
                string sqlCount = "select * from DetailInfo DELETE FROM DetailInfo WHERE id='" + Id + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                MessageBox.Show("A Student DetailInfo has been deleted!");
            }
            else
                MessageBox.Show("pls select a row to delete");
        }

        
        public void createTempPDF(byte[] data)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("temp.pdf", FileMode.Create);
                fs.Write(data, 0, data.Length);
                fs.Close();
                pdfVisaView_VISA_DetailView.src = fs.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fs = null;
            }
        }
        public void downloadFromDatabse(String document)
        {
            try
            {
                SqlConnection
                sqlConn = new SqlConnection(App.ConnectionString);
                SqlCommand sqlCmd = new SqlCommand("select * from Visa where ID = '" + txtID_DetailView.Text + "'", sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    byte[] data = (byte[])reader[document];
                    createTempPDF(data);
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_VISA_DetailView_Click(object sender, EventArgs e)
        {
            downloadFromDatabse("VisaScan");
        }
        // Document Collection
        public void lockCheckboxDocument()
        {
            ckbPassport_DoccumentCo_DetailView.Enabled = false;
            ckbEnglish_DoccumentCo_DetailView.Enabled = false;
            ckbHelthCheck_DoccumentCo_DetailView.Enabled = false;
            ckbSchooling_DoccumentCo_DetailView.Enabled = false;
            ckbOfferLetter_DoccumentCo_DetailView.Enabled = false;
            ckbOther_DoccumentCo_DetailView.Enabled = false;
            
        }
        public void loadDocumentFromDatabase()
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();
                string sqlCount = " select * from DocumentCollection where ID = '" + Id + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    rtxtNote_DoccumentCo_DetailView.Text = reader["Note"].ToString();
                    String date = reader["Deadline"].ToString();
                    if (!String.IsNullOrEmpty(date))
                    {
                        dtpDeadline_DoccumentCo_DetailView.Value = Convert.ToDateTime(date, System.Globalization.CultureInfo.CurrentCulture);
                    }
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Boolean isNull(String column)
        {
            Boolean value = false;
            try
            {
                SqlConnection sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = "select * from DocumentCollection where ID = '" + Id + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.IsDBNull(reader[column]))
                    {
                        value = true;
                        break;
                    }
                }
                sqlConn.Close();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public Boolean idExistDocumentCollection()
        {
            Boolean value = false;
            try
            {
                SqlConnection sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = "select * from DocumentCollection";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Id.Equals(reader["ID"].ToString()))
                    {
                        value = true;
                        break;
                    }
                }
                sqlConn.Close();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public void setCheckedDocument()
        {
            if (isNull("Passport") || !idExistDocumentCollection())
            {
                ckbPassport_DoccumentCo_DetailView.Checked = false;
                btnPassportShow_DoccumentCo_DetailView.Enabled = false;
            }
            else
            {
                ckbPassport_DoccumentCo_DetailView.Checked = true;
                btnPassportShow_DoccumentCo_DetailView.Enabled = true;

            }
            if (isNull("HealthCheck") || !idExistDocumentCollection())
            {
                ckbHelthCheck_DoccumentCo_DetailView.Checked = false;
                btnHelthCheckShow_DoccumentCo_DetailView.Enabled = false;

            }
            else
            {
                ckbHelthCheck_DoccumentCo_DetailView.Checked = true;
                btnHelthCheckShow_DoccumentCo_DetailView.Enabled = true;
            }
            if (isNull("Schooling") || !idExistDocumentCollection())
            {
                ckbSchooling_DoccumentCo_DetailView.Checked = false;
                btnSchoolingShow_DoccumentCo_DetailView.Enabled = false;
            }
            else
            {
                ckbSchooling_DoccumentCo_DetailView.Checked = true;
                btnSchoolingShow_DoccumentCo_DetailView.Enabled = true;
            }
            if (isNull("English") || !idExistDocumentCollection())
            {
                ckbEnglish_DoccumentCo_DetailView.Checked = false;
                btnEnglishShow_DoccumentCo_DetailView.Enabled = false;
            }
            else
            {
                ckbEnglish_DoccumentCo_DetailView.Checked = true;
                btnEnglishShow_DoccumentCo_DetailView.Enabled = true;
            }
            if (isNull("OfferLetter") || !idExistDocumentCollection())
            {
                ckbOfferLetter_DoccumentCo_DetailView.Checked = false;
                btnOfferLetterShow_DoccumentCo_DetailView.Enabled = false;
            }
            else
            {
                ckbOfferLetter_DoccumentCo_DetailView.Checked = true;
                btnOfferLetterShow_DoccumentCo_DetailView.Enabled = true;
            }
            if (isNull("Others") || !idExistDocumentCollection())
            {
                ckbOther_DoccumentCo_DetailView.Checked = false;
                btnOthersShow_DoccumentCo_DetailView.Enabled = false;
            }
            else
            {
                ckbOther_DoccumentCo_DetailView.Checked = true;
                btnOthersShow_DoccumentCo_DetailView.Enabled = true;
            }
        }
        public void downloadDocumentDatabase(String document)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(App.ConnectionString);
                SqlCommand sqlCmd = new SqlCommand("select * from DocumentCollection where id = '" + Id + "'", sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    byte[] data = (byte[])reader[document];
                    FileStream fs = new FileStream("temp.pdf", FileMode.Create);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                    pdfShow_DocumentCo_DetailView.src = fs.Name;
                    fs = null;
                    // delete file
                    FileInfo fi = new FileInfo("temp.pdf");
                    if (fi.Exists)
                    {
                        fi.Delete();
                    }
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnPassportShow_DoccumentCo_DetailView_Click(object sender, EventArgs e)
        {
            downloadDocumentDatabase("Passport");
        }
        private void btnHelthCheckShow_DoccumentCo_DetailView_Click(object sender, EventArgs e)
        {
            downloadDocumentDatabase("HealthCheck");
        }

        private void btnSchoolingShow_DoccumentCo_DetailView_Click(object sender, EventArgs e)
        {
            downloadDocumentDatabase("Schooling");
        }

        private void btnEnglishShow_DoccumentCo_DetailView_Click(object sender, EventArgs e)
        {
            downloadDocumentDatabase("English");
        }

        private void btnOfferLetterShow_DoccumentCo_DetailView_Click(object sender, EventArgs e)
        {
            downloadDocumentDatabase("OfferLetter");
        }

        private void btnOthersShow_DoccumentCo_DetailView_Click(object sender, EventArgs e)
        {
            downloadDocumentDatabase("Others");
        }
    }
}
