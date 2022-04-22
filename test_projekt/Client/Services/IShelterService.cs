using test_projekt.Shared.Models;


namespace test_projekt.Client.Services;

public interface IShelterService
{

    Task<Shelter[]?> GetAllItems(); // finder alle items i listen

    Task<int> AddBooking(BrugerBooking brugerBooking); // tilføjer en booking

    Task<Shelter?> GetItem(int id); // finder en specifik item, læser id og vælger den


    Task<int> DeleteItem(int id); // sletter en item
    Task<int> UpdateItem(Shelter item); // opdaterer en item

}