using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public String Display(int id)
        {
            ItemVM item = repo.GetItem(id);
            return String.Format("ItemContoller.Display - {0}", item.ToString());
        }
    }
}