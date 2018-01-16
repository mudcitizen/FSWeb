using System;
using System.Collections.Generic;
using System.Text;

namespace FSWeb.Data.Models
{
    public class Find : BaseNamedModel
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public DateTime Date { get; set; }
        public Decimal Latitude { get; set; }
        public Decimal Longitude { get; set; }

        public override string ToString()
        {
            return base.ToString() + String.Format(" ; ItemId - {0} ; Date - {1} ; Latitude - {2} ; Longitude - {3}", ItemId, Date, Latitude, Longitude);
        }
    }
}
