using System.Net.Http.Json;
using test_projekt.Shared.Models;

namespace test_projekt.Client.Services
{
    public class BookingService : IBookingService
    {
        private readonly HttpClient httpClient;


        public Task<BrugerBooking[]?> GetAllBookings()
        {
            var result = httpClient.GetFromJsonAsync<BrugerBooking[]>("api/bookingapi");
            return result;
        }

        public async Task<int> AddBooking(BrugerBooking brugerBooking)
        {
            var response = await httpClient.PostAsJsonAsync("api/bookingapi", brugerBooking);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        /*
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
        */


        public BookingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}

