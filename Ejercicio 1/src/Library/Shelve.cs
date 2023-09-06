
using System.Collections.Generic;

namespace Library
{
    public class Shelve
    {
        public string LibraryShelve { get ; set; } // Estantería
        public List<Book> Books {get; set;} // Lista de libros
        public Shelve (string LibraryShelve) // Constructor del objeto Shelve el cual indicará el número de estantería que tendrá una lista de
        // libros asignada.
        {
            this.LibraryShelve = LibraryShelve;
            this.Books = new List<Book> ();
        }
        public void ShelveBook (Book book)
        {
            Books.Add(book);
        }
    }   
}