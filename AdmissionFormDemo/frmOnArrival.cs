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
    public partial class frmOnArrival : Form
    {
        string selectedID;
        public frmOnArrival()
        {
            InitializeComponent();
        }
        public frmOnArrival(string si)
        {
            InitializeComponent();
            selectedID = si;
        }

        private void frmOnArrival_Load(object sender, EventArgs e)
        {
            try
            {
                string connection = App.ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();
                string sqlSelect = "select * from OnArrival where ID = '" + selectedID + "'";
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
                MessageBox.Show("Cannot load database!"+ex.Message);
            }
        }

        private void btnUpdate_OnArrival_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = App.ConnectionString;
                SqlConnection sqlConn = new SqlConnection(connection);
                sqlConn.Open();

                string id = lbId_OnArrival.Text;
                string dateFlight = dtpDateFlight_OnArrival.Value.ToString("M-d-yyyy");
                string flightNo = txtFlightNo_OnArrival.Text;
                string service = txtService_OnArrival.Text;
                string campusTour = txtCampusTour_OnArrival.Text;
                
                string sql = string.Format("UPDATE OnArrival "
                    + "SET dateFlight = '{0}',flightNo = '{1}', service = '{2}', campusTour = '{3}' "
                    + "WHERE ID = '{4}' ", dateFlight,flightNo, service, campusTour, id);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Student information has been added");

                sqlConn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This app stopped suddenly!" + ex.Message);
            }
        }
    }
}
