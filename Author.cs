using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace SimpleAplicationASP.Net
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author() { }

        public Author(string __firstName, string __lastName)
        {
            FirstName = __firstName;
            LastName = __lastName;
        }
    }
}