using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogicLayer
{
    public class Book
    {
        public int book_no { get; set; }
        public string book_name { get; set; }
        public string author { get; set; }
        public string category { get; set; }

        public Nullable<decimal> cost { get; set; }

    }
}
