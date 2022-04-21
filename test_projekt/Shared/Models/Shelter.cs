using System;
using test_projekt.Shared.Models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;



namespace test_projekt.Shared.Models
{
	[BsonIgnoreExtraElements]

	public class Shelter
	{	

		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string? MongoId { get; set; }

		[BsonElement("properties")]
		public ShelterProperty Property { get; set; }

		public Shelter()
		{
		}


	}
}

