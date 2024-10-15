using ClassLib;
using System;
namespace mainForm
{
    public partial class Form1 : Form
    {
        private DB _db;
        public Form1()
        {
            InitializeComponent();
            NameTextBox.Hide();
            intTextBox.Hide();
            textBox3.Hide();
            comboBox1.Hide();
            _db = new DB();
            LoadDepartments();
        }
        private void LoadDepartments()
        {
            var departments = _db.Departments.ToList();
            comboBox1.DataSource = departments;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }
        private void departmentShowButton_Click(object sender, EventArgs e)
        {
            var departments = _db.Departments.ToList();
            dataGridView1.DataSource = departments;
        }

        private void employeeShowButton_Click(object sender, EventArgs e)
        {

            var employees = _db.Employees.Select(e => new
            {
                e.Id,
                e.Name,
                e.Age,
                e.Expirience,
                DepartmentName = e.Department.Name
            }).ToList();
            dataGridView1.DataSource = employees;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) || !int.TryParse(textBox4.Text, out _))
            {
                MessageBox.Show("Enter a valid ID!", "Error");
                return;
            }
            if (radioButtonDF.Checked)
            {

                var department = _db.Departments.FirstOrDefault(d => d.Id == int.Parse(textBox4.Text));
                if (department == null)
                {
                    MessageBox.Show("Department not found!", "Error");
                    return;
                }
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                if (MessageBox.Show("ARE U SURE?!\n U WILL DELETE ALL WORKERS OF THIS DEPARTMENT", "Clear database", messageBoxButtons) == DialogResult.No)
                {
                    return;
                }
                _db.Departments.Remove(department);
                _db.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                var departments = _db.Departments.ToList();
                dataGridView1.DataSource = departments;
            }
            if (radioButtonDF2.Checked)
            {
                var employee = _db.Employees.FirstOrDefault(e => e.Id == int.Parse(textBox4.Text));
                if (employee == null)
                {
                    MessageBox.Show("Employee not found!", "Error");
                    return;
                }
                _db.Employees.Remove(employee);
                _db.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                var employees = _db.Employees.Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Age,
                    e.Expirience,
                    DepartmentName = e.Department.Name
                }).ToList();
                dataGridView1.DataSource = employees;
            }
            if (!radioButtonDF.Checked && !radioButtonDF2.Checked)
            {
                MessageBox.Show("Select an option!", "Error");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) || !int.TryParse(textBox4.Text, out _))
            {
                MessageBox.Show("Enter a valid ID!", "Error");
                return;
            }
            if (radioButtonDF.Checked)
            {
                var department = _db.Departments.FirstOrDefault(d => d.Id == int.Parse(textBox4.Text));
                if (department == null)
                {
                    MessageBox.Show("Department not found!", "Error");
                    return;
                }
                var employees = _db.Employees
                    .Where(e => e.DepartmentId == department.Id)
                    .ToList();
                dataGridView1.DataSource = new List<Department> { department };
            }
            if (radioButtonDF2.Checked)
            {
                var employee = _db.Employees.FirstOrDefault(e => e.Id == int.Parse(textBox4.Text));
                if (employee == null)
                {
                    MessageBox.Show("Employee not found!", "Error");
                    return;
                }
                dataGridView1.DataSource = new List<Employee> { employee };
            }
            if (!radioButtonDF.Checked && !radioButtonDF2.Checked)
            {
                MessageBox.Show("Select an option!", "Error");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (employeeRadioButton.Checked)
            {
                if (NameTextBox == null || NameTextBox.Text == "")
                {
                    MessageBox.Show("Enter a name!", "Error");
                    return;
                }

                if (intTextBox == null || intTextBox.Text == "" || !int.TryParse(intTextBox.Text, out int age) || age < 18 || age > 100)
                {
                    MessageBox.Show("Enter an correct age!", "Error");
                    return;
                }

                if (textBox3 == null || textBox3.Text == "" || !int.TryParse(textBox3.Text, out int expirience) || expirience > age - 16 || expirience <0)
                {
                    MessageBox.Show("Enter an correct experience!", "Error");
                    return;
                }
            }
            
            if (departmenRadioButton.Checked)
            {
                if (NameTextBox == null || NameTextBox.Text == "")
                {
                    MessageBox.Show("Enter a department name!", "Error");
                    return;
                }

                Department department = new Department { Name = NameTextBox.Text };
                _db.Departments.Add(department);
                _db.SaveChanges();
                LoadDepartments();
            }
            if (employeeRadioButton.Checked)
            {
                var selectedDepartment = _db.Departments
            .FirstOrDefault(d => d.Id == (int)comboBox1.SelectedValue);
                Employee employee = new Employee
                {
                    Name = NameTextBox.Text,
                    Age = int.Parse(intTextBox.Text),
                    Expirience = int.Parse(textBox3.Text),
                    DepartmentId = selectedDepartment.Id,
                    Department = selectedDepartment
                };
                _db.Employees.Add(employee);
                _db.SaveChanges();
                selectedDepartment.UpdateEmployeeAmount();
                _db.SaveChanges();
            }
            NameTextBox.Text = "";
            intTextBox.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Success!");

            if (departmenRadioButton.Checked)
            {
                var departments = _db.Departments.ToList();
                dataGridView1.DataSource = departments;
            }
            else
            {
                var employees = _db.Employees.Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Age,
                    e.Expirience,
                    DepartmentName = e.Department.Name
                }).ToList();
                dataGridView1.DataSource = employees;
            }
        }

        private void departmenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            intTextBox.Hide();
            textBox3.Hide();
            comboBox1.Hide();
            NameTextBox.Show();
        }

        private void employeeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            intTextBox.Text = "";
            textBox3.Text = "";
            NameTextBox.Show();
            intTextBox.Show();
            textBox3.Show();
            comboBox1.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            if (MessageBox.Show("ARE U SURE?!", "Clear database", messageBoxButtons) == DialogResult.No)
            {
                return;
            }
            MessageBox.Show("Database cleared!");
            _db.ClearDatabase();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            //string path = "D:\\!Igor\\!University\\!3 kurs\\1 semestr\\Стек\\TeamProjects\\Lab_3\\mainForm\\bin\\Debug\\net8.0-windows/Lab3DB.db";
            //File.Delete(path);
            //this.Close();
        }
    }
}
