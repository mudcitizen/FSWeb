using FSWeb.Data.DAL;
using FSWeb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FSWeb.Data.Tests
{
    [TestClass]
    public class FSContextTests
    {

        FSContext DbContext; 
        [TestInitialize]
        public void TestInitializer() {
            Debug.WriteLine("TestInitializer()");
            var builder = new DbContextOptionsBuilder<FSContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FSWeb;Trusted_Connection=True;MultipleActiveResultSets=true");
            DbContext = new FSContext(builder.Options);
            DbContext.Database.EnsureDeleted();
            DbContext.Database.EnsureCreated();

            DbInitializer.Initialize(DbContext);
        }
        [TestMethod]
        public void TestItemSummary()
        {
            Debug.WriteLine(String.Format("TestItemSummary() - Begin - {0}", DateTime.Now.ToLongTimeString()));
            foreach (ItemSummary itemSummary in DbContext.ItemSummaries)
                Debug.WriteLine(itemSummary.ToString());
            Debug.WriteLine(String.Format("TestItemSummary() - End   - {0}", DateTime.Now.ToLongTimeString()));

            Debug.WriteLine("End - " + DateTime.Now.ToShortTimeString());

        }
    }
}
