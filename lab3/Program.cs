using Microsoft.EntityFrameworkCore;
using ClassLib;
using SQLitePCL;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////SQLitePCL.Batteries.Init();
            //using (DB db = new DB())
            //{
                
            //    Department NTU_KHPI = new Department { Name = "NTU KHPI"};
            //    Employee Yehor = new Employee { Name = "Yehor Neposydiaka", Age = 19, Expirience = 3, Department = NTU_KHPI};
            //    db.Employees.Add(Yehor);
            //    db.Departments.Add(NTU_KHPI);
            //    db.SaveChanges();
                
            //    Console.WriteLine("Success added");

            //    var emp = db.Employees.ToList();
            //    Console.WriteLine("List of objects:");
            //    foreach (Employee u in emp)
            //    {
            //        Console.WriteLine($"{u.Name}   {u.Id}    {u.Age}");

            //    }
            //}
        }
    }
}
