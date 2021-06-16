using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Student
	{
		[Column("StudentPK")]
		public Guid StudentPK { get; set; }
		[Column("ContactPK")]
		public Guid ContactPK { get; set; }
		[Column("Parent1PK")]
		public Guid Parent1PK { get; set; }
		[Column("Parent2PK")]
		public Guid Parent2PK { get; set; }
		[Column("PaidToDate")]
		public DateTime PaidToDate { get; set; }
		[Column("IsActive")]
		public bool IsActive { get; set; }
		[Column("IsDeleted")]
		public bool IsDeleted { get; set; }
	}
}
