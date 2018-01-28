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
        public IActionResult Index(int pageNumber = 1)
        {
            HomeIndexViewModel vm = new HomeIndexViewModel();

            vm.ItemSummaries = repository.ItemSummaries
                .OrderBy(i => i.CategoryName)
                .OrderBy(i => i.ItemName)
                .Skip((pageNumber - 1) * PageSize)
                .Take(PageSize);

            vm.PagingInfo = new PagingInfo();
            vm.PagingInfo.TotalItems = repository.ItemSummaries.Count();
            vm.PagingInfo.ItemsPerPage = PageSize;
            vm.PagingInfo.CurrentPage = pageNumber;

            return View(vm);
        }
    }
}