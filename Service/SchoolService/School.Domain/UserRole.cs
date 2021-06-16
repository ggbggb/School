using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class UserRole
	{
		[Column("UserRolePK")]
		public Guid UserRolePK { get; set; }

		[Column("Code")]
		[MaxLength(10)]
		public string Code { get; set; }

		[Column("Description")]
		[MaxLength(20)]
		public string Description { get; set; }
	}
}
