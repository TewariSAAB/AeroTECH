using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace AeroTECH.DAL
{
    public class ProjectCRUD
    {
        public void AddProject(string projectName, DateTime startDate, DateTime endDate, int managerId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Projects(ProjectName, StartDate, EndDate, ManagerID) VALUES(@ProjectName, @StartDate, @EndDate, @ManagerID)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@ManagerID", managerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProject(int projectId, string projectName, DateTime startDate, DateTime endDate, int managerId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Projects SET ProjectName = @ProjectName, StartDate = @StartDate, EndDate = @EndDate, ManagerID = @ManagerID WHERE ProjectID = @ProjectID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@ManagerID", managerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProject(int projectId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Projects WHERE ProjectID = @ProjectID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllProjects()
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Projects";
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
    }
}
