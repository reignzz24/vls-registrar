using DocumentFormat.OpenXml.Office.CustomXsn;
using DocumentFormat.OpenXml.Office.Word;
using MySql.Data.MySqlClient;
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
    public partial class ChangeWizard : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=loginform;");
        MySqlCommand command;
        MySqlDataReader mdr;
        public static string currentAccount, currentMode;

        private bool _reset;

        public bool Reset
        {
            get { return _reset; }
            set { _reset = value; }
        }

        public ChangeWizard(string mode, string online)
        {
            InitializeComponent();
            lblHeader.Text += mode;
            lblNew.Text += mode;
            currentMode = mode;
            currentAccount = online;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtValidate.Text))
            {
                MessageBox.Show("Please enter the password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + currentAccount + "' AND Password = '" + txtValidate.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    lblNew.Visible = true;
                    txtNew.Visible = true;
                    btnSubmitNew.Visible = true;
                    connection.Close();
                    txtValidate.Enabled = false;
                    btnValidate.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void txtNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNew.Text))
            {
                btnSubmitNew.Enabled = false;
            }
            else
                btnSubmitNew.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _reset = false;
            this.Close();
        }

        private void btnSubmitNew_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query;
            bool flag = false;

            if(currentMode == "username")
            {
                query = "UPDATE userinfo SET Username = '" + txtNew.Text + "' WHERE Username = '" + currentAccount + "';";
                command = new MySqlCommand(query, connection);
                // Execute the query
                command.ExecuteNonQuery();
                MessageBox.Show("Account changed, please log-in again.");
                flag = true;
            }
            else if(currentMode == "password")
            {
                query = "UPDATE userinfo SET `Password` = '" + txtNew.Text + "' WHERE Username = '" + currentAccount + "';";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Account changed, please log-in again.");
                flag = true;
            }
            connection.Close();
            if(flag)
            {
                _reset = flag;
                this.Close();
            }
        }
    }
}
