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
    public partial class DocumentCollection : Form
    {
        SqlConnection sqlConn;
        public DocumentCollection()
        {
            InitializeComponent();
        }
        public DocumentCollection(String id)
        {
            InitializeComponent();
            labID.Text = id;
            setCheckedDocument();
            loadDataFromDatabase();
            getName(labID.Text);
        }
        private void DocumentCollection_Load(object sender, EventArgs e)
        {
            chkPassport.Enabled = false;
            chkHealthCheck.Enabled = false;
            chkEnglish.Enabled = false;
            chkOfferLetter.Enabled = false;
            chkSchooling.Enabled = false;
            chkOther.Enabled = false;
        }
        public void setCheckedDocument()
        {
            if (isNull("Passport"))
            {
                chkPassport.Checked = false;
                btnShowPassport.Enabled = false;
            }
            else
            {
                chkPassport.Checked = true;
                btnShowPassport.Enabled = true;
            
            }
            if (isNull("HealthCheck"))
            {
                chkHealthCheck.Checked = false;
                btnShowHealthCheck.Enabled = false;

            }
            else
            {
                chkHealthCheck.Checked = true;
                btnShowHealthCheck.Enabled = true;
            }
            if (isNull("Schooling"))
            {
                chkSchooling.Checked = false;
                btnShowSchooling.Enabled = false;
            }
            else
            {
                chkSchooling.Checked = true;
                btnShowSchooling.Enabled = true;
            }
            if (isNull("English"))
            {
                chkEnglish.Checked = false;
                btnShowEnglish.Enabled = false;
            }
            else
            {
                chkEnglish.Checked = true;
                btnShowEnglish.Enabled = true;
            }
            if (isNull("OfferLetter"))
            {
                chkOfferLetter.Checked = false;
                btnShowOfferLetter.Enabled = false;
            }
            else
            {
                chkOfferLetter.Checked = true;
                btnShowOfferLetter.Enabled = true;
            }
            if (isNull("Others"))
            {
                chkOther.Checked = false;
                btnShowOthers.Enabled = false;
            }
            else
            {
                chkOther.Checked = true;
                btnShowOthers.Enabled = true;
            }
        }
     
        public Boolean isNull(String column)
        {
            Boolean value = false;
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = "select * from DocumentCollection where ID = '"+labID.Text+"'";
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
        public void getName(String id)
        {
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = " select * from GeneralInfo where ID = '" + labID.Text + "'";
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
        private void btnUploadPassport_Click(object sender, EventArgs e)
        {
            uploadToDatabase("Passport");
        }

        private void btnShowPassport_Click(object sender, EventArgs e)
        {
            downloadFromDatabse("Passport");
        }

        private void btnShowHealthCheck_Click(object sender, EventArgs e)
        {
            downloadFromDatabse("HealthCheck");
        }

        private void btnShowSchooling_Click(object sender, EventArgs e)
        {
            downloadFromDatabse("Schooling");
        }

        private void btnShowEnglish_Click(object sender, EventArgs e)
        {
            downloadFromDatabse("English");
        }

        private void btnShowOfferLetter_Click(object sender, EventArgs e)
        {
            downloadFromDatabse("OfferLetter");
        }

        private void btnShowOthers_Click(object sender, EventArgs e)
        {
            downloadFromDatabse("Others");
        }

        private void btnUploadHealthCheck_Click(object sender, EventArgs e)
        {
            uploadToDatabase("HealthCheck");
        }

        private void btnUploadSchooling_Click(object sender, EventArgs e)
        {
            uploadToDatabase("Schooling");
        }

        private void btnUploadEnglish_Click(object sender, EventArgs e)
        {
            uploadToDatabase("English");
        }

        private void btnUploadOfferLetter_Click(object sender, EventArgs e)
        {
            uploadToDatabase("OfferLetter");
        }

        private void btnUploadOthers_Click(object sender, EventArgs e)
        {
            uploadToDatabase("Others");
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (axAcroPDF1.src == null)
            {
                MessageBox.Show("You have to choose a pdf to display !");
                return;
            }
            DocumentPreview dp = new DocumentPreview(axAcroPDF1);
            dp.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("temp.pdf");
            if (fi.Exists)
            {
                fi.Delete();
            }
            this.Close();
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
                String sqlUpdate = "update DocumentCollection set " + document + " =  @contents where ID = '" + labID.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, sqlConn);
                cmd.Parameters.AddWithValue("@contents", data);
                sqlConn.Open();
                if (cmd.ExecuteNonQuery() != 0)
                    MessageBox.Show("Adding PDF file is done !");
                sqlConn.Close();
                setCheckedDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void downloadFromDatabse(String document)
        {
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                SqlCommand sqlCmd = new SqlCommand("select * from DocumentCollection where id = '" + labID.Text + "'", sqlConn);
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
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (axAcroPDF1.src == null)
            {
                MessageBox.Show("You have to choose a pdf to display !");
                return;
            }
            try
            {
                FileStream fs = new FileStream("temp.pdf", FileMode.Open);
                if (fs == null)
                {
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
        private void btnOpen_Click(object sender, EventArgs e)
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
        public void createTempPDF(byte[] data)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("temp.pdf", FileMode.Create);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String note = txtNote.Text;
                String passout = datepickerDeadline.Value.ToShortDateString();
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sql = string.Format(" update DocumentCollection "
                    + " set Note = '{0}', Deadline = '{1}' "
                    + " where ID = '{2}';", note, passout, labID.Text);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Document information has been updated !");
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
        public void loadDataFromDatabase()
        {
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = " select * from DocumentCollection where ID = '" + labID.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    txtNote.Text = reader["Note"].ToString();
                    String date = reader["Deadline"].ToString();
                    if (!String.IsNullOrEmpty(date))
                    {
                        datepickerDeadline.Value = Convert.ToDateTime(date, System.Globalization.CultureInfo.CurrentCulture);
                    }
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
