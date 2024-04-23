using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections.Generic;

namespace CALCULATOR_Project
{
    public partial class TableNameInputForm : Form
    {
        private string connectionString = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=calculatorDB;Integrated Security=True";

        public TableNameInputForm()
        {
            InitializeComponent();
            this.Size = new Size(350, 500);
            op_text1.TextChanged += new EventHandler(op_text1_TextChanged);
            op_text2.TextChanged += new EventHandler(op_text2_TextChanged);
        }

        private void TableNameInputForm_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with table names from the database
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DataTable schemaTable = connection.GetSchema("Tables");

                    foreach (DataRow row in schemaTable.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        comboBoxTables.Items.Add(tableName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching table names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTableName = comboBoxTables.SelectedItem.ToString();

            // Retrieve data from the selected table
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {selectedTableName}", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    // Set DataGridView's DataSource to the retrieved data
                    dataGridViewData.DataSource = dataTable;

                    // Update the label to show the selected table
                    label2.Text = $"Selected Table: {selectedTableName}";

                    // Display a message box indicating that the table has been selected successfully
                    // MessageBox.Show($"Table '{selectedTableName}' selected successfully.", "Table Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Check the selected table name and perform specific actions accordingly
                    switch (selectedTableName)
                    {
                        case "Addition":
                        case "Substraction":
                        case "Multiplication":
                        case "Division":
                            // For tables with operands (e.g., Addition, Subtraction, Multiplication, Division)
                            PopulateComboBoxWithOperands(selectedTableName);
                            break;
                        case "Sq":
                        case "Sqr":
                            PopulateComboBoxWithOperands(selectedTableName);
                            break;
                        case "History":
                            PopulateComboBoxWithOperands(selectedTableName);
                            break;
                        default:
                            // Handle unknown table names
                            MessageBox.Show("Unknown table name: " + selectedTableName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data from the selected table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateComboBoxWithOperands(string tableName)
        {
            try
            {
                string idColumnName = GetIDColumnName(tableName);

                if (string.IsNullOrEmpty(idColumnName))
                {
                    MessageBox.Show($"ID column not found for table '{tableName}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT {idColumnName} FROM {tableName}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<string> idList = new List<string>();
                    while (reader.Read())
                    {
                        string id = reader[idColumnName].ToString();
                        idList.Add(id);
                    }

                    comboBoxID.DataSource = idList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetIDColumnName(string tableName)
        {
            switch (tableName)
            {
                case "Addition":
                    return "AID";
                case "Substraction":
                    return "SID";
                case "Multiplication":
                    return "MID";
                case "Division":
                    return "DID";
                case "Sq":
                    return "SQID";
                case "Sqr":
                    return "SQRID";
                case "History":
                    return "HID";

                default:
                    return ""; // Return empty string for unknown table names
            }
        }


        // Inside the TableNameInputForm class definition

        private void op_text1_TextChanged(object sender, EventArgs e)
        {
            CalculateResultAndUpdateDatabase();
        }

        private void op_text2_TextChanged(object sender, EventArgs e)
        {
            CalculateResultAndUpdateDatabase();
        }

        private void CalculateResultAndUpdateDatabase()
        {
            try
            {
                string selectedTableName = comboBoxTables.SelectedItem.ToString();
                string selectedID = comboBoxID.SelectedItem.ToString();

                // Fetch Operand1 and Operand2 values from the text boxes
                double operand1Value = double.TryParse(op_text1.Text, out double operand1) ? operand1 : 0.0;
                double operand2Value = double.TryParse(op_text2.Text, out double operand2) ? operand2 : 0.0;

                // Perform calculation based on the selected table
                double result = 0.0;
                string operation = ""; // Operation performed

                switch (selectedTableName)
                {
                    case "Addition":
                        result = operand1Value + operand2Value;
                        operation = "+";
                        break;
                    case "Substraction":
                        result = operand1Value - operand2Value;
                        operation = "-";
                        break;
                    case "Multiplication":
                        result = operand1Value * operand2Value;
                        operation = "x";
                        break;
                    case "Division":
                        if (operand2Value != 0)
                        {
                            result = operand1Value / operand2Value;
                            operation = "/";
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case "Sq":
                        result = Math.Pow(operand1Value, 2);
                        operation = "x²";
                        break;
                    case "Sqr":
                        if (operand1Value >= 0)
                        {
                            result = Math.Sqrt(operand1Value);
                            operation = "√2";
                        }
                        else
                        {
                            MessageBox.Show("Cannot calculate square root of a negative number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case "History":
                        // Handle History table calculation if needed
                        break;
                    default:
                        MessageBox.Show($"Unsupported table: {selectedTableName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Update the Result value in the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery;
                    SqlCommand updateCommand;
                    if (selectedTableName == "Sq" || selectedTableName == "Sqr")
                    {
                        // For tables Sq and Sqr with one operand
                        updateQuery = $"UPDATE {selectedTableName} SET Operand = @Operand, Result = @Result  WHERE {GetIDColumnName(selectedTableName)} = @ID";
                        updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@Operand", operand1Value);
                        updateCommand.Parameters.AddWithValue("@Result", result);
                    }
                    else
                    {
                        // For other tables with two operands
                        updateQuery = $"UPDATE {selectedTableName} SET Operand1 = @Operand1, Operand2 = @Operand2, Result = @Result  WHERE {GetIDColumnName(selectedTableName)} = @ID";
                        updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@Operand1", operand1Value);
                        updateCommand.Parameters.AddWithValue("@Operand2", operand2Value);
                        updateCommand.Parameters.AddWithValue("@Result", result);
                    }

                    updateCommand.Parameters.AddWithValue("@ID", selectedID);
                    updateCommand.Parameters.AddWithValue("@Operation", operation);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    // Update the history table
                    InsertOperationHistory(operand1Value, operand2Value, result, operation);
                }

                // Update the result textbox
                res_text1.Text = result.ToString();
                comboBoxTables_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertOperationHistory(double operand1, double operand2, double result, string operation)
        {
            try
            {
                string query = "INSERT INTO History (Operand1, Operand2, Result, Operation, CreatedAt) " +
                               "VALUES (@Operand1, @Operand2, @Result, @Operation, GETDATE());";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Operand1", operand1);
                    cmd.Parameters.AddWithValue("@Operand2", operand2);
                    cmd.Parameters.AddWithValue("@Result", result);
                    cmd.Parameters.AddWithValue("@Operation", operation);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting operation history into the database: " + ex.Message);
            }
        }

        private void labelSelectedTable_Click(object sender, EventArgs e)
        {

        }
    }
}

