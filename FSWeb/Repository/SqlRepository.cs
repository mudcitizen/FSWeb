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

        public SqlRepository(FSContext context,IMapper mapperParm)
        {
            dbContext = context;
            mapper = mapperParm;
        }
        public IQueryable<ItemSummaryVM> ItemSummaries
        {
            get
            {
                ItemSummary itemSum = dbContext.ItemSummaries.First();
                ItemSummaryVM isvm = mapper.Map<ItemSummaryVM>(itemSum);
                String s = isvm.ToString();
                return dbContext.ItemSummaries.ProjectTo<ItemSummaryVM>().AsQueryable();
            }
        }
    }
}
