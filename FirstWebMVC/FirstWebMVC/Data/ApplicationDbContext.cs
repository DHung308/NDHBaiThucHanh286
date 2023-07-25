using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FirstWebMVC.Models.Person> Person { get; set; } = default!;

        public DbSet<FirstWebMVC.Models.Employee> Employee { get; set; } = default!;

        public DbSet<FirstWebMVC.Models.Animal> Animal { get; set; } = default!;

        public DbSet<FirstWebMVC.Models.Cat> Cat { get; set; } = default!;

        public DbSet<FirstWebMVC.Models.Dog> Dog { get; set; } = default!;
    }
}
