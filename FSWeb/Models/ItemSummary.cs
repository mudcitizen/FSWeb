using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSWeb.Models
{
    public class ItemSummary
    {
        public String CategoryName { get; }
        public int CategoryId { get; }
        public String ItemName { get; }
        public int ItemId { get; }
        public int FindCount { get; }
        public DateTime LastFind { get; }

        public ItemSummary(String catName, int catId, String itemName, int itemId, int findCount, DateTime lastFind)
        {
            CategoryName = catName;
            CategoryId = catId;
            ItemName = itemName;
            ItemId = itemId;
            FindCount = findCount;
            LastFind = lastFind;
        }
        public override string ToString()
        {
            return String.Format("CategoryName - {0} ; CategoryId - {1} ; ItemName - {2} ; ItemId - {3} ; FindCount - {4} ; LastFind - {5} ", CategoryName, CategoryId, ItemName, ItemId, FindCount, LastFind);

        }
    }
}
