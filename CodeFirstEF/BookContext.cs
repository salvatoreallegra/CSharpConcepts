using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF
{
    public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Data Source=(LocalDB)\MSSQLLocalDB;Database=Books;Integrated Security=True");
        }
        public DbSet<Book> Books { get; set; }
    }
}
