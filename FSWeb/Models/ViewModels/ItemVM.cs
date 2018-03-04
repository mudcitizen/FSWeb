using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSWeb.Models.ViewModels
{
    public class ItemVM
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Notes { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return String.Format("Id - {0} ; Name - {1} ; Notes - {2} ; CategoryId - {3}", Id, Name, Notes, CategoryId);
        }
    }
}
