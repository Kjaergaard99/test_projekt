﻿using test_projekt.Shared.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace test_projekt.Server.Models
{
	public class BookingDBContext
	{
		private readonly IMongoDatabase mongoDatabase;

		public BookingDBContext()
		{
			string atlasConnection = "mongodb+srv://haha:haha@cluster0.uupb3.mongodb.net/test";
			var client = new MongoClient(atlasConnection);
			mongoDatabase = client.GetDatabase("shelterdb");
		}
		public IMongoCollection<BrugerBooking> BookingListe
		{
			get
			{
				return
				mongoDatabase.GetCollection<BrugerBooking>("bookings");
			}
		}

	}
}

