using CSPOS.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmOrder : Form
    {
        private static readonly FrmOrder _instance = new FrmOrder();

        protected DmOrder _order;
        protected IList<DmOrderStatus> _dsStatuses;

        public static FrmOrder Instance
        {
            get
            {
                return _instance;
            }
        }

        private FrmOrder()
        {
            InitializeComponent();

            lbxOrderItems.DisplayMember = nameof(DmOrderItem.Summary);

            cbxStatus.DisplayMember = nameof(DmOrderStatus.Name);
            cbxStatus.ValueMember = nameof(DmOrderStatus.OrderStatusID);
        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            PushData();
            DialogResult = DialogResult.OK;
        }

        public DialogResult Run(DmOrder pOrder, IList<DmOrderStatus> pOrderStatuses)
        {
            _order = pOrder;
            _dsStatuses = pOrderStatuses;

            lbxOrderItems.DataSource = new BindingList<DmOrderItem>(pOrder.navOrderItems.ToList());

            cbxStatus.DataSource = new BindingList<DmOrderStatus>(_dsStatuses);

            UpdateForm();

            return ShowDialog();
        }

        protected virtual void UpdateForm()
        {
            tbxOrderId.Text = _order.OrderID.ToString();
            tbxCustomer.Text = _order.CustomerName;
            txbCreatedDate.Text = _order.CreatedDate.ToString();
            cbxStatus.SelectedValue = _order.OrderStatusID;
        }

        protected virtual void PushData()
        {
            _order.CustomerName = tbxCustomer.Text;
            _order.OrderStatusID = (cbxStatus.SelectedItem as DmOrderStatus).OrderStatusID;
        }
    }
}
