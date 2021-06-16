using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class ClassLevel
	{
		[Column("ClassLevelPK")]
		public Guid ClassLevelPK { get; set; }

		[Column("Description")]
		[MaxLength(20)]
		public string Description { get; set; }

		[Column("SchoolPK")]
		public Guid SchoolPK { get; set; }

	}
}
