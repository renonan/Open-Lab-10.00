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
            LOTR.Pages = 1000;
            LOTR.Category = "Fantasy";
            LOTR.Author = "J.R.R.Tolkien";
            LOTR.ReleaseDate=1954;
            Console.WriteLine($"Title:{LOTR.Title} \n Pages:{LOTR.Pages}\n Category:{LOTR.Category}\n Author:{LOTR.Author}\n ReleaseDate:{LOTR.ReleaseDate}\n");
        }
    }
}
