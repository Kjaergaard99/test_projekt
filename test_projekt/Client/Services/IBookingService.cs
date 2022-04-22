using test_projekt.Shared.Models;


namespace test_projekt.Client.Services;

public interface IBookingService
{

    Task<BrugerBooking[]?> GetAllBookings(); // finder alle items i listen

    Task<int> AddBooking(BrugerBooking brugerBooking); // tilføjer en booking

    /*
    Task<int> DeleteItem(int id); // sletter en item

    Task<int> UpdateItem(Shelter item); // opdaterer en item
    */
}