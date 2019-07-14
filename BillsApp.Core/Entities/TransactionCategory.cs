using System.ComponentModel.DataAnnotations;

namespace BillsApp.Core.Entities
{
	public class TransactionCategory : Entity
	{
		[Required]
		public string Name { get; set; }
	}
}
