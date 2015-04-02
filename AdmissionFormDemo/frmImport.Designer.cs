namespace AdmissionTrackingApp
{
    partial class frmImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Import = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddtoDB_Import = new System.Windows.Forms.Button();
            this.btnImport_Import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSheet_Import = new System.Windows.Forms.TextBox();
            this.btnBrowse_Import = new System.Windows.Forms.Button();
            this.txtLinkFile_Import = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAccomodation_Import = new System.Windows.Forms.Button();
            this.btnOnArrival_Import = new System.Windows.Forms.Button();
            this.btnVisa_Import = new System.Windows.Forms.Button();
            this.btnFee_Import = new System.Windows.Forms.Button();
            this.btnDocCollection_Import = new System.Windows.Forms.Button();
            this.btnDetailInfo_Import = new System.Windows.Forms.Button();
            this.btnGeneralInfo_Import = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Import)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Import);
            this.groupBox1.Location = new System.Drawing.Point(4, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // dataGridView_Import
            // 
            this.dataGridView_Import.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Import.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Import.Name = "dataGridView_Import";
            this.dataGridView_Import.Size = new System.Drawing.Size(763, 445);
            this.dataGridView_Import.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddtoDB_Import);
            this.groupBox2.Controls.Add(this.btnImport_Import);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSheet_Import);
            this.groupBox2.Controls.Add(this.btnBrowse_Import);
            this.groupBox2.Controls.Add(this.txtLinkFile_Import);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atribute";
            // 
            // btnAddtoDB_Import
            // 
            this.btnAddtoDB_Import.Location = new System.Drawing.Point(775, 18);
            this.btnAddtoDB_Import.Name = "btnAddtoDB_Import";
            this.btnAddtoDB_Import.Size = new System.Drawing.Size(174, 23);
            this.btnAddtoDB_Import.TabIndex = 5;
            this.btnAddtoDB_Import.Text = "Add to Database";
            this.btnAddtoDB_Import.UseVisualStyleBackColor = true;
            this.btnAddtoDB_Import.Click += new System.EventHandler(this.btnAddtoDB_Import_Click);
            // 
            // btnImport_Import
            // 
            this.btnImport_Import.Location = new System.Drawing.Point(675, 18);
            this.btnImport_Import.Name = "btnImport_Import";
            this.btnImport_Import.Size = new System.Drawing.Size(94, 23);
            this.btnImport_Import.TabIndex = 4;
            this.btnImport_Import.Text = "Import";
            this.btnImport_Import.UseVisualStyleBackColor = true;
            this.btnImport_Import.Click += new System.EventHandler(this.btnImport_Import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sheet";
            // 
            // txtSheet_Import
            // 
            this.txtSheet_Import.Location = new System.Drawing.Point(415, 19);
            this.txtSheet_Import.Name = "txtSheet_Import";
            this.txtSheet_Import.Size = new System.Drawing.Size(138, 20);
            this.txtSheet_Import.TabIndex = 2;
            // 
            // btnBrowse_Import
            // 
            this.btnBrowse_Import.Location = new System.Drawing.Point(301, 18);
            this.btnBrowse_Import.Name = "btnBrowse_Import";
            this.btnBrowse_Import.Size = new System.Drawing.Size(48, 23);
            this.btnBrowse_Import.TabIndex = 1;
            this.btnBrowse_Import.Text = "...";
            this.btnBrowse_Import.UseVisualStyleBackColor = true;
            this.btnBrowse_Import.Click += new System.EventHandler(this.btnBrowse_Import_Click);
            // 
            // txtLinkFile_Import
            // 
            this.txtLinkFile_Import.Location = new System.Drawing.Point(9, 20);
            this.txtLinkFile_Import.Name = "txtLinkFile_Import";
            this.txtLinkFile_Import.Size = new System.Drawing.Size(286, 20);
            this.txtLinkFile_Import.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAccomodation_Import);
            this.groupBox3.Controls.Add(this.btnOnArrival_Import);
            this.groupBox3.Controls.Add(this.btnVisa_Import);
            this.groupBox3.Controls.Add(this.btnFee_Import);
            this.groupBox3.Controls.Add(this.btnDocCollection_Import);
            this.groupBox3.Controls.Add(this.btnDetailInfo_Import);
            this.groupBox3.Controls.Add(this.btnGeneralInfo_Import);
            this.groupBox3.Location = new System.Drawing.Point(779, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 463);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execute";
            // 
            // btnAccomodation_Import
            // 
            this.btnAccomodation_Import.Image = ((System.Drawing.Image)(resources.GetObject("btnAccomodation_Import.Image")));
            this.btnAccomodation_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccomodation_Import.Location = new System.Drawing.Point(9, 284);
            this.btnAccomodation_Import.Name = "btnAccomodation_Import";
            this.btnAccomodation_Import.Size = new System.Drawing.Size(164, 23);
            this.btnAccomodation_Import.TabIndex = 20;
            this.btnAccomodation_Import.Text = "Accomodation";
            this.btnAccomodation_Import.UseVisualStyleBackColor = true;
            // 
            // btnOnArrival_Import
            // 
            this.btnOnArrival_Import.Image = ((System.Drawing.Image)(resources.GetObject("btnOnArrival_Import.Image")));
            this.btnOnArrival_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnArrival_Import.Location = new System.Drawing.Point(9, 240);
            this.btnOnArrival_Import.Name = "btnOnArrival_Import";
            this.btnOnArrival_Import.Size = new System.Drawing.Size(164, 23);
            this.btnOnArrival_Import.TabIndex = 19;
            this.btnOnArrival_Import.Text = "On arrival";
            this.btnOnArrival_Import.UseVisualStyleBackColor = true;
            // 
            // btnVisa_Import
            // 
            this.btnVisa_Import.Image = ((System.Drawing.Image)(resources.GetObject("btnVisa_Import.Image")));
            this.btnVisa_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisa_Import.Location = new System.Drawing.Point(9, 198);
            this.btnVisa_Import.Name = "btnVisa_Import";
            this.btnVisa_Import.Size = new System.Drawing.Size(164, 23);
            this.btnVisa_Import.TabIndex = 18;
            this.btnVisa_Import.Text = "VISA";
            this.btnVisa_Import.UseVisualStyleBackColor = true;
            // 
            // btnFee_Import
            // 
            this.btnFee_Import.Image = ((System.Drawing.Image)(resources.GetObject("btnFee_Import.Image")));
            this.btnFee_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFee_Import.Location = new System.Drawing.Point(9, 155);
            this.btnFee_Import.Name = "btnFee_Import";
            this.btnFee_Import.Size = new System.Drawing.Size(164, 23);
            this.btnFee_Import.TabIndex = 17;
            this.btnFee_Import.Text = "Fee";
            this.btnFee_Import.UseVisualStyleBackColor = true;
            // 
            // btnDocCollection_Import
            // 
            this.btnDocCollection_Import.Image = ((System.Drawing.Image)(resources.GetObject("btnDocCollection_Import.Image")));
            this.btnDocCollection_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocCollection_Import.Location = new System.Drawing.Point(9, 115);
            this.btnDocCollection_Import.Name = "btnDocCollection_Import";
            this.btnDocCollection_Import.Size = new System.Drawing.Size(164, 23);
            this.btnDocCollection_Import.TabIndex = 16;
            this.btnDocCollection_Import.Text = "Document collection";
            this.btnDocCollection_Import.UseVisualStyleBackColor = true;
            // 
            // btnDetailInfo_Import
            // 
            this.btnDetailInfo_Import.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailInfo_Import.Image")));
            this.btnDetailInfo_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailInfo_Import.Location = new System.Drawing.Point(9, 76);
            this.btnDetailInfo_Import.Name = "btnDetailInfo_Import";
            this.btnDetailInfo_Import.Size = new System.Drawing.Size(164, 23);
            this.btnDetailInfo_Import.TabIndex = 15;
            this.btnDetailInfo_Import.Text = "Detail Infomation";
            this.btnDetailInfo_Import.UseVisualStyleBackColor = true;
            // 
            // btnGeneralInfo_Import
            // 
            this.btnGeneralInfo_Import.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneralInfo_Import.Image")));
            this.btnGeneralInfo_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneralInfo_Import.Location = new System.Drawing.Point(10, 33);
            this.btnGeneralInfo_Import.Name = "btnGeneralInfo_Import";
            this.btnGeneralInfo_Import.Size = new System.Drawing.Size(164, 23);
            this.btnGeneralInfo_Import.TabIndex = 14;
            this.btnGeneralInfo_Import.Text = "General Infomation";
            this.btnGeneralInfo_Import.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmImport";
            this.Text = "Import";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Import)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddtoDB_Import;
        private System.Windows.Forms.Button btnImport_Import;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSheet_Import;
        private System.Windows.Forms.Button btnBrowse_Import;
        private System.Windows.Forms.TextBox txtLinkFile_Import;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAccomodation_Import;
        private System.Windows.Forms.Button btnOnArrival_Import;
        private System.Windows.Forms.Button btnVisa_Import;
        private System.Windows.Forms.Button btnFee_Import;
        private System.Windows.Forms.Button btnDocCollection_Import;
        private System.Windows.Forms.Button btnDetailInfo_Import;
        private System.Windows.Forms.Button btnGeneralInfo_Import;
        private System.Windows.Forms.DataGridView dataGridView_Import;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}