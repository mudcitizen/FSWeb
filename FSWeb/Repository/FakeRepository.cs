using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Models;
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

        public IQueryable<ItemSummaryVM> ItemSummaries => throw new NotImplementedException();

        public void DeleteCategory(CategoryUI entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(ItemUI entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryUI> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemUI> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public CategoryUI GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public ItemUI GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertCategory(CategoryUI entity)
        {
            throw new NotImplementedException();
        }

        public void InsertItem(ItemUI entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(CategoryUI entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(ItemUI entity)
        {
            throw new NotImplementedException();
        }
    }
}
