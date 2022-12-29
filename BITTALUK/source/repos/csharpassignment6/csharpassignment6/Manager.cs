using System;
using System.Collections.Generic;
using System.Text;

public delegate void displayManagerDetails();

namespace CSharpAssignment6
{
    [Serializable]
    public class Manager : Employee, Interface1
    {
        private double petrolAllowance;
        private double foodAllowance;
        private double otherAllowance;
        private double managerGrossSalary;
        private double netSalary;
        private double pf;
        private double tds;

        public Manager() { }
        public double PETROLALLOWANCE
        {
            get { return petrolAllowance; }
            set { petrolAllowance = (SALARY * 8) / 100; }
        }
        public double FOODALLOWANCE
        {
            get { return foodAllowance; }
            set { foodAllowance = (SALARY * 13) / 100; }
        }
        public double OTHERALLOWANCE
        {
            get { return otherAllowance; }
            set { otherAllowance = (SALARY * 3) / 100; }
        }

        public double MANAGERGROSSSALARY
        {
            set
            {
                managerGrossSalary = GROSSSALARY + PETROLALLOWANCE + FOODALLOWANCE + OTHERALLOWANCE;
            }
            get { return managerGrossSalary; }
        }
        public double PFM
        {
            get { return pf; }
            set { pf = (GROSSSALARY * 10) / 100; }
        }

        public double TDSM
        {
            get { return tds; }
            set { tds = (GROSSSALARY * 18) / 100; }
        }
        public Manager(int empNo, string empName, double salary) : base(empNo, empName, salary)
        {
            this.PFM = PFM;
            this.TDSM = TDSM;
            this.PETROLALLOWANCE = PETROLALLOWANCE;
            this.FOODALLOWANCE = FOODALLOWANCE;
            this.OTHERALLOWANCE = OTHERALLOWANCE;
            this.MANAGERGROSSSALARY = MANAGERGROSSSALARY;
        }
        public override double calculateSalary()
        {
            netSalary = MANAGERGROSSSALARY - (PFM + TDSM);
            return netSalary;
        }

        public new void displayDetails()
        {
            Console.WriteLine("PRINTING MANAGER DETAILS");
            Console.WriteLine($"Employee No: {EMPNO}");
            Console.WriteLine($"Employee Name: {EMPNAME}");
            Console.WriteLine($"Employee Salary: Rs.{SALARY}");
            Console.WriteLine($"Manager Gross Salary: Rs.{MANAGERGROSSSALARY}");
            Console.WriteLine($"Net Salary: Rs.{netSalary}");
        }

        public override string ToString()
        {
            return $"EMPLOYEE NUMBER: {EMPNO}, NAME: {EMPNAME}, SALARY: {SALARY}";
        }
    }
}
