using Club25_Domain.Agregates.AgencyAgregate.Entities;
using Club25_Domain.CommonEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class DescriptionConfiguration : IEntityTypeConfiguration<Description>
{
	public void Configure(EntityTypeBuilder<Description> builder)
	{
		builder.UseTpcMappingStrategy();

		builder.Property(p => p.Id)
		       .HasColumnName(nameof(BandDescription.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(e => e.DescriptionText)
		       .HasColumnName(nameof(BandDescription.DescriptionText).ToLower())
		       .HasMaxLength(2048);

		builder.Property(e => e.LanguageCode)
		       .HasColumnName(nameof(BandDescription).ToLower())
		       .HasConversion<string>();
	}
}