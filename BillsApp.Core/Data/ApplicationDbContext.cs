using BillsApp.Core.Entities;
using BillsApp.Core.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BillsApp.Core.Data
{
	public class ApplicationDbContext : IdentityDbContext<AppUser>
	{
		public DbSet<Transaction> Transactions { get; set; }
		public DbSet<TransactionElement> TransactionElements { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<File> Files { get; set; }
		public DbSet<TransactionCategory> TransactionCategories { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Budget> Budgets { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<TransactionTag>().HasKey(x => new {x.TransactionId, x.TagId});

			builder.Entity<PaymentType>().HasData(Helpers.EntitiesFromEnum.BuildEntityFromEnum<PaymentTypeEnum>());
		}
	}
}
