using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato2
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //Constructor statement. Enables arguments to be sent when creating new object
        public Book(string aTitle, string aAuthor, int aPages)
        {
            //Any code here will be run whenever a new object is created
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Pages: {pages}");
            Console.WriteLine();
        }
    }
}
