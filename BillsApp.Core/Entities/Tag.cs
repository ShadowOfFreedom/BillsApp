using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BillsApp.Core.Entities
{
	public class Tag : Entity
	{
		[Required]
		public string Name { get; set; }
		public List<TransactionTag> TransactionTags { get; set; }

		public Tag()
		{
			TransactionTags = new List<TransactionTag>();
		}
	}
}
