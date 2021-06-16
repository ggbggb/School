using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class SchoolOpenClass
	{
		[Column("SchoolOpenClassPK")]
		public Guid SchoolOpenClassPK { get; set; }

		[Column("SchoolPK")]
		public Guid SchoolPK { get; set; }

		[Column("SchoolTermPK")]
		public Guid SchoolTermPK { get; set; }

		[Column("ClassPK")]
		public Guid ClassPK { get; set; }
	}
}
