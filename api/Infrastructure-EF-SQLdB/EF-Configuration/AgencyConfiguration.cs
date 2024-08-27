using Club25_Domain.Agregates.AgencyAgregate;
using Club25_Domain.Agregates.AgencyAgregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class AgencyConfiguration : IEntityTypeConfiguration<Agency>
{
	public void Configure(EntityTypeBuilder<Agency> builder)
	{
		builder.ToTable(nameof(Agency))
		       .HasKey(k => k.Id);

		var columnOrder = 0;

		builder.HasMany(m => m.Bands)
		       .WithOne(o => o.Agency)
		       .HasForeignKey(k => k.AgencyId)
		       .IsRequired();

		builder.HasMany(m => m.Agents)
		       .WithOne(o => o.Agency)
		       .HasForeignKey(f => f.AgencyId)
		       .IsRequired();

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Agency.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(p => p.Name)
		       .IsRequired()
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(100)
		       .HasColumnName(nameof(Agency.Name).ToLower());

		builder.OwnsOne(o => o.Contact, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Email)
			                 .IsRequired()
			                 .HasColumnName(nameof(ContactVO.Email).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(32);
			navigationBuilder.Property(p => p.Phone)
			                 .HasColumnName(nameof(ContactVO.Phone).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(16);
			navigationBuilder.Property(p => p.Country)
			                 .HasColumnName(nameof(ContactVO.Country).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.City)
			                 .HasColumnName(nameof(ContactVO.City).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.Address)
			                 .HasColumnName(nameof(ContactVO.Address).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(100);
		});
	}
}