using System;
using System.Collections.Generic;
using System.Text;

namespace FSWeb.Data.Models
{
    public class Find : INamedModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public DateTime Date { get; set; }
        public Decimal Latitude { get; set; }
        public Decimal Longitude { get; set; }

    }
}
