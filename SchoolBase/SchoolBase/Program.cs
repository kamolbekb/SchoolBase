namespace Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("ad123","Joe Doe","+998992932",3_000_000);
            employee.DisplayInfo();
            employee.CalculateTax();
        }
    }
    class TotalBase
    {
        public TotalBase()
        {

        }
        public string Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public TotalBase(string id,string fullName,string phoneNumber)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Id:{Id}\nFull name:{FullName}\nPhone Number:{PhoneNumber}");
        }
    }
    class Student : TotalBase
    {
        public Student()
        {

        }
        public decimal AverageGrade { get; set; }
        public decimal[] Marks { get; set; }
        public Student(string id,string fullName,string phoneNumber,decimal averageGrade)
            : base(id, fullName, phoneNumber)
        {
            AverageGrade = averageGrade;
        }
    }
    class Employee:TotalBase
    {
        public Employee()
        {

        }
        public decimal Salary { get; set; }
        public Employee(string id,string fullName,string phoneNumber,decimal salary)
            : base(id, fullName, phoneNumber)
        {
            Salary = salary;
        }
        public void CalculateTax()
        {
            Console.WriteLine($"Salary:{Salary}");
            Console.WriteLine($"Salary of employee considering Taxes:{Salary - (Salary / 100 * 13)}");
        }
    }
    class Teachers : TotalBase
    {
        public Teachers()
        {

        }
        public decimal HourlyRate { get; set; }
        public Teachers(string id, string fullName, string phoneNumber, decimal hourlyRate)
            : base(id, fullName, phoneNumber)
        {
            HourlyRate = hourlyRate;
        }
    }
}