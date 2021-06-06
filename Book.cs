using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SimpleAplicationASP.Net
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int bookId { get; set; }
        public string bookTitle { get; set; } 
        public string bookAuthor { get; set; }
        public int bookDateRelease { get; set; }
        public BookCoverType bookCover { get; set; }

        public Book() { }

        public Book (int __bookId, string __bookTitle, string __bookAuthor, int __bookDateRelease, BookCoverType __bookCover)
        {
            bookId = __bookId;
            bookTitle = __bookTitle;
            bookAuthor = __bookAuthor;
            bookDateRelease = __bookDateRelease;
            bookCover = __bookCover;
        }




    }
}
