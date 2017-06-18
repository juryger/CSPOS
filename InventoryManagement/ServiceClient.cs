using CSPOS.Domain.DTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class ServiceClient
    {
        public async static Task<List<DtoCatalogItem>> GetCatalogAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = "http://localhost:8080/api/catalog";

                return JsonConvert.DeserializeObject<List<DtoCatalogItem>>(
                    await httpClient.GetStringAsync(uri));
            }
        }
    }
}
