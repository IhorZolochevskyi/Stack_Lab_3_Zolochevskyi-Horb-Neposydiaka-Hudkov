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
            dataGridLabel.Location = new Point(270, 9);
            dataGridLabel.Name = "dataGridLabel";
            dataGridLabel.Size = new Size(41, 28);
            dataGridLabel.TabIndex = 0;
            dataGridLabel.Text = "List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(550, 348);
            dataGridView1.TabIndex = 1;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(590, 71);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 2;
            // 
            // intTextBox
            // 
            intTextBox.Location = new Point(590, 110);
            intTextBox.Name = "intTextBox";
            intTextBox.Size = new Size(100, 23);
            intTextBox.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(590, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(712, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // departmenRadioButton
            // 
            departmenRadioButton.AutoSize = true;
            departmenRadioButton.Location = new Point(604, 227);
            departmenRadioButton.Name = "departmenRadioButton";
            departmenRadioButton.Size = new Size(88, 19);
            departmenRadioButton.TabIndex = 6;
            departmenRadioButton.TabStop = true;
            departmenRadioButton.Text = "Department";
            departmenRadioButton.UseVisualStyleBackColor = true;
            departmenRadioButton.CheckedChanged += departmenRadioButton_CheckedChanged;
            // 
            // employeeRadioButton
            // 
            employeeRadioButton.AutoSize = true;
            employeeRadioButton.Location = new Point(604, 252);
            employeeRadioButton.Name = "employeeRadioButton";
            employeeRadioButton.Size = new Size(77, 19);
            employeeRadioButton.TabIndex = 7;
            employeeRadioButton.TabStop = true;
            employeeRadioButton.Text = "Employee";
            employeeRadioButton.UseVisualStyleBackColor = true;
            employeeRadioButton.CheckedChanged += employeeRadioButton_CheckedChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(590, 289);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 35);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(712, 183);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(100, 29);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Font = new Font("Segoe UI", 12F);
            inputLabel.Location = new Point(590, 40);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(94, 21);
            inputLabel.TabIndex = 10;
            inputLabel.Text = "Enter values";
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Font = new Font("Segoe UI", 12F);
            indexLabel.Location = new Point(715, 40);
            indexLabel.Name = "indexLabel";
            indexLabel.RightToLeft = RightToLeft.No;
            indexLabel.Size = new Size(87, 21);
            indexLabel.TabIndex = 11;
            indexLabel.Text = "Enter index";
            // 
            // radioButtonDF
            // 
            radioButtonDF.AutoSize = true;
            radioButtonDF.Location = new Point(724, 114);
            radioButtonDF.Name = "radioButtonDF";
            radioButtonDF.Size = new Size(88, 19);
            radioButtonDF.TabIndex = 13;
            radioButtonDF.TabStop = true;
            radioButtonDF.Text = "Department";
            radioButtonDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonDF2
            // 
            radioButtonDF2.AutoSize = true;
            radioButtonDF2.Location = new Point(724, 139);
            radioButtonDF2.Name = "radioButtonDF2";
            radioButtonDF2.Size = new Size(77, 19);
            radioButtonDF2.TabIndex = 14;
            radioButtonDF2.TabStop = true;
            radioButtonDF2.Text = "Employee";
            radioButtonDF2.UseVisualStyleBackColor = true;
            // 
            // findButton
            // 
            findButton.Location = new Point(712, 227);
            findButton.Name = "findButton";
            findButton.Size = new Size(100, 29);
            findButton.TabIndex = 15;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // departmentShowButton
            // 
            departmentShowButton.Location = new Point(12, 418);
            departmentShowButton.Name = "departmentShowButton";
            departmentShowButton.Size = new Size(260, 23);
            departmentShowButton.TabIndex = 16;
            departmentShowButton.Text = "Department";
            departmentShowButton.UseVisualStyleBackColor = true;
            departmentShowButton.Click += departmentShowButton_Click;
            // 
            // employeeShowButton
            // 
            employeeShowButton.Location = new Point(320, 418);
            employeeShowButton.Name = "employeeShowButton";
            employeeShowButton.Size = new Size(242, 23);
            employeeShowButton.TabIndex = 17;
            employeeShowButton.Text = "Employee";
            employeeShowButton.UseVisualStyleBackColor = true;
            employeeShowButton.Click += employeeShowButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(590, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 18;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.InfoText;
            ClearButton.ForeColor = SystemColors.ButtonFace;
            ClearButton.Location = new Point(694, 384);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(158, 76);
            ClearButton.TabIndex = 19;
            ClearButton.Text = "CLEAR DATABASE";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 466);
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
