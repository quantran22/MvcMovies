using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1721050358.Models;

    public class DemoDBContext : DbContext
    {
        public DemoDBContext (DbContextOptions<DemoDBContext> options)
            : base(options)
        {
        }

        public DbSet<_1721050358.Models.Movie> Movie { get; set; }

        public DbSet<_1721050358.Models.Person> Person { get; set; }

        public DbSet<_1721050358.Models.Teacher> Teacher { get; set; }

        public DbSet<_1721050358.Models.Category> Category { get; set; }

        public DbSet<_1721050358.Models.Product> Product { get; set; }
    }
