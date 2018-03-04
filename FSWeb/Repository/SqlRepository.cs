using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FSWeb.Data.DAL;
using FSWeb.Data.Models;
using FSWeb.Models.ViewModels;

namespace FSWeb.Repository
{
    public class SqlRepository : IRepository
    {
        FSContext dbContext;
        IMapper mapper;

        SqlEntityRepository<Item> ItemRepository => new SqlEntityRepository<Item>(dbContext);

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

        public ItemVM GetItem(int id)
        {
            return mapper.Map<ItemVM>(ItemRepository.Get(id));
        }

        public IEnumerable<ItemVM> GetAllItems()
        {
            return ItemRepository.GetAll().AsQueryable().ProjectTo<ItemVM>();
        }

        public void InsertItem(ItemVM entity)
        {
            ItemRepository.Insert(mapper.Map<Item>(entity));
        }

        public void UpdateItem(ItemVM entity)
        {
            ItemRepository.Update(mapper.Map<Item>(entity));
        }

        public void DeleteItem(ItemVM entity)
        {
            ItemRepository.Delete(mapper.Map<Item>(entity));
        }
    }
}
