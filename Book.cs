using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleAplicationASP.Net
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public Publisher Publisher { get; set; }

        public Book() { }
        public Book(Author __author, string __title, int __year, Publisher __publisher)
        {
            Author = __author;
            Title = __title;
            Year = __year;
            Publisher = __publisher;
        }
    }
}
