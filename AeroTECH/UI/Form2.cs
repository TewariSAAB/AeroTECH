using System;
using System.Data;
using System.Windows.Forms;
using AeroTECH.DAL;
using MySqlConnector;

namespace AeroTECH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadProjectData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                string projectName = textBoxProjectName.Text.Trim();
                if (string.IsNullOrEmpty(projectName))
                {
                    MessageBox.Show("Project Name is required.");
                    return;
                }

                DateTime startDate = dateTimePickerStart.Value;
                DateTime endDate = dateTimePickerEnd.Value;
                int managerId;

                if (!int.TryParse(textBoxManagerID.Text, out managerId))
                {
                    MessageBox.Show("Please enter a valid Manager ID.");
                    return;
                }

                // Create the ProjectCRUD object and call AddProject
                ProjectCRUD projectCrud = new ProjectCRUD();
                projectCrud.AddProject(projectName, startDate, endDate, managerId);

                // Refresh the Data Grid View to show the updated data
                LoadProjectData();

                // Clear the form for new input
                ClearForm();
                MessageBox.Show("Project added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                int projectId;
                if (!int.TryParse(textBoxProjectID.Text, out projectId))
                {
                    MessageBox.Show("Please select a valid Project ID to update.");
                    return;
                }

                string projectName = textBoxProjectName.Text.Trim();
                if (string.IsNullOrEmpty(projectName))
                {
                    MessageBox.Show("Project Name is required.");
                    return;
                }

                DateTime startDate = dateTimePickerStart.Value;
                DateTime endDate = dateTimePickerEnd.Value;
                int managerId;

                if (!int.TryParse(textBoxManagerID.Text, out managerId))
                {
                    MessageBox.Show("Please enter a valid Manager ID.");
                    return;
                }

                // Create the ProjectCRUD object and call UpdateProject
                ProjectCRUD projectCrud = new ProjectCRUD();
                projectCrud.UpdateProject(projectId, projectName, startDate, endDate, managerId);

                // Refresh the Data Grid View to show the updated data
                LoadProjectData();

                // Clear the form for new input
                ClearForm();
                MessageBox.Show("Project updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int projectId;
                if (!int.TryParse(textBoxProjectID.Text, out projectId))
                {
                    MessageBox.Show("Please select a valid Project ID to delete.");
                    return;
                }

                // Create the ProjectCRUD object and call DeleteProject
                ProjectCRUD projectCrud = new ProjectCRUD();
                projectCrud.DeleteProject(projectId);

                // Refresh the Data Grid View to show the updated data
                LoadProjectData();

                // Clear the form for new input
                ClearForm();
                MessageBox.Show("Project deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadProjectData()
        {
            try
            {
                ProjectCRUD projectCrud = new ProjectCRUD();
                DataTable projects = projectCrud.GetAllProjects();
                dataGridViewProjects.DataSource = projects;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            textBoxProjectID.Clear();
            textBoxProjectName.Clear();
            textBoxManagerID.Clear();
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void dataGridViewProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate fields when a row is selected
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewProjects.Rows[e.RowIndex];
                    textBoxProjectID.Text = row.Cells["ProjectID"].Value.ToString();
                    textBoxProjectName.Text = row.Cells["ProjectName"].Value.ToString();
                    textBoxManagerID.Text = row.Cells["ManagerID"].Value.ToString();
                    dateTimePickerStart.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                    dateTimePickerEnd.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while selecting the project: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
