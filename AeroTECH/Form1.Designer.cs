namespace AeroTECH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Submit = new Button();
            Reset = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label6 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox7 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 122);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First Name";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 164);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Last Name";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 208);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "ProjectManager // Engineer";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 249);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Email";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(157, 294);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Phone Number";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 129);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 5;
            label1.Text = "First name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 171);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 6;
            label2.Text = "Last name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 215);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 256);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 301);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 9;
            label5.Text = "Phone number";
            // 
            // Submit
            // 
            Submit.Location = new Point(563, 350);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 10;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += button1_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(449, 350);
            Reset.Name = "Reset";
            Reset.Size = new Size(94, 29);
            Reset.TabIndex = 11;
            Reset.Text = "Update";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += update_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 85);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 12;
            label6.Text = "User ID";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(157, 78);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "User ID";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(336, 350);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Delete_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 350);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Read";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Read_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(452, 242);
            dataGridView1.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(225, 27);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Search";
            textBox7.Size = new Size(183, 27);
            textBox7.TabIndex = 17;
            // 
            // button3
            // 
            button3.Location = new Point(449, 25);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Search_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox7);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(Reset);
            Controls.Add(Submit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Submit;
        private Button Reset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label6;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox7;
        private Button button3;
    }
}
