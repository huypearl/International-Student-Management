using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionTrackingApp
{
    public partial class frmCounselingHistory : Form
    {
        int n = 0;
        MainForm main = new MainForm();
        DetailView view = new DetailView();
        AddNewForm newf = new AddNewForm();
        DetailInfo detail = new DetailInfo();
        EditGeneralInfo general = new EditGeneralInfo();
        string[] lines = System.IO.File.ReadAllLines(@"D:\Demo.txt");
        public frmCounselingHistory(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            btnPrev_Log.Enabled = false;
            for (int j = 0; j < lines.Length; j++)
            // foreach (string line in lines)
            {
                if (lines[j] != null)
                {
                    rtxt_Log.Text += lines[j] + "\n";
                }

            }
        }
        public frmCounselingHistory(DetailView view)
        {
            InitializeComponent();
            this.view = view;
            AddLog(view.Time, view.Do, view.ID, view.acl, view.acc);
        }
        public frmCounselingHistory(AddNewForm newf)
        {
            InitializeComponent();
            this.newf = newf;
            AddLog(newf.Time, newf.Do, newf.ID, newf.acl, newf.acc);
        }
        public frmCounselingHistory(EditGeneralInfo general)
        {
            InitializeComponent();
            this.general = general;
            AddLog(general.Time, general.Do, general.ID, general.acl, general.acc);
        }
        public frmCounselingHistory(DetailInfo detail)
        {
            InitializeComponent();
            this.detail = detail;
            AddLog(detail.Time, detail.Do, detail.ID, detail.acl, detail.acc);
        }


        private void btnNext_Log_Click(object sender, EventArgs e)
        {
            rtxt_Log.Clear();
            n = n + 50;
            btnPrev_Log.Enabled = true;
            for (int j = n; j < lines.Length; j++)
            {
                if (lines[j] != null)
                {
                    rtxt_Log.Text += lines[j] + "\n";
                }
            }

        }


        private void btnFind_Log_Click(object sender, EventArgs e)
        {
            rtxt_Log.Clear();
            for (int j = 0; j < lines.Length; j++)
            //foreach (string line in lines)
            {
                if (lines[j].ToLower().Contains(txtID_Log.Text.ToLower()))
                {
                    rtxt_Log.Text += lines[j] + "\n";
                }
            }
        }

        private void btnRefresh_Log_Click(object sender, EventArgs e)
        {
            rtxt_Log.Clear();
            for (int j = 0; j < lines.Length; j++)
            // foreach (string line in lines)
            {
                if (lines[j] != null)
                {
                    rtxt_Log.Text += lines[j] + "\n";
                }
                btnPrev_Log.Enabled = false;
            }
        }
        public void AddLog(string a, string b, string c, string d, string e)
        {
            TextWriter tsw = new StreamWriter(@"D:\Demo.txt", true);
            tsw.WriteLine(a + "   " + d + " " + e + b + " " + c);
            tsw.Close();
        }

        private void btnPrev_Log_Click(object sender, EventArgs e)
        {
            rtxt_Log.Clear();

            n = n - 50;
            for (int j = n; j < lines.Length; j++)
            {
                if (lines[j] != null)
                {
                    rtxt_Log.Text += lines[j] + "\n";
                }
            }
            if (n == 0)
            {
                btnPrev_Log.Enabled = false;
                return;
            }

        }
    }
}
