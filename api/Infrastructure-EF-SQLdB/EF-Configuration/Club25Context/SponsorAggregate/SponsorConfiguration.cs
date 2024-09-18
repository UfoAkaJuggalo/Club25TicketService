using Club25_Domain.Aggregates.SponsorAggregate;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.SponsorAggregate;

public sealed class SponsorConfiguration : IEntityTypeConfiguration<Sponsor>
{
	public void Configure(EntityTypeBuilder<Sponsor> builder)
	{
		builder.ToTable(nameof(Sponsor));

		builder.HasMany(m => m.Links)
		       .WithOne();

		builder.HasMany(m => m.Descriptions)
		       .WithOne(m => m.Sponsor)
		       .HasForeignKey(m => m.SponsorId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(m => m.SponsorAgents)
		       .WithOne(m => m.Sponsor)
		       .HasForeignKey(m => m.SponsorId)
		       .OnDelete(DeleteBehavior.Restrict);

		builder.HasMany(m => m.SponsorContracts)
		       .WithOne(m => m.Sponsor)
		       .HasForeignKey(m => m.SponsorId);

		builder.ComplexProperty(o => o.Contact, navigationBuilder =>
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