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
        int PageSize = 1;

        public HomeController(IRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(String category, int page = 1)
        {
            HomeIndexViewModel vm = new HomeIndexViewModel()
            {
                ItemSummaries = repository.ItemSummaries
                .Where(i => category == null || i.CategoryName == category)
                .OrderBy(i => i.CategoryName)
                .OrderBy(i => i.ItemName)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                CurrentCategory = category,

                PagingInfo = new PagingInfo()
                {
                    TotalItems = repository.ItemSummaries.Count(),
                    ItemsPerPage = PageSize,
                    CurrentPage = page
                }
            };
            return View(vm);
        }
    }
}
