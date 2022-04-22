using System.Net.Http.Json;
using test_projekt.Shared.Models;

namespace test_projekt.Client.Services
{
    public class ShelterService : IShelterService
    {
        private readonly HttpClient httpClient;


        public Task<Shelter[]?> GetAllItems()
        {
            var result = httpClient.GetFromJsonAsync<Shelter[]>("api/shelterapi");
            return result;
        }

        public async Task<int> AddBooking(BrugerBooking brugerBooking)
        {
            var response = await httpClient.PostAsJsonAsync("api/shelterapi", brugerBooking);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        /*
        public async Task<Shelter> GetItem(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Shelter>("api/shelterapi/" + id);
            return result;
        }

        public async Task<int> UpdateItem(Shelter item)
        {
            var response = await httpClient.PutAsJsonAsync("api/shelterapi", item);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;

        }

        public async Task<int> DeleteItem(int id)
        {
            var response = await httpClient.DeleteAsync("api/shelterapi/" + id);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }
        */


        public ShelterService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}

