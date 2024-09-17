using Club25_Domain.Aggregates.UserAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25UsersContext;

public sealed class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
	public void Configure(EntityTypeBuilder<Permission> builder)
	{
		builder.ToTable(nameof(Permission))
		       .HasKey(k => k.Id);

		var columnOrder = 0;

		builder.Property(e => e.Id)
		       .UseIdentityColumn()
		       .HasColumnName(nameof(Permission.Id).ToLower())
		       .HasColumnOrder(columnOrder++);
		builder.Property(e => e.Name)
		       .HasMaxLength(32)
		       .HasColumnName(nameof(Permission.Name).ToLower())
		       .HasColumnOrder(columnOrder++);
		builder.Property(e => e.Description)
		       .HasMaxLength(512)
		       .HasColumnName(nameof(Permission.Description).ToLower())
		       .HasColumnOrder(columnOrder);
	}
}