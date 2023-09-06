
using System.Collections.Generic;

namespace Library
{
    public class Shelve
    {
        public string LibraryShelve { get ; set; }
        public List<Book> Books {get; set;}
        public Shelve (string LibraryShelve)
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