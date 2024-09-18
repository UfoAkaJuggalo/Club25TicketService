using System.Reflection;
using Club25_Domain.Aggregates.ClientAggregate;
using Club25_Domain.Aggregates.ClientAggregate.Entities;
using Infrastructure_EF_SQLdB.EF_Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure_EF_SQLdB.Contexts;

public sealed class Club25ClientsContext : DbContext
{
	public Club25ClientsContext()
	{
	}

	public Club25ClientsContext(DbContextOptions<Club25ClientsContext> options) : base(options)
	{
	}

	public DbSet<Client> Clients { get; set; }
	public DbSet<Purchase> Purchases { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
		=> optionsBuilder.UseSqlServer(
			"Data Source=HOFFMAN;Initial Catalog=Club25Clients;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(),
		                                             type => type.Namespace.Contains("Club25ClientsContext"));
	}
}