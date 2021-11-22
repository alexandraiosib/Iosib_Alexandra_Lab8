using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iosib_Alexandra_Lab8.Models;

namespace Iosib_Alexandra_Lab8.Data
{
    public class Iosib_Alexandra_Lab8Context : DbContext
    {
        public Iosib_Alexandra_Lab8Context (DbContextOptions<Iosib_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Iosib_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Iosib_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Iosib_Alexandra_Lab8.Models.Category> Category { get; set; }
    }
}
