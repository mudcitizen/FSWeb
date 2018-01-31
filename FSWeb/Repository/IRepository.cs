using FSWeb.Models.ViewModels;
using System.Linq;

namespace FSWeb.Repository
{
    public interface IRepository
    {
        IQueryable<ItemSummaryVM> ItemSummaries { get; }
    }
}
