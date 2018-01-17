using FSWeb.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
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

        public IEnumerable<ItemSummary> ItemSummaries
        {
            get
            {
                IEnumerable<FindSummary> findSummary = Finds.GroupBy(f => f.ItemId).Select(grouping => new FindSummary()
                { ItemId = grouping.Key, LastFind = grouping.Max(f => f.Date), FindCount = grouping.Count() }).ToList();

                var itemSummary = Items
                    .Join(Categories, item => item.CategoryId, cat => cat.Id, (item, cat) =>
                     new
                     {
                         ItemId = item.Id,
                         ItemName = item.Name,
                         CategoryName = cat.Name,
                         CategoryId = cat.Id
                     }
                     )
                     .Join(findSummary, item => item.ItemId, fs => fs.ItemId, (item, fs) => new ItemSummary(item.CategoryName, item.CategoryId, item.ItemName, item.ItemId, fs.FindCount, fs.LastFind));

                /*
                var itemSummary2 = Items
                       .Join(findSummary, item => item.Id, 
                             fs => fs.ItemId, 
                             (item, fs) => new ItemSummary(item.Category.Name, item.Category.Id, item.Name, item.Id, fs.FindCount, fs.LastFind));
                             */

                return itemSummary;
            }

        }

        public FSContext(DbContextOptions<FSContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable(Contants.TableNames.Categories);
            modelBuilder.Entity<Item>().ToTable(Contants.TableNames.Items);
            modelBuilder.Entity<Find>().ToTable(Contants.TableNames.Finds);
            base.OnModelCreating(modelBuilder);
        }

        class FindSummary
        {
            public int ItemId { get; set; }
            public int FindCount { get; set; }
            public DateTime LastFind { get; set; }
        }

    }
}
