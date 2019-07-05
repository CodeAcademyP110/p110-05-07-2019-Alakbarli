using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Language
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should not be longer than 50 characters."), Required]
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
