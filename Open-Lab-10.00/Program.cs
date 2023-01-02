using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book LOTR= new Book();
            LOTR.SetTitle("LOTR");
            LOTR.SetPages(1000);
            LOTR.SetCategory("Fantasy");
            LOTR.SetAuthor("J.R.R.Tolkien");
            LOTR.SetReleaseDate(1954);
            LOTR.WriteInfo();
        }
    }
}
