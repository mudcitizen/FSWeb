using FSWeb.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSWeb.Data.DAL
{
    public class FSContext : DbContext
    {
        /*
         * https://garywoodfine.com/how-to-seed-your-ef-core-database/
         */
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Find> Finds { get; set; }

        public FSContext(DbContextOptions<FSContext> options) : base(options) { }

    }
}
