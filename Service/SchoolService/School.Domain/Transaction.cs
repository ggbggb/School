using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Transaction
	{
		[Column("TransactionPK")]
		public Guid TransactionPK { get; set; }

		[Column("TransactionDate")]
		public DateTime TransactionDate { get; set; }

		[Column("SchoolPK")]
		public Guid SchoolPK { get; set; }

		[Column("Description")]
		[MaxLength(100)]
		public string Description { get; set; }

		[Column("IsCredit")]
		public bool IsCredit { get; set; }

		[Column("Amount")]
		public decimal Amount { get; set; }

		[Column("PayerContactPK")]
		public Guid PayerContactPK { get; set; }

		[Column("PayeeContactPK")]
		public Guid PayeeContactPK { get; set; }	
	}
}
