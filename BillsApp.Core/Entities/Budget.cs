using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsApp.Core.Entities
{
	public class Budget : Entity
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public Guid UserId { get; set; }
		public Guid CategoryId { get; set; }
		[Required]
		[Column(TypeName = "decimal(16,4)")]
		public decimal Amount { get; set; }
		[Required]
		public DateTime FromDate { get; set; }
		[Required]
		public DateTime ToDate { get; set; }
		[Required]
		public DateTime CreateDate { get; set; }
		[Required]
		public DateTime ModificationDate { get; set; }
	}
}
