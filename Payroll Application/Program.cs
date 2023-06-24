
using System.Collections;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestCase")]

namespace Payroll
{
    public class Employee
    {
        private static int lastAssignedId = 0; 
        protected int emp_Id;
        protected string emp_Name;
        protected decimal basic_sal;

        public int EmployeeId
        {
            get { return emp_Id; }
            set { emp_Id = value; }
        }

        public string EmployeeName
        {
            get { return emp_Name; }
            set { emp_Name = value; }
        }

        public decimal BasicSalary
        {
            get { return basic_sal; }
            set { basic_sal = value; }
        }

        public Employee(string name, decimal salary)
        {
            lastAssignedId++; // Increment the ID counter
            emp_Id = lastAssignedId;
            emp_Name = name;
            basic_sal = salary;
        }

        public virtual decimal Calculate_Salary()
        {
            decimal deduction = basic_sal * 0.2m;
            return basic_sal - deduction;
        }
    }

    public class Programmer : Employee
    {
        private decimal hra;

        public Programmer(string name, decimal salary) : base(name, salary)
        {
            hra = basic_sal * 0.05m;
        }

        public override decimal Calculate_Salary()
        {
            decimal deduction = basic_sal * 0.2m;
            return basic_sal - deduction + hra;
        }
    }

    public class Manager : Employee
    {
        private decimal bonus;

        public Manager(string name, decimal salary) : base(name, salary)
        {
            bonus = basic_sal * 0.1m;
        }

        public override decimal Calculate_Salary()
        {
            decimal deduction = basic_sal * 0.2m;
            return basic_sal - deduction + bonus;
        }
    }

    public class Sale_Exe : Employee
    {
        private decimal travel_all;

        public Sale_Exe(string name, decimal salary) : base(name, salary)
        {
            travel_all = basic_sal * 0.15m;
        }

        public override decimal Calculate_Salary()
        {
            decimal deduction = basic_sal * 0.2m;
            return basic_sal - deduction + travel_all;
        }
    }

    class Program
    {
        public static void Main()
        {
            ArrayList employees = new ArrayList();

            // Create employee objects and add them to the ArrayList
            employees.Add(new Programmer("Yash", 5000m));
            employees.Add(new Manager("Abhishek", 8000m));
            employees.Add(new Sale_Exe("Piyush", 6000m));

            // Calculate and display salaries
            foreach (Employee emp in employees)
            {
                Console.WriteLine("Employee ID: {0}, Employee Name: {1}, Salary: {2}", emp.EmployeeId, emp.EmployeeName, emp.Calculate_Salary());
            }
        }
    }
}
