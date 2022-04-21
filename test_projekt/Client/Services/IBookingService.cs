﻿using test_projekt.Shared.Models;


namespace test_projekt.Client.Services;

public interface IBookingService
{

    Task<Shelter[]?> GetAllItems(); // finder alle items i listen

    Task<Shelter?> GetItem(int id); // finder en specifik item, læser id og vælger den

    Task<int> AddItem(Shelter item); // tilføjer en item til shopping listen

    Task<int> DeleteItem(int id); // sletter en item
    Task<int> UpdateItem(Shelter item); // opdaterer en item

}