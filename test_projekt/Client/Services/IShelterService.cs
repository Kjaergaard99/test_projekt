using test_projekt.Shared.Models;


namespace test_projekt.Client.Services;

public interface IShelterService
{

    Task<Shelter[]?> GetAllItems(); // finder alle items i listen

    // Task<int> AddShelter(Shelter shelter); // tilføjer en booking

    /*
    Task<int> AddShelter(Shelter shelter);

    Task<int> DeleteItem(int id); // sletter en item

    Task<int> UpdateItem(Shelter item); // opdaterer en item
    */
}