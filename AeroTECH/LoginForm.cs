using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace AeroTECH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from text boxes
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Verify credentials
            if (VerifyLogin(username, password))
            {
                // Open the main form if credentials are correct
                FormMain mainForm = new FormMain();
                this.Hide(); // Hide the login form
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool VerifyLogin(string username, string password)
        {
            // Replace with your database connection string
            string connectionString = "Server=database-1.ckvwwmvanacd.us-east-1.rds.amazonaws.com;Database=AeroTech;User ID=admin;Password=Dhruv0204;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Employees WHERE email=@email AND UserID=@UserID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", username);
                    cmd.Parameters.AddWithValue("@UserID", password); // Note: For production, use hashed passwords!

                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}
