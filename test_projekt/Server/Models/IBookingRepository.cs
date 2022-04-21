using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_projekt.Shared.Models;

namespace test_projekt.Server.Models
{
    public interface IBookingRepository
    {
        List<Shelter> GetAllItems();

        void AddBooking(BrugerBooking brugerBooking);
    }
}
