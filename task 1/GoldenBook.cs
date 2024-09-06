using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class GoldenBook : Book
    {
        public GoldenBook(string author, string title, decimal price) : base(author, title, price) { }
        public GoldenBook() : base() { }
        public override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }
            set
            {
                base.Price = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
