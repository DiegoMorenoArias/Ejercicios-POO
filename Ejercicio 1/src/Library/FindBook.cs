
using System;
using System.Collections.Generic;

namespace Library

{
    public class FindBook
    {
        public static bool Flag =false;
        public static void EncontrarLibros (Management everything, Book book)
        {
            foreach (Sector element in everything.Sectors)
            {
                foreach (Shelve shelve in element.Shelves)
                {
                    foreach (Book libro in shelve.Books)
                    {
                        if (libro.Code==book.Code)
                        {
                            Console.WriteLine($"El libro {book.Title} fue encontrado en el sector {element.LibrarySector}, estantería {shelve.LibraryShelve}.");
                            Flag=true;
                        }
                    }
                }
            }
            if (!Flag)
            {
                Console.WriteLine($"El libro '{book.Title}' no se encontró en el administrador de sectores.");
            }
        }



        

    }
}