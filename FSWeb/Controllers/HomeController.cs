using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Data.Models;
using FSWeb.Models.ViewModels;
using FSWeb.Repository;
using Microsoft.AspNetCore.Mvc;


namespace FSWeb.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository;
        int PageSize = 2;

        public HomeController(IRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(String category, int page = 1)
        {

            IEnumerable<ItemSummaryVM> isvms = repository.ItemSummaries.Where(itemSum => category == null || itemSum.CategoryName.Equals(category, StringComparison.CurrentCultureIgnoreCase));
            HomeIndexVM vm = new HomeIndexVM()

            {
                ItemSummaries = isvms.OrderBy(i => i.CategoryName)
                .OrderBy(i => i.ItemName)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                CurrentCategory = category,

                PagingInfo = new PagingInfo()
                {
                    
                    TotalItems = isvms.Count(),
                    ItemsPerPage = PageSize,
                    CurrentPage = page
                }
            };
            return View(vm);
        }
    }
}
