namespace ClassLib
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Expirience { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }


    }
}
