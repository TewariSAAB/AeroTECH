using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using AeroTECH.DAL;

namespace AeroTECH
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadProjectFilesData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = textBoxFileName.Text.Trim();
                DateTime uploadDate = dateTimePickerUploadDate.Value;
                int projectId;

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("File Name is required.");
                    return;
                }

                if (!int.TryParse(textBoxProjectID.Text, out projectId))
                {
                    MessageBox.Show("Please enter a valid Project ID.");
                    return;
                }

                ProjectFileCRUD fileCrud = new ProjectFileCRUD();
                fileCrud.AddProjectFile(projectId, fileName, uploadDate);

                LoadProjectFilesData();
                ClearForm();
                MessageBox.Show("File added successfully.");
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
                int fileId;
                if (!int.TryParse(textBoxFileID.Text, out fileId))
                {
                    MessageBox.Show("Please select a valid File ID to update.");
                    return;
                }

                string fileName = textBoxFileName.Text.Trim();
                DateTime uploadDate = dateTimePickerUploadDate.Value;
                int projectId;

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("File Name is required.");
                    return;
                }

                if (!int.TryParse(textBoxProjectID.Text, out projectId))
                {
                    MessageBox.Show("Please enter a valid Project ID.");
                    return;
                }

                ProjectFileCRUD fileCrud = new ProjectFileCRUD();
                fileCrud.UpdateProjectFile(fileId, projectId, fileName, uploadDate);

                LoadProjectFilesData();
                ClearForm();
                MessageBox.Show("File updated successfully.");
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
                int fileId;
                if (!int.TryParse(textBoxFileID.Text, out fileId))
                {
                    MessageBox.Show("Please select a valid File ID to delete.");
                    return;
                }

                ProjectFileCRUD fileCrud = new ProjectFileCRUD();
                fileCrud.DeleteProjectFile(fileId);

                LoadProjectFilesData();
                ClearForm();
                MessageBox.Show("File deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadProjectFilesData()
        {
            try
            {
                ProjectFileCRUD fileCrud = new ProjectFileCRUD();
                DataTable files = fileCrud.GetAllProjectFiles();
                dataGridViewFiles.DataSource = files;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            textBoxFileID.Clear();
            textBoxFileName.Clear();
            textBoxProjectID.Clear();
            dateTimePickerUploadDate.Value = DateTime.Now;
        }

        private void dataGridViewFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewFiles.Rows[e.RowIndex];
                    textBoxFileID.Text = row.Cells["FileID"].Value.ToString();
                    textBoxProjectID.Text = row.Cells["ProjectID"].Value.ToString();
                    textBoxFileName.Text = row.Cells["FileName"].Value.ToString();
                    dateTimePickerUploadDate.Value = Convert.ToDateTime(row.Cells["UploadDate"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while selecting the file: {ex.Message}");
            }
        }
    }
}
