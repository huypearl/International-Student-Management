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
 * ThangPD
 * 
 * **/
namespace AdmissionTrackingApp
{
    public partial class AddNewForm : Form
    {
        SqlDataAdapter sda = null;
        DataSet ds = null;
        SqlConnection sqlConn = null;
        public string Time { get; set; }
        public string Do { get; set; }
        public string ID { get; set; }
        public string acc { get; set; }
        public string acl { get; set; }

        private string imagePath ="";

        Login log = null;
        public AddNewForm()
        {
            InitializeComponent();
        }
        FileStream fs = null;
        public AddNewForm(string id,Login log)
        {
            InitializeComponent();
            this.log = log;
            string idNew = "";
            char[] c = id.ToCharArray(); //gan vao c
            char[] tg = new char[4];  //mang char chua phan so trong id
            for (int i = 3; i < 7; i++) //gan gia tri phan so trong id tu c vao tg
            {
                tg[i - 3] = c[i];
                idNew = idNew + tg[i - 3];
            }
            //dua gia tri tu tg vao idNew

            int ms = int.Parse(idNew);     // parse gia tri tu idNew vao ms theo kieu int
            ms++;                          //tang gia tri len 1 don vi
            //gan gia tri moi vao idNew  o dang string
            if (ms < 10)
            {
                idNew = "000" + ms;
            }
            else if (ms < 100)
            {
                idNew = "00" + ms;
            }
            else if (ms < 1000)
            {
                idNew = "0" + ms;
            }
            else
            {
                idNew = "" + ms;
            }
            tg = idNew.ToCharArray();      //truyen lai gia tri phan so cua id moi vao tg 
            for (int i = 3; i < 7; i++)    //dat lai gia tri phan so cho id
            {
                c[i] = tg[i - 3];
            }
            idNew = "";          //chuyen lai ve dang string
            for (int i = 0; i < c.Length; i++)
            {
                idNew = idNew + c[i];
            }
            txtID_AddNewForm.Text = idNew;

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

        private void btnAdd_AddNewForm(object sender, EventArgs e)
        {
            //open connection
            String connection = @"data source = (local); database = Admission_Tracking; integrated security = true";
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(connection);
            sqlConn.Open();
            string sqlCount = "select * from GeneralInfo";
            SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "GeneralInfo");


            string id = txtID_AddNewForm.Text;
            //check id not null
            if (string.IsNullOrEmpty(id))
            {
                errorProvider1.SetError(txtID_AddNewForm, "ID cannot be empty!");
                txtID_AddNewForm.Focus();
                return;
            }



            string name = txtName_AddNewForm.Text;
            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(txtName_AddNewForm, "Name cannot be empty!");
                txtName_AddNewForm.Focus();
                return;
            }

