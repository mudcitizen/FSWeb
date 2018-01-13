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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable(Contants.TableNames.Categories);
            modelBuilder.Entity<Item>().ToTable(Contants.TableNames.Items);
            modelBuilder.Entity<Find>().ToTable(Contants.TableNames.Finds);
            base.OnModelCreating(modelBuilder);
        }

    }
}
