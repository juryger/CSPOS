using CSPOS.Domain.Delegates;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSPOS.Domain.Models
{
    public class DmOrder
    {
        public static LoadOrderForm LoadOrderFormDelegate;

        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int OrderStatusID { get; set; }
        public bool Deleted { get; set; }

        public object Summary { get { return this.ToString(); } }

        public IEnumerable<DmOrderItem> navOrderItems { get; set; }

        public override string ToString()
        {
            return string.Format("#{0}, {1}, {2}", OrderID, CustomerName, CreatedDate.ToShortDateString());
        }

        public DialogResult EditDetails(IList<DmOrderStatus> pOrderStatuses)
        {
            return LoadOrderFormDelegate == null ?
                DialogResult.Cancel :
                LoadOrderFormDelegate.Invoke(this, pOrderStatuses);
        }

        public DmOrder MakeCopy()
        {
            return new DmOrder()
            {
                OrderID = this.OrderID,
                CustomerName = this.CustomerName,
                CreatedDate = this.CreatedDate,
                OrderStatusID = this.OrderStatusID,
                Deleted = this.Deleted,
                navOrderItems = this.navOrderItems
            };
        }

        public void SyncState(DmOrder state)
        {
            this.OrderID = state.OrderID;
            this.CustomerName = state.CustomerName;
            this.CreatedDate = state.CreatedDate;
            this.OrderStatusID = state.OrderStatusID;
            this.Deleted = state.Deleted;
        }
    }
}
