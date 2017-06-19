using CSPOS.Domain.DTO;
using CSPOS.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utils
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

        public async static Task<HttpResponseMessage> AddNewCatalogItemAsync(DmCatalogItem item)
        {
            using (var httpClient = new HttpClient())
            {
                var uri = "http://localhost:8080/api/catalog";
                var content = new StringContent(
                    JsonConvert.SerializeObject(item),
                    Encoding.UTF8,
                    "application/json");

                return await httpClient.PutAsync(uri, content);
            }
        }

        public async static Task<HttpResponseMessage> UpdateCatalogItemAsync(DmCatalogItem item)
        {
            using (var httpClient = new HttpClient())
            {
                var uri = "http://localhost:8080/api/catalog";
                var content = new StringContent(
                    JsonConvert.SerializeObject(item),
                    Encoding.UTF8,
                    "application/json");

                return await httpClient.PostAsync(uri, content);
            }
        }

        public async static Task<HttpResponseMessage> DeleteCatalogItemAsync(int itemId)
        {
            using (var httpClient = new HttpClient())
            {
                var uri = "http://localhost:8080/api/catalog/" + itemId.ToString();
                return await httpClient.DeleteAsync(uri);
            }
        }
    }
}
