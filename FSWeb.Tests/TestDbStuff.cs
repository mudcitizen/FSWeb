using FSWeb.Data.DAL;
using System.Diagnostics;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;


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

        [TestMethod]
        public void TestReadConfig()
        {

            const string appSettings = "appsettings.json";
            string relativePath = "../../FSWeb";
            string curDir = Directory.GetCurrentDirectory();
            string absolutePath = Path.GetFullPath(relativePath);
            string settingsFileName = Path.Combine(absolutePath, appSettings);

            if (File.Exists(settingsFileName))
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(absolutePath)
                .AddJsonFile(appSettings)
                .Build();
                string connStr = config["ConnectionStrings:DefaultConnection"];
                Debug.WriteLine(connStr);
            }
            else
            {
                Debug.WriteLine(settingsFileName + " does not exist");
            }


        }
    }
}
