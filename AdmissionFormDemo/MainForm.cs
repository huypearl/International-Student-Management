using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;

namespace AdmissionTrackingApp
{
    public partial class MainForm : Form
    {
        String idSelected;
        DataView dv = null;
        public string Usename { get; set; }
        public string Password { get; set; }
        public string AccountLevel { get; set; }
        public MainForm()
        {
            InitializeComponent();
            AutoCompleteTextBox();
        }
        Login log = null;

        /**
         * PhucVT
         * Get variable from Login Form
         * 
         * **/
        public MainForm(Login log)
        {
            InitializeComponent();
            this.log = log;
            AutoCompleteTextBox();
        }

        /**
         * Variable
         * COMMON
         * 
         **/

        SqlDataAdapter sda = null;
        DataSet ds = null;
        SqlConnection sqlConn = null;
        SqlDataReader dr = null;
        string idgenerate = "";
        public string StudentStatus { get; set; }
        public int CurrentIndex { get; set; }
        public string StudentNote { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }

        /**
         * Phuc VT
         * Set visible - enable on GUI
         * 
         **/
        public void setLockForm()
        {
            btnAddAccount_MainForm.Enabled = false;
            btnAccountManager_MainForm.Enabled = false;
            btnGeneralInfo_MainForm.Enabled = true;
            btnDetailInfo_MainForm.Enabled = true;
            btnDocCollection_MainForm.Enabled = false;
            btnGeneralInfo_MainForm.Enabled = false;
            btnFee_MainForm.Enabled = false;
            btnVisa_MainForm.Enabled = false;
            btnOnArrival_MainForm.Enabled = false;

        }
        public void autoUnlockGUI()
        {
            if (log.AccountLevel == 1)
            {
                btnAddAccount_MainForm.Enabled = true;
                btnAccountManager_MainForm.Enabled = true;
            }
            try
            {
                String connection = App.ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();
                string sqlSelect = "select * from GeneralInfo";
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "GeneralInfo");

                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    String id = reader["Id"].ToString();
                    if(id.Equals(idSelected))
                    {
                        StudentStatus = reader.GetValue(10).ToString();
                        StudentNote = reader.GetValue(12).ToString();
                    }
                }
                sqlConn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            txtStatus_Status_MainForm.Enabled = true;
            txtStatus_Status_MainForm.Text = StudentStatus;
            rtxtNote_MainForm.Text = StudentNote;
            if(StudentStatus=="Processing Level 1")
            {
                btnGeneralInfo_MainForm.Enabled = true;
                btnDetailInfo_MainForm.Enabled = true;
                btnDocCollection_MainForm.Enabled = false;
                btnFee_MainForm.Enabled = false;
                btnVisa_MainForm.Enabled = false;
                btnOnArrival_MainForm.Enabled = false;
                btnAccomodation_MainForm.Enabled = false;
            } 
            else if(StudentStatus=="Processing Level 2")
            {
                btnGeneralInfo_MainForm.Enabled = true;
                btnDetailInfo_MainForm.Enabled = true;
                btnDocCollection_MainForm.Enabled = true;
                btnFee_MainForm.Enabled = false;
                btnVisa_MainForm.Enabled = false;
                btnOnArrival_MainForm.Enabled = false;
                btnAccomodation_MainForm.Enabled = false;
            }
            else if (StudentStatus == "Processing Level 3")
            {
                btnGeneralInfo_MainForm.Enabled = true;
                btnDetailInfo_MainForm.Enabled = true;
                btnDocCollection_MainForm.Enabled = true;
                btnFee_MainForm.Enabled = true;
                btnVisa_MainForm.Enabled = false;
                btnOnArrival_MainForm.Enabled = false;
                btnAccomodation_MainForm.Enabled = false;
            }
            else if (StudentStatus == "Processing Level 4")
            {
                btnGeneralInfo_MainForm.Enabled = true;
                btnDetailInfo_MainForm.Enabled = true;
                btnDocCollection_MainForm.Enabled = true;
                btnFee_MainForm.Enabled = true;
                btnVisa_MainForm.Enabled = true;
                btnOnArrival_MainForm.Enabled = false;
                btnAccomodation_MainForm.Enabled = false;
            }
            else if (StudentStatus == "Processing Level 5")
            {
                btnGeneralInfo_MainForm.Enabled = true;
                btnDetailInfo_MainForm.Enabled = true;
                btnDocCollection_MainForm.Enabled = true;
                btnFee_MainForm.Enabled = true;
                btnVisa_MainForm.Enabled = true;
                btnOnArrival_MainForm.Enabled = true;
                btnAccomodation_MainForm.Enabled = true;
            }
            else if (StudentStatus == "Matched")
            {
                btnGeneralInfo_MainForm.Enabled = true;
                btnDetailInfo_MainForm.Enabled = true;
                btnDocCollection_MainForm.Enabled = true;
                btnFee_MainForm.Enabled = true;
                btnVisa_MainForm.Enabled = true;
                btnOnArrival_MainForm.Enabled = true;
                btnAccomodation_MainForm.Enabled = true;
            }
            else if (StudentStatus == "Out")
            {
                btnGeneralInfo_MainForm.Enabled = true;
                btnDetailInfo_MainForm.Enabled = true;
                btnDocCollection_MainForm.Enabled = false;
                btnFee_MainForm.Enabled = false;
                btnVisa_MainForm.Enabled = false;
                btnOnArrival_MainForm.Enabled = false;
                btnAccomodation_MainForm.Enabled = false;
            }
            else
            {
                btnGeneralInfo_MainForm.Enabled = true;
                btnDetailInfo_MainForm.Enabled = true;
                btnDocCollection_MainForm.Enabled = false;
                btnFee_MainForm.Enabled = false;
                btnVisa_MainForm.Enabled = false;
                btnOnArrival_MainForm.Enabled = false;
                btnAccomodation_MainForm.Enabled = false;
            }
        }

