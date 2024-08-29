using Club25_Domain.Aggregates.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.ToTable("User");

		builder.HasOne(d => d.IdGroupNavigation).WithMany(p => p.Users)
		       .HasForeignKey(d => d.IdGroup)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_User_UserGroup");

		builder.HasOne(d => d.IdPersonNavigation).WithMany(p => p.Users)
		       .HasForeignKey(d => d.IdPerson)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_User_Person");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.IdGroup).HasColumnName("id_group");
		builder.Property(e => e.IdPerson).HasColumnName("id_person");
		builder.Property(e => e.Password)
		       .HasMaxLength(25)
		       .HasColumnName("password");
	}
}