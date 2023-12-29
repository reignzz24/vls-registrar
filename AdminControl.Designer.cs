namespace vls_registrar
{
    partial class AdminControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControl));
            this.dgvLogs = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.changeUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAccount = new Guna.UI.WinForms.GunaButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AllowUserToResizeColumns = false;
            this.dgvLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogs.ColumnHeadersHeight = 25;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLogs.EnableHeadersVisualStyles = false;
            this.dgvLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLogs.Location = new System.Drawing.Point(10, 60);
            this.dgvLogs.MultiSelect = false;
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(800, 335);
            this.dgvLogs.TabIndex = 1;
            this.dgvLogs.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLogs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLogs.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvLogs.ThemeStyle.ReadOnly = false;
            this.dgvLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLogs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLogs.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLogs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogs_CellDoubleClick);
            this.dgvLogs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogs_CellValueChanged);
            this.dgvLogs.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvLogs_ColumnAdded);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUsernameToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(172, 48);
            // 
            // changeUsernameToolStripMenuItem
            // 
            this.changeUsernameToolStripMenuItem.Name = "changeUsernameToolStripMenuItem";
            this.changeUsernameToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changeUsernameToolStripMenuItem.Text = "Change Username";
            this.changeUsernameToolStripMenuItem.Click += new System.EventHandler(this.changeUsernameToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.AnimationHoverSpeed = 0.07F;
            this.btnAccount.AnimationSpeed = 0.03F;
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAccount.BorderColor = System.Drawing.Color.Black;
            this.btnAccount.ContextMenuStrip = this.gunaContextMenuStrip1;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAccount.Location = new System.Drawing.Point(607, 12);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAccount.OnHoverImage = null;
            this.btnAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccount.Radius = 15;
            this.btnAccount.Size = new System.Drawing.Size(94, 42);
            this.btnAccount.TabIndex = 8;
            this.btnAccount.Text = "name";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Location = new System.Drawing.Point(510, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(91, 42);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::vls_registrar.Properties.Resources.logout1;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(707, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Radius = 15;
            this.btnLogout.Size = new System.Drawing.Size(103, 42);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log - Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BaseColor = System.Drawing.Color.Olive;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::vls_registrar.Properties.Resources.pen1;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(344, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Size = new System.Drawing.Size(160, 42);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BaseColor = System.Drawing.Color.Maroon;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::vls_registrar.Properties.Resources.remove;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(178, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(160, 42);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.AnimationHoverSpeed = 0.07F;
            this.btnGenerateReport.AnimationSpeed = 0.03F;
            this.btnGenerateReport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGenerateReport.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerateReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Image = global::vls_registrar.Properties.Resources.file;
            this.btnGenerateReport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.OnHoverImage = null;
            this.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Size = new System.Drawing.Size(160, 42);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 409);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvLogs);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminControl";
            this.Text = "VLS | Admin Control";
            this.Load += new System.EventHandler(this.LoginSuccessFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvLogs;
        private Guna.UI.WinForms.GunaButton btnGenerateReport;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaButton btnAccount;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeUsernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}