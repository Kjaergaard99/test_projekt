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

        //ShelterDBContext brugerDB = new ShelterDBContext();


        public void AddBooking(BrugerBooking brugerBooking)
        {
            db.Bookings.InsertOne(brugerBooking);
        }

        public List<Shelter> GetAllItems()
        {
            Console.WriteLine("getallitems - repository");
            return db.Items.Find(_ => true).ToList();
        }

        public List<BrugerBooking> GetAllBookings()
        {
            Console.WriteLine("getallitems - bookingrepository");
            return db.Bookings.Find(_ => true).ToList();
        }



        public ShelterRepositoryMongo()
        {

        }
    }
}
