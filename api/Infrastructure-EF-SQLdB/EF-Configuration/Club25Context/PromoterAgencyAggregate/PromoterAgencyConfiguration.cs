using Club25_Domain.Aggregates.PromoterAgencyAggregate;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.PromoterAgencyAggregate;

public sealed class PromoterAgencyConfiguration : IEntityTypeConfiguration<PromoterAgency>
{
	public void Configure(EntityTypeBuilder<PromoterAgency> builder)
	{
		builder.ToTable(nameof(PromoterAgency));

		builder.HasMany(m => m.Accountants)
		       .WithMany(m => m.PromoterAgencies)
		       .UsingEntity(j => j.ToTable("Accountants"));

		builder.HasMany(m => m.Promoters)
		       .WithOne(p => p.PromoterAgency)
		       .HasForeignKey(f => f.PromoterAgencyId)
		       .IsRequired();

		builder.OwnsOne(o => o.Contact, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Email)
			                 .IsRequired()
			                 .HasColumnName(nameof(ContactVO.Email).ToLower())
			                 .HasMaxLength(32);
			navigationBuilder.Property(p => p.Phone)
			                 .HasColumnName(nameof(ContactVO.Phone).ToLower())
			                 .HasMaxLength(16);
			navigationBuilder.Property(p => p.Country)
			                 .HasColumnName(nameof(ContactVO.Country).ToLower())
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.City)
			                 .HasColumnName(nameof(ContactVO.City).ToLower())
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.Address)
			                 .HasColumnName(nameof(ContactVO.Address).ToLower())
			                 .HasMaxLength(100);
		});
	}
}