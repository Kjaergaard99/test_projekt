﻿using System.ComponentModel.DataAnnotations;
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

		
		public DateTime StartDato { get; set; } = DateTime.Now;

		
		public DateTime SlutDato { get; set; } = DateTime.Now;

		public string ValgtShelter { get; set; }


		public BrugerBooking(string navn = "", string email = "", string valgtShelter = "")
		{
			this.Navn = navn;
			this.Email = email;
			this.ValgtShelter = valgtShelter;
		}
	}
}

