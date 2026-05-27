using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

/**
 IN SQL DATABASE

CREATE TABLE tblMobilePhones (
    MobileCode VARCHAR(20) PRIMARY KEY,
    Make       VARCHAR(50) NOT NULL,
    Quantity   INT NOT NULL
);

 */



namespace Question1_1_SectionC1
{
    public partial class Form1 : Form
    {
        // Connection string — update Data Source to your LocalDB instance
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MobileStockDB.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // 1.2.1 btnAdd — Insert a record into tblMobilePhones
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Input validation (non-functional: reliability)
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtMake.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                lblOutput.Text = "All fields are required.";
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                lblOutput.Text = "Quantity must be a valid positive number.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO tblMobilePhones (MobileCode, Make, Quantity) " +
                                   "VALUES (@MobileCode, @Make, @Quantity)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MobileCode", txtCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@Make", txtMake.Text.Trim());
                        cmd.Parameters.AddWithValue("@Quantity", quantity);

                        cmd.ExecuteNonQuery();
                    }
                }

                lblOutput.Text = "Record Added";
                ClearFields();
            }
            catch (SqlException ex) when (ex.Number == 2627) // Primary key violation
            {
                lblOutput.Text = "Error: MobileCode already exists.";
            }
            catch (Exception ex)
            {
                lblOutput.Text = "Error: " + ex.Message;
            }

        }


        // 1.2.2 btnDelete — Delete a record by MobileCode
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                lblOutput.Text = "Please enter a Mobile Code to delete.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // First check if the record exists
                    string checkQuery = "SELECT COUNT(*) FROM tblMobilePhones WHERE MobileCode = @MobileCode";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MobileCode", txtCode.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            lblOutput.Text = "Record NOT Found";
                            return;
                        }
                    }

                    // Record exists — proceed to delete
                    string deleteQuery = "DELETE FROM tblMobilePhones WHERE MobileCode = @MobileCode";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@MobileCode", txtCode.Text.Trim());
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                lblOutput.Text = "Record Found";
                ClearFields();
            }
            catch (Exception ex)
            {
                lblOutput.Text = "Error: " + ex.Message;
            }

        }

        // 1.2.3 btnFind — Find a record by MobileCode
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                lblOutput.Text = "Please enter a Mobile Code to find.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT MobileCode, Make, Quantity FROM tblMobilePhones " +
                                   "WHERE MobileCode = @MobileCode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MobileCode", txtCode.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMake.Text = reader["Make"].ToString();
                                txtQuantity.Text = reader["Quantity"].ToString();
                                lblOutput.Text = "Record Deleted"; // As per assessment spec
                            }
                            else
                            {
                                lblOutput.Text = "Record NOT Found";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblOutput.Text = "Error: " + ex.Message;
            }

        }

        // method to clear input fields
        private void ClearFields()
        {
            txtCode.Text = "";
            txtMake.Text = "";
            txtQuantity.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
