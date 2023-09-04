using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDCollection
{
    public class DVDLibrary
    {
        public static int libraryCountSeed = 1;

        public string Name { get; }
        public int LibrarySize { get; }

        public DVDLibrary(string name)
        {
            Name = name;
        }

        public void LibraryAddition(string title, string rating, int length, DateTime date, DateTime watchedDate)
        {
            var addition = new LibraryChange(title, rating, length, date, watchedDate);
            allChanges.Add(addition);
        }

        private List<LibraryChange> allChanges = new List<LibraryChange>();

        public string GetChangesHistory()
        {
            var report = new System.Text.StringBuilder();

            report.AppendLine($"Title{-10} Rating{-5} Length{5:N0} Date Added\tLast Watched");
            foreach (var change in allChanges)
            {
                report.AppendLine($"{change.Title}\t\t{change.Rating}\t{change.Length}\t{change.Date.ToShortDateString()}");
            }

            return report.ToString();
        }
    }
}
