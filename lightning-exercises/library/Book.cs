using System;

namespace Library
{
    public class Book
    {
        public Book()
        {
            IsAvailable = true;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

    }
}
