using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Class
	{
		[Column("ClassPK")]
		public Guid ClassPK { get; set; }

		[Column("Name")]
		[MaxLength(30)]
		public string Name { get; set; }

		[Column("SchoolPK")]
		public Guid SchoolPK { get; set; }

		[Column("StudentMaxNo")]
		public int StudentMaxNo { get; set; }

		[Column("StudentNo")]
		public int StudentNo { get; set; }

		[Column("Teacher1PK")]
		public Guid Teacher1PK { get; set; }

		[Column("Teacher2PK")]
		public Guid Teacher2PK { get; set; }

		[Column("TuitionFee")]
		public decimal TuitionFee { get; set; }

		[Column("ClassLevelPK")]
		public Guid ClassLevelPK { get; set; }

		[Column("Description")]
		[MaxLength(150)]
		public string Description { get; set; }

		[Column("DaysOn")]
		[MaxLength(7)]
		public string DaysOn { get; set; }

		[Column("StartTime")]
		[MaxLength(5)]
		public string StartTime { get; set; }

		[Column("EndTime")]
		[MaxLength(5)]
		public string EndTime { get; set; }
	}
}
