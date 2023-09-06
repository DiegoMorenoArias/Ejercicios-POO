
using System.Collections.Generic;
namespace Library
{
    public class Sector
    {
        public string LibrarySector { get ; }
        public List<Shelve> Shelves { get; }
    

        public Sector(string LibrarySector)
        {
            this.LibrarySector = LibrarySector;
            this.Shelves = new List<Shelve> ();
        }
        public void SectorBook (Shelve shelve)
        {
            this.Shelves.Add(shelve);
        }
    }
}