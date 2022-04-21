using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_projekt.Shared.Models;


namespace test_projekt.Server.Models
{
    internal class BookingRepository : IBookingRepository
    {
        private static readonly List<Shelter> Items;
        public List<Shelter> GetAllItems()
        {
            return Items;
        }


        static BookingRepository()
        {
            Items = new List<Shelter>();
            Items.Clear();
            InsertTestData();

        }

        public static void InsertTestData()
        {
            /*
            Items.Add(new Shelter(id: 1, "Bananer", 5, false));
            Items.Add(new Shelter(id: 2, "Gulerødder", 10, true));
            */
        }
    }
}
