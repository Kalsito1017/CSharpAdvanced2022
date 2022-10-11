using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> book;

        public Library(params Book[] books)
        {
            this.book = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator() => new LibraryIterator(this.book);

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();


        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books.OrderBy(b => b.CompareTo(b)));
            }

            public bool MoveNext() => currentIndex++ < this.books.Count;
            public void Reset() => currentIndex = 0;
            public Book Current => this.books[currentIndex - 1];
            object IEnumerator.Current => Current;
            public void Dispose() { }
        }
    }
}