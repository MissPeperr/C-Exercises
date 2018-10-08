using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class CardHolder
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        private List<Book> _currentBooks = new List<Book>();

        public void CheckoutBook(Book book)
        {
            _currentBooks.Add(book);
        }

        public void CheckInBook(Book book)
        {
            _currentBooks.Remove(book);
        }

        // HOW I WOULD HAVE DONE THIS ORIGINALLY
        // public bool hasBook(string isbn)
        // {
        //     foreach(Book book in _currentBooks)
        //     {
        //         if(book.ISBN == isbn)
        //         {
        //             return true;
        //         }
        //     }
        //     return false;
        // }

        // USING A LINQ METHOD
        public bool hasBook(string isbn)
        {
            bool hasBook = _currentBooks.Any(book => book.ISBN == isbn);
            if(hasBook)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}