using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF
{
    public class Book
    {
       [Key] public int Code { get; set; } 
       public string Title {get; set; }
       public string Author { get; set; }

    }
}
