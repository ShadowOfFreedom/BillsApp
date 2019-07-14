using System;
using System.ComponentModel.DataAnnotations;

namespace BillsApp.Core.Entities
{
	public class File : Entity
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public Guid TransactionId { get; set; }
		[Required]
		public byte[] FileBytes { get; set; }
	}
}
