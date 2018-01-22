using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Data.DAL;
using FSWeb.Data.Models;

namespace FSWeb.Repository
{
    public class SqlRepository : IRepository
    {
        FSContext dbContext;

        public SqlRepository(FSContext context)
        {
            dbContext = context;
        }
        public IQueryable<ItemSummary> ItemSummaries => dbContext.ItemSummaries;
    }
}
