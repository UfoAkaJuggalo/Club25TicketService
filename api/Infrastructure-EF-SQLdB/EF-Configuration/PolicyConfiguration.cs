using Club25_Domain.Aggregates.UserAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class PolicyConfiguration : IEntityTypeConfiguration<Policy>
{
	public void Configure(EntityTypeBuilder<Policy> builder)
	{
		builder.HasNoKey()
		       .ToTable("Policy");

		builder.HasOne(d => d.IdPermissionNavigation).WithMany()
		       .HasForeignKey(d => d.IdPermission)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Policy_Permission");

		builder.HasOne(d => d.IdUserGroupNavigation).WithMany()
		       .HasForeignKey(d => d.IdUserGroup)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Policy_UserGroup");

		builder.Property(e => e.IdPermission).HasColumnName("idPermission");
		builder.Property(e => e.IdUserGroup).HasColumnName("idUserGroup");
	}
}