using System;
using System.Collections.Generic;

namespace FSWeb.Models.ViewModels
{
    public class HomeIndexVM
    {
        public PagingInfo PagingInfo { get; set; }
        public IEnumerable<ItemSummaryVM> ItemSummaries { get; set; }
        public String CurrentCategory { get; set; }

    }
}
