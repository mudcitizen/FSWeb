using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Models;

namespace FSWeb.Repository
{
    public class FakeRepository : IRepository
    {
        IList<ItemSummary> itemSummaries;

        public FakeRepository() {
            const String catName = "Mushroom";
            const int catId = 1;
            itemSummaries = new List<ItemSummary>
            {
                new ItemSummary(catName,catId,"Chartrelle",1,10,DateTime.Now.AddMonths(-1)),
                new ItemSummary(catName,catId,"Black Trumpet",2,20,DateTime.Now.AddMonths(-2)),
            };
        }

        public IQueryable<ItemSummary> ItemSummaries => itemSummaries.AsQueryable<ItemSummary>();
    }
}
