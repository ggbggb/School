using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class SchoolEnrolment
	{
		[Column("SchoolEnrolmentPK")]
		public Guid SchoolEnrolmentPK { get; set; }

		[Column("ClassPK")]
		public Guid ClassPK { get; set; }

		[Column("StudentPK")]
		public Guid StudentPK { get; set; }
	}
}
