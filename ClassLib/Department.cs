using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Department
    {
        public int Id { get; set; } // Первичный ключ
        public string Name { get; set; }

        // Коллекция работников, связанных с департаментом
        public List<Employee> Employees { get; set; } = new List<Employee>();

        // Количество работников
        public int EmployeeAmount { get; set; }

        // Обновляем количество работников при добавлении в базу данных
        public void UpdateEmployeeAmount()
        {
            EmployeeAmount = Employees.Count;
        }
    }
}
