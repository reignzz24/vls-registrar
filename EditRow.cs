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
    public partial class EditRow : Form
    {
        public static int logId;
        public EditRow(int id)
        {
            InitializeComponent();
            logId = id + 1;
        }

        private void EditRow_Load(object sender, EventArgs e)
        {
            lblCurrentEditRow.Text = logId.ToString();
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=loginform");

            try
            {
                conn.Open();
                // Set up command to retrieve data from table
                string query = "SELECT purpose, " +
                    "account_num, " +
                    "last_name, " +
                    "first_name, " +
                    "middle_name, " +
                    "course, " +
                    "year_section" +
                    " FROM logbook WHERE logbook_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", logId);

                // Execute the command and get a data reader
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    // Get the values of the columns
                    string purpose = rdr.GetString(0);
                    string accountNum = rdr.GetString(1);
                    string lastName = rdr.GetString(2);
                    string firstName = rdr.GetString(3);
                    string middleName = rdr.GetString(4);
                    string course = rdr.GetString(5);
                    string yearSection = rdr.GetString(6);

                    txtPurpose.Text = purpose;
                    txtAcctNum.Text = accountNum;
                    txtLastName.Text = lastName;
                    txtFirstName.Text = firstName;
                    txtMiddleName.Text = middleName;
                    txtCourse.Text = course;
                    txtYearSection.Text = yearSection;
                    Console.WriteLine(purpose);
                    Console.WriteLine(accountNum);
                    Console.WriteLine(lastName);
                    Console.WriteLine(firstName);
                    Console.WriteLine(middleName);
                    Console.WriteLine(course);
                    Console.WriteLine(yearSection);

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uh, oh! Something went wrong. \n Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Open a connection to the database
            using (MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password="))
            {
                conn.Open();

                // Build the SQL query
                string sql = "UPDATE loginform.logbook " +
                             "SET purpose = @purpose, " +
                                 "account_num = @acctnum, " +
                                 "last_name = @lastname, " +
                                 "first_name = @firstname, " +
                                 "middle_name = @middlename, " +
                                 "course = @course, " +
                                 "year_section = @section" +
                             " WHERE logbook_id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Add parameters to the MySqlCommand object
                    cmd.Parameters.AddWithValue("@purpose", txtPurpose.Text);
                    cmd.Parameters.AddWithValue("@acctnum", txtAcctNum.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtMiddleName.Text);
                    cmd.Parameters.AddWithValue("@course", txtCourse.Text);
                    cmd.Parameters.AddWithValue("@section", txtYearSection.Text);
                    cmd.Parameters.AddWithValue("@Id", logId);
                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
                // Close the connection
                conn.Close();
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Connection string to the database
            string connectionString = "datasource=localhost;port=3307;username=root;password=;database=loginform";

            // ID of the row to delete
            int id = logId;

            // SQL query to delete the row by id
            string query = "DELETE FROM logbook WHERE logbook_id = @id;";

            // Establish a new connection to the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a new command with the query and connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@id", id);

                        // Execute the query and get the number of affected rows
                        int rowsAffected = command.ExecuteNonQuery();

                        // Display a message to the user indicating whether the delete was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were deleted.");
                        }
                    }

                    // Get the total number of rows in the logbook table
                    string countQuery = "SELECT COUNT(*) FROM logbook;";
                    int rowCount = 0;
                    using (MySqlCommand countCommand = new MySqlCommand(countQuery, connection))
                    {
                        rowCount = Convert.ToInt32(countCommand.ExecuteScalar());

                        // Reassign the logbook_id values starting from the deleted row's logbook_id value + 1
                        string reassignQuery = "UPDATE logbook SET logbook_id = @new_id WHERE logbook_id = @old_id";
                        using (MySqlCommand reassignCommand = new MySqlCommand(reassignQuery, connection))
                        {
                            for (int i = id; i <= rowCount + 1; i++)
                            {
                                reassignCommand.Parameters.Clear();
                                reassignCommand.Parameters.AddWithValue("@new_id", i - 1);
                                reassignCommand.Parameters.AddWithValue("@old_id", i);

                                reassignCommand.ExecuteNonQuery();
                            }

                            // Set the auto-increment value to the total number of rows in the logbook table
                            string setAutoIncrementQuery = "ALTER TABLE logbook AUTO_INCREMENT = @rowCount";
                            using (MySqlCommand setAutoIncrementCommand = new MySqlCommand(setAutoIncrementQuery, connection))
                            {
                                setAutoIncrementCommand.Parameters.AddWithValue("@rowCount", rowCount);
                                setAutoIncrementCommand.ExecuteNonQuery();

                                // Display a message to the user indicating that the logbook_id values have been reassigned and auto_increment value has been updated
                                MessageBox.Show("logbook_id values have been reassigned and auto_increment value has been updated.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if the delete operation fails
                    MessageBox.Show("Error deleting row: " + ex.Message);
                }
            }
            this.Close();
        }
    }
}
