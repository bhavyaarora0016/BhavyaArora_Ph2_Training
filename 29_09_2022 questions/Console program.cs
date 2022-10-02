using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2909Lib;

namespace _2909_ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _2909Lib.Library context = new _2909Lib.Library();
            context.books.Create();

            context.books.Add(new Book { book_no = 16, book_name = "blockchain evolution", author = "tom hanks", cost = 999, category = "english" });
            context.SaveChanges();
            Console.WriteLine("book added.");
        }
    }
}
