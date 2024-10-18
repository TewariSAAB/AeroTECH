using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace AeroTECH.DAL
{
    public class AssignmentCRUD
    {
        public void AddAssignment(int userId, int projectId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Assignment (UserID, ProjectID) VALUES (@UserID, @ProjectID)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAssignment(int assignmentId, int userId, int projectId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Assignment SET UserID = @UserID, ProjectID = @ProjectID WHERE AssignmentID = @AssignmentID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAssignment(int assignmentId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Assignment WHERE AssignmentID = @AssignmentID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllAssignments()
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Assignment";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
