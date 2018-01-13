using FSWeb.Data.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace FSWeb.Data.Tests
{
    [TestClass]
    public class FSContextTests
    {

        [TestInitialize]
        public void TestInitializer() {
            Debug.WriteLine("TestInitializer()");
        }
        [TestMethod]
        public void TestCreate()
        {
            var builder = new DbContextOptionsBuilder<FSContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FSWeb;Trusted_Connection=True;MultipleActiveResultSets=true");
            FSContext context = new FSContext(builder.Options);
            context.Database.EnsureCreated();
            Debug.WriteLine("End - " + DateTime.Now.ToShortTimeString());

        }
    }
}
