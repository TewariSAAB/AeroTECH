using System.Data;
using MySqlConnector;
using MySql.Data.MySqlClient;
using Assignment.DAL;
using System.Windows.Forms;

namespace AeroTECH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get values through form
            string id = textBox6.Text.Trim();
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string role = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string phone = textBox5.Text.Trim();

            //Add validations
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(role)
                || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please fill all information");
                return;
            }

            try
            {
                // CRUD To Add Employee
                AeroTechCRUD aerotechCrud = new AeroTechCRUD();
                aerotechCrud.AddEmployee(id, firstName, lastName, role, email, phone);

                //  Message for addition of the new employee
                MessageBox.Show("New Empoyee is added");

                // Clear form
                ClearForm();
            }

            catch (Exception ex)
            {
                //For any exception
                MessageBox.Show($"There is an occurred : {ex.Message}");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            // Get values from form fields
            string id = textBox6.Text.Trim(); // Assume textBox6 holds the employee ID for the update
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string role = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string phone = textBox5.Text.Trim();

            // Basic validations
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(role) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all required information.");
                return;
            }

            try
            {
                AeroTechCRUD aerotechCrud = new AeroTechCRUD();
                aerotechCrud.UpdateEmployee(int.Parse(id), firstName, lastName, role, email, phone);
                MessageBox.Show("Employee details updated successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Get employee ID for deletion
            string id = textBox6.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter the Employee ID to delete.");
                return;
            }

            try
            {
                AeroTechCRUD aerotechCrud = new AeroTechCRUD();
                aerotechCrud.DeleteEmployee(int.Parse(id));
                MessageBox.Show("Employee has been deleted successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox7.Text.Trim();
            LoadEmployeeData(searchTerm);
        }

        private void LoadEmployeeData(string searchTerm = "")
        {
            try
            {
                AeroTechCRUD aerotechCrud = new AeroTechCRUD();
                DataTable dataTable;

                if (string.IsNullOrEmpty(searchTerm))
                {
                    dataTable = aerotechCrud.GetAllEmployees();
                }
                else
                {
                    dataTable = aerotechCrud.SearchEmployees(searchTerm);
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
