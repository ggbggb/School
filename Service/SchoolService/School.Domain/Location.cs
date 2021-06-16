using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Location
	{
		[Column("LocationPK")]
		public Guid LocationPK { get; set; }

		[Column("Address")]
		[MaxLength(50)]
		public string Address { get; set; }

		[Column("Suburb")]
		[MaxLength(20)]
		public string Suburb { get; set; }

		[Column("Postcode")]
		[MaxLength(10)]
		public string Postcode { get; set; }

		[Column("State")]
		[MaxLength(10)]
		public string State { get; set; }

		[Column("Country")]
		[MaxLength(20)]
		public string Country { get; set; }

	}
}
