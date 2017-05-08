using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _3312Final.Models;
using Q400Calculator.Models;

namespace _3312Final.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Airplane> Airplane { get; set; }
        public DbSet<ClimbData> ClimbData { get; set; }
        public DbSet<Flap5Landing> Flap5Landing { get; set; }
        public DbSet<Flap10Landing> Flap10Landing { get; set; }
        public DbSet<Flaps15Landing> Flaps15Landing { get; set; }
        public DbSet<Flaps35Landing> Flaps35Landing { get; set; }
        public DbSet<Flaps5Takeoff> Flaps5Takeoff { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<ClimbData>().ToTable("ClimbData");
            builder.Entity<Flap5Landing>().ToTable("Flap5Landing");
            builder.Entity<Flap10Landing>().ToTable("Flap10Landing");
            builder.Entity<Flaps15Landing>().ToTable("Flaps15Landing");
            builder.Entity<Flaps35Landing>().ToTable("Flaps35Landing");
            builder.Entity<Flaps5Takeoff>().ToTable("Flaps5Takeoff");
        }

    }
}
