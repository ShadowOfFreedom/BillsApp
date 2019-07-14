using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BillsApp.Core.Enums;

namespace BillsApp.Core.Entities
{
	public class Transaction : Entity
	{
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public Guid CategoryId { get; set; }
		[Required]
		public DateTime TransactionDate { get; set; }
		[Required]
		public DateTime CreateDate { get; set; }
		[Required]
		public DateTime ModificationDate { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }
		[Required]
		public Guid UserId { get; set; }
		public PaymentTypeEnum PaymentType { get; set; }
		public List<TransactionTag> TransactionTags { get; set; }

		public Transaction()
		{
			TransactionTags = new List<TransactionTag>();
		}
	}
}
