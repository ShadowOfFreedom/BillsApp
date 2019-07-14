using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Identity;

namespace BillsApp.Core.Entities
{
	public class AppUser : IdentityUser
	{
		public Collection<Budget> Budgets { get; set; }
		public Collection<Transaction> Transactions { get; set; }
	}
}
