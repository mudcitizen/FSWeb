using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSWeb.Models.ViewModels
{
    public class ItemSummaryVM
    {
        public ItemSummaryVM() { }

        public ItemSummaryVM(String catName, int catId, String itemName, int itemId, int findCount, DateTime lastFind)
        {
            CategoryName = catName;
            CategoryId = catId;
            ItemName = itemName;
            ItemId = itemId;
            FindCount = findCount;
            LastFind = lastFind;
        }

        public String CategoryName { get; set; }
        public int CategoryId { get; set;  }
        public String ItemName { get; set;  }
        public int ItemId { get; set; }
        public int FindCount { get; set; }
        public DateTime LastFind { get; set;  }
        public override string ToString()
        {
            return String.Format("CategoryName - {0} ; CategoryId - {1} ; ItemName - {2} ; ItemId - {3} ; FindCount - {4} ; LastFind - {5} ", CategoryName, CategoryId, ItemName, ItemId, FindCount, LastFind);

        }
    }
}
