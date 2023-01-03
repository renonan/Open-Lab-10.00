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
        public string Title
        {
            get { return title; } 
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
            }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int ReleaseDate
        {
        
            get { return releaseDate; }
            set 
            {
                if (value <= 2021 && value >= 1450)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }
 
        }
        public Book()
        {
         title = "-1";
         pages = -1;
         category = "-1";
         author = "-1";
         releaseDate = -1;
        }
        public Book(string Title,int Pages)
        {
            title = Title;
            pages = Pages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string Title, int Pages,string Category,string Author,int ReleaseDate)
        {
            title = Title;
            pages = Pages;
            category = Category;
            author = Author;
            releaseDate = ReleaseDate;
        }
        public void WriteInfo()
        {
            Console.WriteLine($"Title:{title} \n Pages:{pages}\n Category:{category}\n Author:{author}\n ReleaseDate:{releaseDate}\n");
        }







    }
}
