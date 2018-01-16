using System;
using System.Collections.Generic;
using System.Text;

namespace FSWeb.Data.Models
{
    public class Item : BaseNamedModel
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return base.ToString() + String.Format(" ; CategoryId - {0}", CategoryId);
        }
    }
}
