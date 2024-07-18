using Club25_Domain.Agregates.UserAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
	public void Configure(EntityTypeBuilder<Permission> builder)
	{
		builder.ToTable("Permission");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Description)
		       .HasMaxLength(160)
		       .HasColumnName("description");
		builder.Property(e => e.Name)
		       .HasMaxLength(50)
		       .HasColumnName("name");
	}
}