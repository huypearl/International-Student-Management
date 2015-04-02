using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace AdmissionTrackingApp
{
    public partial class frmImport : Form
    {
        public string sheet = null;
        DataTable test = null;
        public frmImport()
        {
            InitializeComponent();
        }
        private void btnImport_Import_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinkFile_Import.Text))
            {
                errorProvider1.SetError(txtLinkFile_Import, "Link cannot be empty!");
                txtLinkFile_Import.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtSheet_Import.Text))
            {
                errorProvider1.SetError(txtSheet_Import, "Sheet cannot be empty!");
                txtSheet_Import.Focus();
                return;
            }
            else
            {
                test = getDataFromXLS(txtLinkFile_Import.Text);             
                if (test != null)
                    dataGridView_Import.DataSource = test;
            }
        }
        private DataTable getDataFromXLS(string strFilePath)
        {
            string sheet = txtSheet_Import.Text;
            try
            {
                //sheet = txtSheet_Import.Text;
                string strConnectionString = "";
                strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                                 "Data Source=" + strFilePath + "; Jet OLEDB:Engine Type=5;" +
                                                 "Extended Properties=Excel 8.0;";
                OleDbConnection cnCSV = new OleDbConnection(strConnectionString);
                cnCSV.Open();
                //string stringConn="SELECT * FROM [{0}$]"
                OleDbCommand cmdSelect = new OleDbCommand(@String.Format("SELECT * FROM [{0}$]", sheet), cnCSV);
                OleDbDataAdapter daCSV = new OleDbDataAdapter(); 
                daCSV.SelectCommand = cmdSelect;
                DataTable dtb = new DataTable();
                daCSV.Fill(dtb);
                cnCSV.Close();
                daCSV = null;
                return dtb;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally { }
        }

        private void btnBrowse_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Exel File(*.xls)|*.xls";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtLinkFile_Import.Text = ofd.FileName;
                //imagePath = ofd.FileName;
            }
            else
            {
                return;
            }
        }
        int mobile;
        private void btnAddtoDB_Import_Click(object sender, EventArgs e)
        {
            String connection = @"data source = (local); database = Admission_Tracking; integrated security = true";
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(connection);
            sqlConn.Open();
            string sqlCount = "select * from GeneralInfo";
            SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "GeneralInfo");

            for (int i = 0; i < dataGridView_Import.RowCount; i++)
            {
                string id = dataGridView_Import.CurrentRow.Cells[0].Value.ToString();
                string name = dataGridView_Import.CurrentRow.Cells[1].Value.ToString();
                // in general information tab for a new student
                string date = dataGridView_Import.CurrentRow.Cells[2].Value.ToString();
                bool gender;
                if (dataGridView_Import.CurrentRow.Cells[3].Value.ToString() == "Male")
                    gender = true;
                else
                    gender = false;
                string address = dataGridView_Import.CurrentRow.Cells[4].Value.ToString();
                string email = dataGridView_Import.CurrentRow.Cells[5].Value.ToString();
                if (dataGridView_Import.CurrentRow.Cells[6].Value.ToString() != null)
                {
                    mobile = Convert.ToInt32(dataGridView_Import.CurrentRow.Cells[6].Value.ToString());
                }
                else
                    mobile = 0;
                string skype = "";
                string type = "";
                string ip = "";
                string studentstatus = dataGridView_Import.CurrentRow.Cells[7].Value.ToString(); ;

                string statusnote = "";
                string note = "";

                //add anh
                //byte[] pb = null;
                //if (imagePath != "")
                //{
                //    pb = File.ReadAllBytes(imagePath);
                //}

                //save textbox data to newrow = ds.table[0].newRow
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
                //newrow[13] = pb;

                ds.Tables[0].Rows.Add(newrow);

                //configure sda to parse data form ds to datasource
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                sda.Update(ds, "GeneralInfo");

            }
            MessageBox.Show("New applicant has been added!");
            sqlConn.Close();
            this.Close();
        }

    }
}
