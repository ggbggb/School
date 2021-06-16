using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class School
	{
		[Column("SchoolPK")]
		public Guid SchoolPK { get; set; }

		[Column("Name")]
		[MaxLength(50)]
		public string Name { get; set; }

		[Column("LocationPK")]
		public Guid LocationPK { get; set; }

		[Column("PrincipleUserPK")]
		public Guid PrincipleUserPK { get; set; }

		[Column("ContactUserPK")]
		public Guid ContactUserPK { get; set; }
	}
}
