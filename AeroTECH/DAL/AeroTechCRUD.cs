using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Assignment.DAL
{
    public class AeroTechCRUD
    {
        public void AddEmployee(string id, string firstName, string lastName, string role, string email, string phone)
        {
            DBHelper dbHelper = new DBHelper();
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = " INSERT INTO Employees(UserID, FirstName, LastName, Role, Email, Phone) Values(@UserID, @FirstName, @LastName, @Role, @Email, @Phone)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", id);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New employee is added"); 
            }
        }

        public void UpdateEmployee(int id, string firstName, string lastName, string role, string email, string phone)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, " +
                               "Role = @Role, Email = @Email, Phone = @Phone WHERE UserID = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Employees WHERE UserId = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllEmployees()
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Employees";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }


        public DataTable SearchEmployees(string searchTerm)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Employees WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR Role LIKE @SearchTerm OR UserId LIKE @SearchTerm";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

    }
}
