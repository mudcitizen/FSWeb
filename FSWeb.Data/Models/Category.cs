using System;
using System.Collections.Generic;
using System.Text;

namespace FSWeb.Data.Models
{
    public class Category  : INamedModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
