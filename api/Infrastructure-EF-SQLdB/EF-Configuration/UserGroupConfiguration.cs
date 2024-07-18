using Club25_Domain.Agregates.UserAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
{
	public void Configure(EntityTypeBuilder<UserGroup> builder)
	{
		builder.ToTable("UserGroup");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Name)
		       .HasMaxLength(15)
		       .HasColumnName("name");
	}
}