using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDCollection
{
    public class LibraryChange
    {
        public string Title { get; }
        public string Rating { get; }
        public int Length { get; }
        public DateTime Date { get; }
        public DateTime LastWatched { get; }

        public LibraryChange(string title, string rating, int length, DateTime date, DateTime watchedDate)
        {
            Title = title;
            Rating = rating;
            Length = length;
            Date = date;
            LastWatched = watchedDate;
        }
        //private static int libraryEntrySeed = 1;
        
        //public string Title { get;}
        //public string Genre { get;}
        //public int Rating { get; }
        //public int Length { get; }
        //public string Director { get; }
        //public int LibraryPosition { get; }

        //public DVD(string name, int rating)
        //{
        //    Title = name;
        //    Rating = rating;
        //    LibraryPosition = libraryEntrySeed;
        //    libraryEntrySeed++;
        //}

        ////private List<DVDCollection> allDVDs = new List<DVD>; 
    }
}
