using System.ComponentModel.DataAnnotations;

namespace BillsApp.Core.Entities
{
	public class Product : Entity
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Unit { get; set; }
	}
}
