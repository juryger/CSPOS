using CSPOS.Domain.Delegates;
using CSPOS.Domain.Models;
using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set up delegate responsible for showing forms
            DmNewCatalogItem.LoadCatalogItemFormDelegate = new LoadCatalogItemForm(NewCatalogItemForm.Instance.Run);
            DmUsedCatalogItem.LoadCatalogItemFormDelegate = new LoadCatalogItemForm(UsedCatalogItemForm.Instance.Run);

            Application.Run(new ManagementForm());
        }
    }
}
