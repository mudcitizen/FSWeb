using FSWeb.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace FSWeb.Repository
{
    public interface IRepository 
    {
        IQueryable<ItemSummaryVM> ItemSummaries { get; }
        ItemVM GetItem(int id);

        IEnumerable<ItemVM> GetAllItems();

        void InsertItem(ItemVM entity);

        void UpdateItem(ItemVM entity);

        void DeleteItem(ItemVM entity);
    }
}
