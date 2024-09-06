using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Student:Person
    {
        private int faculty_number;
        public int Faculty_number
        {
            get
            {
                return faculty_number;
            }
            set
            {
                try
                {
                    if (value < 5 || value > 10) throw new ArgumentException("Invalid faculty number!");
                }
                catch(ArgumentException ex) 
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                faculty_number = value;
            }
        }

        public Student(string name, string surname, int faculty_number)
        {
            Name = name;
            Surname = surname;
            Faculty_number = faculty_number;
        }

        public override string ToString()
        {
            return $"\nFirst Name : {Name}\nLast Name : {Surname}\nFaculty number : {Faculty_number}\n";
        }
    }
}
