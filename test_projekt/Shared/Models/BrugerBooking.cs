using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace test_projekt.Shared.Models
{
	public class BrugerBooking
	{

		[Required]
		public string Navn { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
		public DateTime StartDato { get; set; } = DateTime.Now;

		[Required]
		public DateTime SlutDato { get; set; } = DateTime.Now;


		public BrugerBooking(string navn = "", string email = "")
		{
			this.Navn = navn;
			this.Email = email;
		}
	}
}

