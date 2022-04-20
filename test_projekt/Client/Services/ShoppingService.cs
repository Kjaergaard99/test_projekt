using System.Net.Http.Json;
using blazor_modul_13_14.Shared.Models;

namespace blazor_modul_13_14.Client.Services
{
    public class ShoppingService : IShoppingService
    {

        private readonly HttpClient httpClient;

        public ShoppingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<ShoppingItem[]?> GetAllItems()
        {
            var result = httpClient.GetFromJsonAsync<ShoppingItem[]>("api/shopapi");
            return result;
        }

        public async Task<int> AddItem(ShoppingItem item)
        {
            var response = await httpClient.PostAsJsonAsync("api/shopapi", item);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<ShoppingItem> GetItem(int id)
        {
            var result = await httpClient.GetFromJsonAsync<ShoppingItem>("api/shopapi/" + id);
            return result;
        }

        public async Task<int> UpdateItem(ShoppingItem item)
        {
            var response = await httpClient.PutAsJsonAsync("api/shopapi", item);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;

        }

        public async Task<int> DeleteItem(int id)
        {
            var response = await httpClient.DeleteAsync("api/shopapi/" + id);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

    }
}

