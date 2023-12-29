namespace vls_registrar
{
    partial class SpreadsheetMaker
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
            this.dtpFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gbToPicker = new Guna.UI.WinForms.GunaGroupBox();
            this.dtpTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.rbCustom = new Guna.UI.WinForms.GunaRadioButton();
            this.rbToday = new Guna.UI.WinForms.GunaRadioButton();
            this.gbFromPicker = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.rbPreciseDate = new Guna.UI.WinForms.GunaRadioButton();
            this.rbAllRecords = new Guna.UI.WinForms.GunaRadioButton();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnExport = new Guna.UI.WinForms.GunaButton();
            this.gbToPicker.SuspendLayout();
            this.gbFromPicker.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.BaseColor = System.Drawing.Color.White;
            this.dtpFrom.BorderColor = System.Drawing.Color.Silver;
            this.dtpFrom.CustomFormat = null;
            this.dtpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.ForeColor = System.Drawing.Color.Black;
            this.dtpFrom.Location = new System.Drawing.Point(12, 39);
            this.dtpFrom.MaxDate = new System.DateTime(2023, 2, 18, 15, 34, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1992, 6, 15, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFrom.Size = new System.Drawing.Size(223, 30);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.Text = "Monday, 15 June 1992";
            this.dtpFrom.Value = new System.DateTime(1992, 6, 15, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // gbToPicker
            // 
            this.gbToPicker.BackColor = System.Drawing.Color.Transparent;
            this.gbToPicker.BaseColor = System.Drawing.Color.White;
            this.gbToPicker.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbToPicker.Controls.Add(this.dtpTo);
            this.gbToPicker.Controls.Add(this.rbCustom);
            this.gbToPicker.Controls.Add(this.rbToday);
            this.gbToPicker.Enabled = false;
            this.gbToPicker.LineColor = System.Drawing.Color.Gainsboro;
            this.gbToPicker.Location = new System.Drawing.Point(12, 171);
            this.gbToPicker.Name = "gbToPicker";
            this.gbToPicker.Radius = 15;
            this.gbToPicker.Size = new System.Drawing.Size(247, 106);
            this.gbToPicker.TabIndex = 1;
            this.gbToPicker.Text = "To";
            this.gbToPicker.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dtpTo
            // 
            this.dtpTo.BaseColor = System.Drawing.Color.White;
            this.dtpTo.BorderColor = System.Drawing.Color.Silver;
            this.dtpTo.CustomFormat = null;
            this.dtpTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpTo.Enabled = false;
            this.dtpTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.ForeColor = System.Drawing.Color.Black;
            this.dtpTo.Location = new System.Drawing.Point(12, 67);
            this.dtpTo.MaxDate = new System.DateTime(2023, 2, 18, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.OnPressedColor = System.Drawing.Color.Black;
            this.dtpTo.Size = new System.Drawing.Size(223, 30);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.Text = "Saturday, 18 February 2023";
            this.dtpTo.Value = new System.DateTime(2023, 2, 18, 0, 0, 0, 0);
            // 
            // rbCustom
            // 
            this.rbCustom.BaseColor = System.Drawing.SystemColors.Control;
            this.rbCustom.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbCustom.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbCustom.FillColor = System.Drawing.Color.White;
            this.rbCustom.Location = new System.Drawing.Point(143, 41);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(69, 20);
            this.rbCustom.TabIndex = 1;
            this.rbCustom.Text = "Custom";
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbToday
            // 
            this.rbToday.BaseColor = System.Drawing.SystemColors.Control;
            this.rbToday.Checked = true;
            this.rbToday.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbToday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbToday.FillColor = System.Drawing.Color.White;
            this.rbToday.Location = new System.Drawing.Point(37, 41);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(61, 20);
            this.rbToday.TabIndex = 0;
            this.rbToday.Text = "Today";
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbToday_CheckedChanged);
            // 
            // gbFromPicker
            // 
            this.gbFromPicker.BackColor = System.Drawing.Color.Transparent;
            this.gbFromPicker.BaseColor = System.Drawing.Color.White;
            this.gbFromPicker.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbFromPicker.Controls.Add(this.dtpFrom);
            this.gbFromPicker.Enabled = false;
            this.gbFromPicker.LineColor = System.Drawing.Color.Gainsboro;
            this.gbFromPicker.Location = new System.Drawing.Point(12, 85);
            this.gbFromPicker.Name = "gbFromPicker";
            this.gbFromPicker.Radius = 15;
            this.gbFromPicker.Size = new System.Drawing.Size(247, 80);
            this.gbFromPicker.TabIndex = 3;
            this.gbFromPicker.Text = "From";
            this.gbFromPicker.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.rbPreciseDate);
            this.gunaGroupBox2.Controls.Add(this.rbAllRecords);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.IndianRed;
            this.gunaGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 15;
            this.gunaGroupBox2.Size = new System.Drawing.Size(247, 67);
            this.gunaGroupBox2.TabIndex = 6;
            this.gunaGroupBox2.Text = "Select Scope:";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbPreciseDate
            // 
            this.rbPreciseDate.BaseColor = System.Drawing.SystemColors.Control;
            this.rbPreciseDate.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbPreciseDate.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbPreciseDate.FillColor = System.Drawing.Color.White;
            this.rbPreciseDate.Location = new System.Drawing.Point(124, 36);
            this.rbPreciseDate.Name = "rbPreciseDate";
            this.rbPreciseDate.Size = new System.Drawing.Size(102, 20);
            this.rbPreciseDate.TabIndex = 3;
            this.rbPreciseDate.Text = "Date-Precised";
            this.rbPreciseDate.CheckedChanged += new System.EventHandler(this.rbPreciseDate_CheckedChanged);
            // 
            // rbAllRecords
            // 
            this.rbAllRecords.BaseColor = System.Drawing.SystemColors.Control;
            this.rbAllRecords.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbAllRecords.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbAllRecords.FillColor = System.Drawing.Color.White;
            this.rbAllRecords.Location = new System.Drawing.Point(18, 36);
            this.rbAllRecords.Name = "rbAllRecords";
            this.rbAllRecords.Size = new System.Drawing.Size(88, 20);
            this.rbAllRecords.TabIndex = 2;
            this.rbAllRecords.Text = "All Records";
            this.rbAllRecords.CheckedChanged += new System.EventHandler(this.rbAllRecords_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::vls_registrar.Properties.Resources.remove;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(137, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 15;
            this.btnCancel.Size = new System.Drawing.Size(122, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.AnimationHoverSpeed = 0.07F;
            this.btnExport.AnimationSpeed = 0.03F;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnExport.BorderColor = System.Drawing.Color.Black;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.Enabled = false;
            this.btnExport.FocusedColor = System.Drawing.Color.Empty;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::vls_registrar.Properties.Resources.send;
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.Location = new System.Drawing.Point(12, 283);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport.OnHoverImage = null;
            this.btnExport.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport.Radius = 15;
            this.btnExport.Size = new System.Drawing.Size(122, 35);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // SpreadsheetMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 322);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbFromPicker);
            this.Controls.Add(this.gbToPicker);
            this.Name = "SpreadsheetMaker";
            this.Text = "Export";
            this.gbToPicker.ResumeLayout(false);
            this.gbToPicker.PerformLayout();
            this.gbFromPicker.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDateTimePicker dtpFrom;
        private Guna.UI.WinForms.GunaGroupBox gbToPicker;
        private Guna.UI.WinForms.GunaDateTimePicker dtpTo;
        private Guna.UI.WinForms.GunaRadioButton rbCustom;
        private Guna.UI.WinForms.GunaRadioButton rbToday;
        private Guna.UI.WinForms.GunaGroupBox gbFromPicker;
        private Guna.UI.WinForms.GunaButton btnExport;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaRadioButton rbPreciseDate;
        private Guna.UI.WinForms.GunaRadioButton rbAllRecords;
    }
}