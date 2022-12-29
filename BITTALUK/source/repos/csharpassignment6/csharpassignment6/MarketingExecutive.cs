using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment6
{
    [Serializable]
    public class MarketingExecutive : Employee, Interface1
    {
        private double kmTravel;
        private double tourAllowance;
        private double telephoneAllowance;
        private double marketingExecutiveGrossSalary;
        private double netSalary;
        private double pf;
        private double tds;

        public double KMTRAVEL { get { return kmTravel; } set { this.kmTravel = value; } }
        public double TELEPHONEALLOWANCE
        {
            get { return telephoneAllowance; }
            set { telephoneAllowance = 1000; }
        }
        public double TOURALLOWANCE
        {
            get { return tourAllowance; }
            set { tourAllowance = 5 * KMTRAVEL; }
        }
        public double MARKETINGEXECUTIVEGROSSSALARY
        {
            get { return marketingExecutiveGrossSalary; }
            set { marketingExecutiveGrossSalary = GROSSSALARY + TOURALLOWANCE + TELEPHONEALLOWANCE; }
        }
        public double PFME
        {
            get { return pf; }
            set { pf = (GROSSSALARY * 10) / 100; }
        }

        public double TDSME
        {
            get { return tds; }
            set { tds = (GROSSSALARY * 18) / 100; }
        }
        public override double calculateSalary()
        {
            netSalary = MARKETINGEXECUTIVEGROSSSALARY - (PFME + TDSME);
            return netSalary;
        }
        public MarketingExecutive(int empNo, string empName, double salary, double kmTravel) : base(empNo, empName, salary)
        {
            this.KMTRAVEL = kmTravel;
            this.TOURALLOWANCE = TOURALLOWANCE;
            this.TELEPHONEALLOWANCE = TELEPHONEALLOWANCE;
            this.PFME = PFME;
            this.TDSME = TDSME;
            this.MARKETINGEXECUTIVEGROSSSALARY = MARKETINGEXECUTIVEGROSSSALARY;
        }
        public void displayDetails()
        {
            Console.WriteLine("MARKETING EXECUTIVE DETAILS");
            Console.WriteLine($"Employee No: {EMPNO}");
            Console.WriteLine($"Employee Name: {EMPNAME}");
            Console.WriteLine($"Employee Salary: Rs.{SALARY}");
            Console.WriteLine($"Marketing Executive Gross Salary: Rs.{MARKETINGEXECUTIVEGROSSSALARY}");
            Console.WriteLine($"Net Salary: Rs.{netSalary}");
        }
    }
}
