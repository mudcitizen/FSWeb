using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FSWeb.Models.ViewModels
{
    public class ItemVM
    {
        public ItemUI Item { get; set; }
        public CategoryUI Category { get; set; }
        public List<SelectListItem> CategorySelector { get; set; }
    }
}
