using CSPOS.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CSPOS.Domain.Models
{
    public class DmOrder
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatues OrderStatusID { get; set; }
        public bool Deleted { get; set; }

        public object Summary { get { return this.ToString(); } }

        public IEnumerable<DmOrderItem> navOrderItems { get; set; }

        public override string ToString()
        {
            return string.Format("#{0}, {1}, {2}", OrderID, CustomerName, CreatedDate.ToShortDateString());
        }
    }
}
