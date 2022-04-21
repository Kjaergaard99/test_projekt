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
		private readonly IBookingRepository Repository = new BookingRepositoryMongo();

		public BookingController(IBookingRepository bookingRepository)
        {
			if (Repository == null && bookingRepository != null)
            {
				Repository = bookingRepository;
                Console.WriteLine("Repository initialized");
            }
        }

		[HttpGet]
		public IEnumerable<Shelter> GetAllItems()
        {
			Console.WriteLine("getallitems - controller");
			return Repository.GetAllItems();
        }

		/*
		public BookingController()
		{
		}

		*/
	}
}

