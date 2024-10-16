namespace mainForm
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
            dataGridLabel = new Label();
            dataGridView1 = new DataGridView();
            NameTextBox = new TextBox();
            intTextBox = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            departmenRadioButton = new RadioButton();
            employeeRadioButton = new RadioButton();
            addButton = new Button();
            DeleteButton = new Button();
            inputLabel = new Label();
            indexLabel = new Label();
            radioButtonDF = new RadioButton();
            radioButtonDF2 = new RadioButton();
            findButton = new Button();
            departmentShowButton = new Button();
            employeeShowButton = new Button();
            comboBox1 = new ComboBox();
            ClearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridLabel
            // 
            dataGridLabel.AutoSize = true;
            dataGridLabel.Font = new Font("Segoe UI", 15F);
            dataGridLabel.Location = new Point(386, 15);
            dataGridLabel.Margin = new Padding(4, 0, 4, 0);
            dataGridLabel.Name = "dataGridLabel";
            dataGridLabel.Size = new Size(62, 41);
            dataGridLabel.TabIndex = 0;
            dataGridLabel.Text = "List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 67);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(786, 580);
            dataGridView1.TabIndex = 1;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(843, 118);
            NameTextBox.Margin = new Padding(4, 5, 4, 5);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Введіть ім'я";
            NameTextBox.Size = new Size(141, 31);
            NameTextBox.TabIndex = 2;
            // 
            // intTextBox
            // 
            intTextBox.Location = new Point(843, 183);
            intTextBox.Margin = new Padding(4, 5, 4, 5);
            intTextBox.Name = "intTextBox";
            intTextBox.PlaceholderText = "Введіть вік";
            intTextBox.Size = new Size(141, 31);
            intTextBox.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(843, 250);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введіть стаж";
            textBox3.Size = new Size(141, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1017, 118);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Введіть індекс";
            textBox4.Size = new Size(141, 31);
            textBox4.TabIndex = 5;
            // 
            // departmenRadioButton
            // 
            departmenRadioButton.AutoSize = true;
            departmenRadioButton.Location = new Point(863, 378);
            departmenRadioButton.Margin = new Padding(4, 5, 4, 5);
            departmenRadioButton.Name = "departmenRadioButton";
            departmenRadioButton.Size = new Size(132, 29);
            departmenRadioButton.TabIndex = 6;
            departmenRadioButton.TabStop = true;
            departmenRadioButton.Text = "Department";
            departmenRadioButton.UseVisualStyleBackColor = true;
            departmenRadioButton.CheckedChanged += departmenRadioButton_CheckedChanged;
            // 
            // employeeRadioButton
            // 
            employeeRadioButton.AutoSize = true;
            employeeRadioButton.Location = new Point(863, 420);
            employeeRadioButton.Margin = new Padding(4, 5, 4, 5);
            employeeRadioButton.Name = "employeeRadioButton";
            employeeRadioButton.Size = new Size(115, 29);
            employeeRadioButton.TabIndex = 7;
            employeeRadioButton.TabStop = true;
            employeeRadioButton.Text = "Employee";
            employeeRadioButton.UseVisualStyleBackColor = true;
            employeeRadioButton.CheckedChanged += employeeRadioButton_CheckedChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(843, 482);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(143, 58);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(1017, 305);
            DeleteButton.Margin = new Padding(4, 5, 4, 5);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(143, 48);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Font = new Font("Segoe UI", 12F);
            inputLabel.Location = new Point(843, 67);
            inputLabel.Margin = new Padding(4, 0, 4, 0);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(143, 32);
            inputLabel.TabIndex = 10;
            inputLabel.Text = "Enter values";
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Font = new Font("Segoe UI", 12F);
            indexLabel.Location = new Point(1021, 67);
            indexLabel.Margin = new Padding(4, 0, 4, 0);
            indexLabel.Name = "indexLabel";
            indexLabel.RightToLeft = RightToLeft.No;
            indexLabel.Size = new Size(134, 32);
            indexLabel.TabIndex = 11;
            indexLabel.Text = "Enter index";
            // 
            // radioButtonDF
            // 
            radioButtonDF.AutoSize = true;
            radioButtonDF.Location = new Point(1034, 190);
            radioButtonDF.Margin = new Padding(4, 5, 4, 5);
            radioButtonDF.Name = "radioButtonDF";
            radioButtonDF.Size = new Size(132, 29);
            radioButtonDF.TabIndex = 13;
            radioButtonDF.TabStop = true;
            radioButtonDF.Text = "Department";
            radioButtonDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonDF2
            // 
            radioButtonDF2.AutoSize = true;
            radioButtonDF2.Location = new Point(1034, 232);
            radioButtonDF2.Margin = new Padding(4, 5, 4, 5);
            radioButtonDF2.Name = "radioButtonDF2";
            radioButtonDF2.Size = new Size(115, 29);
            radioButtonDF2.TabIndex = 14;
            radioButtonDF2.TabStop = true;
            radioButtonDF2.Text = "Employee";
            radioButtonDF2.UseVisualStyleBackColor = true;
            // 
            // findButton
            // 
            findButton.Location = new Point(1017, 378);
            findButton.Margin = new Padding(4, 5, 4, 5);
            findButton.Name = "findButton";
            findButton.Size = new Size(143, 48);
            findButton.TabIndex = 15;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // departmentShowButton
            // 
            departmentShowButton.Location = new Point(17, 697);
            departmentShowButton.Margin = new Padding(4, 5, 4, 5);
            departmentShowButton.Name = "departmentShowButton";
            departmentShowButton.Size = new Size(371, 38);
            departmentShowButton.TabIndex = 16;
            departmentShowButton.Text = "Department";
            departmentShowButton.UseVisualStyleBackColor = true;
            departmentShowButton.Click += departmentShowButton_Click;
            // 
            // employeeShowButton
            // 
            employeeShowButton.Location = new Point(457, 697);
            employeeShowButton.Margin = new Padding(4, 5, 4, 5);
            employeeShowButton.Name = "employeeShowButton";
            employeeShowButton.Size = new Size(346, 38);
            employeeShowButton.TabIndex = 17;
            employeeShowButton.Text = "Employee";
            employeeShowButton.UseVisualStyleBackColor = true;
            employeeShowButton.Click += employeeShowButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(843, 315);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 33);
            comboBox1.TabIndex = 18;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.InfoText;
            ClearButton.ForeColor = SystemColors.ButtonFace;
            ClearButton.Location = new Point(991, 640);
            ClearButton.Margin = new Padding(4, 5, 4, 5);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(226, 127);
            ClearButton.TabIndex = 19;
            ClearButton.Text = "CLEAR DATABASE";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 777);
            Controls.Add(ClearButton);
            Controls.Add(comboBox1);
            Controls.Add(employeeShowButton);
            Controls.Add(departmentShowButton);
            Controls.Add(findButton);
            Controls.Add(radioButtonDF2);
            Controls.Add(radioButtonDF);
            Controls.Add(indexLabel);
            Controls.Add(inputLabel);
            Controls.Add(DeleteButton);
            Controls.Add(addButton);
            Controls.Add(employeeRadioButton);
            Controls.Add(departmenRadioButton);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(intTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dataGridLabel;
        private DataGridView dataGridView1;
        private TextBox NameTextBox;
        private TextBox intTextBox;
        private TextBox textBox3;
        private TextBox textBox4;
        private RadioButton departmenRadioButton;
        private RadioButton employeeRadioButton;
        private Button addButton;
        private Button DeleteButton;
        private Label inputLabel;
        private Label indexLabel;
        private RadioButton radioButtonDF;
        private RadioButton radioButtonDF2;
        private Button findButton;
        private Button departmentShowButton;
        private Button employeeShowButton;
        private ComboBox comboBox1;
        private Button ClearButton;
    }
}
