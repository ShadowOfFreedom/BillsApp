using System;

namespace BillsApp.Core.Entities
{
	public class TransactionTag : Entity
	{
		public Guid TransactionId { get; set; }
		public Transaction Transaction { get; set; }

		public Guid TagId { get; set; }
		public Tag Tag { get; set; }
	}
}
