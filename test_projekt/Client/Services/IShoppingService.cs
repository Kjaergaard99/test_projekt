using blazor_modul_13_14.Shared.Models;
namespace blazor_modul_13_14.Client.Services;

public interface IShoppingService
{

    Task<ShoppingItem[]?> GetAllItems(); // finder alle items i listen

    Task<ShoppingItem?> GetItem(int id); // finder en specifik item, læser id og vælger den

    Task<int> AddItem(ShoppingItem item); // tilføjer en item til shopping listen

    Task<int> DeleteItem(int id); // sletter en item
    Task<int> UpdateItem(ShoppingItem item); // opdaterer en item

}