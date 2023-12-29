using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vls_registrar
{
    public partial class SignUp : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public SignUp()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(80, 255, 255, 255);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblrequired1.Visible = true; 
                lblrequired2.Visible = true;
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + txtUsername.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("Username not available!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    string connectionString = "datasource=127.0.0.1;port=3307;username=root;password=;database=loginform;";
                    string iquery = "INSERT INTO userinfo(`ID`,`Username`, `Password`) VALUES (NULL, '" + txtUsername.Text + "', '" + txtPassword.Text + "')";

                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        databaseConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Account Successfully Created!");
                    this.Hide();
                    var login = new LogIn();
                    login.Closed += (s, args) => this.Close();
                    login.Show();

                    /*this.Hide();

                    LogIn order = new LogIn();

                    order.ShowDialog();*/
                }

                connection.Close();
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            
                if (chkShow.Checked == true)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new LogIn();
            login.Closed += (s, args) => this.Close();
            login.Show();

            /*this.Hide();

            LogIn order = new LogIn();

            order.ShowDialog();*/
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(this.txtUsername.SelectedText == "")
            {
                lblrequired1.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPassword.SelectedText == "")
            {
                lblrequired2.Visible = false;
            }
        }
    }
}
