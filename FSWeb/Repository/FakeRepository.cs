using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Data.Models;
using FSWeb.Models.ViewModels;

namespace FSWeb.Repository
{
    public class FakeRepository : IRepository
    {
        IList<ItemSummaryVM> itemSummaries;

        public FakeRepository() {
            const String catName = "Mushroom";
            const int catId = 1;
            itemSummaries = new List<ItemSummaryVM>
            {
                new ItemSummaryVM(catName,catId,"Chartrelle",1,10,DateTime.Now.AddMonths(-1)),
                new ItemSummaryVM(catName,catId,"Black Trumpet",2,20,DateTime.Now.AddMonths(-2)),
            };
        }

        public IQueryable<ItemSummaryVM> ItemSummaries => itemSummaries.AsQueryable<ItemSummaryVM>();
    }
}
