using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library
    {
       
        public List<Book> books { get; set; }
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
    }
}
