using System;
using System.Collections.Generic;
using System.Text;

namespace FSWeb.Data.Models
{
    public class Item : INamedModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int CategoryId { get; set; }
    }
}
