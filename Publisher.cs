using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAplicationASP.Net
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Publisher() { }

        public Publisher(string __name)
        {
            Name = __name;
        }

    }
}
