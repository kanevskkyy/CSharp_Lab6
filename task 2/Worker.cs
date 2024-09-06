using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Worker:Person
    {
        private double week_salary;
        private double working_hours;
        public double Week_salary
        {
            get
            {
                return week_salary;
            }
            set
            {
                try
                {
                    if (value < 10) throw new ArgumentException("Expected value mismatch! Argument : weekSalary");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                week_salary = value;
            }
        }

        public double Working_hours
        {
            get
            {
                return working_hours;
            }
            set
            {
                try
                {
                    if (value < 1 || value > 12) throw new ArgumentException("Expected value mismatch! Argument : workHoursPerDay");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                working_hours = value;
            }
        }

        public double Salary_per_hour()
        {
            return week_salary / (working_hours * 5);
        }

        public Worker(string name, string surname,  double week_salary, double working_hours)
        {
            Name = name;
            Surname = surname;
            Working_hours = working_hours;
            Week_salary = week_salary;
        }

        public override string ToString()
        {
            return $"\nFirst Name : {Name}\nLast name : {Surname}\nWeek Salary : {Week_salary:F2}\nHours per day : {Working_hours:F2}\nSalary per hour : {Salary_per_hour():F2}";
        }

    }
}
