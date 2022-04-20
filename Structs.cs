using System;

namespace Struct{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.employeeName = "Fahim";
            employee.employeeJob = "Software Engineer";

            employee.Salary = 45000;
            
            employee.employeeInfo();
            
        }
    }

    struct Employee
    {
        public string employeeName;
        public string employeeJob;

        private decimal salary;

        public decimal Salary {
            get { return salary;}
            set {salary = value;}
        }

        public void employeeInfo()
        {
            Console.WriteLine($"Employee Name: {employeeName} \nJob Title: {employeeJob}\nSalary : {salary}");
        }
    }
}