using CSPOS.Domain.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSPOS.Domain.Delegates
{
    public delegate DialogResult LoadCatalogItemForm(DmCatalogItem pCatalogItem,
        IList<DmCatalogCategory> pCategories,
        IList<DmCatalogMaker> pMakers,
        IList<DmCatalogCondition> pConditions);
}
