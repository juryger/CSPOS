using CSPOS.Domain.DTO;
using CSPOS.Domain.Enums;
using CSPOS.Domain.Models;
using InventoryManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ManagementForm : Form
    {
        private List<DmCatalogItem> _dataSource;
        private DmCatalogItem _selectedItem;
        private TinyObjectMapperHelper _objMapper;

        public ManagementForm()
        {
            InitializeComponent();

            _objMapper = TinyObjectMapperHelper.Instance;
        }

        private void btnOrderFilter_Click(object sender, EventArgs e)
        {
            var of = new OrderForm();
            of.Show();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            lbxCatalog.DataSource = null;

            LoadCatalog();
        }

        private void LoadCatalog()
        {
            ServiceClient.GetCatalogAsync()
                .ContinueWith(t =>
                {
                    try
                    {
                        lbxCatalog.Invoke(new Action<List<DtoCatalogItem>>(BindCatalogListBox), t.Result);
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action<string>(NotifyError),
                            ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                    }
                });
        }

        private void BindCatalogListBox(List<DtoCatalogItem> dataSource)
        {
            _dataSource = dataSource.Select(s => DoObjectMapping(s)).ToList();

            lbxCatalog.DataSource = _dataSource;
            lbxCatalog.DisplayMember = nameof(DtoCatalogItem.Name);
        }

        private DmCatalogItem DoObjectMapping(DtoCatalogItem dto)
        {
            if (dto.ItemType == CSPOS.Domain.Enums.CatalogItemTypes.NewCatalogItem)
                return _objMapper.Map<DmNewCatalogItem>(dto);

            return _objMapper.Map<DmUsedCatalogItem>(dto);
        }

        private void NotifyError(string message)
        {
            MessageBox.Show(message);
        }

        private void lbxCatalog_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedItem = lbxCatalog.SelectedItem as DmCatalogItem;

            tsbEdit.Enabled = _selectedItem != null;
            tsbDelete.Enabled = _selectedItem != null;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            var inputBox = new InputBox("Enter N for New catalog item, U for Used catalog item");
            if (inputBox.ShowDialog() != DialogResult.OK)
            {
                inputBox.Close();
                return;
            }

            DmCatalogItem catalogItem = null;
            var reply = Convert.ToChar(inputBox.getAnswer());
            switch (char.ToUpper(reply))
            {
                case 'N':
                    catalogItem = DmNewCatalogItem.InitializeNew();
                    DmNewCatalogItem.LoadCatalogItemFormDelegate(catalogItem);
                    break;
                case 'U':
                    catalogItem = DmUsedCatalogItem.InitializeNew();
                    DmUsedCatalogItem.LoadCatalogItemFormDelegate(catalogItem);
                    break;
                default:
                    return;
            }

            ServiceClient.AddNewCatalogItemAsync(catalogItem)
                .ContinueWith(t =>
                {
                    try
                    {
                        this.Invoke(new Action<HttpResponseMessage, DmCatalogItem>(AddNewCatalogItem), t.Result, catalogItem);
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action<string>(NotifyError),
                            ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                    }
                });
        }

        private void AddNewCatalogItem(HttpResponseMessage msg, DmCatalogItem catalogItem)
        {
            // TODO: analyse response

            _dataSource.Add(catalogItem);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
                return;

            if (_selectedItem.ItemType == CatalogItemTypes.NewCatalogItem.ConvertToInt())
                DmNewCatalogItem.LoadCatalogItemFormDelegate(_selectedItem);
            else if (_selectedItem.ItemType == CatalogItemTypes.UsedCatalogItem.ConvertToInt())
                DmUsedCatalogItem.LoadCatalogItemFormDelegate(_selectedItem);

            ServiceClient.UpdateCatalogItemAsync(_selectedItem)
                .ContinueWith(t =>
                {
                    try
                    {
                        this.Invoke(new Action<HttpResponseMessage, DmCatalogItem>(EditNewCatalogItem), t.Result, _selectedItem);
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action<string>(NotifyError),
                            ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                    }
                });
        }

        private void EditNewCatalogItem(HttpResponseMessage msg, DmCatalogItem catalogItem)
        {
            // TODO: analyse response
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
                return;

            if (MessageBox.Show("Are you sure?", "Deleting item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            ServiceClient.DeleteCatalogItemAsync(_selectedItem.CatalogItemID)
                .ContinueWith(t =>
                {
                    try
                    {
                        this.Invoke(new Action<HttpResponseMessage, DmCatalogItem>(DeleteNewCatalogItem), t.Result, _selectedItem);
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action<string>(NotifyError),
                            ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                    }
                });
        }

        private void DeleteNewCatalogItem(HttpResponseMessage msg, DmCatalogItem catalogItem)
        {
            // TODO: analyse response

            _dataSource.Remove(catalogItem);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            LoadCatalog();
        }
    }
}
