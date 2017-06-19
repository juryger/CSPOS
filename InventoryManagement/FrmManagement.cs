using CSPOS.Domain.DTO;
using CSPOS.Domain.Enums;
using CSPOS.Domain.Models;
using InventoryManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmManagement : Form
    {
        private List<DmCatalogItem> _dsCatalog;
        private List<DmCatalogCategory> _dsCatalogCategories;
        private List<DmCatalogMaker> _dsCatalogMakers;
        private List<DmCatalogCondition> _dsCatalogConditions;
        private List<DmOrder> _dsOrders;
        private List<DmOrderStatus> _dsOrderStatuses;

        private TinyObjectMapperHelper _objMapper;

        public FrmManagement()
        {
            InitializeComponent();

            _objMapper = TinyObjectMapperHelper.Instance;
        }

        private DmCatalogItem SelectedCatalogItem
        {
            get { return lbxCatalog.SelectedItem as DmCatalogItem; }
        }

        private DmOrder SelectedOrder
        {
            get { return lbxOrders.SelectedItem as DmOrder; }
        }

        private void btnOrderFilter_Click(object sender, EventArgs e)
        {
            var of = new FrmOrder();
            of.Show();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            LoadCatalog();
        }

        private void tcContent_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tcContent.SelectedIndex == 0)
            {
                LoadCatalog();
            }
            else if (tcContent.SelectedIndex == 1)
            {
                LoadOrders();
            }
        }

        private void LoadCatalog()
        {
            lbxCatalog.DataSource = null;
            cbxCategory.DataSource = null;
            cbxMaker.DataSource = null;
            cbxType.DataSource = null;

            try
            {
                ServiceClient.GetCatalogAsync()
                .ContinueWith(t =>
                {
                    lbxCatalog.Invoke(
                        new Action(() =>
                        {
                            _dsCatalog = t.Result.Select(s => DoCatalogObjectMapping(s)).ToList();

                            lbxCatalog.DataSource = _dsCatalog;
                            lbxCatalog.DisplayMember = nameof(DmCatalogItem.Summary);

                            tsStatus.Text = string.Format("Catalog items: {0}", _dsCatalog.Count);
                        }));
                })
                .ContinueWith(t =>
                {
                    ServiceClient.GetCatalogCategoriesAsync()
                        .ContinueWith(st =>
                        {
                            cbxCategory.Invoke(
                                new Action(() =>
                                {
                                    _dsCatalogCategories =
                                        st.Result.Select(s => _objMapper.Map<DmCatalogCategory>(s)).ToList();

                                    cbxCategory.DataSource = _dsCatalogCategories;
                                    cbxCategory.DisplayMember = nameof(DmCatalogCategory.Name);
                                }));

                        });
                })
                .ContinueWith(t =>
                {
                    ServiceClient.GetCatalogMakersAsync()
                        .ContinueWith(st =>
                        {
                            cbxMaker.Invoke(
                                new Action(() =>
                                {
                                    _dsCatalogMakers =
                                        st.Result.Select(s => _objMapper.Map<DmCatalogMaker>(s)).ToList();

                                    cbxMaker.DataSource = _dsCatalogMakers;
                                    cbxCategory.DisplayMember = nameof(DmCatalogMaker.Name);
                                }));

                        });
                })
                .ContinueWith(t =>
                {
                    ServiceClient.GetCatalogTypesAsync()
                        .ContinueWith(st =>
                        {
                            cbxType.Invoke(
                                new Action(() =>
                                {
                                    cbxType.DataSource =
                                        st.Result.Select(s => _objMapper.Map<DmCatalogType>(s)).ToList();
                                    cbxCategory.DisplayMember = nameof(DmCatalogType.Name);
                                }));

                        });
                })
                .ContinueWith(t =>
                {
                    ServiceClient.GetCatalogConditionsAsync()
                        .ContinueWith(st =>
                        {
                            this.Invoke(
                                new Action(() =>
                                {
                                    _dsCatalogConditions =
                                        st.Result.Select(s => _objMapper.Map<DmCatalogCondition>(s)).ToList();
                                }));

                        });
                });
            }
            catch (Exception ex)
            {
                this.Invoke(new Action<string>(NotifyError),
                    string.Format("Error occured during loading catalog: {0}",
                        ex.InnerException != null ? ex.InnerException.Message : ex.Message));
            }
        }

        private DmCatalogItem DoCatalogObjectMapping(DtoCatalogItem dto)
        {
            if (dto.ItemType == CSPOS.Domain.Enums.CatalogItemTypes.NewCatalogItem)
                return _objMapper.Map<DmNewCatalogItem>(dto);

            return _objMapper.Map<DmUsedCatalogItem>(dto);
        }

        private void LoadOrders()
        {
            lbxOrders.DataSource = null;
            cbxOrderStatus.DataSource = null;
            cbxOrderCustomer.DataSource = null;

            try
            {
                ServiceClient.GetOrdersAsync()
                    .ContinueWith(t =>
                    {
                        lbxCatalog.Invoke(
                            new Action(() =>
                            {
                                _dsOrders = t.Result.Select(s => _objMapper.Map<DmOrder>(s)).ToList();

                                lbxOrders.DataSource = _dsOrders;
                                lbxOrders.DisplayMember = nameof(DmOrder.Summary);

                                cbxOrderCustomer.DataSource = _dsOrders.Select(x => x.CustomerName);

                                tsStatus.Text = string.Format("Total orders sum: {0}", _dsOrders.SelectMany(o => o.navOrderItems).Sum(x => x.Price));

                            }));
                    })
                    .ContinueWith(t =>
                    {
                        ServiceClient.GetOrderStatusesAsync()
                            .ContinueWith(st =>
                            {
                                cbxOrderStatus.Invoke(
                                    new Action(() =>
                                    {
                                        _dsOrderStatuses =
                                            st.Result.Select(s => _objMapper.Map<DmOrderStatus>(s)).ToList();

                                        cbxOrderStatus.DataSource = _dsOrderStatuses;
                                        cbxOrderStatus.DisplayMember = nameof(DmOrderStatus.Name);
                                    }));
                            });
                    });
            }
            catch (Exception ex)
            {
                this.Invoke(new Action<string>(NotifyError),
                    string.Format("Error occured during loading orders: {0}",
                        ex.InnerException != null ? ex.InnerException.Message : ex.Message));
            }
        }

        private void NotifyError(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lbxCatalog_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            if (tcContent.SelectedIndex == 0)
                LoadCatalog();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (tcContent.SelectedIndex == 0)
            {
                var inputBox = new FrmSparePartTypeSelection();
                if (inputBox.ShowDialog() != DialogResult.OK)
                {
                    inputBox.Close();
                    return;
                }

                DmCatalogItem catalogItem = null;
                var reply = inputBox.GetAnswer();
                switch (reply)
                {
                    case CatalogItemTypes.NewCatalogItem:
                        catalogItem = DmNewCatalogItem.InitializeNew();
                        break;
                    case CatalogItemTypes.UsedCatalogItem:
                        catalogItem = DmUsedCatalogItem.InitializeNew();
                        break;
                    default:
                        return;
                }

                if (catalogItem == null ||
                    DialogResult.Cancel == catalogItem.EditDetails(_dsCatalogCategories, _dsCatalogMakers, _dsCatalogConditions))
                {
                    return;
                }

                ServiceClient.AddNewCatalogItemAsync(catalogItem)
                    .ContinueWith(t =>
                    {
                        try
                        {
                            this.Invoke(new Action(() =>
                            {
                                // TODO: analyse response t.Result

                                _dsCatalog.Add(catalogItem);
                            }));
                        }
                        catch (Exception ex)
                        {
                            this.Invoke(new Action<string>(NotifyError),
                                ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                        }
                    });
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (tcContent.SelectedIndex == 0)
            {
                var catalogItem = SelectedCatalogItem;
                if (catalogItem == null)
                    return;

                var editCatalogItem = catalogItem.MakeCopy();

                if (DialogResult.Cancel == editCatalogItem.EditDetails(_dsCatalogCategories, _dsCatalogMakers, _dsCatalogConditions))
                    return;

                ServiceClient.UpdateCatalogItemAsync(editCatalogItem)
                    .ContinueWith(t =>
                    {
                        try
                        {
                            this.Invoke(new Action(() =>
                            {
                                // TODO: analyse response t.Result

                                catalogItem.SyncState(editCatalogItem);
                            }));
                        }
                        catch (Exception ex)
                        {
                            this.Invoke(new Action<string>(NotifyError),
                                ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                        }
                    });
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (tcContent.SelectedIndex == 0)
            {
                var catalogItem = SelectedCatalogItem;
                if (catalogItem == null)
                    return;

                if (MessageBox.Show("Are you sure?", "Deleting item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                ServiceClient.DeleteCatalogItemAsync(catalogItem.CatalogItemID)
                    .ContinueWith(t =>
                    {
                        try
                        {
                            this.Invoke(new Action(() =>
                            {
                                // TODO: analyse response t.Result

                                _dsCatalog.Remove(catalogItem);
                            }));
                        }
                        catch (Exception ex)
                        {
                            this.Invoke(new Action<string>(NotifyError),
                                ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                        }
                    });
            }
        }

        private void lbxOrders_SelectedValueChanged(object sender, EventArgs e)
        {
        }
    }
}
