using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain
{
	public class Invoice
	{
		[Column("InvoicePK")]
		public Guid InvoicePK { get; set; }

		[Column("SchoolPK")]
		public Guid SchoolPK { get; set; }

		[Column("InvoiceNo")]
		[MaxLength(20)]
		public string InvoiceNo { get; set; }

		[Column("Description")]
		[MaxLength(100)]
		public string Description { get; set; }

		[Column("DueDate")]
		public DateTime DueDate { get; set; }

		[Column("InvoiceFromContactPK")]
		public Guid InvoiceFromContactPK { get; set; }

		[Column("InvoiceToContactPK")]
		public Guid InvoiceToContactPK { get; set; }

		[Column("InvoiceForContactPK")]
		public Guid InvoiceForContactPK { get; set; }

		[Column("IsPaid")]
		public bool IsPaid { get; set; }

		[Column("IsDeleted")]
		public bool IsDeleted { get; set; }
	}
}
