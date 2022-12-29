using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CSharpAssignment6
{

    public interface Interface1
    {
        void displayDetails();
    }
    [Serializable]
    public class Employee : Interface1
    {
        private int empNo;
        private string empName;
        private double salary;
        private double hra;
        private double ta;
        private double da;
        private double pf;
        private double tds;
        private double netSalary;
        private double grossSalary;

        public Employee() { }

        public int EMPNO
        {
            get { return empNo; }
            set
            {
                try
                {

                    if (value < 0)
                    {
                        throw new Exception("Employee ID cannot be negative");
                    }
                    this.empNo = value;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
        }
        public string EMPNAME
        {
            get { return empName; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("Employee name cannot be null.");
                    }
                    this.empName = value;
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    Environment.Exit(1);
                }
            }
        }
        public double SALARY
        {
            get { return salary; }
            set
            {
                try
                {

                    if (value < 0)
                    {
                        throw new Exception("Salary cannot be negative");
                    }
                    this.salary = value;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
        }

        public double GROSSSALARY
        {
            set
            {
                if (SALARY < 5000)
                {
                    hra = (SALARY * 10) / 100;
                    ta = (SALARY * 5) / 100;
                    da = (SALARY * 15) / 100;
                    grossSalary = SALARY + hra + ta + da;
                }
                else if (SALARY < 10000)
                {
                    hra = (SALARY * 15) / 100;
                    ta = (SALARY * 10) / 100;
                    da = (SALARY * 20) / 100;
                    grossSalary = SALARY + hra + ta + da;
                }
                else if (SALARY < 15000)
                {
                    hra = (SALARY * 20) / 100;
                    ta = (SALARY * 15) / 100;
                    da = (SALARY * 25) / 100;
                    grossSalary = SALARY + hra + ta + da;
                }
                else if (SALARY < 20000)
                {
                    hra = (SALARY * 25) / 100;
                    ta = (SALARY * 20) / 100;
                    da = (SALARY * 30) / 100;
                    grossSalary = SALARY + hra + ta + da;
                }
                else if (SALARY >= 20000)
                {
                    hra = (SALARY * 30) / 100;
                    ta = (SALARY * 25) / 100;
                    da = (SALARY * 35) / 100;
                    grossSalary = SALARY + hra + ta + da;
                }
            }
            get { return grossSalary; }
        }

        public double PF
        {
            get { return pf; }
            set { pf = (GROSSSALARY * 10) / 100; }
        }

        public double TDS
        {
            get { return tds; }
            set { tds = (GROSSSALARY * 18) / 100; }
        }

        public virtual double calculateSalary()
        {
            netSalary = GROSSSALARY - (PF + TDS);
            return netSalary;
        }
        public Employee(int empNo, string empName, double salary)
        {
            this.EMPNO = empNo;
            this.EMPNAME = empName;
            this.SALARY = salary;
            this.GROSSSALARY = GROSSSALARY;
            this.PF = PF;
            this.TDS = TDS;
        }

        public void displayDetails()
        {
            Console.WriteLine("PRINTING EMPLOYEE DETAILS");
            Console.WriteLine($"Employee No: {EMPNO}");
            Console.WriteLine($"Employee Name: {EMPNAME}");
            Console.WriteLine($"Employee Salary: Rs.{SALARY}");
            Console.WriteLine($"Employees Gross Salary: {GROSSSALARY}");
            Console.WriteLine($"Employees Net Salary: {netSalary}");
        }
    }
}