using CSPOS.Domain.DTO;
using CSPOS.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utils
{
    internal sealed class ServiceClient
    {
        private static string _baseUrl;

        static ServiceClient()
        {
            _baseUrl = ConfigurationManager.AppSettings["srvUrl"] ?? "http://localhost:8080";
        }

        #region HttGet methods

        public async static Task<List<DtoCatalogItem>> GetCatalogAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/catalog";

                return JsonConvert.DeserializeObject<List<DtoCatalogItem>>(
                    await httpClient.GetStringAsync(uri));
            }
        }

        public async static Task<List<DtoCatalogCategory>> GetCatalogCategoriesAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/catalog/categories";

                return JsonConvert.DeserializeObject<List<DtoCatalogCategory>>(
                    await httpClient.GetStringAsync(uri));
            }
        }

        public async static Task<List<DtoCatalogMaker>> GetCatalogMakersAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/catalog/makers";

                return JsonConvert.DeserializeObject<List<DtoCatalogMaker>>(
                    await httpClient.GetStringAsync(uri));
            }
        }

        public async static Task<List<DtoCatalogCondition>> GetCatalogConditionsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/catalog/conditions";

                return JsonConvert.DeserializeObject<List<DtoCatalogCondition>>(
                    await httpClient.GetStringAsync(uri));
            }
        }

        public async static Task<List<DtoCatalogType>> GetCatalogTypesAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/catalog/types";

                return JsonConvert.DeserializeObject<List<DtoCatalogType>>(
                    await httpClient.GetStringAsync(uri));
            }
        }

        public async static Task<HttpResponseMessage> AddNewCatalogItemAsync(DmCatalogItem item)
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/catalog";
                var content = new StringContent(
                    JsonConvert.SerializeObject(item),
                    Encoding.UTF8,
                    "application/json");

                return await httpClient.PutAsync(uri, content);
            }
        }

        public async static Task<List<DtoOrder>> GetOrdersAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/orders";

                return JsonConvert.DeserializeObject<List<DtoOrder>>(
                    await httpClient.GetStringAsync(uri));
            }
        }

        public async static Task<List<DtoOrderStatus>> GetOrderStatusesAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/orders/statuses";

                return JsonConvert.DeserializeObject<List<DtoOrderStatus>>(
                    await httpClient.GetStringAsync(uri));
            }
        }

        #endregion

        public async static Task<HttpResponseMessage> UpdateCatalogItemAsync(DmCatalogItem item)
        {
            using (var httpClient = new HttpClient())
            {
                var uri = _baseUrl + "/api/catalog";
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
                var uri = _baseUrl + "/api/catalog/" + itemId.ToString();
                return await httpClient.DeleteAsync(uri);
            }
        }
    }
}
