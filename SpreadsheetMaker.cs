using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vls_registrar
{
    public partial class SpreadsheetMaker : Form
    {
        private bool _scope;
        private string _dtpto;
        private string _dtpfrom;
        private bool _cancelExport;

        public bool Scope
        {
            get { return _scope; }
            set { _scope = value; }
        }

        public string DtpTo
        {
            get { return _dtpto; }
            set { _dtpto = value; }
        }

        public string DtpFrom
        {
            get { return _dtpfrom; }
            set { _dtpfrom = value; }
        }

        public bool CancelExport
        {
            get { return _cancelExport; }
            set { _cancelExport = value; }
        }

        public SpreadsheetMaker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cancelExport = true;
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (rbAllRecords.Checked)
            {
                _scope = true;
            }
            else if (rbPreciseDate.Checked)
            {
                DateTime now = DateTime.Now;
                _scope = false;
                _dtpfrom = dtpFrom.Value.ToString("yyyy-MM-dd");
                if (rbToday.Checked)
                    _dtpto = now.ToString("yyyy-MM-dd");
                else if (rbCustom.Checked)
                    _dtpto = dtpTo.Value.ToString("yyyy-MM-dd");
            }
            Close();
        }

        private void rbAllRecords_CheckedChanged(object sender, EventArgs e)
        {
            gbFromPicker.Enabled = false;
            gbToPicker.Enabled = false;
            gbFromPicker.LineColor = Color.Gainsboro;
            gbToPicker.LineColor = Color.Gainsboro;
            btnExport.Enabled = true;
        }

        private void rbPreciseDate_CheckedChanged(object sender, EventArgs e)
        {
            gbFromPicker.Enabled = true;
            gbToPicker.Enabled = true;
            gbFromPicker.LineColor = Color.IndianRed;
            gbToPicker.LineColor = Color.IndianRed;
            btnExport.Enabled = true;
        }

        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            dtpTo.Enabled = false;
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            dtpTo.Enabled = true;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            // Set the minimum date for dtpTo to be the selected date in dtpFrom
            dtpTo.MinDate = dtpFrom.Value;

            // Set the maximum date for dtpFrom to be one day before the current date
            dtpFrom.MaxDate = DateTime.Today.AddDays(-1);

            // If the selected date in dtpFrom is after the selected date in dtpTo,
            // set the selected date in dtpTo to be the same as dtpFrom
            if (dtpTo.Value < dtpFrom.Value)
            {
                dtpTo.Value = dtpFrom.Value;
            }
        }
    }
}
