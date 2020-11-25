using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Potor_Raul_Lab8.Models;

namespace Potor_Raul_Lab8.Data
{
    public class Potor_Raul_Lab8Context : DbContext
    {
        public Potor_Raul_Lab8Context (DbContextOptions<Potor_Raul_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Potor_Raul_Lab8.Models.Book> Book { get; set; }

        public DbSet<Potor_Raul_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Potor_Raul_Lab8.Models.Category> Category { get; set; }
    }
}
