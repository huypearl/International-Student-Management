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
    public partial class frmVisa : Form
    {
        string selectedID;
        public frmVisa()
        {
            InitializeComponent();
        }

        public frmVisa(string si)
        {
            InitializeComponent();
            selectedID = si;
        }

        private void frmVisa_Load(object sender, EventArgs e)
        {
            try
            {
                string connection = App.ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();
                string sqlSelect = "select * from VISA where ID = '" + selectedID + "'";
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    lbId_Visa.Text = reader["ID"].ToString();
                    txtType_Visa.Text = reader["Type"].ToString();
                    string number = reader["Number"].ToString();
                    string doi = reader["DateOfIssue"].ToString();
                    string doe = reader["DateOfExpiry"].ToString();
                    txtNumber_Visa.Text = number;
                    dtpDateOfIssue_Visa.Text = doi;
                    dtpDateOfExpiry_Visa.Text = doe;
                    rtxtNote_Visa.Text = reader["Note"].ToString();

                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load database!" + ex.Message);
            }
        }

        private void btnUpdate_VISA_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = App.ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();

                string id = lbId_Visa.Text;
                string number = txtNumber_Visa.Text;
                string type_VISA = txtType_Visa.Text;
                string doi = dtpDateOfIssue_Visa.Value.ToString("M-d-yyyy");
                string doe = dtpDateOfExpiry_Visa.Value.ToString("M-d-yyyy");
                string note = rtxtNote_Visa.Text;

                string sql = string.Format("UPDATE VISA "
                    + "SET Number = '{0}', Type ='{1}', DateOfIssue = '{2}', DateOfExpiry = '{3}', Note = '{4}' "
                    + "WHERE ID = '{5}' ", number, type_VISA, doi, doe, note, id);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Student information has been added");
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This app stopped suddenly!" + ex.Message);
            }
        }

        public void uploadToDatabase(String document)
        {
            string connection = App.ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connection);
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
                String sqlUpdate = "update VISA set " + document + " =  @contents where ID = '" + selectedID + "'";
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

        public void createTempPDF(byte[] data)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("temp.pdf", FileMode.Create);
                fs.Write(data, 0, data.Length);
                fs.Close();
                axAcroPDF3.src = fs.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fs = null;
            }
        }
        public void downloadFromDatabse(String document)
        {
            SqlConnection sqlConn;
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                SqlCommand sqlCmd = new SqlCommand("select * from Visa where ID = '" + lbId_Visa.Text + "'", sqlConn);
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

        private void btnBrowse_frmVisa_Click(object sender, EventArgs e)
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

        private void btnShow_frmVisa_Click(object sender, EventArgs e)
        {
            downloadFromDatabse("VisaScan");
        }
    }
}
