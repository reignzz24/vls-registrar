namespace vls_registrar
{
    partial class ClientControl
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
            this.txtAcctNum = new Guna.UI.WinForms.GunaTextBox();
            this.txtLastName = new Guna.UI.WinForms.GunaTextBox();
            this.txtFirstName = new Guna.UI.WinForms.GunaTextBox();
            this.txtYearSection = new Guna.UI.WinForms.GunaTextBox();
            this.txtCourse = new Guna.UI.WinForms.GunaTextBox();
            this.txtMiddleName = new Guna.UI.WinForms.GunaTextBox();
            this.cbAgreed = new System.Windows.Forms.CheckBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.btnSubmit = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtPurpose = new Guna.UI.WinForms.GunaTextBox();
            this.pbSecretLogOut = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecretLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.BackColor = System.Drawing.Color.Transparent;
            this.txtAcctNum.BaseColor = System.Drawing.Color.White;
            this.txtAcctNum.BorderColor = System.Drawing.Color.Silver;
            this.txtAcctNum.BorderSize = 1;
            this.txtAcctNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcctNum.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAcctNum.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAcctNum.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAcctNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAcctNum.Location = new System.Drawing.Point(342, 91);
            this.txtAcctNum.MaxLength = 10;
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.PasswordChar = '\0';
            this.txtAcctNum.Radius = 15;
            this.txtAcctNum.SelectedText = "";
            this.txtAcctNum.Size = new System.Drawing.Size(220, 26);
            this.txtAcctNum.TabIndex = 1;
            this.txtAcctNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcctNum.TextChanged += new System.EventHandler(this.checkTextBoxes);
            this.txtAcctNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcctNum_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BaseColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.Silver;
            this.txtLastName.BorderSize = 1;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLastName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.Location = new System.Drawing.Point(342, 123);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.Radius = 15;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(220, 26);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.checkTextBoxes);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BaseColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColor = System.Drawing.Color.Silver;
            this.txtFirstName.BorderSize = 1;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFirstName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.Location = new System.Drawing.Point(342, 155);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.Radius = 15;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(220, 26);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.checkTextBoxes);
            // 
            // txtYearSection
            // 
            this.txtYearSection.BackColor = System.Drawing.Color.Transparent;
            this.txtYearSection.BaseColor = System.Drawing.Color.White;
            this.txtYearSection.BorderColor = System.Drawing.Color.Silver;
            this.txtYearSection.BorderSize = 1;
            this.txtYearSection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYearSection.FocusedBaseColor = System.Drawing.Color.White;
            this.txtYearSection.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtYearSection.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYearSection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYearSection.Location = new System.Drawing.Point(342, 251);
            this.txtYearSection.MaxLength = 3;
            this.txtYearSection.Name = "txtYearSection";
            this.txtYearSection.PasswordChar = '\0';
            this.txtYearSection.Radius = 15;
            this.txtYearSection.SelectedText = "";
            this.txtYearSection.Size = new System.Drawing.Size(220, 26);
            this.txtYearSection.TabIndex = 6;
            this.txtYearSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYearSection.TextChanged += new System.EventHandler(this.checkTextBoxes);
            // 
            // txtCourse
            // 
            this.txtCourse.BackColor = System.Drawing.Color.Transparent;
            this.txtCourse.BaseColor = System.Drawing.Color.White;
            this.txtCourse.BorderColor = System.Drawing.Color.Silver;
            this.txtCourse.BorderSize = 1;
            this.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourse.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCourse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCourse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCourse.Location = new System.Drawing.Point(342, 219);
            this.txtCourse.MaxLength = 20;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.Radius = 15;
            this.txtCourse.SelectedText = "";
            this.txtCourse.Size = new System.Drawing.Size(220, 26);
            this.txtCourse.TabIndex = 5;
            this.txtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCourse.TextChanged += new System.EventHandler(this.checkTextBoxes);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.txtMiddleName.BaseColor = System.Drawing.Color.White;
            this.txtMiddleName.BorderColor = System.Drawing.Color.Silver;
            this.txtMiddleName.BorderSize = 1;
            this.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiddleName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMiddleName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMiddleName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMiddleName.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleName.Location = new System.Drawing.Point(342, 187);
            this.txtMiddleName.MaxLength = 50;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.Radius = 15;
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.Size = new System.Drawing.Size(220, 26);
            this.txtMiddleName.TabIndex = 4;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbAgreed
            // 
            this.cbAgreed.AutoSize = true;
            this.cbAgreed.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgreed.Location = new System.Drawing.Point(163, 293);
            this.cbAgreed.Name = "cbAgreed";
            this.cbAgreed.Size = new System.Drawing.Size(409, 49);
            this.cbAgreed.TabIndex = 7;
            this.cbAgreed.Text = "I agree to share my data with PUPT Registrar\'s office, and understand that \r\nmy i" +
    "nformation will be protected by the Data Privacy Act of 2012 (or \r\nofficially kn" +
    "own as Republic Act 10173 (RA 10173)).";
            this.cbAgreed.UseVisualStyleBackColor = true;
            this.cbAgreed.CheckedChanged += new System.EventHandler(this.cbAgreed_CheckedChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(160, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(131, 15);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Purpose of Transaction:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(160, 96);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(169, 15);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Accounting Number (Receipt):";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(160, 128);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(66, 15);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "Last Name:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(160, 160);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(67, 15);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "First Name:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(160, 192);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(82, 15);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Middle Name:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(160, 224);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(46, 15);
            this.gunaLabel6.TabIndex = 13;
            this.gunaLabel6.Text = "Course:";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(160, 256);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(77, 15);
            this.gunaLabel7.TabIndex = 14;
            this.gunaLabel7.Text = "Year/Section:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AnimationHoverSpeed = 0.07F;
            this.btnSubmit.AnimationSpeed = 0.03F;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = null;
            this.btnSubmit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSubmit.Location = new System.Drawing.Point(163, 348);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnHoverImage = null;
            this.btnSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmit.Radius = 15;
            this.btnSubmit.Size = new System.Drawing.Size(399, 42);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(10, 117);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(128, 13);
            this.gunaLabel8.TabIndex = 17;
            this.gunaLabel8.Text = "Virtual Logbook System";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(32, 133);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(85, 12);
            this.gunaLabel9.TabIndex = 18;
            this.gunaLabel9.Text = "for Registrar\'s Office";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Location = new System.Drawing.Point(146, 14);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1, 376);
            this.gunaGroupBox1.TabIndex = 19;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtPurpose
            // 
            this.txtPurpose.AutoCompleteCustomSource.AddRange(new string[] {
            "Certificate of Grades",
            "Transcript of Records (TOR)",
            "Certificate of Graduation (COG)",
            "Registration Card (RegiCard, COR, COE)",
            "Certificate of Good Moral Character"});
            this.txtPurpose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPurpose.BackColor = System.Drawing.Color.Transparent;
            this.txtPurpose.BaseColor = System.Drawing.Color.White;
            this.txtPurpose.BorderColor = System.Drawing.Color.Silver;
            this.txtPurpose.BorderSize = 1;
            this.txtPurpose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurpose.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPurpose.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPurpose.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPurpose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPurpose.Location = new System.Drawing.Point(342, 59);
            this.txtPurpose.MaxLength = 50;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.PasswordChar = '\0';
            this.txtPurpose.Radius = 15;
            this.txtPurpose.SelectedText = "";
            this.txtPurpose.Size = new System.Drawing.Size(220, 26);
            this.txtPurpose.TabIndex = 20;
            this.txtPurpose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPurpose.TextChanged += new System.EventHandler(this.checkTextBoxes);
            // 
            // pbSecretLogOut
            // 
            this.pbSecretLogOut.BaseColor = System.Drawing.Color.White;
            this.pbSecretLogOut.Image = global::vls_registrar.Properties.Resources.pupt_logo;
            this.pbSecretLogOut.Location = new System.Drawing.Point(23, 14);
            this.pbSecretLogOut.Name = "pbSecretLogOut";
            this.pbSecretLogOut.Size = new System.Drawing.Size(100, 100);
            this.pbSecretLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSecretLogOut.TabIndex = 16;
            this.pbSecretLogOut.TabStop = false;
            this.pbSecretLogOut.UseTransfarantBackground = false;
            this.pbSecretLogOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSecretLogOut_MouseDown);
            this.pbSecretLogOut.MouseLeave += new System.EventHandler(this.pbSecretLogOut_MouseLeave);
            this.pbSecretLogOut.MouseHover += new System.EventHandler(this.pbSecretLogOut_MouseHover);
            this.pbSecretLogOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSecretLogOut_MouseUp);
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 402);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.pbSecretLogOut);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.cbAgreed);
            this.Controls.Add(this.txtYearSection);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAcctNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientControl";
            this.Text = "VLS (Registrar) | Logbook Interface";
            ((System.ComponentModel.ISupportInitialize)(this.pbSecretLogOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtAcctNum;
        private Guna.UI.WinForms.GunaTextBox txtLastName;
        private Guna.UI.WinForms.GunaTextBox txtFirstName;
        private Guna.UI.WinForms.GunaTextBox txtYearSection;
        private Guna.UI.WinForms.GunaTextBox txtCourse;
        private Guna.UI.WinForms.GunaTextBox txtMiddleName;
        private System.Windows.Forms.CheckBox cbAgreed;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaButton btnSubmit;
        private Guna.UI.WinForms.GunaCirclePictureBox pbSecretLogOut;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtPurpose;
    }
}