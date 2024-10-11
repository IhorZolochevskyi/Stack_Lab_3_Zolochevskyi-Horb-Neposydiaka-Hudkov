using ClassLib;
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

            var employees = _db.Employees
     .Select(e => new
     {
         e.Id,
         e.Name,
         e.Age,
         e.Expirience,
         DepartmentName = e.Department.Name 
     })
     .ToList();
            dataGridView1.DataSource = employees;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (radioButtonDF.Checked)
            {

            }
            if (radioButtonDF2.Checked)
            {

            }
            if(!radioButtonDF.Checked||!radioButtonDF2.Checked)
            {
                MessageBox.Show("Select option!", "Error");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (departmenRadioButton.Checked)
            {
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
            }
            NameTextBox.Text = "";
            intTextBox.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Success!");
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

        }
    }
}
