using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FSWeb.Controllers
{
    public class ItemController : Controller
    {
        public String Display(int id)
        {
            return String.Format("ItemContoller.Display({0}", id);
        }
    }
}