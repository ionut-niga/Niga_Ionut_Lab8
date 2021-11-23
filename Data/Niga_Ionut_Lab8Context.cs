using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Niga_Ionut_Lab8.Models;

namespace Niga_Ionut_Lab8.Data
{
    public class Niga_Ionut_Lab8Context : DbContext
    {
        public Niga_Ionut_Lab8Context (DbContextOptions<Niga_Ionut_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Niga_Ionut_Lab8.Models.Book> Book { get; set; }

        public DbSet<Niga_Ionut_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Niga_Ionut_Lab8.Models.Category> Category { get; set; }
    }
}
