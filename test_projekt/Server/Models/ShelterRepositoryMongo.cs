using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_projekt.Shared.Models;
using MongoDB.Driver;

namespace test_projekt.Server.Models
{
    internal class ShelterRepositoryMongo : IShelterRepository
    {
        // private static readonly List<ShoppingItem> Items;
        ShelterDBContext db = new ShelterDBContext();

        BookingDBContext brugerDB = new BookingDBContext();


        public void AddBooking(BrugerBooking brugerBooking)
        {
            brugerDB.BookingListe.InsertOne(brugerBooking);
        }

        public List<Shelter> GetAllItems()
        {
            Console.WriteLine("getallitems - repository");
            return db.Items.Find(_ => true).ToList();
        }



        public ShelterRepositoryMongo()
        {

        }
    }
}
