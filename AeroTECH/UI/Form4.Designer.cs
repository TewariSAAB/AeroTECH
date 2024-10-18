namespace AeroTECH
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAssignments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxAssignmentID;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.Label labelAssignmentID;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelProjectID;

        private void InitializeComponent()
        {
            dataGridViewAssignments = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            textBoxAssignmentID = new TextBox();
            textBoxUserID = new TextBox();
            textBoxProjectID = new TextBox();
            labelAssignmentID = new Label();
            labelUserID = new Label();
            labelProjectID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAssignments
            // 
            dataGridViewAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssignments.Location = new Point(12, 12);
            dataGridViewAssignments.Name = "dataGridViewAssignments";
            dataGridViewAssignments.RowHeadersWidth = 51;
            dataGridViewAssignments.Size = new Size(578, 150);
            dataGridViewAssignments.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(147, 247);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(266, 247);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 31);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(378, 247);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBoxAssignmentID
            // 
            textBoxAssignmentID.Location = new Point(129, 183);
            textBoxAssignmentID.Name = "textBoxAssignmentID";
            textBoxAssignmentID.Size = new Size(100, 27);
            textBoxAssignmentID.TabIndex = 4;
            // 
            // textBoxUserID
            // 
            textBoxUserID.Location = new Point(301, 183);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(100, 27);
            textBoxUserID.TabIndex = 5;
            // 
            // textBoxProjectID
            // 
            textBoxProjectID.Location = new Point(490, 180);
            textBoxProjectID.Name = "textBoxProjectID";
            textBoxProjectID.Size = new Size(100, 27);
            textBoxProjectID.TabIndex = 6;
            // 
            // labelAssignmentID
            // 
            labelAssignmentID.AutoSize = true;
            labelAssignmentID.Location = new Point(12, 187);
            labelAssignmentID.Name = "labelAssignmentID";
            labelAssignmentID.Size = new Size(108, 20);
            labelAssignmentID.TabIndex = 7;
            labelAssignmentID.Text = "Assignment ID:";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Location = new Point(235, 187);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(60, 20);
            labelUserID.TabIndex = 8;
            labelUserID.Text = "User ID:";
            // 
            // labelProjectID
            // 
            labelProjectID.AutoSize = true;
            labelProjectID.Location = new Point(407, 186);
            labelProjectID.Name = "labelProjectID";
            labelProjectID.Size = new Size(77, 20);
            labelProjectID.TabIndex = 9;
            labelProjectID.Text = "Project ID:";
            // 
            // FormAssignment
            // 
            ClientSize = new Size(602, 355);
            Controls.Add(labelProjectID);
            Controls.Add(labelUserID);
            Controls.Add(labelAssignmentID);
            Controls.Add(textBoxProjectID);
            Controls.Add(textBoxUserID);
            Controls.Add(textBoxAssignmentID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewAssignments);
            Name = "FormAssignment";
            Text = "Manage Assignments";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
