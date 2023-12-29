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
    public partial class ConfirmationClient : Form
    {
        public ConfirmationClient(string purpose, 
                                  string accountNum, 
                                  string lastname,
                                  string firstname,
                                  string middlename,
                                  string course,
                                  string yearSection)
        {
            InitializeComponent();
            lblPurpose.Text = purpose;
            lblAcctNum.Text = accountNum;
            lblLastName.Text = lastname;
            lblFirstName.Text = firstname;
            lblMiddleName.Text = middlename;
            lblCourse.Text = course;
            lblYearSection.Text = yearSection;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
