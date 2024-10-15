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
            dataGridLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridLabel.Location = new Point(511, 252);
            dataGridLabel.Margin = new Padding(4, 0, 4, 0);
            dataGridLabel.Name = "dataGridLabel";
            dataGridLabel.Size = new Size(195, 48);
            dataGridLabel.TabIndex = 0;
            dataGridLabel.Text = "Objects list";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 319);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1142, 395);
            dataGridView1.TabIndex = 1;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(22, 71);
            NameTextBox.Margin = new Padding(4, 5, 4, 5);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Введіть ім'я";
            NameTextBox.Size = new Size(141, 31);
            NameTextBox.TabIndex = 2;
            // 
            // intTextBox
            // 
            intTextBox.Location = new Point(182, 71);
            intTextBox.Margin = new Padding(4, 5, 4, 5);
            intTextBox.Name = "intTextBox";
            intTextBox.PlaceholderText = "Введіть вік";
            intTextBox.Size = new Size(141, 31);
            intTextBox.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 112);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введіть досвід";
            textBox3.Size = new Size(141, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(609, 70);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 31);
            textBox4.TabIndex = 5;
            // 
            // departmenRadioButton
            // 
            departmenRadioButton.AutoSize = true;
            departmenRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            departmenRadioButton.Location = new Point(341, 71);
            departmenRadioButton.Margin = new Padding(4, 5, 4, 5);
            departmenRadioButton.Name = "departmenRadioButton";
            departmenRadioButton.Size = new Size(167, 36);
            departmenRadioButton.TabIndex = 6;
            departmenRadioButton.TabStop = true;
            departmenRadioButton.Text = "Department";
            departmenRadioButton.UseVisualStyleBackColor = true;
            departmenRadioButton.CheckedChanged += departmenRadioButton_CheckedChanged;
            // 
            // employeeRadioButton
            // 
            employeeRadioButton.AutoSize = true;
            employeeRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            employeeRadioButton.Location = new Point(341, 107);
            employeeRadioButton.Margin = new Padding(4, 5, 4, 5);
            employeeRadioButton.Name = "employeeRadioButton";
            employeeRadioButton.Size = new Size(144, 36);
            employeeRadioButton.TabIndex = 7;
            employeeRadioButton.TabStop = true;
            employeeRadioButton.Text = "Employee";
            employeeRadioButton.UseVisualStyleBackColor = true;
            employeeRadioButton.CheckedChanged += employeeRadioButton_CheckedChanged;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.Location = new Point(220, 23);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(288, 38);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.Location = new Point(773, 71);
            DeleteButton.Margin = new Padding(4, 5, 4, 5);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(178, 36);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            inputLabel.Location = new Point(22, 16);
            inputLabel.Margin = new Padding(4, 0, 4, 0);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(190, 45);
            inputLabel.TabIndex = 10;
            inputLabel.Text = "Enter values";
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            indexLabel.Location = new Point(597, 15);
            indexLabel.Margin = new Padding(4, 0, 4, 0);
            indexLabel.Name = "indexLabel";
            indexLabel.RightToLeft = RightToLeft.No;
            indexLabel.Size = new Size(179, 45);
            indexLabel.TabIndex = 11;
            indexLabel.Text = "Enter index";
            // 
            // radioButtonDF
            // 
            radioButtonDF.AutoSize = true;
            radioButtonDF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonDF.Location = new Point(609, 107);
            radioButtonDF.Margin = new Padding(4, 5, 4, 5);
            radioButtonDF.Name = "radioButtonDF";
            radioButtonDF.Size = new Size(167, 36);
            radioButtonDF.TabIndex = 13;
            radioButtonDF.TabStop = true;
            radioButtonDF.Text = "Department";
            radioButtonDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonDF2
            // 
            radioButtonDF2.AutoSize = true;
            radioButtonDF2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonDF2.Location = new Point(807, 107);
            radioButtonDF2.Margin = new Padding(4, 5, 4, 5);
            radioButtonDF2.Name = "radioButtonDF2";
            radioButtonDF2.Size = new Size(144, 36);
            radioButtonDF2.TabIndex = 14;
            radioButtonDF2.TabStop = true;
            radioButtonDF2.Text = "Employee";
            radioButtonDF2.UseVisualStyleBackColor = true;
            // 
            // findButton
            // 
            findButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            findButton.Location = new Point(773, 24);
            findButton.Margin = new Padding(4, 5, 4, 5);
            findButton.Name = "findButton";
            findButton.Size = new Size(178, 36);
            findButton.TabIndex = 15;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // departmentShowButton
            // 
            departmentShowButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            departmentShowButton.Location = new Point(33, 260);
            departmentShowButton.Margin = new Padding(4, 5, 4, 5);
            departmentShowButton.Name = "departmentShowButton";
            departmentShowButton.Size = new Size(251, 42);
            departmentShowButton.TabIndex = 16;
            departmentShowButton.Text = "Department";
            departmentShowButton.UseVisualStyleBackColor = true;
            departmentShowButton.Click += departmentShowButton_Click;
            // 
            // employeeShowButton
            // 
            employeeShowButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            employeeShowButton.Location = new Point(924, 260);
            employeeShowButton.Margin = new Padding(4, 5, 4, 5);
            employeeShowButton.Name = "employeeShowButton";
            employeeShowButton.Size = new Size(251, 43);
            employeeShowButton.TabIndex = 17;
            employeeShowButton.Text = "Employee";
            employeeShowButton.UseVisualStyleBackColor = true;
            employeeShowButton.Click += employeeShowButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 112);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 33);
            comboBox1.TabIndex = 18;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Red;
            ClearButton.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(967, 23);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(227, 120);
            ClearButton.TabIndex = 19;
            ClearButton.Text = "CLEAR DATABASE";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 758);
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
            Text = "Lab_3";
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
