using FSWeb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSWeb.Repository
{
    public interface IRepository
    {
        IQueryable<ItemSummary> ItemSummaries { get; }
    }
}
