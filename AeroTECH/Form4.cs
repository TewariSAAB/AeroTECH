using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using AeroTECH.DAL;

namespace AeroTECH
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadAssignmentData();
        }

        private void LoadAssignmentData()
        {
            try
            {
                AssignmentCRUD assignmentCRUD = new AssignmentCRUD();
                dataGridViewAssignments.DataSource = assignmentCRUD.GetAllAssignments();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading assignments: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(textBoxUserID.Text.Trim());
                int projectId = int.Parse(textBoxProjectID.Text.Trim());

                AssignmentCRUD assignmentCRUD = new AssignmentCRUD();
                assignmentCRUD.AddAssignment(userId, projectId);

                MessageBox.Show("New Assignment added successfully!");
                LoadAssignmentData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding assignment: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int assignmentId = int.Parse(textBoxAssignmentID.Text.Trim());
                int userId = int.Parse(textBoxUserID.Text.Trim());
                int projectId = int.Parse(textBoxProjectID.Text.Trim());

                AssignmentCRUD assignmentCRUD = new AssignmentCRUD();
                assignmentCRUD.UpdateAssignment(assignmentId, userId, projectId);

                MessageBox.Show("Assignment updated successfully!");
                LoadAssignmentData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating assignment: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int assignmentId = int.Parse(textBoxAssignmentID.Text.Trim());

                AssignmentCRUD assignmentCRUD = new AssignmentCRUD();
                assignmentCRUD.DeleteAssignment(assignmentId);

                MessageBox.Show("Assignment deleted successfully!");
                LoadAssignmentData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting assignment: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            textBoxAssignmentID.Clear();
            textBoxUserID.Clear();
            textBoxProjectID.Clear();
        }
    }
}
