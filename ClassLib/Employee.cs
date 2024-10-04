using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    internal class Employee
    {
        public int IdEmployee { get; set; }     // Поле для хранения ID сотрудника
        public string Name { get; set; }         // Поле для хранения имени сотрудника
        public string Position { get; set; }     // Поле для хранения должности сотрудника

        // Конструктор
        public Employee(int idEmployee, string name, string position)
        {
            IdEmployee = idEmployee;
            Name = name;
            Position = position;
        }
    }
}
