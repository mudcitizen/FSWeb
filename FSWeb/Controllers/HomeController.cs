using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FSWeb.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository;

        public HomeController(IRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.ItemSummaries);
        }
    }
}