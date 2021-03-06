﻿using GqlChocolate.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GqlChocolate.Database
{
    public class MyDbContext : DbContext
    {
        public static string DbConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotChocolate;Integrated Security=True;";

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }

        public DbSet<Locations> Location { get; set; }
        public DbSet<Categories> Category { get; set; }

        public DbSet<LocationCategoryXwalk> LocationCategoryXwalk { get; set; }
        public DbSet<Tags> Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<LocationCategoryXwalk>()
               .HasKey(p => new { p.LocationId, p.CategoryId });
        }

    }
}
