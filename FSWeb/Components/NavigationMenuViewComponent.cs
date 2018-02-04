using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Repository;
using FSWeb.Infrastructure.Routing;

namespace FSWeb.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        IRepository repository;

        public NavigationMenuViewComponent(IRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values[RoutingConstants.Segment.Category.ToLower()];
            // ToDo - This should use Category - not ItemSummary
            return View(repository
                .ItemSummaries
                .Select(itemSummary => itemSummary.CategoryName)
                .Distinct()
                .OrderBy(catName => catName));
        }
    }
}
