using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CALCULATOR_Project
{
    public partial class calculator : Form
    {
        double resultvalue = 0;
        string operformed = "";
        bool isoperformed = false;
        string ConnectionString = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=calculatorDB;Integrated Security=True";

        public calculator()
        {
            InitializeComponent();
        }

        //( The buttons that we are clicking i.e (1,2,3,4,5,6,7,8,9,0).)-------------1
        private void button_click(object sender, EventArgs e)
        {
            if (tbdisplay.Text == "0" || (isoperformed))
                tbdisplay.Clear();
            isoperformed = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!tbdisplay.Text.Contains("."))
                    tbdisplay.Text += btn.Text;
            }
            else
            {
                tbdisplay.Text += btn.Text;
            }
        }

        //( The operations that we performing i.e (+ ,x ,/ ,-,square and square_root))-------------------------2
        private void operation_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            operformed = btn.Text;
            resultvalue = double.Parse(tbdisplay.Text);
            lbcurrentop.Text = resultvalue + " " + operformed;
            isoperformed = true;
        }

        //(The button which clear all the displayed or entered one .)-------------------------------3
        private void CE_btn_Click(object sender, EventArgs e)
        {
            tbdisplay.Text = "0";
            resultvalue = 0;
        }

        //(The button which clear all the displayed or entered one .)--------------------------------4
        private void c_btn_Click(object sender, EventArgs e)
        {
            if (tbdisplay.Text.Length > 0)
                tbdisplay.Text = tbdisplay.Text.Remove(tbdisplay.Text.Length - 1, 1);
            if (tbdisplay.Text == "")
                tbdisplay.Text = "0";
        }

        //(The button which shows the result after doing the operations on the values .)---------------------5
        private void equal_btn_Click(object sender, EventArgs e)
        {
            double currval = double.Parse(tbdisplay.Text);

            if (operformed == "+")
            {
                double operand1 = resultvalue;
                double operand2 = currval;
                double result = operand1 + operand2;

                tbdisplay.Text = result.ToString();
                int aid = InsertCurrentOperationIntoDatabase("Addition", operand1, operand2, result);
                InsertOperationHistory(operand1, operand2, result, "+", aid);
            }
            else if (operformed == "-")
            {
                double operand1 = resultvalue;
                double operand2 = currval;
                double result = operand1 - operand2;

                tbdisplay.Text = result.ToString();
                int sid = InsertCurrentOperationIntoDatabase("Substraction", operand1, operand2, result);
                InsertOperationHistory(operand1, operand2, result, "-", sid);
            }
            else if (operformed == "x")
            {
                double operand1 = resultvalue;
                double operand2 = currval;
                double result = operand1 * operand2;

                tbdisplay.Text = result.ToString();
                int mid = InsertCurrentOperationIntoDatabase("Multiplication", operand1, operand2, result);
                InsertOperationHistory(operand1, operand2, result, "x", mid);
            }
            else if (operformed == "/")
            {
                double operand1 = resultvalue;
                double operand2 = currval;

                // Check for division by zero
                if (operand2 == 0)
                {
                    MessageBox.Show("Error: Division by zero.");
                    return;
                }

                double result = operand1 / operand2;

                tbdisplay.Text = result.ToString();
                int did = InsertCurrentOperationIntoDatabase("Division", operand1, operand2, result);
                InsertOperationHistory(operand1, operand2, result, "/", did);
            }
            else if (operformed == "√2") // Square root operation
            {
                double result = Math.Sqrt(currval);

                tbdisplay.Text = result.ToString();
                int sqrid = InsertCurrentOperationIntoDatabase("Sqr", currval, 0, result);
                InsertOperationHistory(currval, 0, result, "√2", sqrid);
            }
            else if (operformed == "x²") // Square operation
            {
                double result = currval * currval;

                tbdisplay.Text = result.ToString();
                int sqid = InsertCurrentOperationIntoDatabase("Sq", currval, 0, result);
                InsertOperationHistory(currval, 0, result, "x²", sqid);
            }

            // Reset operation performed and current operation label
            operformed = "";
            lbcurrentop.Text = "";
        }


        //(The button which deletes the displayed value one by one)-------------------------------6 
        private void del_btn_Click(object sender, EventArgs e)
        {
            if (tbdisplay.Text.Length > 0)
                tbdisplay.Text = tbdisplay.Text.Remove(tbdisplay.Text.Length - 1, 1);
            if (tbdisplay.Text == "")
                tbdisplay.Text = "0";
        }

        //(Adding data into the database i.e (all the operations performed on the operands are added into the history table in the database)----7
        private void InsertOperationHistory( double operand1, double operand2, double result, string operation,double aid)
        {
            try
            {
                string query = "SET IDENTITY_INSERT History ON; " +
                               "INSERT INTO History (HID, Operand1, Operand2, Result, Operation, CreatedAt) " +
                               "VALUES (@HID, @Operand1, @Operand2, @Result, @Operation, GETDATE()); " +
                               "SET IDENTITY_INSERT History OFF;";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@HID", aid);
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


        //(Adding the data of the individual operations in the individual table in the database .)---------------8
        private int InsertCurrentOperationIntoDatabase(string tableName, double operand1, double operand2, double result)
        {
            string idColumn;
            string operand1Column;
            string operand2Column = "Operand2"; // Default value for tables other than Sq and Sqr
            switch (tableName)
            {
                case "Addition":
                    idColumn = "AID";
                    operand1Column = "Operand1";
                    break;
                case "Substraction":
                    idColumn = "SID";
                    operand1Column = "Operand1";
                    break;
                case "Multiplication":
                    idColumn = "MID";
                    operand1Column = "Operand1";
                    break;
                case "Division":
                    idColumn = "DID";
                    operand1Column = "Operand1";
                    break;
                case "Sq":
                    idColumn = "SQID";
                    operand1Column = "Operand";
                    operand2Column = null; // No Operand2 column in Sq table
                    break;
                case "Sqr":
                    idColumn = "SQRID";
                    operand1Column = "Operand";
                    operand2Column = null; // No Operand2 column in Sqr table
                    break;
                default:
                    throw new ArgumentException("Invalid table name");
            }

            try
            {
                string query;
                if (operand2Column != null)
                {
                    query = $"INSERT INTO {tableName} ({operand1Column}, {operand2Column}, Result) OUTPUT INSERTED.{idColumn} VALUES (@Operand1, @Operand2, @Result)";
                }
                else
                {
                    query = $"INSERT INTO {tableName} ({operand1Column}, Result) OUTPUT INSERTED.{idColumn} VALUES (@Operand1, @Result)";
                }

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Operand1", operand1);
                    if (operand2Column != null)
                    {
                        cmd.Parameters.AddWithValue("@Operand2", operand2);
                    }
                    cmd.Parameters.AddWithValue("@Result", result);
                    return (int)cmd.ExecuteScalar(); // Return the generated ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting operation into the database: " + ex.Message);
                return -1; // Return -1 indicating failure
            }
        }




        //(The button wich displays all the data in the history table)-------------------------9
        private void history_btn_Click(object sender, EventArgs e)
        {
            StringBuilder historyBuilder = new StringBuilder();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM History";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int count = 1;
                    historyBuilder.AppendLine("FULL HISTORY :");
                    while (reader.Read())
                    {
                        double operand1 = reader.GetDouble(1);
                        double operand2 = reader.GetDouble(2);
                        double result = reader.GetDouble(3);
                        string operation = reader.GetString(4);
                        DateTime createdAt = reader.GetDateTime(5);

                        historyBuilder.AppendLine($"{count}. Operation: {operand1} {operation} {operand2} = {result}");
                        count++;
                    }
                }
                MessageBox.Show(historyBuilder.ToString(), "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching operation history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To The Calculator");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            TableNameInputForm form = new TableNameInputForm();
            form.ShowDialog(); 
        }

        private void tbdisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
