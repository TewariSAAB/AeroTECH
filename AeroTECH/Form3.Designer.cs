namespace AeroTECH
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxFileID;
        private TextBox textBoxProjectID;
        private TextBox textBoxFileName;
        private DateTimePicker dateTimePickerUploadDate;
        private DataGridView dataGridViewFiles;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;

        private void InitializeComponent()
        {
            textBoxFileID = new TextBox();
            textBoxProjectID = new TextBox();
            textBoxFileName = new TextBox();
            dateTimePickerUploadDate = new DateTimePicker();
            dataGridViewFiles = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiles).BeginInit();
            SuspendLayout();
            // 
            // textBoxFileID
            // 
            textBoxFileID.Location = new Point(134, 40);
            textBoxFileID.Name = "textBoxFileID";
            textBoxFileID.PlaceholderText = "File ID";
            textBoxFileID.ReadOnly = true;
            textBoxFileID.Size = new Size(125, 27);
            textBoxFileID.TabIndex = 0;
            // 
            // textBoxProjectID
            // 
            textBoxProjectID.Location = new Point(134, 88);
            textBoxProjectID.Name = "textBoxProjectID";
            textBoxProjectID.PlaceholderText = "Project ID";
            textBoxProjectID.Size = new Size(125, 27);
            textBoxProjectID.TabIndex = 1;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Location = new Point(134, 138);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.PlaceholderText = "File Name";
            textBoxFileName.Size = new Size(125, 27);
            textBoxFileName.TabIndex = 2;
            // 
            // dateTimePickerUploadDate
            // 
            dateTimePickerUploadDate.Location = new Point(134, 179);
            dateTimePickerUploadDate.Name = "dateTimePickerUploadDate";
            dateTimePickerUploadDate.Size = new Size(200, 27);
            dateTimePickerUploadDate.TabIndex = 3;
            // 
            // dataGridViewFiles
            // 
            dataGridViewFiles.ColumnHeadersHeight = 29;
            dataGridViewFiles.Location = new Point(354, 12);
            dataGridViewFiles.Name = "dataGridViewFiles";
            dataGridViewFiles.RowHeadersWidth = 51;
            dataGridViewFiles.Size = new Size(283, 242);
            dataGridViewFiles.TabIndex = 4;
            dataGridViewFiles.CellClick += dataGridViewFiles_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(64, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(168, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(286, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 8;
            label1.Text = "File ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 95);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 9;
            label2.Text = "Project ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 141);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 10;
            label3.Text = "File Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 184);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 11;
            label4.Text = "Upload Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 234);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 12;
            label5.Text = "File Path";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // Form3
            // 
            ClientSize = new Size(662, 399);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFileID);
            Controls.Add(textBoxProjectID);
            Controls.Add(textBoxFileName);
            Controls.Add(dateTimePickerUploadDate);
            Controls.Add(dataGridViewFiles);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "Form3";
            Text = "Project Files Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
    }
}
