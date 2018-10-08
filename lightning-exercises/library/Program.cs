using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a few (4 or so) instances of books and use the method on your Library class to add them to the list of books in an instance of Library
            */

            Book EndersGame = new Book(){
                Name = "Ender's Game",
                Author = "Orson Scott Card",
                ISBN = "ft37h890j"
            };

            Book AnimalFarm = new Book(){
                Name = "Animal Farm",
                Author = "George Orwell",
                ISBN = "giy5uno3p"
            };

            Book GreatGatsby = new Book(){
                Name = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "htu3oine"
            };

            Book Twilight = new Book(){
                Name = "Twilight",
                Author = "Stephenie Meyer",
                ISBN = "g678bi2d"
            };

            Book book1 = new Book(){
                Name = "Book 1",
                Author = "Author 1",
                ISBN = "ehfh78394"
            };

            Book book2 = new Book(){
                Name = "Book 2",
                Author = "Author 2",
                ISBN = "sdnbfayqu89"
            };
            

            List<Book> newBooks = new List<Book>(){
                book1, book2
            };

            Library NSSLibrary = new Library(newBooks, "We the best Library", "Everywhere");

            NSSLibrary.AddToLibrary(EndersGame);
            NSSLibrary.AddToLibrary(AnimalFarm);
            NSSLibrary.AddToLibrary(GreatGatsby);
            NSSLibrary.AddToLibrary(Twilight);

        }
    }
}