            // in general information tab for a new student
            DateTime date = dtpDoB_AddNewForm.Value.Date;
            Boolean gender = radMale_AddNewForm.Checked;
            string address = txtAddress_AddNewForm.Text;
            if (string.IsNullOrEmpty(address))
            {
                errorProvider1.SetError(txtAddress_AddNewForm, "Address cannot be empty!");
                txtAddress_AddNewForm.Focus();
                return;
            }
            string email = txtMail_AddNewForm.Text;
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txtMail_AddNewForm, "Email cannot be empty!");
                txtMail_AddNewForm.Focus();
                return;
            }
            //check if mobile is number or not 
            char[] m = txtMobile_AddNewForm.Text.ToCharArray();
            foreach (char c in m)
            {
                if (!char.IsDigit(c))
                {
                    errorProvider1.SetError(txtMobile_AddNewForm, "Mobile must be all numbers!");
                    txtMobile_AddNewForm.Focus();
                    return;
                }
            }
            int mobile;
            if (!String.IsNullOrEmpty(txtMobile_AddNewForm.Text))
            {
                mobile = int.Parse(txtMobile_AddNewForm.Text);

            }
            else mobile = 0;


            string skype = txtSkype_AddNewForm.Text;
            string type = txtTypeOfDegree_AddNewForm.Text;
            if (string.IsNullOrEmpty(type))
            {
                errorProvider1.SetError(txtTypeOfDegree_AddNewForm, "Type of Degree cannot be empty!");
                txtTypeOfDegree_AddNewForm.Focus();
                return;
            }
            string ip = txtInterestedPro_AddNewForm.Text;
            if (string.IsNullOrEmpty(ip))
            {
                errorProvider1.SetError(txtInterestedPro_AddNewForm, "Interested Program cannot be empty!");
                txtInterestedPro_AddNewForm.Focus();
                return;
            }
            int choice = cbxStudentStatus_AddNewForm.SelectedIndex;
            string studentstatus = "";

            if (choice == 0)
            {
                studentstatus = "Out";
            }
            if (choice == 1)
            {
                studentstatus = "On hold";
            } if (choice == 2)
            {
                studentstatus = "Processing Level 1";
            } if (choice == 3)
            {
                studentstatus = "Processing Level 2";
            } if (choice == 4)
            {
                studentstatus = "Processing Level 3";
            } if (choice == 5)
            {
                studentstatus = "Processing Level 4";
            } if (choice == 6)
            {
                studentstatus = "Processing Level 5";
            } if (choice == 7)
            {
                studentstatus = "Matched";
            }
            string statusnote = txtStatusNote_AddNewForm.Text;
            string note = rtxtNote_AddNewForm.Text;


            //add anh
            byte[] pb = null;
            if (imagePath != "")
            {
                pb = File.ReadAllBytes(imagePath);
            }
            
            //save data to newrow = ds.table[0].newRow
            DataRow newrow = ds.Tables["GeneralInfo"].NewRow();

            newrow[0] = id;
            newrow[1] = name;
            newrow[2] = date;
            newrow[3] = gender;
            newrow[4] = address;
            newrow[5] = email;
            newrow[6] = mobile;
            newrow[7] = skype;
            newrow[8] = type;
            newrow[9] = ip;
            newrow[10] = studentstatus;
            newrow[11] = statusnote;
            newrow[12] = note;
            newrow[13] = pb;
            ds.Tables[0].Rows.Add(newrow);

            //configure sda to parse data form ds to datasource
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            sda.Update(ds, "GeneralInfo");
            

            //get this variable to transfer to log
            Time = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            Do = " had Add new student";
            ID = id;
            frmCounselingHistory ch = new frmCounselingHistory(this);

            /**
             * PhungVM
             * Add Visa
             * 
             * **/

            try
            {
                string sqlSelect1 = " Select * from VISA ";
                SqlCommand sqlCmd2 = new SqlCommand(sqlSelect1, sqlConn);
                sda = new SqlDataAdapter(sqlCmd2);
                ds = new DataSet();
                sda.Fill(ds, "VISA");
                string type_VISA = txtType_VISA_AddNewForm.Text;
                string number = txtNumber_VISA_AddNewForm.Text;
                string doi = dtpDateOfIssue_VISA_AddNewForm.Value.ToShortDateString();
                string doe = dtpDateOfExpiry_VISA_AddNewForm.Value.ToShortDateString();
                string note_VISA = rtxtNote_VISA_AddNewForm.Text;
                DataRow newRow1 = ds.Tables["VISA"].NewRow();
                newRow1[0] = id;
                newRow1[1] = number;
                newRow1[2] = type_VISA;
                newRow1[3] = doi;
                newRow1[4] = doe;
                newRow1[5] = note_VISA;
                ds.Tables[0].Rows.Add(newRow1);
                SqlCommandBuilder builder1 = new SqlCommandBuilder(sda);
                sda.Update(ds, "VISA");
                uploadToDatabase("VisaScan");
                //MessageBox.Show("New Student has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //On Arrival
            try
            {
                string sqlSelect2 = " Select * from OnArrival ";
                SqlCommand sqlCmd3 = new SqlCommand(sqlSelect2, sqlConn);
                sda = new SqlDataAdapter(sqlCmd3);
                ds = new DataSet();
                sda.Fill(ds, "OnArrival");
                DateTime dateFlight = dtpDateFlight_OnArrival.Value.Date;
                string flightNo = txtFlightNo_OnArrival.Text;
                string service = txtService_OnArrival.Text;
                string campusTour = txtCampusTour_OnArrival.Text;
                DataRow newRow2 = ds.Tables["OnArrival"].NewRow();
                newRow2[0] = id;
                newRow2[1] = dateFlight;
                newRow2[2] = flightNo;
                newRow2[3] = service;
                newRow2[4] = campusTour;
                ds.Tables[0].Rows.Add(newRow2);
                SqlCommandBuilder builder1 = new SqlCommandBuilder(sda);
                sda.Update(ds, "OnArrival");
                //MessageBox.Show("New Student has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // DetailView & Document  - HuyTLN
            addDetailView();
            addDocumentInfo();
            // delete temp file document
            FileInfo fi = new FileInfo("tempDocument.pdf");
            if (fi.Exists)  fi.Delete();
            FileInfo fi2 = new FileInfo("temp.pdf");
            if (fi2.Exists)
            {
                fi.Delete();
            }
            MessageBox.Show("New applicant has been added!");
            this.Close();
            imagePath = "";
        }

        public void uploadToDatabase(String document)
        {
            try
            {
                FileStream fs = new FileStream("temp.pdf", FileMode.Open);
                if (fs == null)
                {
                    MessageBox.Show("Please choose a PDF file to upload");
                    return;
                }
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();
                sqlConn = new SqlConnection(App.ConnectionString);
                String sqlUpdate = "update VISA set " + document + " =  @contents where ID = '" + txtID_AddNewForm.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, sqlConn);
                cmd.Parameters.AddWithValue("@contents", data);
                sqlConn.Open();
                if (cmd.ExecuteNonQuery() != 0)
                    //MessageBox.Show("Adding PDF file is done !");
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "JPG file only(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                imagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.Height = 138;
                pictureBox1.Width = 120;
                pictureBox1.Update();
            }
            profiletxt_AddNewForm.Enabled = false;
            profiletxt_AddNewForm.Visible = false;
        }

        private void btnClose_VISA_AddNewForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_VISA_AddNewForm_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Multiselect = false;
            ofd.Filter = "PDF file only(*.pdf)|*.pdf";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();
                createTempPDF(data);
            }
        }

        private void btnDownload_VISA_AddNewForm_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("temp.pdf", FileMode.Open);
                if (fs == null)
                {
                    MessageBox.Show("Please choose a PDF file to save !");
                    return;
                }
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save File";
                sfd.Filter = "PDF file only(*.pdf)|*.pdf";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fname = sfd.FileName;
                    if (fname.LastIndexOf(".pdf") == -1) fname += ".pdf";
                    fs = new FileStream(fname, FileMode.Create);
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                    if (MessageBox.Show("Do you want to open this file ?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        System.Diagnostics.Process.Start(fname);
                }
                sfd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void createTempPDF(byte[] data)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("temp.pdf", FileMode.Create);
                fs.Write(data, 0, data.Length);
                fs.Close();
                axAcroPDF2.src = fs.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fs = null;
            }
        }
        public void addDetailView()
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
                String note = txtNoteDetailView.Text;
                String idSelected = txtID_AddNewForm.Text;
                // set data to database
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sql = string.Format(" update DetailInfo "
                    + " set SchoolName = '{0}', TypeOfSchool = '{1}', SchoolLocation = '{2}', Passouts = '{3}', GPA = {4}, Company ='{5}', "
                    + " FieldOfWork = '{6}', CompanyLocation = '{7}', Position = '{8}', YearOfExperience = {9}, Note = '{10}' "
                    + " where ID = '{11}';", schoolName, schoolType, schoolLocation, passout, gpaString, company, workfield, companyLocation, position, yearString, note, idSelected);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                sqlCmd.ExecuteNonQuery();

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

        // Document Collection - HuyTLN
        public void uploadDocumentToDatabase(String document)
        {
            try
            {
                FileStream fs = new FileStream("tempDocument.pdf", FileMode.Open);
                if (fs == null)
                {
                    MessageBox.Show("Please choose a PDF file to upload");
                    return;
                }
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();
                sqlConn = new SqlConnection(App.ConnectionString);
                String sqlUpdate = "update DocumentCollection set " + document + " =  @contents where ID = '" + txtID_AddNewForm.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, sqlConn);
                cmd.Parameters.AddWithValue("@contents", data);
                sqlConn.Open();
                if (cmd.ExecuteNonQuery() != 0)
                    MessageBox.Show("Adding PDF file is done !");
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addDocumentInfo()
        {
            try
            {
                String note = rtxtNote_DocCollection_AddNewForm.Text;
                String passout = dtpDeadline_DocCollection_AddNewForm.Value.ToShortDateString();
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sql = string.Format(" update DocumentCollection "
                    + " set Note = '{0}', Deadline = '{1}' "
                    + " where ID = '{2}';", note, passout, txtID_AddNewForm.Text);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
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
        private void btnOpen_DocumentCollection_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Multiselect = false;
            ofd.Filter = "PDF file only(*.pdf)|*.pdf";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();
                createTempPDFforDocument(data);
            }
        }
        public void createTempPDFforDocument(byte[] data)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("tempDocument.pdf", FileMode.Create);
                fs.Write(data, 0, data.Length);
                fs.Close();
                axAcroPDF1.src = fs.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fs = null;
            }
        }

        private void btnUploadPassport_Click(object sender, EventArgs e)
        {
            uploadDocumentToDatabase("Passport");
        }

        private void btnUploadHealthCheck_Click(object sender, EventArgs e)
        {
            uploadDocumentToDatabase("HealthCheck");
        }

        private void btnUploadSchooling_Click(object sender, EventArgs e)
        {
            uploadDocumentToDatabase("Schooling");
        }

        private void btnUploadEnglish_Click(object sender, EventArgs e)
        {
            uploadDocumentToDatabase("English");
        }

        private void btnUploadOfferLetter_Click(object sender, EventArgs e)
        {
            uploadDocumentToDatabase("OfferLetter");
        }

        private void btnUploadOthers_Click(object sender, EventArgs e)
        {
            uploadDocumentToDatabase("Others");
        }
    }
}