        private void showTotalRecord()
        {
            if (gridView_MainForm.SelectedCells[0].Value == null) return;
            try
            {
                lbNumRecord_MainForm.Text = "" + (gridView_MainForm.RowCount - 1);
                lbRowIndex_MainForm.Text = "" + gridView_MainForm.SelectedCells[0].RowIndex;
                lbColumnIndex_MainForm.Text = "" + gridView_MainForm.SelectedCells[0].ColumnIndex;
                lbContent_MainForm.Text = gridView_MainForm.SelectedCells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        public void updateData()
        {
            //PhucVT - Set lock form
            setLockForm();
            autoUnlockGUI();

            //HuyTLN - Fill data to DataGridView
            gridView_MainForm.ReadOnly = true;
            sqlConn = new SqlConnection(App.ConnectionString);
            sqlConn.Open();
            string sqlCount = "select ID, Name , DoB, Gender = "
                                   + " case Gender "
                                   + " when '1' then 'Male'"
                                   + " when '0' then 'Female'"
                                   + " end, Address, Email, Mobile, StudentStatus"
                                   + " from GeneralInfo";
            SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
            sda = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            sda.Fill(ds, "GeneralInfo");

            //Thang PD
            dv = new DataView(ds.Tables["GeneralInfo"]);

            SqlDataReader reader = sqlCmd.ExecuteReader();

            gridView_MainForm.DataSource = dv;

            //gridView_MainForm.DataSource = ds.Tables["GeneralInfo"];
            int count = gridView_MainForm.RowCount;
            if (count == 1)
            {
                MessageBox.Show("Data null");
                btnDelete_MainForm.Enabled = false;
                sqlConn.Close();
                return;
            }
            else btnDelete_MainForm.Enabled = true;
            //CurrentIndex = gridView_MainForm.CurrentRow.Index;
            idgenerate = gridView_MainForm.Rows[count - 2].Cells[0].Value.ToString();
            sqlConn.Close();

            //PhucVT - Get infomation for Account
            if (log.AccountLevel == 1)
            {
                labAccountLevel_MainForm.Text = "Admin";
                AccountLevel = "Admin";
            }
            else
            {
                labAccountLevel_MainForm.Text = "Agent";
                AccountLevel = "Agent";
            }
            llbAccountName_MainForm.Text = log.Account;
            Usename = log.Account;
            autoUnlockGUI();

            showTotalRecord();
        }

        public void AutoCompleteTextBox()
        {
            //Properties autocopelete for ID
            txtID_MainForm.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtID_MainForm.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection collID = new AutoCompleteStringCollection();

            //Properties autocopelete for Name
            txtName_MainForm.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtName_MainForm.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection collName = new AutoCompleteStringCollection();

            //Properties autocomplete for Address
            txtAddress_Search_Mainform.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAddress_Search_Mainform.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection collAddress = new AutoCompleteStringCollection();

            //Get data to Custom Source
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = "select ID, Name , DoB, Gender = "
                                       + " case Gender "
                                       + " when '1' then 'Male'"
                                       + " when '0' then 'Female'"
                                       + " end, Address, Email, Mobile, StudentStatus"
                                       + " from GeneralInfo";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string name = reader["Name"].ToString();
                    string address = reader["Address"].ToString();
                    collID.Add(id);
                    collName.Add(name);
                    collAddress.Add(address);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtID_MainForm.AutoCompleteCustomSource=collID;
            txtName_MainForm.AutoCompleteCustomSource = collName;
            txtAddress_Search_Mainform.AutoCompleteCustomSource = collAddress;
        }
        
        /**
         * COMMON
         * 
         * **/
        private void MainForm_Load(object sender, EventArgs e)
        {
            updateData();
        }

        /**
         * TuanHA
         * Function General Information and Detail Infomation
         * 
         * **/
        private void btnDetail_MainForm_Click(object sender, EventArgs e)
        {
            if (gridView_MainForm.CurrentRow != null)
            {
                DetailView dti = new DetailView(idSelected,log);
                dti.ShowDialog();
                updateData();
            }
            else
            {
                MessageBox.Show("Please choose a student to update information...!",
                            "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /**
         * ThangPD
         * All Function for btnAdd_MainForm
         * 
         * **/
        private void btnAdd_MainForm_Click(object sender, EventArgs e)
        {
            try
            {
                String connection = @"data source = (local); database = Admission_Tracking; integrated security = true";
                sqlConn = new SqlConnection(connection);
                sqlConn.Open();
                string sqlCount = "select ID, Name , DoB, Gender = "
                                       + " case Gender "
                                       + " when '1' then 'Male'"
                                       + " when '0' then 'Female'"
                                       + " end, Address, Email, Mobile, StudentStatus"
                                       + " from GeneralInfo";
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                sda = new SqlDataAdapter(sqlCmd);
                ds = new DataSet();
                sda.Fill(ds, "GeneralInfo");
                gridView_MainForm.DataSource = ds.Tables["GeneralInfo"];
                int count = gridView_MainForm.RowCount;
                if (count == 0 || count == 1)
                {
                    idgenerate = "AP00000";
                }
                else
                {
                    idgenerate = gridView_MainForm.Rows[count - 2].Cells[0].Value.ToString();
                }
                sqlConn.Close();
                AddNewForm anf = new AddNewForm(idgenerate,log);
                anf.ShowDialog();
                updateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /**
         * PhucVT
         * Delete a applicant
         * 
         * **/
        private void btnDelete_MainForm_Click(object sender, EventArgs e)
        {
            /*
            * 1. select a row from datagridview
            * 2. remove selected row
            */
            if (String.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("You have to choose an student !");
                return;
            }
            if (gridView_MainForm.SelectedCells[0] != null)
            {
                if (MessageBox.Show("Delete?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int i = gridView_MainForm.SelectedCells[0].RowIndex;
                    String g = null;
                    if (gridView_MainForm.CurrentRow != null)
                    {
                        g = gridView_MainForm.CurrentRow.Cells[0].Value.ToString();
                        //remove ith row
                        ds.Tables[0].Rows[i].Delete();
                        //configure sda
                        SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                        sda.Update(ds, "GeneralInfo");
                        MessageBox.Show("A applicant has been deleted");
                        // write to log
                    }
                    if (!String.IsNullOrEmpty(g))
                    {
                        TextWriter tsw = new StreamWriter(@"D:\Demo.txt", true);
                        string s = null;
                        if (log.AccountLevel == 1)
                        {
                            s = "Admin";
                        }
                        else
                        {
                            s = "Agent";
                        }
                        tsw.WriteLine(DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + "   " + s + " " + log.Account + " had deleted Student "+g);
                        tsw.Close();
                    }
                }
            }
            else
                MessageBox.Show("Please select a row to delete");
            updateData();
        }

        /**
         * DauNQ
         * All Function for btnGeneralInfo_MainForm
         * 
         * **/
        private void btnGeneralInfo_MainForm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("You have to choose an student !");
                return;
            }
            if (gridView_MainForm.CurrentRow != null)
            {
                EditGeneralInfo editGen = new EditGeneralInfo(idSelected,log);
                editGen.ShowDialog();
                updateData();
            }
            else
            {
                MessageBox.Show("Please choose a student to update information...!",
                            "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /**
         * HuyTLN
         * All Function for btnDetail_MainForm
         * 
         * **/
        private void btnDetailInfo_MainForm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("You have to choose an student !");
                return;
            }
            if (gridView_MainForm.CurrentRow != null)
            {
                if (!idExistInTable(idSelected, "DetailInfo"))
                {
                    if (MessageBox.Show("This student doesn't have any information! Would you want to add new information ?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        insertIdToTable(idSelected, "DetailInfo");
                    }
                    else
                    {
                        return;
                    }
                }
                DetailInfo dti = new DetailInfo(idSelected,log);
                dti.ShowDialog();
                updateData();
            }
            else
            {
                MessageBox.Show("Please choose a student to update information...!",
                            "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // 2 Ham dung chung
        public void insertIdToTable(String id, String table)
        {
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                String sqlInsert = " insert into " + table + "(ID) values('" + id + "')";
                SqlCommand sqlCmd = new SqlCommand(sqlInsert, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Boolean idExistInTable(String id, String table)
        {
            Boolean value = false;
            try
            {
                sqlConn = new SqlConnection(App.ConnectionString);
                sqlConn.Open();
                string sqlCount = "select * from " + table;
                SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    if (id.Equals(reader["ID"].ToString()))
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

        // HuyTLN
        private void btnDocCollection_MainForm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("You have to choose an student !");
                return;
            }
            if (gridView_MainForm.CurrentRow != null)
            {
                if (!idExistInTable(idSelected, "DocumentCollection"))
                {
                    if (MessageBox.Show("This student doesn't have any information! Would you want to add new information ?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        insertIdToTable(idSelected, "DocumentCollection");
                    }
                    else
                    {
                        return;
                    }
                }
                DocumentCollection dc = new DocumentCollection(idSelected);
                dc.ShowDialog();
                updateData();
                //dc.Focus();
            }
            else
            {
                MessageBox.Show("Please choose a student to update information...!",
                            "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //Others

        private void btnFee_MainForm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("You have to choose an student !");
                return;
            }
            frmFee f = new frmFee();
            f.ShowDialog();
            updateData();
        }

        private void btnVisa_MainForm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("You have to choose an student !");
                return;
            }
            frmVisa visa = new frmVisa(idSelected);
            visa.ShowDialog();
            updateData();
        }

        //DauNQ add OnArrival info
        
        private void btnOnArrival_MainForm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("You have to choose an student !");
                return;
            }
            if (gridView_MainForm.CurrentRow != null)
            {
                if (!idExistInTable(idSelected, "OnArrival"))
                {
                    if (MessageBox.Show("This student doesn't have any information of OnArrival! Would you want to add new information ?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        insertIdToTable(idSelected, "OnArrival");
                    }
                    else
                    {
                        return;
                    }
                }
                frmOnArrival onArrival = new frmOnArrival(idSelected);
                onArrival.ShowDialog();
                updateData();
            }
            else
            {
                MessageBox.Show("Please choose a student to update information...!",
                            "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogout_MainForm_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChangePass_MainForm_Click(object sender, EventArgs e)
        {
            frmChangePass cpass = new frmChangePass(log);
            cpass.ShowDialog();
            updateData();
        }

        private void btnAddAccount_MainForm_Click(object sender, EventArgs e)
        {
            frmAddNewAccount ana = new frmAddNewAccount();
            ana.ShowDialog();
            updateData();
        }

        /**
         * PhucVT
         * All Function for Change THEME GUI
         * 
         * **/
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.visualStyler1.LoadVisualStyle("Aero (Black).vssf");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.visualStyler1.LoadVisualStyle("OSX (iTunes).vssf");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.visualStyler1.LoadVisualStyle("Chameleon (Colored1).vssf");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.visualStyler1.LoadVisualStyle("Cel Shaded (cell).vssf");
        }

        /**
         * COMMON
         * 
         * **/
        private void gridView_MainForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //HuyTLN- get cell index for use in DetailInfo
            idSelected = gridView_MainForm.CurrentRow.Cells[0].Value.ToString();

            //PhucVT -- Auto Unlock GUI
            CurrentIndex = gridView_MainForm.CurrentRow.Index;
            autoUnlockGUI();
            showTotalRecord();
        }

        private void btnRefresh_MainForm_Click(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(App.ConnectionString);
            sqlConn.Open();
            string sqlCount = "select ID, Name , DoB, Gender = "
                                   + " case Gender "
                                   + " when '1' then 'Male'"
                                   + " when '0' then 'Female'"
                                   + " end, Address, Email, Mobile, StudentStatus"
                                   + " from GeneralInfo";
            SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
            sda = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            sda.Fill(ds, "GeneralInfo");
            dv = new DataView(ds.Tables["GeneralInfo"]);
            gridView_MainForm.DataSource = dv;
            sqlConn.Close();
        }

        private void btnSearch_MainForm_Click(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(App.ConnectionString);
            sqlConn.Open();
            string sqlCount = "";


            if (radID_MainForm.Checked)
            {
                string id = txtID_MainForm.Text;
                sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where ID = '" + id + "'";
            }
            if (radName_MainForm.Checked)
            {
                string name = txtName_MainForm.Text;
                sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where Name = '" + name + "'";
            }
            if (radAddress_MainForm.Checked)
            {
                string add = txtCity_Address_MainForm.Text; ;
                sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where Address = '" + add + "'";
            }
            if (radStatus_MainForm.Checked)
            {
                int status = cbxStatus_MainForm.SelectedIndex;
                if (status == 0)
                {
                    sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where StudentStatus = 'Out'";
                }
                if (status == 1)
                {
                    sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where StudentStatus = 'On hold'";
                }
                if (status == 2)
                {
                    sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where StudentStatus = 'Processing Level 1'";
                }
                if (status == 3)
                {
                    sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where StudentStatus = 'Processing Level 2'";
                }
                if (status == 4)
                {
                    sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where StudentStatus = 'Processing Level 3'";
                }
                if (status == 5)
                {
                    sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where StudentStatus = 'Processing Level 4'";
                }
                if (status == 6)
                {
                    sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where StudentStatus = 'Processing Level 5'";
                }
                if (status == 7)
                {
                    sqlCount = "select ID, Name , DoB, Gender = case Gender when '1' then 'Male' when '0' then 'Female' end, Address, Email, Mobile, StudentStatus from GeneralInfo where StudentStatus = 'Matched'";
                }

            }

            SqlCommand sqlCmd = new SqlCommand(sqlCount, sqlConn);
            sda = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            sda.Fill(ds, "GeneralInfo");
            gridView_MainForm.DataSource = ds.Tables["GeneralInfo"];
            showTotalRecord();
        }

        private void btnAccountManager_MainForm_Click(object sender, EventArgs e)
        {
            frmAccountManager amg = new frmAccountManager();
            amg.Show();
        }

        private void btnImportfromFile_MainForm_Click(object sender, EventArgs e)
        {
            frmImport ip = new frmImport();
            ip.Show();
        }

        private void gridView_MainForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLog_MainForm_Click(object sender, EventArgs e)
        {
            frmCounselingHistory log1 = new frmCounselingHistory(this);
            log1.Show();
        }

        private void btnAccomodation_MainForm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idSelected))
            {
                MessageBox.Show("You have to choose an student !");
                return;
            }
            // show form
        }

        private void txtID_MainForm_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "ID like '%" + txtID_MainForm.Text + "%'";
        }

        private void txtName_MainForm_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "Name like '%" + txtName_MainForm.Text + "%'";
        }

        private void txtCity_Address_MainForm_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtAddress_Search_Maninform_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "Address like '%" + txtAddress_Search_Mainform.Text + "%'";
        }

        private void cbxStatus_MainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status = cbxStatus_MainForm.SelectedIndex;
            if (status == 0)
            {
                dv.RowFilter = "StudentStatus like '%Out%'";
            }
            if (status == 1)
            {
                dv.RowFilter = "StudentStatus like '%On hold%'";
            }
            if (status == 2)
            {
                dv.RowFilter = "StudentStatus like '%Processing Level 1%'";
            }
            if (status == 3)
            {
                dv.RowFilter = "StudentStatus like '%Processing Level 2%'";
            }
            if (status == 4)
            {
                dv.RowFilter = "StudentStatus like '%Processing Level 3%'";
            }
            if (status == 5)
            {
                dv.RowFilter = "StudentStatus like '%Processing Level 4%'";
            }
            if (status == 6)
            {
                dv.RowFilter = "StudentStatus like '%Processing Level 5%'";
            }
            if (status == 7)
            {
                dv.RowFilter = "StudentStatus like '%Matched%'";
            }
        }

        
    }
}
