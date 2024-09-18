using Club25_Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
{
	public void Configure(EntityTypeBuilder<UserAccount> builder)
	{
		var columnOrder = 0;

		builder.UseTpcMappingStrategy()
		       .HasKey(x => x.Id);

		builder.Property(x => x.Id)
		       .HasColumnName(nameof(UserAccount.Id).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .ValueGeneratedOnAdd();

		builder.Property(p => p.Login)
		       .HasColumnName(nameof(UserAccount.Login).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .IsRequired()
		       .HasMaxLength(64);

		builder.Property(p => p.Name)
		       .HasColumnName(nameof(UserAccount.Name).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .IsRequired()
		       .HasMaxLength(64);

		builder.Property(p => p.Surname)
		       .HasColumnName(nameof(UserAccount.Surname).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .IsRequired()
		       .HasMaxLength(64);

		builder.Property(p => p.Email)
		       .HasColumnName(nameof(UserAccount.Email).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .IsRequired()
		       .HasMaxLength(64);

		builder.Property(p => p.Pass)
		       .HasColumnName(nameof(UserAccount.Pass).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .IsRequired()
		       .HasMaxLength(64);

		builder.Property(p => p.Salt)
		       .HasColumnName(nameof(UserAccount.Salt).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .IsRequired()
		       .HasMaxLength(32);

		builder.Property(p => p.ConfigVersion)
		       .HasColumnName(nameof(UserAccount.ConfigVersion).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasPrecision(8, 4);
	}
}