using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should not be longer than 50 characters."), Required]
        public string Name { get; set; }

        public DateTime PostedDate { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int PageCount { get; set; }

        public decimal Price { get; set; }

        public int AuthorId { get; set; }
        public int LanguageId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Language Language { get; set; }

    }
}
