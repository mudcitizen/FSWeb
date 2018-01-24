using System;
using System.IO;
using FSWeb.Data.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FSWeb.Data.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FSContext>
    {
        public FSContext CreateDbContext(string[] args)
        {

            /*
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();
              */

            var builder = new DbContextOptionsBuilder<FSContext>();

            //String connectionString = configuration.GetConnectionString("DefaultConnection");
            String connectionString = "(localdb)\\mssqllocaldb; Database = FSWebApp; Trusted_Connection = True; MultipleActiveResultSets = true"; 
            builder.UseSqlServer(connectionString, o => o.MigrationsAssembly("FSWeb"));

            return new FSContext(builder.Options);
        }
    }
}
