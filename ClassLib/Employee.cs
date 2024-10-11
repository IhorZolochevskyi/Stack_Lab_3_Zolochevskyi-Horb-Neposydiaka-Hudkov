namespace ClassLib
{
    public class Employee
    {
        public int Id { get; set; } // Первичный ключ
        public string Name { get; set; }
        public int Age { get; set; }
        public int Expirience { get; set; }

        // Внешний ключ для департамента
        public int DepartmentId { get; set; }

        // Навигационное свойство для департамента
        public Department Department { get; set; }


    }
}
