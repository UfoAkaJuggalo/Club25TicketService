using System.Reflection;
using Club25_Domain.Aggregates.UserAggregate;
using Club25_Domain.Aggregates.UserAggregate.Entities;
using Infrastructure_EF_SQLdB.EF_Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure_EF_SQLdB.Contexts;

public sealed class Club25UsersContext : DbContext
{
	public Club25UsersContext()
	{
	}

	public Club25UsersContext(DbContextOptions<Club25UsersContext> options) : base(options)
	{
	}

	public DbSet<User> Users { get; set; }
	public DbSet<UserGroup> UserGroups { get; set; }
	public DbSet<Permission> Permissions { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
		=> optionsBuilder.UseSqlServer(
			"Data Source=HOFFMAN;Initial Catalog=Club25Users;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(),
		                                             type => type.Namespace.Contains("Club25UsersContext"));
	}
}