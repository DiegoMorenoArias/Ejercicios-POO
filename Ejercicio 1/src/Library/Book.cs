using System;

namespace Library
{
    public class Book
    {

        public string Title { get ; } // Título del libro
        public string Author { get ; } // Título del autor
        public string Code { get ;  } // Código del libro
        public Book(String title, String author, String code) // Constructor del libro con sus informaciones respectivas
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}
