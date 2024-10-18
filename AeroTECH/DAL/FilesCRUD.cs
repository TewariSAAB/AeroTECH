using System.Data;
using MySql.Data.MySqlClient;

namespace AeroTECH.DAL
{
    public class ProjectFileCRUD
    {
        public void AddProjectFile(int projectId, string fileName, DateTime uploadDate)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO ProjectFiles (ProjectID, FileName, UploadDate) VALUES (@ProjectID, @FileName, @UploadDate)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@UploadDate", uploadDate);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProjectFile(int fileId, int projectId, string fileName, DateTime uploadDate)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE ProjectFiles SET ProjectID = @ProjectID, FileName = @FileName, UploadDate = @UploadDate WHERE FileID = @FileID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FileID", fileId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@UploadDate", uploadDate);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProjectFile(int fileId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM ProjectFiles WHERE FileID = @FileID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FileID", fileId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllProjectFiles()
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM ProjectFiles";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
