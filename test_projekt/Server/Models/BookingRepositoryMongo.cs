using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_projekt.Shared.Models;
using MongoDB.Driver;

namespace test_projekt.Server.Models
{
    internal class BookingRepositoryMongo : IBookingRepository
    {
        // private static readonly List<ShoppingItem> Items;
        BookingDBContext db = new BookingDBContext();


        public void AddItem(Shelter item)
        {
            db.Items.InsertOne(item);
        }

        public List<Shelter> GetAllItems()
        {
            Console.WriteLine("getallitems - repository");
            return db.Items.Find(_ => true).ToList();
        }


        public BookingRepositoryMongo()
        {

        }
    }
}
