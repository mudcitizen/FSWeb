using FSWeb.Data.DAL;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSWeb.Tests
{
    [TestClass]
    public class TestDbStuff
    {
        [TestMethod]
        public void TestDesignTimeDbContextFactory() 
        {
            IDesignTimeDbContextFactory<FSContext> o = new DesignTimeDbContextFactory();
            FSContext context = o.CreateDbContext(null);
            context.Database.EnsureCreated();

        }
    }
}
