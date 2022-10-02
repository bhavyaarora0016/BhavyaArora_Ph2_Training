using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace EntityFramework_ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Insert Book 2.Update Book 3.Book Count 4.Get All Books");
            int choice = Int32.Parse(Console.ReadLine());
            BookOperations b = new BookOperations();
            Book book = new Book();
            switch (choice)
            {
                case 1:

                    Console.WriteLine("Enter Book Number :");
                    book.book_no = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Book Name :");
                    book.book_name = Console.ReadLine();
                    Console.WriteLine("Enter Author ;");
                    book.author = Console.ReadLine();
                    Console.WriteLine("Enter Cost of the Book");
                    book.cost = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Category");
                    book.category = Console.ReadLine();
                    b.InsertBook(book);
                    break;
                case 2:
                    //BookBal book = new BookBal();
                    Console.WriteLine("Enter Book Number :");
                    book.book_no = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Book Name :");
                    book.book_name = Console.ReadLine();
                    Console.WriteLine("Enter Author ;");
                    book.author = Console.ReadLine();
                    Console.WriteLine("Enter Cost of the Book");
                    book.cost = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Category");
                    book.category = Console.ReadLine();
                    b.UpdateBook(book);
                    break;
                case 3:
                    int id = b.Count();
                    Console.WriteLine("Book Count  : " + id);
                    break;
                case 4:
                    List<Book> bookList = new List<Book>();
                    bookList = b.GetAllBooks();
                    foreach (var item in bookList)
                    {
                        Console.WriteLine(item.book_no + " " + item.book_name + " " + item.author + " " + item.cost);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
