namespace WinFormsOffice365
{
    partial class MainForm
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
            this.btnReadContacts = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lnklblLog = new System.Windows.Forms.LinkLabel();
            this.lblUserLogged = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreatePhone = new System.Windows.Forms.TextBox();
            this.txtCreateEmail = new System.Windows.Forms.TextBox();
            this.txtCreateFamilyName = new System.Windows.Forms.TextBox();
            this.txtCreateGivenName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageProfile = new System.Windows.Forms.PictureBox();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadContacts
            // 
            this.btnReadContacts.Enabled = false;
            this.btnReadContacts.Location = new System.Drawing.Point(12, 41);
            this.btnReadContacts.Name = "btnReadContacts";
            this.btnReadContacts.Size = new System.Drawing.Size(133, 47);
            this.btnReadContacts.TabIndex = 0;
            this.btnReadContacts.Text = "Read Contacts";
            this.btnReadContacts.UseVisualStyleBackColor = true;
            this.btnReadContacts.Click += new System.EventHandler(this.btnReadContacts_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(13, 95);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(0, 13);
            this.lblInformation.TabIndex = 1;
            // 
            // lnklblLog
            // 
            this.lnklblLog.AutoSize = true;
            this.lnklblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLog.Location = new System.Drawing.Point(13, 9);
            this.lnklblLog.Name = "lnklblLog";
            this.lnklblLog.Size = new System.Drawing.Size(59, 20);
            this.lnklblLog.TabIndex = 2;
            this.lnklblLog.TabStop = true;
            this.lnklblLog.Text = "Sign In";
            this.lnklblLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLog_LinkClicked);
            // 
            // lblUserLogged
            // 
            this.lblUserLogged.AutoSize = true;
            this.lblUserLogged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogged.Location = new System.Drawing.Point(193, 12);
            this.lblUserLogged.Name = "lblUserLogged";
            this.lblUserLogged.Size = new System.Drawing.Size(0, 17);
            this.lblUserLogged.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtCreatePhone);
            this.groupBox1.Controls.Add(this.txtCreateEmail);
            this.groupBox1.Controls.Add(this.txtCreateFamilyName);
            this.groupBox1.Controls.Add(this.txtCreateGivenName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a contact";
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(398, 129);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(133, 26);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreatePhone
            // 
            this.txtCreatePhone.Location = new System.Drawing.Point(86, 103);
            this.txtCreatePhone.Name = "txtCreatePhone";
            this.txtCreatePhone.Size = new System.Drawing.Size(445, 20);
            this.txtCreatePhone.TabIndex = 7;
            // 
            // txtCreateEmail
            // 
            this.txtCreateEmail.Location = new System.Drawing.Point(86, 77);
            this.txtCreateEmail.Name = "txtCreateEmail";
            this.txtCreateEmail.Size = new System.Drawing.Size(445, 20);
            this.txtCreateEmail.TabIndex = 6;
            // 
            // txtCreateFamilyName
            // 
            this.txtCreateFamilyName.Location = new System.Drawing.Point(86, 51);
            this.txtCreateFamilyName.Name = "txtCreateFamilyName";
            this.txtCreateFamilyName.Size = new System.Drawing.Size(445, 20);
            this.txtCreateFamilyName.TabIndex = 5;
            // 
            // txtCreateGivenName
            // 
            this.txtCreateGivenName.Location = new System.Drawing.Point(86, 25);
            this.txtCreateGivenName.Name = "txtCreateGivenName";
            this.txtCreateGivenName.Size = new System.Drawing.Size(445, 20);
            this.txtCreateGivenName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Given name";
            // 
            // imageProfile
            // 
            this.imageProfile.Image = global::WinFormsOffice365.Properties.Resources.DefaultUser;
            this.imageProfile.Location = new System.Drawing.Point(156, 4);
            this.imageProfile.Name = "imageProfile";
            this.imageProfile.Size = new System.Drawing.Size(32, 32);
            this.imageProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProfile.TabIndex = 6;
            this.imageProfile.TabStop = false;
            this.imageProfile.Visible = false;
            // 
            // rtxtResults
            // 
            this.rtxtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtResults.Location = new System.Drawing.Point(12, 124);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(550, 203);
            this.rtxtResults.TabIndex = 7;
            this.rtxtResults.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 532);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.imageProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUserLogged);
            this.Controls.Add(this.lnklblLog);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnReadContacts);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadContacts;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.LinkLabel lnklblLog;
        private System.Windows.Forms.Label lblUserLogged;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreatePhone;
        private System.Windows.Forms.TextBox txtCreateEmail;
        private System.Windows.Forms.TextBox txtCreateFamilyName;
        private System.Windows.Forms.TextBox txtCreateGivenName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageProfile;
        private System.Windows.Forms.RichTextBox rtxtResults;
    }
}

