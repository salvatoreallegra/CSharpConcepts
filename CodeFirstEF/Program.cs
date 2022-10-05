using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using static System.Console;


namespace CodeFirstEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                Book book1 = new Book { Author = "Bill Perkins", Title="Flopping a Set"};
                Book book2 = new Book { Author = "Bart Ehrman", Title = "Lost Christianities" };
                db.Books.Add(book1);
                db.Books.Add(book2);
                db.SaveChanges();
                var query = from b in db.Books
                            orderby b.Title
                            select b;
                WriteLine("All books in the database:");
                foreach (var b in query)
                {
                    WriteLine($"{b.Title} by {b.Author}, code={b.Code}");
                }
                WriteLine("Press a key to exit...");
                ReadKey();
            }
        }
    }
}