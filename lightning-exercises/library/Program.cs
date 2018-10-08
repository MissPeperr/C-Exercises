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
                ISBN = "ft37h890j",
                IsAvailable = true
            };

            Book AnimalFarm = new Book(){
                Name = "Animal Farm",
                Author = "George Orwell",
                ISBN = "giy5uno3p",
                IsAvailable = true
            };

            Book GreatGatsby = new Book(){
                Name = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "htu3oine",
                IsAvailable = true
            };

            Book Twilight = new Book(){
                Name = "Twilight",
                Author = "Stephenie Meyer",
                ISBN = "g678bi2d",
                IsAvailable = true
            };

            Book book1 = new Book(){
                Name = "Book 1",
                Author = "Author 1",
                ISBN = "ehfh78394",
                IsAvailable = true
            };

            Book book2 = new Book(){
                Name = "Book 2",
                Author = "Author 2",
                ISBN = "sdnbfayqu89",
                IsAvailable = true
            };

            CardHolder Madi = new CardHolder(){
                FullName = "Madison Peper",
                Id = 1
            };

            CardHolder Kayla = new CardHolder(){
                FullName = "Kayla Reid",
                Id = 2
            };

            List<CardHolder> allCardHolders = new List<CardHolder>(){
                Madi, Kayla
            };

            List<Book> newBooks = new List<Book>(){
                book1, book2, Twilight, AnimalFarm, GreatGatsby, EndersGame
            };

            Library NSSLibrary = new Library(newBooks, "We the best Library", "Everywhere");

            Console.WriteLine("///// Checkout a book /////");
            NSSLibrary.Checkout(Twilight.ISBN, Madi);

            if(NSSLibrary.IsAvailable(Twilight.ISBN))
            {
                Console.WriteLine($"{Twilight.Name} is currently available.");
            }
            else
            {
                Console.WriteLine($"{Twilight.Name} is currently unavailable.");
                foreach(CardHolder cardHolder in allCardHolders)
                {
                    if(cardHolder.hasBook(Twilight.ISBN))
                    {
                        Console.WriteLine($"{cardHolder.FullName} currently has {Twilight.Name}");
                    }
                }
            }

            Console.WriteLine("///// Check-in a book /////");
            NSSLibrary.CheckIn(Twilight.ISBN, Madi);

            if(NSSLibrary.IsAvailable(Twilight.ISBN))
            {
                Console.WriteLine($"{Twilight.Name} is currently available.");
            }
            else
            {
                Console.WriteLine($"{Twilight.Name} is currently unavailable.");
                foreach(CardHolder cardHolder in allCardHolders)
                {
                    if(cardHolder.hasBook(Twilight.ISBN))
                    {
                        Console.WriteLine($"{cardHolder.FullName} currently has {Twilight.Name}");
                    }
                }
            }

        }
    }
}
