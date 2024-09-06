using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Book
    {
        private string _author;
        private string _title;
        private decimal _price;

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public Book() { }

        public string Title
        {
            get
            {
                return _title;
            } 
            set
            {
                try
                {
                    if(value.Length < 3)
                    {
                        throw new ArgumentException("Title is not valid");
                    }
                    _title = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }

        public string Author
        {
            get
            { 
                return _author; 
            }
            set
            {
                try
                {
                    string[]name_and_surname = value.Split();
                    if (char.IsDigit(name_and_surname[1][0]))
                    {
                        throw new ArgumentException("Error! Name of author cannot start with number");
                    }
                    _author = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }


        virtual public decimal Price
        {
            get { return _price; }
            set
            {
                try
                {
                    if (value <= 0) throw new ArgumentException("Invalid price");
                    _price = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name}\nTitle : {Title}\nAuthor : {Author}\nPrice : {Price:F2} UAH";
        }

    }

}
