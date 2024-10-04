namespace ClassLib
{
    public class Department
    {
        public int IdDepartment { get; set; }  // Поле для хранения ID департамента
        public string Name { get; set; }        // Поле для хранения названия департамента

        // Конструктор
        public Department(int idDepartment, string name)
        {
            IdDepartment = idDepartment;
            Name = name;
        }
    }
}
