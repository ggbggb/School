using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class User
	{
		[Column("UserPK")]
		public Guid UserPK { get; set; }

		[Column("LoginName")]
		[MaxLength(50)]
		public string LoginName { get; set; }

		[Column("Password")]
		[MaxLength(20)]
		public string Password { get; set; }

		[Column("UserRolePK")]
		public Guid UserRolePK { get; set; }

		[Column("RegistrationStartDate")]
		public DateTime RegistrationStartDate { get; set; }

		[Column("LicenseExpiryDate")]
		public DateTime LicenseExpiryDate { get; set; }

		[Column("CreatedDate")]
		public DateTime CreatedDate { get; set; }
	}
}
