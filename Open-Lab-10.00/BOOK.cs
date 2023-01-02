using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    public class Book
    {
        //Fields
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        //Methods
        public string SetTitle(string title)
        {
            this.title = title;
            return title; 
        }
        public int SetPages(int pages)
        {
            this.pages = pages;
            return pages;
        }
        public string SetCategory(string category)
        {
            this.category = category;
            return category;
        }
        public string SetAuthor(string author)
        {
            this.author = author;
            return author;
        }

        public int SetReleaseDate(int releaseDate)
        {
            this.releaseDate = releaseDate;
            return releaseDate;
        }
        public void WriteInfo() 
        {
            Console.WriteLine($"Title:{title} \n Pages:{pages}\n Category:{category}\n Author:{author}\n ReleaseDate:{releaseDate}\n"); 
        }






    }
}
