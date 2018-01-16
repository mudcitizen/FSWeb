using System;
using System.Collections.Generic;
using System.Text;

namespace FSWeb.Data.Models
{
    public class BaseNamedModel : INamedModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Notes { get; set; }

        public override string ToString()
        {
            return String.Format("Id - {0} ; Name - {2} ; Notes - {3}", Id, Name, Notes);
        }
    }
}
