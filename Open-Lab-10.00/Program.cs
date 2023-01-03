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
            Book HOBIT = new Book("Hobbit", 310, "Fantasy", "J.R.R.Tolkien",1937) ;
            Console.WriteLine($"Title:{LOTR.Title} \n Pages:{LOTR.Pages}\n Category:{LOTR.Category}\n Author:{LOTR.Author}\n ReleaseDate:{LOTR.ReleaseDate}\n");
            Console.WriteLine($"Title:{LOTR2.Title} \n Pages:{LOTR2.Pages}\n Category:{LOTR2.Category}\n Author:{LOTR2.Author}\n ReleaseDate:{LOTR2.ReleaseDate}\n");
            Console.WriteLine($"Title:{LOTR3.Title} \n Pages:{LOTR3.Pages}\n Category:{LOTR3.Category}\n Author:{LOTR3.Author}\n ReleaseDate:{LOTR3.ReleaseDate}\n");
            Console.WriteLine($"Title:{HOBIT.Title} \n Pages:{HOBIT.Pages}\n Category:{HOBIT.Category}\n Author:{HOBIT.Author}\n ReleaseDate:{HOBIT.ReleaseDate}\n");
        }
    }
}
