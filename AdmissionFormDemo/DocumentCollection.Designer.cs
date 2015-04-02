namespace AdmissionTrackingApp
{
    partial class DocumentCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentCollection));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.datepickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUploadOthers = new System.Windows.Forms.Button();
            this.btnUploadOfferLetter = new System.Windows.Forms.Button();
            this.btnUploadEnglish = new System.Windows.Forms.Button();
            this.btnUploadSchooling = new System.Windows.Forms.Button();
            this.btnUploadHealthCheck = new System.Windows.Forms.Button();
            this.btnUploadPassport = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnShowOthers = new System.Windows.Forms.Button();
            this.btnShowOfferLetter = new System.Windows.Forms.Button();
            this.btnShowEnglish = new System.Windows.Forms.Button();
            this.btnShowSchooling = new System.Windows.Forms.Button();
            this.btnShowHealthCheck = new System.Windows.Forms.Button();
            this.btnShowPassport = new System.Windows.Forms.Button();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkOfferLetter = new System.Windows.Forms.CheckBox();
            this.chkEnglish = new System.Windows.Forms.CheckBox();
            this.chkSchooling = new System.Windows.Forms.CheckBox();
            this.chkHealthCheck = new System.Windows.Forms.CheckBox();
            this.chkPassport = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNote);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.datepickerDeadline);
            this.groupBox4.Location = new System.Drawing.Point(600, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 309);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Infomation";
            // 
            // txtNote
            // 
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtNote.Location = new System.Drawing.Point(40, 81);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(203, 158);
            this.txtNote.TabIndex = 78;
            this.txtNote.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(96, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(111, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 24);
            this.label33.TabIndex = 77;
            this.label33.Text = "Note";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 76;
            this.label32.Text = "Deadline";
            // 
            // datepickerDeadline
            // 
            this.datepickerDeadline.Location = new System.Drawing.Point(61, 19);
            this.datepickerDeadline.Name = "datepickerDeadline";
            this.datepickerDeadline.Size = new System.Drawing.Size(206, 20);
            this.datepickerDeadline.TabIndex = 75;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.btnUploadOthers);
            this.groupBox3.Controls.Add(this.btnUploadOfferLetter);
            this.groupBox3.Controls.Add(this.btnUploadEnglish);
            this.groupBox3.Controls.Add(this.btnUploadSchooling);
            this.groupBox3.Controls.Add(this.btnUploadHealthCheck);
            this.groupBox3.Controls.Add(this.btnUploadPassport);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Controls.Add(this.btnPreview);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.axAcroPDF1);
            this.groupBox3.Controls.Add(this.btnShowOthers);
            this.groupBox3.Controls.Add(this.btnShowOfferLetter);
            this.groupBox3.Controls.Add(this.btnShowEnglish);
            this.groupBox3.Controls.Add(this.btnShowSchooling);
            this.groupBox3.Controls.Add(this.btnShowHealthCheck);
            this.groupBox3.Controls.Add(this.btnShowPassport);
            this.groupBox3.Controls.Add(this.chkOther);
            this.groupBox3.Controls.Add(this.chkOfferLetter);
            this.groupBox3.Controls.Add(this.chkEnglish);
            this.groupBox3.Controls.Add(this.chkSchooling);
            this.groupBox3.Controls.Add(this.chkHealthCheck);
            this.groupBox3.Controls.Add(this.chkPassport);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 309);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documents";
            // 
            // btnUploadOthers
            // 
            this.btnUploadOthers.Location = new System.Drawing.Point(212, 271);
            this.btnUploadOthers.Name = "btnUploadOthers";
            this.btnUploadOthers.Size = new System.Drawing.Size(49, 23);
            this.btnUploadOthers.TabIndex = 125;
            this.btnUploadOthers.Text = "Upload";
            this.btnUploadOthers.UseVisualStyleBackColor = true;
            this.btnUploadOthers.Click += new System.EventHandler(this.btnUploadOthers_Click);
            // 
            // btnUploadOfferLetter
            // 
            this.btnUploadOfferLetter.Location = new System.Drawing.Point(212, 221);
            this.btnUploadOfferLetter.Name = "btnUploadOfferLetter";
            this.btnUploadOfferLetter.Size = new System.Drawing.Size(49, 23);
            this.btnUploadOfferLetter.TabIndex = 124;
            this.btnUploadOfferLetter.Text = "Upload";
            this.btnUploadOfferLetter.UseVisualStyleBackColor = true;
            this.btnUploadOfferLetter.Click += new System.EventHandler(this.btnUploadOfferLetter_Click);
            // 
            // btnUploadEnglish
            // 
            this.btnUploadEnglish.Location = new System.Drawing.Point(212, 172);
            this.btnUploadEnglish.Name = "btnUploadEnglish";
            this.btnUploadEnglish.Size = new System.Drawing.Size(49, 23);
            this.btnUploadEnglish.TabIndex = 123;
            this.btnUploadEnglish.Text = "Upload";
            this.btnUploadEnglish.UseVisualStyleBackColor = true;
            this.btnUploadEnglish.Click += new System.EventHandler(this.btnUploadEnglish_Click);
            // 
            // btnUploadSchooling
            // 
            this.btnUploadSchooling.Location = new System.Drawing.Point(212, 119);
            this.btnUploadSchooling.Name = "btnUploadSchooling";
            this.btnUploadSchooling.Size = new System.Drawing.Size(49, 23);
            this.btnUploadSchooling.TabIndex = 122;
            this.btnUploadSchooling.Text = "Upload";
            this.btnUploadSchooling.UseVisualStyleBackColor = true;
            this.btnUploadSchooling.Click += new System.EventHandler(this.btnUploadSchooling_Click);
            // 
            // btnUploadHealthCheck
            // 
            this.btnUploadHealthCheck.Location = new System.Drawing.Point(213, 68);
            this.btnUploadHealthCheck.Name = "btnUploadHealthCheck";
            this.btnUploadHealthCheck.Size = new System.Drawing.Size(49, 23);
            this.btnUploadHealthCheck.TabIndex = 121;
            this.btnUploadHealthCheck.Text = "Upload";
            this.btnUploadHealthCheck.UseVisualStyleBackColor = true;
            this.btnUploadHealthCheck.Click += new System.EventHandler(this.btnUploadHealthCheck_Click);
            // 
            // btnUploadPassport
            // 
            this.btnUploadPassport.Location = new System.Drawing.Point(213, 20);
            this.btnUploadPassport.Name = "btnUploadPassport";
            this.btnUploadPassport.Size = new System.Drawing.Size(49, 23);
            this.btnUploadPassport.TabIndex = 120;
            this.btnUploadPassport.Text = "Upload";
            this.btnUploadPassport.UseVisualStyleBackColor = true;
            this.btnUploadPassport.Click += new System.EventHandler(this.btnUploadPassport_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(299, 260);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(65, 23);
            this.btnOpen.TabIndex = 119;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(451, 260);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(68, 23);
            this.btnPreview.TabIndex = 118;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 83;
            this.btnSave.Text = "Save as";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(286, 18);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(269, 221);
            this.axAcroPDF1.TabIndex = 117;
            // 
            // btnShowOthers
            // 
            this.btnShowOthers.Location = new System.Drawing.Point(157, 272);
            this.btnShowOthers.Name = "btnShowOthers";
            this.btnShowOthers.Size = new System.Drawing.Size(49, 23);
            this.btnShowOthers.TabIndex = 116;
            this.btnShowOthers.Text = "Show";
            this.btnShowOthers.UseVisualStyleBackColor = true;
            this.btnShowOthers.Click += new System.EventHandler(this.btnShowOthers_Click);
            // 
            // btnShowOfferLetter
            // 
            this.btnShowOfferLetter.Location = new System.Drawing.Point(158, 222);
            this.btnShowOfferLetter.Name = "btnShowOfferLetter";
            this.btnShowOfferLetter.Size = new System.Drawing.Size(49, 23);
            this.btnShowOfferLetter.TabIndex = 115;
            this.btnShowOfferLetter.Text = "Show";
            this.btnShowOfferLetter.UseVisualStyleBackColor = true;
            this.btnShowOfferLetter.Click += new System.EventHandler(this.btnShowOfferLetter_Click);
            // 
            // btnShowEnglish
            // 
            this.btnShowEnglish.Location = new System.Drawing.Point(158, 173);
            this.btnShowEnglish.Name = "btnShowEnglish";
            this.btnShowEnglish.Size = new System.Drawing.Size(49, 23);
            this.btnShowEnglish.TabIndex = 114;
            this.btnShowEnglish.Text = "Show";
            this.btnShowEnglish.UseVisualStyleBackColor = true;
            this.btnShowEnglish.Click += new System.EventHandler(this.btnShowEnglish_Click);
            // 
            // btnShowSchooling
            // 
            this.btnShowSchooling.Location = new System.Drawing.Point(158, 120);
            this.btnShowSchooling.Name = "btnShowSchooling";
            this.btnShowSchooling.Size = new System.Drawing.Size(49, 23);
            this.btnShowSchooling.TabIndex = 113;
            this.btnShowSchooling.Text = "Show";
            this.btnShowSchooling.UseVisualStyleBackColor = true;
            this.btnShowSchooling.Click += new System.EventHandler(this.btnShowSchooling_Click);
            // 
            // btnShowHealthCheck
            // 
            this.btnShowHealthCheck.Location = new System.Drawing.Point(157, 69);
            this.btnShowHealthCheck.Name = "btnShowHealthCheck";
            this.btnShowHealthCheck.Size = new System.Drawing.Size(49, 23);
            this.btnShowHealthCheck.TabIndex = 112;
            this.btnShowHealthCheck.Text = "Show";
            this.btnShowHealthCheck.UseVisualStyleBackColor = true;
            this.btnShowHealthCheck.Click += new System.EventHandler(this.btnShowHealthCheck_Click);
            // 
            // btnShowPassport
            // 
            this.btnShowPassport.Location = new System.Drawing.Point(158, 20);
            this.btnShowPassport.Name = "btnShowPassport";
            this.btnShowPassport.Size = new System.Drawing.Size(49, 23);
            this.btnShowPassport.TabIndex = 111;
            this.btnShowPassport.Text = "Show";
            this.btnShowPassport.UseVisualStyleBackColor = true;
            this.btnShowPassport.Click += new System.EventHandler(this.btnShowPassport_Click);
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(6, 275);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(15, 14);
            this.chkOther.TabIndex = 105;
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // chkOfferLetter
            // 
            this.chkOfferLetter.AutoSize = true;
            this.chkOfferLetter.Location = new System.Drawing.Point(6, 225);
            this.chkOfferLetter.Name = "chkOfferLetter";
            this.chkOfferLetter.Size = new System.Drawing.Size(15, 14);
            this.chkOfferLetter.TabIndex = 104;
            this.chkOfferLetter.UseVisualStyleBackColor = true;
            // 
            // chkEnglish
            // 
            this.chkEnglish.AutoSize = true;
            this.chkEnglish.Location = new System.Drawing.Point(6, 176);
            this.chkEnglish.Name = "chkEnglish";
            this.chkEnglish.Size = new System.Drawing.Size(15, 14);
            this.chkEnglish.TabIndex = 103;
            this.chkEnglish.UseVisualStyleBackColor = true;
            // 
            // chkSchooling
            // 
            this.chkSchooling.AutoSize = true;
            this.chkSchooling.Location = new System.Drawing.Point(6, 123);
            this.chkSchooling.Name = "chkSchooling";
            this.chkSchooling.Size = new System.Drawing.Size(15, 14);
            this.chkSchooling.TabIndex = 102;
            this.chkSchooling.UseVisualStyleBackColor = true;
            // 
            // chkHealthCheck
            // 
            this.chkHealthCheck.AutoSize = true;
            this.chkHealthCheck.Location = new System.Drawing.Point(6, 72);
            this.chkHealthCheck.Name = "chkHealthCheck";
            this.chkHealthCheck.Size = new System.Drawing.Size(15, 14);
            this.chkHealthCheck.TabIndex = 101;
            this.chkHealthCheck.UseVisualStyleBackColor = true;
            // 
            // chkPassport
            // 
            this.chkPassport.AutoSize = true;
            this.chkPassport.Location = new System.Drawing.Point(6, 22);
            this.chkPassport.Name = "chkPassport";
            this.chkPassport.Size = new System.Drawing.Size(15, 14);
            this.chkPassport.TabIndex = 99;
            this.chkPassport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "ID: ";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(192, 35);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(152, 25);
            this.labID.TabIndex = 81;
            this.labID.Text = "Show ID here";
            // 
            // btnOK
            // 
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(366, 411);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 23);
            this.btnOK.TabIndex = 82;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "Name:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(550, 35);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(190, 25);
            this.labName.TabIndex = 84;
            this.labName.Text = "Show Name here";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(27, 275);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 13);
            this.label31.TabIndex = 131;
            this.label31.Text = "Others";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(27, 225);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 13);
            this.label26.TabIndex = 130;
            this.label26.Text = "Resumé / CV";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(27, 176);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 13);
            this.label27.TabIndex = 129;
            this.label27.Text = "English Cetification";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(27, 123);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 13);
            this.label28.TabIndex = 128;
            this.label28.Text = "Academic Certification";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(27, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 13);
            this.label29.TabIndex = 127;
            this.label29.Text = "HealthCheck";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(27, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 13);
            this.label30.TabIndex = 126;
            this.label30.Text = "Passport";
            // 
            // DocumentCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 446);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "DocumentCollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Collection";
            this.Load += new System.EventHandler(this.DocumentCollection_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker datepickerDeadline;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkOfferLetter;
        private System.Windows.Forms.CheckBox chkEnglish;
        private System.Windows.Forms.CheckBox chkSchooling;
        private System.Windows.Forms.CheckBox chkHealthCheck;
        private System.Windows.Forms.CheckBox chkPassport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSave;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btnShowOthers;
        private System.Windows.Forms.Button btnShowOfferLetter;
        private System.Windows.Forms.Button btnShowEnglish;
        private System.Windows.Forms.Button btnShowSchooling;
        private System.Windows.Forms.Button btnShowHealthCheck;
        private System.Windows.Forms.Button btnShowPassport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnUploadOthers;
        private System.Windows.Forms.Button btnUploadOfferLetter;
        private System.Windows.Forms.Button btnUploadEnglish;
        private System.Windows.Forms.Button btnUploadSchooling;
        private System.Windows.Forms.Button btnUploadHealthCheck;
        private System.Windows.Forms.Button btnUploadPassport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
    }
}