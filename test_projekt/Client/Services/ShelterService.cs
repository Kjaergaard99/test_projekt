using System.Net.Http.Json;
using test_projekt.Shared.Models;

namespace test_projekt.Client.Services
{
    public class ShelterService : IShelterService
    {
        private readonly HttpClient httpClient;


        public Task<Shelter[]?> GetAllItems()
        {
            var result = httpClient.GetFromJsonAsync<Shelter[]>("api/bookingapi");
            return result;
        }

        public async Task<int> AddBooking(BrugerBooking brugerBooking)
        {
            var response = await httpClient.PostAsJsonAsync("api/bookingapi", brugerBooking);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }


        public async Task<int> AddItem(Shelter item)
        {
            var response = await httpClient.PostAsJsonAsync("api/bookingapi", item);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }


        public async Task<Shelter> GetItem(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Shelter>("api/bookingapi/" + id);
            return result;
        }

        public async Task<int> UpdateItem(Shelter item)
        {
            var response = await httpClient.PutAsJsonAsync("api/bookingapi", item);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;

        }

        public async Task<int> DeleteItem(int id)
        {
            var response = await httpClient.DeleteAsync("api/bookingapi/" + id);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }



        public ShelterService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}

