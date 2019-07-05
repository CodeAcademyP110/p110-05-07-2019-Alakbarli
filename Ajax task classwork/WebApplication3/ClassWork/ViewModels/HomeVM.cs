using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Book> Books { get; set; }

        public IEnumerable<Author> Authors { get; set; }

        public IEnumerable<Language> Languages { get; set; }

    }
}
