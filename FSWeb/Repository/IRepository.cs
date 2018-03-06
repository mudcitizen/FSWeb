using FSWeb.Models;
using System.Collections.Generic;
using System.Linq;
using FSWeb.Models.ViewModels;

namespace FSWeb.Repository
{
    public interface IRepository 
    {
        IQueryable<ItemSummaryVM> ItemSummaries { get; }
        ItemUI GetItem(int id);

        #region Item
        IEnumerable<ItemUI> GetAllItems();

        void InsertItem(ItemUI entity);

        void UpdateItem(ItemUI entity);

        void DeleteItem(ItemUI entity);
        #endregion

        #region Category
        CategoryUI GetCategory(int id);

        IEnumerable<CategoryUI> GetAllCategories();

        void InsertCategory(CategoryUI entity);

        void UpdateCategory(CategoryUI entity);

        void DeleteCategory(CategoryUI entity);
        #endregion
    }
}
