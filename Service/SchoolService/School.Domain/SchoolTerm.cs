using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class SchoolTerm
	{
		[Column("SchoolTermPK")]
		public Guid SchoolTermPK { get; set; }

		[Column("Description")]
		[MaxLength(20)]
		public string Description { get; set; }

		[Column("StartDate")]
		public DateTime StartDate { get; set; }

		[Column("EndDate")]
		public DateTime EndDate { get; set; }

		[Column("SchoolPK")]
		public Guid SchoolPK { get; set; }
	}
}
