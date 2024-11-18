using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManager.Domain;
using Microsoft.Build.Framework;
using CarRentalManager.Configurations.Entities;

namespace CarRentalManager.Data
{
    public class CarRentalManagerContext : DbContext
    {
        public CarRentalManagerContext (DbContextOptions<CarRentalManagerContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManager.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManager.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManager.Domain.Colours> Colours { get; set; } = default!;
        public DbSet<CarRentalManager.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManager.Domain.Bookings> Bookings { get; set; } = default!;
        public DbSet<CarRentalManager.Domain.Customer> Customer { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
