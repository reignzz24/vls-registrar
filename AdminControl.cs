using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vls_registrar
{
    public partial class AdminControl : Form
    {

        public AdminControl(string account)
        {
            InitializeComponent();
            btnAccount.Text = account;
            this.MaximizeBox = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index order = new Index();
            order.ShowDialog();
        }

        private void LoginSuccessFrom_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM loginform.logbook", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvLogs.DataSource = table;
            foreach (DataGridViewRow row in dgvLogs.Rows)
            {
                row.Cells[0].ReadOnly = true;
                row.Cells[8].ReadOnly = true;
            }

            // Set the row height to adjust automatically based on the cell content
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            // Disable cell content clipping
            dgvLogs.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Set the column header height to a fixed value
            dgvLogs.ColumnHeadersHeight = 30;

            // Set the first column to read-only
            dgvLogs.Columns[0].ReadOnly = true;
            dgvLogs.Columns[8].ReadOnly = true;

            // Disable column header height resizing
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Set fixed width for columns
            dgvLogs.Columns[0].Width = 40; //id
            dgvLogs.Columns[1].Width = 60; //purpose
            dgvLogs.Columns[2].Width = 75; //acctnum
            dgvLogs.Columns[3].Width = 140; //lastname
            dgvLogs.Columns[4].Width = 140; //firstname
            dgvLogs.Columns[5].Width = 75; //middlename
            dgvLogs.Columns[6].Width = 60; //course
            dgvLogs.Columns[7].Width = 60; //section
            dgvLogs.Columns[8].Width = 150; //timestamp

            dgvLogs.Columns[0].HeaderText = "ID";
            dgvLogs.Columns[1].HeaderText = "Purpose";
            dgvLogs.Columns[2].HeaderText = "Acct. #";
            dgvLogs.Columns[3].HeaderText = "Last Name";
            dgvLogs.Columns[4].HeaderText = "First Name";
            dgvLogs.Columns[5].HeaderText = "M. N.";
            dgvLogs.Columns[6].HeaderText = "Course";
            dgvLogs.Columns[7].HeaderText = "Section";
            dgvLogs.Columns[8].HeaderText = "Last Updated";

        }

        private void dgvLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the double-clicked cell is not a header cell, and is in the first column
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Display a form to let the user edit the row
                EditRow editForm = new EditRow(e.RowIndex);
                editForm.ShowDialog();
                if (e.ColumnIndex == 0)
                {
                    // Cancel the event to prevent editing
                    dgvLogs.CurrentCell = null;
                }
                else if (e.ColumnIndex == 8)
                {
                    // Cancel the event to prevent editing
                    dgvLogs.CurrentCell = null;
                }
                // Refresh the DataGridView after the row has been edited
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=loginform");
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM logbook", conn);
                da.Fill(ds, "logbook");
                dgvLogs.DataSource = ds.Tables["logbook"];
                conn.Close();
            }
        }

        private void dgvLogs_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            // Set the first column read-only
            if (e.Column.Index == 0)
            {
                e.Column.ReadOnly = true;
            }
            if (e.Column.Index == 8)
            {
                e.Column.ReadOnly = true;
            }
        }

        private void dgvLogs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the edited cell is in the second column and the row index is valid
            if ((e.ColumnIndex > 0 && e.ColumnIndex < 8) && e.RowIndex >= 0 && e.RowIndex < dgvLogs.RowCount)
            {
                // Get the primary key of the edited row
                int id = Convert.ToInt32(dgvLogs.Rows[e.RowIndex].Cells[0].Value);

                // Get the new value of the edited cell
                string newValue = dgvLogs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Open a connection to the database
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=");
                conn.Open();

                // Build the SQL query
                string sql = "UPDATE loginform.logbook SET " + dgvLogs.Columns[e.ColumnIndex].Name + " = @NewValue WHERE logbook_id = @Id";

                // Create a MySqlCommand object with the SQL query and connection
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // Add parameters to the MySqlCommand object
                cmd.Parameters.AddWithValue("@NewValue", newValue);
                cmd.Parameters.AddWithValue("@Id", id);

                // Execute the query
                cmd.ExecuteNonQuery();

                // Get the row index of the edited cell
                int rowIndex = e.RowIndex;

                // Get the current timestamp value for the row
                DateTime currentTimestamp = (DateTime)dgvLogs.Rows[rowIndex].Cells["date_received"].Value;

                // Update the timestamp value to the current time
                DateTime newTimestamp = DateTime.Now;

                // Update the value in the timestamp cell
                dgvLogs.Rows[rowIndex].Cells["date_received"].Value = newTimestamp;

                // Close the connection
                conn.Close();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row in the DataGridView
            if (dgvLogs.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = dgvLogs.SelectedRows[0].Index;

                // Open the EditRow form and pass the selected row index as a parameter
                EditRow editForm = new EditRow(rowIndex);
                editForm.ShowDialog();

                // Refresh the DataGridView after the row has been edited
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=loginform");
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM logbook", conn);
                da.Fill(ds, "logbook");
                dgvLogs.DataSource = ds.Tables["logbook"];
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row in the DataGridView
            if (dgvLogs.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = dgvLogs.SelectedRows[0].Index;
                rowIndex++;
                DialogResult result = MessageBox.Show("Are you sure you want to delete Row: " + rowIndex + "?"
                                + Environment.NewLine + "This action will be deleted forever.", 
                                "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if(result == DialogResult.OK)
                {
                    // Connection string to the database
                    string connectionString = "datasource=localhost;port=3307;username=root;password=;database=loginform";

                    // ID of the row to delete
                    int id = rowIndex;

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
                }
                else if(result == DialogResult.Cancel)
                {
                    return;
                }

                // Refresh the DataGridView after the row has been edited
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=loginform");
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM logbook", conn);
                da.Fill(ds, "logbook");
                dgvLogs.DataSource = ds.Tables["logbook"];
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=loginform");
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM logbook", conn);
            da.Fill(ds, "logbook");
            dgvLogs.DataSource = ds.Tables["logbook"];
            conn.Close();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            bool scope, isCancelled;
            string dtpFrom, dtpTo;
            SpreadsheetMaker sm = new SpreadsheetMaker();
            sm.ShowDialog();

            isCancelled = sm.CancelExport;
            if (!isCancelled)
            {
                scope = sm.Scope;
                dtpFrom = sm.DtpFrom;
                dtpTo = sm.DtpTo;

                string query;
                if (scope)
                {
                    query = "SELECT * FROM logbook";
                }
                else
                {
                    query = $"SELECT * FROM logbook WHERE date_received BETWEEN '{dtpFrom}' AND '{dtpTo}'";
                }

                // Get the data from the database
                DataTable data = GetDataFromDatabase(query);

                // Save the data to a CSV file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV file (.csv)|.csv";
                saveFileDialog.FileName = "Logbook Report.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(data, saveFileDialog.FileName);
                    MessageBox.Show("Report generated successfully.");
                }
            }
            else
                return;
        }

        private DataTable GetDataFromDatabase(string query)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=loginform"))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        private void ExportToCSV(DataTable dataTable, string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                // Write the headers to the CSV file
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    streamWriter.Write(dataTable.Columns[i].ColumnName);
                    if (i < dataTable.Columns.Count - 1)
                    {
                        streamWriter.Write(",");
                    }
                }
                streamWriter.WriteLine();

                // Write the data to the CSV file
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        streamWriter.Write(dataTable.Rows[i][j]);
                        if (j < dataTable.Columns.Count - 1)
                        {
                            streamWriter.Write(",");
                        }
                    }
                    streamWriter.WriteLine();
                }
            }
        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeWizard cw = new ChangeWizard("username", btnAccount.Text);
            cw.ShowDialog();

            if (cw.Reset)
            {
                this.Hide();
                Index order = new Index();
                order.ShowDialog();
            }
            else
                return;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeWizard cw = new ChangeWizard("password", btnAccount.Text);
            cw.ShowDialog();

            if (cw.Reset)
            {
                this.Hide();
                Index order = new Index();
                order.ShowDialog();
            }
            else
                return;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Show the context menu as a dropdown menu from the button
            btnAccount.ContextMenuStrip.Show(btnAccount, new Point(0, btnAccount.Height));
        }
    }
}
