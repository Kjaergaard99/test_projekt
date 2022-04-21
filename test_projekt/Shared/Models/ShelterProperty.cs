using System;


using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace test_projekt.Shared.Models
{
	[BsonIgnoreExtraElements]
	public class ShelterProperty
	{
		public ShelterProperty()
		{
		}

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
	}
}

