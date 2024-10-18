using System;
using System.Windows.Forms;

namespace AeroTECH
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnLogout.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            // Open the Employee form
            Form1 formEmployee = new Form1();
            formEmployee.ShowDialog();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            // Open the Project form
            Form2 formProject = new Form2();
            formProject.ShowDialog();
        }

        private void btnProjectFiles_Click(object sender, EventArgs e)
        {
            // Open the Project Files form
            Form3 formProjectFiles = new Form3();
            formProjectFiles.ShowDialog();
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            // Open the Assignment form
            Form4 formAssignment = new Form4();
            formAssignment.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Log out and show the login form again
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
