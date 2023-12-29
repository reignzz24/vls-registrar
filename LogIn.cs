using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace vls_registrar
{
    public partial class LogIn : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            this.Hide();

            SignUp order = new SignUp();

            order.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(textbox.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblrequired1.Visible = true;
                lblrequired2.Visible = true;
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + txtUsername.Text + "' AND `Password` = '" + textbox.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                { /*
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.userinfo set where Username='" + this.txtUsername.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    */
                    
                    
                    
                    MessageBox.Show("Login Successful!", "Notice", MessageBoxButtons.OK);

                    this.Hide();
                    var success = new AdminControl(txtUsername.Text);
                    success.Closed += (s, args) => this.Close();
                    success.Show();
                    /*this.Hide();
                    LoginSuccessFrom frm2 = new LoginSuccessFrom();
                    frm2.ShowDialog();*/

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblTry.Visible = true;   
                }

                connection.Close();
            }
        }


        private void gunaImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaImageCheckBox1.Checked == true)
            {
                textbox.UseSystemPasswordChar = false;
            }
            else if(!gunaImageCheckBox1.Checked) {

                textbox.UseSystemPasswordChar = true;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            /*this.Hide();

            Index order = new Index();

            order.ShowDialog();*/

            this.Hide();
            var index = new Index();
            index.Closed += (s, args) => this.Close();
            index.Show();

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            /*this.Hide();

            SignUp order = new SignUp();

            order.ShowDialog();*/

            this.Hide();
            var signup = new SignUp();
            signup.Closed += (s, args) => this.Close();
            signup.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.SelectedText == "")
            {
                lblrequired1.Visible = false; 
                lblTry.Visible = false;
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (textbox.SelectedText == "")
            {
                lblrequired2.Visible = false;
                lblTry.Visible = false;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
