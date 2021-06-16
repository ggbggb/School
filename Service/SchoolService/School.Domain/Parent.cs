using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Parent
	{
		[Column("ParentPK")]
		public Guid ParentPK { get; set; }

		[Column("ContactPK")]
		public Guid ContactPK { get; set; }

	}
}
