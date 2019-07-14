using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsApp.Core.Entities
{
	public class TransactionElement : Entity
	{
		[Required]
		public Guid TransactionId { get; set; }
		[Required]
		public Guid ProductId { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }
		[Required]
		[Column(TypeName = "decimal(16,4)")]
		public decimal Amount { get; set; }
		[Required]
		public Transaction Transaction { get; set; }
	}
}
