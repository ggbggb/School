using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Creditor
	{
		[Column("CreditorPK")]
		public Guid	CreditorPK { get; set; }

		[Column("Name")]
		[MaxLength(50)]
		public string Name { get; set; }

		[Column("ContactPK")]
		public Guid ContactPK { get; set; }

	}
}
