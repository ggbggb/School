using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Teacher
	{
		[Column("TeacherPK")]
		public Guid TeacherPK { get; set; }

		[Column("AvailableDays")]
		[MaxLength(7)]
		public string AvailableDays { get; set; }

		[Column("Salary")]
		public decimal Salary { get; set; }

		[Column("ContactPK")]
		public Guid ContactPK { get; set; }
	}
}
