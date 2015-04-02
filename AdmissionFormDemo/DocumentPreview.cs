using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdmissionTrackingApp
{
    public partial class DocumentPreview : Form
    {
        public DocumentPreview()
        {
            InitializeComponent();
        }
        public DocumentPreview(AxAcroPDFLib.AxAcroPDF axAcroPDF)
        {
            InitializeComponent();
            this.axAcroPDF1.src = axAcroPDF.src;
        }
    }
}
