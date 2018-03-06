using FSWeb.Models;
using FSWeb.Models.ViewModels;
using FSWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FSWeb.Controllers
{
    public class ItemController : Controller
    {
        IRepository repo;

        public ItemController(IRepository repository)
        {
            repo = repository;
        }

        public IActionResult Display(int id)
        {
            ItemUI item = repo.GetItem(id);
            CategoryUI category = repo.GetCategory(item.CategoryId);

            ItemVM vm = new ItemVM() { Item = item, Category = category };
            return View(vm);
        }
    }
}