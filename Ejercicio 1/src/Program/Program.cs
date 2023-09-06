using System;
using Library;
namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            Shelve shelf1 = new Shelve("7");
            Shelve shelf2 = new Shelve("3");

            Sector sector1 = new Sector("A");
            Sector sector2 = new Sector("B");

            shelf1.ShelveBook(book1);
            shelf2.ShelveBook(book2);

            sector1.SectorBook(shelf1);
            sector2.SectorBook(shelf2);

            Management admin = new Management ("Admin");
            admin.AddSector("1", sector1);
            admin.AddSector("2", sector2);
            FindBook.EncontrarLibros(admin, book1);
        }
    }
}