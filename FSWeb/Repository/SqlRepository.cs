using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FSWeb.Data.DAL;
using FSWeb.Data.Models;
using FSWeb.Models;
using FSWeb.Models.ViewModels;

namespace FSWeb.Repository
{
    public class SqlRepository : IRepository
    {
        FSContext dbContext;
        IMapper mapper;

        SqlEntityRepository<Item> ItemRepository => new SqlEntityRepository<Item>(dbContext);
        SqlEntityRepository<Category> CategoryRepository => new SqlEntityRepository<Category>(dbContext);

        public SqlRepository(FSContext context,IMapper mapperParm)
        {
            dbContext = context;
            mapper = mapperParm;
        }
        public IQueryable<ItemSummaryVM> ItemSummaries
        {
            get
            {
                // Pretty sure the following is debugging code
                //ItemSummary itemSum = dbContext.ItemSummaries.First();
                //ItemSummaryVM isvm = mapper.Map<ItemSummaryVM>(itemSum);
                //String s = isvm.ToString();
                return dbContext.ItemSummaries.ProjectTo<ItemSummaryVM>().AsQueryable();
            }
        }

        #region Item 
        public ItemUI GetItem(int id)
        {
            return mapper.Map<ItemUI>(ItemRepository.Get(id));
        }

        public IEnumerable<ItemUI> GetAllItems()
        {
            return ItemRepository.GetAll().AsQueryable().ProjectTo<ItemUI> ();
        }

        public void InsertItem(ItemUI entity)
        {
            ItemRepository.Insert(mapper.Map<Item>(entity));
        }

        public void UpdateItem(ItemUI entity)
        {
            ItemRepository.Update(mapper.Map<Item>(entity));
        }

        public void DeleteItem(ItemUI entity)
        {
            ItemRepository.Delete(mapper.Map<Item>(entity));
        }
        #endregion

        #region Category
        public CategoryUI GetCategory(int id)
        {
            return mapper.Map<CategoryUI>(CategoryRepository.Get(id));
        }

        public IEnumerable<CategoryUI> GetAllCategories()
        {
            return CategoryRepository.GetAll().AsQueryable().ProjectTo<CategoryUI>();
        }

        public void InsertCategory(CategoryUI entity)
        {
            CategoryRepository.Insert(mapper.Map<Category>(entity));
        }
        public void UpdateCategory(CategoryUI entity)
        {
            CategoryRepository.Update(mapper.Map<Category>(entity));
        }
        public void DeleteCategory(CategoryUI entity)
        {
            CategoryRepository.Delete(mapper.Map<Category>(entity));
        }
        #endregion

    }
}
