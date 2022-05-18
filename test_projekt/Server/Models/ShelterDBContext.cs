using test_projekt.Shared.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace test_projekt.Server.Models
{
	public class ShelterDBContext
	{
		private readonly IMongoDatabase mongoDatabase;

		public ShelterDBContext()
		{
			string atlasConnection = "mongodb+srv://haha:haha@cluster0.uupb3.mongodb.net/test";
			var client = new MongoClient(atlasConnection);
			mongoDatabase = client.GetDatabase("shelterdb"); // gemmer connection til database i en variabel
		}
		public IMongoCollection<Shelter> Items
		{
			get
			{
				return
				mongoDatabase.GetCollection<Shelter>("shelters");
			}
		}

		public IMongoCollection<BrugerBooking> Bookings
		{
			get
			{
				return
				mongoDatabase.GetCollection<BrugerBooking>("bookings");
			}
		}

	}
}

