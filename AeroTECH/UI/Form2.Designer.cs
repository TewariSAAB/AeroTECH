namespace AeroTECH
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.TextBox textBoxManagerID;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private void InitializeComponent()
        {
            textBoxProjectID = new TextBox();
            textBoxProjectName = new TextBox();
            textBoxManagerID = new TextBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            dataGridViewProjects = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).BeginInit();
            SuspendLayout();
            // 
            // textBoxProjectID a
            // 
            textBoxProjectID.Location = new Point(117, 27);
            textBoxProjectID.Name = "textBoxProjectID";
            textBoxProjectID.PlaceholderText = "Project ID";
            textBoxProjectID.Size = new Size(105, 27);
            textBoxProjectID.TabIndex = 0;
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Location = new Point(117, 72);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.PlaceholderText = "Project Name";
            textBoxProjectName.Size = new Size(105, 27);
            textBoxProjectName.TabIndex = 1;
            // 
            // textBoxManagerID
            // 
            textBoxManagerID.Location = new Point(117, 121);
            textBoxManagerID.Name = "textBoxManagerID";
            textBoxManagerID.PlaceholderText = "Manager ID";
            textBoxManagerID.Size = new Size(105, 27);
            textBoxManagerID.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(250, 50);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 27);
            dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(250, 128);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 27);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // dataGridViewProjects
            // 
            dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjects.Location = new Point(12, 211);
            dataGridViewProjects.Name = "dataGridViewProjects";
            dataGridViewProjects.RowHeadersWidth = 51;
            dataGridViewProjects.Size = new Size(600, 139);
            dataGridViewProjects.TabIndex = 5;
            dataGridViewProjects.CellClick += dataGridViewProjects_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(490, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 25);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(490, 72);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 27);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(490, 128);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 27);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 9;
            label1.Text = "Project ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 10;
            label2.Text = "Project Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 11;
            label3.Text = "Manager ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 17);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 12;
            label4.Text = "Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 93);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 13;
            label5.Text = "End Date";
            // 
            // Form2
            // 
            ClientSize = new Size(640, 380);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxProjectID);
            Controls.Add(textBoxProjectName);
            Controls.Add(textBoxManagerID);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dataGridViewProjects);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "Form2";
            Text = "Project Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
