
using System;
using System.Collections.Generic;

namespace Library

{
    public class FindBook
    {
        public static bool Flag =false;
        public static void EncontrarLibros (Management everything, Book book) // Función que permite encontrar un libro 
        {
            foreach (Sector element in everything.Sectors) // Para cada Lista de sectores en el objeto Management brindado
            {
                foreach (Shelve shelve in element.Shelves) // Para cada estantería en la lista de estanterías del sector recorrido
                {
                    foreach (Book libro in shelve.Books) // Para cada libro en la lista de libros de la estantería recorrida
                    {
                        if (libro.Code==book.Code) // Si los códigos de los libros coinciden entonces se encontró el libro y se imprime.
                        {
                            Console.WriteLine($"El libro {book.Title} fue encontrado en el sector {element.LibrarySector}, estantería {shelve.LibraryShelve}.");
                            Flag=true; // Flag se vuelve true.
                        }
                    }
                }
            }
            if (!Flag) // Si Flag no es true significa que el libro no fue encontrado y se imprime en pantalla un mensaje indicándolo.
            {
                Console.WriteLine($"El libro '{book.Title}' no se encontró en el administrador de sectores.");
            }
        }



        

    }
}