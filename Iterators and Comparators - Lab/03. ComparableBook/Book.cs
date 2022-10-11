using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private IReadOnlyList<string> author;

        public string Title { get => title; set => title = value; }

        public int Year { get => year; set => year = value; }

        public IReadOnlyList<string> Author { get => author; set => author = value; }

        public Book(string title, int year, params string[] author)
        {
            Title = title;
            Year = year;
            Author = author;
        }

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);

            if (result == 0)
            {
                return this.Title.CompareTo(other.Title);
            }

             return result;
        }

        public override string ToString()
        {
            return $"{this.title} - {this.year}";
        }
    }
}