using System;

namespace task_2
{
    internal class Person
    {
        private string name;
        private string surname;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                try
                {
                    if (char.IsLower(value[0]))
                    {
                        throw new ArgumentException("Expected upper case letter! Argument : Name");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                try
                {
                    if (value.Length < 4)
                    {
                        throw new ArgumentException("Expected length at least 4 symbols! Argument : Name");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);

                }
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                try
                {
                    if (char.IsLower(value[0]))
                    {
                        throw new ArgumentException("Expected upper case letter! Argument : Name");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                try
                {
                    if (value.Length < 3) throw new ArgumentException("Expected upper case letter! Argument: Surname");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
