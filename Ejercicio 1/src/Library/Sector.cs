
using System.Collections.Generic;
namespace Library
{
    public class Sector
    {
        public string LibrarySector { get ; } // Sector
        public List<Shelve> Shelves { get; } // Lista de estanterías
    

        public Sector(string LibrarySector) // Constructor del objeto Sector que tendrá el número del sector y una lista de estanterías asignada.
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