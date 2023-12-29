namespace vls_registrar
{
    partial class ChangeWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeWizard));
            this.txtValidate = new Guna.UI.WinForms.GunaTextBox();
            this.lblHeader = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNew = new Guna.UI.WinForms.GunaTextBox();
            this.btnSubmitNew = new Guna.UI.WinForms.GunaGradientButton();
            this.btnValidate = new Guna.UI.WinForms.GunaGradientButton();
            this.lblNew = new Guna.UI.WinForms.GunaLabel();
            this.btnBack = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // txtValidate
            // 
            this.txtValidate.BaseColor = System.Drawing.Color.White;
            this.txtValidate.BorderColor = System.Drawing.Color.Silver;
            this.txtValidate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValidate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtValidate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtValidate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtValidate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValidate.Location = new System.Drawing.Point(12, 64);
            this.txtValidate.Name = "txtValidate";
            this.txtValidate.PasswordChar = '\0';
            this.txtValidate.SelectedText = "";
            this.txtValidate.Size = new System.Drawing.Size(263, 30);
            this.txtValidate.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeader.Location = new System.Drawing.Point(9, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(51, 15);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Change ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(9, 46);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(263, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "For security reasons, please enter your password:";
            // 
            // txtNew
            // 
            this.txtNew.BaseColor = System.Drawing.Color.White;
            this.txtNew.BorderColor = System.Drawing.Color.Silver;
            this.txtNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNew.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNew.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNew.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNew.Location = new System.Drawing.Point(12, 124);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '\0';
            this.txtNew.SelectedText = "";
            this.txtNew.Size = new System.Drawing.Size(263, 30);
            this.txtNew.TabIndex = 4;
            this.txtNew.Visible = false;
            this.txtNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNew_KeyPress);
            // 
            // btnSubmitNew
            // 
            this.btnSubmitNew.AnimationHoverSpeed = 0.07F;
            this.btnSubmitNew.AnimationSpeed = 0.03F;
            this.btnSubmitNew.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnSubmitNew.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnSubmitNew.BorderColor = System.Drawing.Color.Black;
            this.btnSubmitNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmitNew.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmitNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmitNew.ForeColor = System.Drawing.Color.White;
            this.btnSubmitNew.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmitNew.Image")));
            this.btnSubmitNew.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSubmitNew.Location = new System.Drawing.Point(281, 124);
            this.btnSubmitNew.Name = "btnSubmitNew";
            this.btnSubmitNew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSubmitNew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSubmitNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmitNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmitNew.OnHoverImage = null;
            this.btnSubmitNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmitNew.Size = new System.Drawing.Size(81, 30);
            this.btnSubmitNew.TabIndex = 5;
            this.btnSubmitNew.Text = "Submit";
            this.btnSubmitNew.Visible = false;
            this.btnSubmitNew.Click += new System.EventHandler(this.btnSubmitNew_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.AnimationHoverSpeed = 0.07F;
            this.btnValidate.AnimationSpeed = 0.03F;
            this.btnValidate.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnValidate.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnValidate.BorderColor = System.Drawing.Color.Black;
            this.btnValidate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnValidate.FocusedColor = System.Drawing.Color.Empty;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Image = ((System.Drawing.Image)(resources.GetObject("btnValidate.Image")));
            this.btnValidate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnValidate.Location = new System.Drawing.Point(281, 64);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnValidate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnValidate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnValidate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnValidate.OnHoverImage = null;
            this.btnValidate.OnPressedColor = System.Drawing.Color.Black;
            this.btnValidate.Size = new System.Drawing.Size(81, 30);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Verify";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNew.Location = new System.Drawing.Point(9, 106);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(62, 15);
            this.lblNew.TabIndex = 6;
            this.lblNew.Text = "Enter new ";
            this.lblNew.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnBack.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(279, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBack.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(81, 25);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ChangeWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 165);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.btnSubmitNew);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtValidate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeWizard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtValidate;
        private Guna.UI.WinForms.GunaLabel lblHeader;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGradientButton btnValidate;
        private Guna.UI.WinForms.GunaTextBox txtNew;
        private Guna.UI.WinForms.GunaGradientButton btnSubmitNew;
        private Guna.UI.WinForms.GunaLabel lblNew;
        private Guna.UI.WinForms.GunaGradientButton btnBack;
    }
}