using System.Linq;
using System.Collections.Generic;
using FSWeb.Models;
using FSWeb.Models.ViewModels;
using FSWeb.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

            List<SelectListItem> categorySelector = new List<SelectListItem>();
            foreach (CategoryUI cat in repo.GetAllCategories().OrderBy(c => c.Name)) {
                categorySelector.Add(new SelectListItem() { Value = cat.Id.ToString(), Text = cat.Name });
            }
            ItemUI item = repo.GetItem(id);
            CategoryUI category = repo.GetCategory(item.CategoryId);
            ItemVM vm = new ItemVM() { Item = item, Category = category, CategorySelector = categorySelector };
            return View(vm);
        }
    }
}