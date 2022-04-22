using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using test_projekt.Server.Models;
using test_projekt.Shared.Models;

namespace test_projekt.Server.Controllers
{
	[ApiController]
	[Route("api/bookingapi")]
	public class BookingController : ControllerBase
	{
		// private readonly IShelterRepository Repository = new ShelterRepositoryMongo();

		private readonly IShelterRepository Bookings = new ShelterRepositoryMongo();

		public BookingController(IShelterRepository bookingRepository)
		{
			if (Bookings == null && bookingRepository != null)
			{
				Bookings = bookingRepository;
				Console.WriteLine("Repository initialized");
			}
		}

		[HttpGet]
		public IEnumerable<BrugerBooking> GetAllBookings()
		{
			Console.WriteLine("getallitems - controller");
			return Bookings.GetAllBookings();
		}

		[HttpPost]
		public void AddBooking(BrugerBooking brugerBooking)
		{
			Console.WriteLine("Add item called: " + brugerBooking.ToString());
			Bookings.AddBooking(brugerBooking);
		}
	}
}

