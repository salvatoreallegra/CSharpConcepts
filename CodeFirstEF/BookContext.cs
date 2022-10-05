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
            @"Data Source=LAPTOP-M3LHAD31;Initial Catalog=Books;encrypt=false;Integrated Security=True;Pooling=False");
        }
        public DbSet<Book> Books { get; set; }
    }
}
