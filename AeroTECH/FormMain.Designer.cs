namespace AeroTECH
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnEmployee = new Button();
            btnProject = new Button();
            btnProjectFiles = new Button();
            btnAssignment = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(100, 62);
            btnEmployee.Margin = new Padding(3, 4, 3, 4);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(200, 62);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Manage Employees";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnProject
            // 
            btnProject.Location = new Point(100, 150);
            btnProject.Margin = new Padding(3, 4, 3, 4);
            btnProject.Name = "btnProject";
            btnProject.Size = new Size(200, 62);
            btnProject.TabIndex = 1;
            btnProject.Text = "Manage Projects";
            btnProject.UseVisualStyleBackColor = true;
            btnProject.Click += btnProject_Click;
            // 
            // btnProjectFiles
            // 
            btnProjectFiles.Location = new Point(100, 238);
            btnProjectFiles.Margin = new Padding(3, 4, 3, 4);
            btnProjectFiles.Name = "btnProjectFiles";
            btnProjectFiles.Size = new Size(200, 62);
            btnProjectFiles.TabIndex = 2;
            btnProjectFiles.Text = "Manage Project Files";
            btnProjectFiles.UseVisualStyleBackColor = true;
            btnProjectFiles.Click += btnProjectFiles_Click;
            // 
            // btnAssignment
            // 
            btnAssignment.Location = new Point(100, 325);
            btnAssignment.Margin = new Padding(3, 4, 3, 4);
            btnAssignment.Name = "btnAssignment";
            btnAssignment.Size = new Size(200, 62);
            btnAssignment.TabIndex = 3;
            btnAssignment.Text = "Manage Assignments";
            btnAssignment.UseVisualStyleBackColor = true;
            btnAssignment.Click += btnAssignment_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(319, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 40);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 461);
            Controls.Add(btnEmployee);
            Controls.Add(btnProject);
            Controls.Add(btnProjectFiles);
            Controls.Add(btnAssignment);
            Controls.Add(btnLogout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnProjectFiles;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnLogout;
    }
}
