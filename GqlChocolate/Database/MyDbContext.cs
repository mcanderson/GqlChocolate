using GqlChocolate.Entities;
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

    }
}
