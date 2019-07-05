using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public class LibraryDb : DbContext
    {
        private readonly LibraryDb dbContext;
        public LibraryDb(DbContextOptions<LibraryDb> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}
