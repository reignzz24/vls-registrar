using Guna.UI.WinForms;
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
using System.Windows.Input;

namespace vls_registrar
{
    public partial class ClientControl : Form
    {
        private Timer timer;
        private bool mouseDown = false;

        public ClientControl()
        {
            InitializeComponent();
            txtPurpose.Focus();
        }

        private void cbAgreed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgreed.Checked)
            {
                if(!CheckTextBoxes())
                {
                    btnSubmit.Enabled = false;
                }
                else
                    btnSubmit.Enabled = true;
            }
            else if (cbAgreed.Checked == false)
            {
                btnSubmit.Enabled = false;
            }
        }

        private bool CheckTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is GunaTextBox textBox && textBox != txtMiddleName && string.IsNullOrEmpty(textBox.Text))
                {
                    // A text box is empty
                    return false;
                }
            }

            // All text boxes are filled
            return true;
        }

        private void clearTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is GunaTextBox textBox)
                {
                    textBox.Text = "";
                    textBox.BaseColor = Color.White;
                }
                if (c is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ConfirmationClient cc = new ConfirmationClient(
                                        txtPurpose.Text,
                                        txtAcctNum.Text,
                                        txtLastName.Text,
                                        txtFirstName.Text,
                                        txtMiddleName.Text,
                                        txtCourse.Text,
                                        txtYearSection.Text);
            DialogResult confirm = cc.ShowDialog();
            if (confirm == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=loginform");
                string query = "INSERT INTO logbook (purpose, account_num, last_name, first_name, middle_name, course, year_section) " +
                               "VALUES ('" + txtPurpose.Text + "', " +
                                       "'" + txtAcctNum.Text + "', " +
                                       "'" + txtLastName.Text + "', " +
                                       "'" + txtFirstName.Text + "', " +
                                       "'" + txtMiddleName.Text + "', " +
                                       "'" + txtCourse.Text + "', " +
                                       "'" + txtYearSection.Text + "');";
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("All done!\r\nYour input has been recorded.");
                conn.Close();
                clearTextBoxes();
            }
            else if (confirm == DialogResult.No)
            {
                return;
            }
        }

        private void checkTextBoxes(object sender, EventArgs e)
        {
            GunaTextBox txt = (GunaTextBox)sender;
            if (string.IsNullOrEmpty(txt.Text))
            {
                btnSubmit.Enabled = false;
                txt.BaseColor = Color.LightCoral;
            }
            else
            {
                txt.BaseColor = Color.White;
            }
        }

        private void txtAcctNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbSecretLogOut_MouseHover(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void pbSecretLogOut_MouseLeave(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();

            // Enable the picture box
            pbSecretLogOut.Enabled = true;
            MessageBox.Show("Entered Admin Mode\r\n\r\nClick on the logo to exit from the client-side.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbSecretLogOut_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pbSecretLogOut_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseDown = false;
                pbSecretLogOutClick();
            }
        }

        private void pbSecretLogOutClick()
        {
            this.Hide();
            Index order = new Index();
            order.ShowDialog();
        }
    }
}
