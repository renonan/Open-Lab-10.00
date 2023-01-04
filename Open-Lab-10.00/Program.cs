using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book LOTR= new Book();
            LOTR.Title="LOTR";
            LOTR.Pages = 432;
            LOTR.Category = "Fantasy";
            LOTR.Author = "J.R.R.Tolkien";
            LOTR.ReleaseDate=1954;
            Book LOTR2 = new Book();
            Book LOTR3 = new Book("LOTR",416);
            Book HOBBIT = new Book("Hobbit", 310, "Fantasy", "J.R.R.Tolkien",1937) ;
            LOTR.WriteInfo();
            LOTR2.WriteInfo();
            LOTR3.WriteInfo();
            HOBBIT.WriteInfo();
        }
    }
}
