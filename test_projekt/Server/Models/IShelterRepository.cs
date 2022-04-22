using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_projekt.Shared.Models;

namespace test_projekt.Server.Models
{
    public interface IShelterRepository
    {
        List<Shelter> GetAllItems();

        List<BrugerBooking> GetAllBookings();

        void AddBooking(BrugerBooking brugerBooking);
    }
}
