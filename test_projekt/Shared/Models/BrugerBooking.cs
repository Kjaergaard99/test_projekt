using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace test_projekt.Shared.Models
{
	[BsonIgnoreExtraElements]
	public class BrugerBooking
	{

		[Required]
		[StringLength(100, ErrorMessage = "Ugyldigt navn")]
		[BsonElement("Navn")]
		public string Navn { get; set; }

		[Required]
		[EmailAddress(ErrorMessage = "Ugyldig email")]
		[BsonElement("Email")]
		public string Email { get; set; }

		[Required]
		[BsonElement("ValgtShelter")]
		public string ValgtShelter { get; set; }

		[Required]
		[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
		[BsonElement("StartDato")]
		public DateTime StartDato { get; set; } = DateTime.Now;

		[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
		[BsonElement("SlutDato")]
		public DateTime SlutDato { get; set; } = DateTime.Now;


		/*
		[BsonRepresentation(BsonType.ObjectId)]
		public string? MongoId { get; set; }
		*/

		/*
		public BrugerBooking(string navn = "", string email = "")
		{
			this.Navn = navn;
			this.Email = email;
		}
		*/

		public BrugerBooking()
        {

        }
	}
}

