﻿using System;
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
		private readonly IShelterRepository Repository = new ShelterRepositoryMongo();

		private readonly IShelterRepository BookingListe = new ShelterRepositoryMongo();

		public BookingController(IShelterRepository bookingRepository)
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

		[HttpPost]
		public void AddBooking(BrugerBooking brugerBooking)
        {
			Console.WriteLine("Add item called: " + brugerBooking.ToString());
			BookingListe.AddBooking(brugerBooking);
		}
	}
}

