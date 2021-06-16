using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Contact
	{
		[Column("ContactPK")]
		public Guid ContactPK { get; set; }

		[Column("Title")]
		[MaxLength(10)]
		public string Title { get; set; }

		[Column("FirstName")]
		[MaxLength(20)]
		public string FirstName { get; set; }

		[Column("MiddleName")]
		[MaxLength(20)]
		public string MiddleName { get; set; }

		[Column("LastName")]
		[MaxLength(20)]
		public string LastName { get; set; }

		[Column("DateOfBirth")]
		public DateTime DateOfBirth { get; set; }

		[Column("Address")]
		[MaxLength(150)]
		public string Address { get; set; }

		[Column("Postcode")]
		[MaxLength(10)]
		public string Postcode { get; set; }

		[Column("State")]
		[MaxLength(10)]
		public string State { get; set; }

		[Column("Country")]
		[MaxLength(20)]
		public string Country { get; set; }

		[Column("Phone")]
		[MaxLength(20)]
		public string Phone { get; set; }

		[Column("Email")]
		[MaxLength(50)]
		public string Email { get; set; }

		[Column("ContactByPhone")]
		public bool ContactByPhone { get; set; }

		[Column("ContactByEmail")]
		public bool ContactByEmail { get; set; }

		[Column("IsDeleted")]
		public bool IsDeleted { get; set; }

		[Column("IsActive")]
		public bool IsActive { get; set; }

	}
}
