using CSPOS.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CSPOS.Domain.DTO
{
    public class DtoOrder
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatues OrderStatusID { get; set; }
        public bool Deleted { get; set; }

        public IEnumerable<DtoOrderItem> navOrderItems { get; set; }
    }
}
