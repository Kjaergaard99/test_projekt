using System;
<<<<<<< HEAD
using test_projekt.Shared.Models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

=======
>>>>>>> fe4c3797421b192bd389769bc969afbd1d73bfbb
namespace test_projekt.Shared.Models
{
	public class Shelter
	{
<<<<<<< HEAD
		[Required]
		[BsonElement("shelter_id")]
		public int ShelterId { get; set; }

		[Required]
		[BsonElement("navn")]
		public string Navn { get; set; }

		[Required]
		[BsonElement("beskrivels")]
		public string Beskrivelse { get; set; }

		[Required]
		[BsonElement("antal_pl")]
		public int AntalPladser { get; set; }

		[Required]
		[BsonElement("postnr")]
		public int PostNr { get; set; }

		[Required]
		[BsonElement("vejnavn")]
		public string Vejnavn { get; set; }

		[Required]
		[BsonElement("husnr")]
		public string HusNr { get; set; }

		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string? MongoId { get; set; }

=======
>>>>>>> fe4c3797421b192bd389769bc969afbd1d73bfbb


		public Shelter()
		{
		}
	}
}

