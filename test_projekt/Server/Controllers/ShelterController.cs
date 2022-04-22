using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using test_projekt.Server.Models;
using test_projekt.Shared.Models;

namespace test_projekt.Server.Controllers
{
	[ApiController]
	[Route("api/shelterapi")]
	public class ShelterController : ControllerBase
	{
		private readonly IShelterRepository Repository = new ShelterRepositoryMongo();

		// private readonly IShelterRepository BookingListe = new ShelterRepositoryMongo();

		public ShelterController(IShelterRepository shelterRepository)
        {
			if (Repository == null && shelterRepository != null)
            {
				Repository = shelterRepository;
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
		[HttpPost]
		public void AddBooking(BrugerBooking brugerBooking)
        {
			Console.WriteLine("Add item called: " + brugerBooking.ToString());
			BookingListe.AddBooking(brugerBooking);
		}
		*/
	}
}

