using FSWeb.Data.Models;
using FSWeb.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSWeb.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public IEnumerable<ItemSummaryVM> ItemSummaries { get; set; }
        public String CurrentCategory { get; set; }

    }
}
