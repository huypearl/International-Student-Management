namespace AdmissionTrackingApp
{
    partial class frmCounselingHistory
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
            this.btnRefresh_Log = new System.Windows.Forms.Button();
            this.btnFind_Log = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_Log = new System.Windows.Forms.TextBox();
            this.btnNext_Log = new System.Windows.Forms.Button();
            this.rtxt_Log = new System.Windows.Forms.RichTextBox();
            this.btnPrev_Log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh_Log
            // 
            this.btnRefresh_Log.Location = new System.Drawing.Point(746, 250);
            this.btnRefresh_Log.Name = "btnRefresh_Log";
            this.btnRefresh_Log.Size = new System.Drawing.Size(87, 27);
            this.btnRefresh_Log.TabIndex = 40;
            this.btnRefresh_Log.Text = "REFRESH";
            this.btnRefresh_Log.UseVisualStyleBackColor = true;
            this.btnRefresh_Log.Click += new System.EventHandler(this.btnRefresh_Log_Click);
            // 
            // btnFind_Log
            // 
            this.btnFind_Log.Location = new System.Drawing.Point(746, 183);
            this.btnFind_Log.Name = "btnFind_Log";
            this.btnFind_Log.Size = new System.Drawing.Size(87, 27);
            this.btnFind_Log.TabIndex = 38;
            this.btnFind_Log.Text = "FIND";
            this.btnFind_Log.UseVisualStyleBackColor = true;
            this.btnFind_Log.Click += new System.EventHandler(this.btnFind_Log_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Enter student ID to find";
            // 
            // txtID_Log
            // 
            this.txtID_Log.Location = new System.Drawing.Point(724, 129);
            this.txtID_Log.Name = "txtID_Log";
            this.txtID_Log.Size = new System.Drawing.Size(132, 20);
            this.txtID_Log.TabIndex = 36;
            // 
            // btnNext_Log
            // 
            this.btnNext_Log.Location = new System.Drawing.Point(808, 21);
            this.btnNext_Log.Name = "btnNext_Log";
            this.btnNext_Log.Size = new System.Drawing.Size(87, 27);
            this.btnNext_Log.TabIndex = 35;
            this.btnNext_Log.Text = "NEXT";
            this.btnNext_Log.UseVisualStyleBackColor = true;
            this.btnNext_Log.Click += new System.EventHandler(this.btnNext_Log_Click);
            // 
            // rtxt_Log
            // 
            this.rtxt_Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rtxt_Log.Location = new System.Drawing.Point(12, 12);
            this.rtxt_Log.Name = "rtxt_Log";
            this.rtxt_Log.Size = new System.Drawing.Size(660, 449);
            this.rtxt_Log.TabIndex = 34;
            this.rtxt_Log.Text = "";
            // 
            // btnPrev_Log
            // 
            this.btnPrev_Log.Location = new System.Drawing.Point(699, 21);
            this.btnPrev_Log.Name = "btnPrev_Log";
            this.btnPrev_Log.Size = new System.Drawing.Size(87, 27);
            this.btnPrev_Log.TabIndex = 41;
            this.btnPrev_Log.Text = "PREV";
            this.btnPrev_Log.UseVisualStyleBackColor = true;
            this.btnPrev_Log.Click += new System.EventHandler(this.btnPrev_Log_Click);
            // 
            // frmCounselingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 476);
            this.Controls.Add(this.btnPrev_Log);
            this.Controls.Add(this.btnRefresh_Log);
            this.Controls.Add(this.btnFind_Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID_Log);
            this.Controls.Add(this.btnNext_Log);
            this.Controls.Add(this.rtxt_Log);
            this.Name = "frmCounselingHistory";
            this.Text = "Counseling History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh_Log;
        private System.Windows.Forms.Button btnFind_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_Log;
        private System.Windows.Forms.Button btnNext_Log;
        private System.Windows.Forms.RichTextBox rtxt_Log;
        private System.Windows.Forms.Button btnPrev_Log;
    }
}