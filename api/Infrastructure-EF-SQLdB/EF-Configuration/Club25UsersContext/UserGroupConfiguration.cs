using Club25_Domain.Aggregates.UserAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25UsersContext;

public sealed class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
{
	public void Configure(EntityTypeBuilder<UserGroup> builder)
	{
		builder.ToTable(nameof(UserGroup))
		       .HasKey(k => k.Id);

		builder.HasMany(m => m.Permissions)
		       .WithMany();

		var columnOrder = 0;

		builder.Property(e => e.Id)
		       .HasColumnName(nameof(UserGroup.Id).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .UseIdentityColumn();
		builder.Property(e => e.Name)
		       .HasColumnName(nameof(UserGroup.Name).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(32);
		builder.Property(e => e.Description)
		       .HasColumnName(nameof(UserGroup.Description).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(512);
	}
}