using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using DAL;

namespace BusinessLogicLayer
{
    public class BookOpt
    {
        public void insertBook(Book bk)
        {
            ShoppingEntities context = new ShoppingEntities();
            Book bk1 = new Book();
            bk1.book_no = bk.book_no;
            bk1.book_name = bk.book_name;
            bk1.author = bk.author;
            bk1.cost = bk.cost;
            bk1.category = bk.category;
            context.Books.Add(bk1);
            context.SaveChanges();
        }
        public void UpdateBook(Book b)
        {
            ShoppingEntities context = new ShoppingEntities();
            // context.s(b.Book_No, b.Book_Name, b.Author, b.Cost, b.Category);
            context.sp_UpdateBook(b.book_no, b.book_name, b.author, b.cost, b.category);
        }
        public int Count()
        {
            ShoppingEntities context = new ShoppingEntities();
            // _db = new DbEntities();
            int id = context.sp_BookCountFinal();
            return id;
        }
        public List<Book> GetAllBooks()
        {
            ShoppingEntities context = new ShoppingEntities();
            var ans = context.GetAllBook();
            List<Book> book = new List<Book>();
            foreach (var item in ans)
            {
                book.Add(new Book { book_no = item.Book_No, book_name = item.Book_Name, author = item.Author, cost = item.Cost, category = item.Category });
            }
            return book;

        }
    }
}
