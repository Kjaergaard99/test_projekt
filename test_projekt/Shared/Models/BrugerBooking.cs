using System;
namespace test_projekt.Shared.Models
{
	public class BrugerBooking
	{
		public string Navn { get; set; }

		public string Email { get; set; }

		public DateTime StartDato { get; set; } = DateTime.Now;

		public DateTime SlutDato { get; set; } = DateTime.Now;


		public BrugerBooking(string navn = "", string email = "")
		{
			this.Navn = navn;
			this.Email = email;
		}
	}
}

