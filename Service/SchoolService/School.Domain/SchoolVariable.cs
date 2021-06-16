using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class SchoolVariable
	{
		[Column("SchoolVariablePK")]
		public Guid SchoolVariablePK { get; set; }

		[Column("SchoolPK")]
		public Guid SchoolPK { get; set; }

		[Column("Name")]
		[MaxLength(30)]
		public string Name { get; set; }

		[Column("Value")]
		[MaxLength(30)]
		public string Value { get; set; }
	}
}
