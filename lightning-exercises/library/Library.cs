using System;
using System.Collections.Generic;

namespace Library
{
    public class Library
    {
        public Library(List<Book> initialInventory, string name, string address)
        {
            _bookList = initialInventory;
            Name = name;
            Address = address;
        }
        public string Address { get; set; }
        public string Name { get; set; }
        // REMEMBER TO ADD THE '_' TO PRIVATE FIELDS
        private List<Book> _bookList = new List<Book>();

        /*  
            since we're not returning anything, use 'void'
        */
        public void AddToLibrary(Book book)
        {
            _bookList.Add(book);
        }

        public void Checkout(string isbn, CardHolder cardHolder)
        {
            foreach (Book book in _bookList)
            {
                if(book.ISBN == isbn && book.IsAvailable)
                {
                    cardHolder.CheckoutBook(book);
                    book.IsAvailable = false;
                }
            }

        }

        public bool IsAvailable(string isbn)
        {
            foreach (Book book in _bookList)
            {
                if(book.ISBN == isbn)
                {
                    return book.IsAvailable;
                }
            }
            return false;
        }

    }
}